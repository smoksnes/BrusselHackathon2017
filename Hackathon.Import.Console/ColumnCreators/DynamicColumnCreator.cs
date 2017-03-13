using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class DynamicColumnCreator : IColumnCreator
    {
        private readonly int _suffixRemove;

        public DynamicColumnCreator(bool hasHeaders, string path, char separator)
        {
            Separator = separator;
            HasHeaders = hasHeaders;
            var fileInfo = new FileInfo(path);
            TableName = Path.GetFileNameWithoutExtension(fileInfo.Name);
        }

        public DynamicColumnCreator(bool hasHeaders, string path, char separator, int suffixRemove)
        {
            _suffixRemove = suffixRemove;
            Separator = separator;
            HasHeaders = hasHeaders;
            var fileInfo = new FileInfo(path);
            var fileName = Path.GetFileNameWithoutExtension(fileInfo.Name);
            TableName = fileName.Substring(0, fileName.Length - suffixRemove);
        }

        public Column[] GetColumns()
        {
            return new Column[0];
        }

        public bool HasHeaders { get; private set; }
        public char Separator { get; private set; }
        public string TableName { get; private set; }
    }
}
