using LumenWorks.Framework.IO.Csv;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Hackathon.Import.Console
{
    public class CsvImporter
    {
        private readonly IColumnCreator _columnCreator;
        private SqlBulkCopy _copy;
        public CsvImporter(IColumnCreator columnCreator)
        {
            _columnCreator = columnCreator;
            System.Console.WriteLine($"Using {_columnCreator.TableName}.");
        }

        public void Import(string path)
        {
            var connection = @"[connection-string]";
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    var csv = new CsvReader(file, _columnCreator.HasHeaders, _columnCreator.Separator);
                    var columns = _columnCreator.GetColumns();
                    _copy = new SqlBulkCopy(connection, SqlBulkCopyOptions.KeepIdentity);
                    _copy.SqlRowsCopied += (sender, args) => System.Console.WriteLine($"{args.RowsCopied} copied.");
                    if (columns.Length == 0 && !_columnCreator.HasHeaders)
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            string[] restrictions = new string[4] { null, null, _columnCreator.TableName, null };
                            conn.Open();
                            var cols = conn.GetSchema("Columns", restrictions).AsEnumerable();
                            var columnList =
                                cols.Select(
                                    s =>
                                        new
                                        {
                                            Name = s.Field<string>("Column_Name"),
                                            DataType = s.Field<string>("DATA_TYPE")
                                        }).ToList();
                            foreach (var column in columnList)
                            {
                                var trimmedName = column.Name.Replace("[", "").Replace("]", "");
                                Type dataType = typeof(string);
                                switch (column.DataType.ToLower())
                                {
                                    case "varchar":
                                    case "nvarchar":
                                        dataType = typeof(string);
                                        break;
                                    case "int":
                                    case "smallint":
                                    case "bigint":
                                        dataType = typeof(int);
                                        break;
                                }

                                var csvColumn = new Column()
                                {
                                    Name = trimmedName,
                                    Type = dataType
                                };
                                csv.Columns.Add(csvColumn);
                                _copy.ColumnMappings.Add(trimmedName, trimmedName);
                            }
                        }
                    }
                    else if (columns.Length == 0 && _columnCreator.HasHeaders)
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            string[] restrictions = new string[4] {null, null, _columnCreator.TableName, null};
                            conn.Open();
                            var cols = conn.GetSchema("Columns", restrictions).AsEnumerable();
                            var columnList =
                                cols.Select(
                                    s =>
                                        new
                                        {
                                            Name = s.Field<string>("Column_Name"),
                                            DataType = s.Field<string>("DATA_TYPE")
                                        }).ToList();
                            var headers = csv.GetFieldHeaders();
                            csv.Columns.Clear();
                            foreach (var header in headers)
                            {
                                var column = columnList.FirstOrDefault(
                                    x =>
                                        x.Name
                                            .Replace("}", "")
                                            .Replace("{", "")
                                            .Replace("[", "")
                                            .Replace("]", "")
                                            .Equals(header, StringComparison.InvariantCultureIgnoreCase));
                                if (column == null)
                                {
                                    System.Console.WriteLine(
                                        $"Did not find column  for header {header}. Skipping column.");
                                    continue;
                                }
                                var trimmedName = column.Name.Replace("[", "").Replace("]", "");
                                Type dataType = typeof(string);
                                switch (column.DataType.ToLower())
                                {
                                    case "varchar":
                                    case "nvarchar":
                                        dataType = typeof(string);
                                        break;
                                    case "int":
                                    case "smallint":
                                    case "bigint":
                                        dataType = typeof(int);
                                        break;
                                    case "decimal":
                                        dataType = typeof(float);
                                        break;
                                }

                                var csvColumn = new Column()
                                {
                                    Name = trimmedName,
                                    Type = dataType
                                };

                                csv.Columns.Add(csvColumn);
                                _copy.ColumnMappings.Add(trimmedName, trimmedName);
                            }
                        }
                    }
                    else if (_columnCreator.HasHeaders)
                    {
                        var headers = csv.GetFieldHeaders();
                        csv.Columns.Clear();
                        foreach (var header in headers)
                        {
                            var column =
                                columns.FirstOrDefault(
                                    x =>
                                        x.Name.Replace("[", "")
                                            .Replace("]", "")
                                            .Equals(header, StringComparison.InvariantCultureIgnoreCase));
                            if (column == null)
                            {
                                System.Console.WriteLine($"Did not find column  for header {header}. Skipping column.");
                                continue;
                            }
                            var trimmedName = column.Name.Replace("[", "").Replace("]", "");
                            csv.Columns.Add(column);
                            _copy.ColumnMappings.Add(trimmedName, trimmedName);
                        }
                    }
                    else
                    {
                        foreach (var column in columns)
                        {
                            csv.Columns.Add(column);
                        }
                    }
                    var now = DateTime.Now;
                    _copy.BatchSize = 2000;
                    _copy.DestinationTableName = _columnCreator.TableName;
                    _copy.WriteToServer(csv);
                    var passed = DateTime.Now - now;
                    System.Console.WriteLine($"Took {passed.TotalSeconds} seconds.");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Exception occured. {ex.Message}");
                System.Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (_copy != null)
                {
                    _copy.Close();
                }
            }
            System.Console.WriteLine($"Import done - {path}");
        }

    }
}