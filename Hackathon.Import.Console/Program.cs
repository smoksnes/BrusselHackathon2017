using Hackathon.Import.Console.ColumnCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] files;

            ImportFt();
            System.Console.WriteLine("All done. ;)");
            System.Console.ReadKey();
            System.Console.ReadKey();
            System.Console.ReadKey();
        }

        private static void ImportEuresCV()
        {
            string euresPath2 = @"C:\Users\sebas\Documents\datasets\eures\CV data DWH 2016-12-01 CSV\CV_SKILL.csv";
            var importer2 = new CsvImporter(new DynamicColumnCreator(true, euresPath2, ','));
            importer2.Import(euresPath2);
            return;

            string euresPath = @"C:\Users\sebas\Documents\datasets\eures\CV data DWH 2016-12-01 CSV\";
            var directory = new System.IO.DirectoryInfo(euresPath);
            var files = directory.GetFiles().Where(x => x.Extension.Equals(".csv",StringComparison.InvariantCultureIgnoreCase)).Select(x => x.FullName).Where(x => !x.EndsWith("_y.csv") && !x.EndsWith("_hh.csv")).ToArray();

            foreach (var file in files)
            {
                System.Console.WriteLine($"Importing {file}");
                var filePath = file;
                var importer = new CsvImporter(new DynamicColumnCreator(true, filePath, ','));
                importer.Import(filePath);
            }
        }

        private static void ImportFt()
        {
            //string euresPath = @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\";
            var path = @"C:\Users\sven\Downloads\datasets\cedefop\cedefop_csv_new";
            var directory = new System.IO.DirectoryInfo(path);
            var files = directory.GetFiles().Where(x => x.Extension.Equals(".csv", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.FullName).Where(x => !x.EndsWith("_y.csv") && !x.EndsWith("_hh.csv")).ToArray();
            foreach (var file in files)
            {
                System.Console.WriteLine($"Importing {file}");
                var filePath = file;
                var importer = new CsvImporter(new DynamicColumnCreator(false, filePath, ';', 3));
                importer.Import(filePath);
            }
        }

        private static void ImportEuresJV()
        {
            string euresPath =
    @"C:\Users\sebas\Documents\datasets\eures\JV data DWH 2016-11-30 CSV\";
            var directory = new System.IO.DirectoryInfo(euresPath);
            var files = directory.GetFiles().Where(x => x.Extension.Equals(".csv", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.FullName).Where(x => !x.EndsWith("_y.csv") && !x.EndsWith("_hh.csv")).ToArray();
            foreach (var file in files)
            {
                System.Console.WriteLine($"Importing {file}");
                var filePath = file;
                var importer = new CsvImporter(new DynamicColumnCreator(true, filePath, ','));
                importer.Import(filePath);
            }
        }

        private static void ImportEu_Lfs_puf()
        {
            // eu_lfs_puf
            var importer = new CsvImporter(new EuLfsPufColumnCreator());
            string eu_lfs_puf_path = @"C:\Users\sebas\Documents\datasets\eu_lfs_puf\puf_all_lfs_2013_1";
            var directory = new System.IO.DirectoryInfo(eu_lfs_puf_path);
            var files = directory.GetFiles().Where(x => x.Extension.Equals(".csv", StringComparison.InvariantCultureIgnoreCase)).Select(x => x.FullName).Where(x => !x.EndsWith("_y.csv") && !x.EndsWith("_hh.csv")).ToArray();
            foreach (var file in files)
            {
                System.Console.WriteLine($"Importing {file}");
                var filePath = file;
                importer.Import(filePath);
            }
            System.Console.WriteLine("All done. ;)");
        }


        private static void ImportFt_Document()
        {
            // ft_document
            var files = new[]
            {
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_document_cz.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_document_de.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_document_en.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_document_it.csv",
            };
            foreach (var file in files)
            {
                var importer = new CsvImporter(new DynamicColumnCreator(false, file, ';', 3));
                System.Console.WriteLine($"Importing {file}");
                var filePath = file;
                importer.Import(filePath);
            }
            System.Console.WriteLine("All done. ;)");
        }

        private void ImportFtSkullProfession()
        {
            // ft_skill_profession
            var files = new[]
            {
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_skill_profession_cz.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_skill_profession_de.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_skill_profession_en.csv",
                @"C:\Users\sebas\Documents\datasets\cedefop\cedefop_csv_new\ft_skill_profession_it.csv",
            };

            foreach (var file in files)
            {
                var importer = new CsvImporter(new DynamicColumnCreator(false, file, ';', 3));
                System.Console.WriteLine($"Importing {file}");
                importer.Import(file);
            }
            System.Console.WriteLine("All done. ;)");
        }
    }
}
