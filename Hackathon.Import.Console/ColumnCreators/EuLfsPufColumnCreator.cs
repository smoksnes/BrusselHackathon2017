using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class EuLfsPufColumnCreator : IColumnCreator
    {
        public Column[] GetColumns()
        {
            //return new Column[0];;
            return new[]
            {
                new Column { Name = "[COEFF]", Type  = typeof(string) },//Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
                new Column { Name = "[QUARTER]", Type = typeof(string) },
                new Column { Name = "[REC]", Type = typeof(string) },
                new Column { Name = "[REFYEAR]", Type = typeof(int) },
                new Column { Name = "[REFWEEK]", Type = typeof(int) },
                new Column { Name = "[INTWEEK]", Type = typeof(int) },
                new Column { Name = "[COUNTRY]", Type = typeof(string) },
                new Column { Name = "[REGION]", Type = typeof(string) },
                new Column { Name = "[DEGURBA]", Type = typeof(int) },
                new Column { Name = "[HHINST]", Type = typeof(int) },
                new Column { Name = "[INTWAVE]", Type = typeof(string) },
                new Column { Name = "[INTQUEST]", Type = typeof(int) },
                new Column { Name = "[REM]", Type = typeof(int) },
                new Column { Name = "[YEAR]", Type = typeof(int) },
                new Column { Name = "[HHPRIV]", Type = typeof(int) },
                new Column { Name = "[SEX]", Type = typeof(int) },
                new Column { Name = "[AGE]", Type = typeof(int) },
                new Column { Name = "[NATIONAL]", Type = typeof(string) },
                new Column { Name = "[YEARESID]", Type = typeof(int) },
                new Column { Name = "[COUNTRYB]", Type = typeof(string) },
                new Column { Name = "[PROXY]", Type = typeof(int) },
                new Column { Name = "[WSTATOR]", Type = typeof(string) },
                new Column { Name = "[NOWKREAS]", Type = typeof(int) },
                new Column { Name = "[STAPRO]", Type = typeof(int) },
                new Column { Name = "[SIGNISAL]", Type = typeof(int) },
                new Column { Name = "[COUNTRYW]", Type = typeof(string) },
                new Column { Name = "[REGIONW]", Type = typeof(string) },
                new Column { Name = "[YSTARTWK]", Type = typeof(int) },
                new Column { Name = "[MSTARTWK]", Type = typeof(int) },
                new Column { Name = "[FTPT]", Type = typeof(int) },
                new Column { Name = "[TEMP]", Type = typeof(int) },
                new Column { Name = "[TEMPDUR]", Type = typeof(int) },
                new Column { Name = "[HWUSUAL]", Type = typeof(int) },
                new Column { Name = "[HWACTUAL]", Type = typeof(int) },
                new Column { Name = "[HWOVERP]", Type = typeof(int) },
                new Column { Name = "[HWOVERPU]", Type = typeof(int) },
                new Column { Name = "[HOURREAS]", Type = typeof(int) },
                new Column { Name = "[WISHMORE]", Type = typeof(int) },
                new Column { Name = "[HWWISH]", Type = typeof(int) },
                new Column { Name = "[LOOKOJ]", Type = typeof(int) },
                new Column { Name = "[EXIST2J]", Type = typeof(int) },
                new Column { Name = "[STAPRO2J]", Type = typeof(int) },
                new Column { Name = "[HWACTUA2]", Type = typeof(int) },
                new Column { Name = "[EXISTPR]", Type = typeof(int) },
                new Column { Name = "[YEARPR]", Type = typeof(int) },
                new Column { Name = "[MONTHPR]", Type = typeof(int) },
                new Column { Name = "[STAPROPR]", Type = typeof(int) },
                new Column { Name = "[ISCOPR3D]", Type = typeof(string) },
                new Column { Name = "[SEEKWORK]", Type = typeof(int) },
                new Column { Name = "[SEEKTYPE]", Type = typeof(int) },
                new Column { Name = "[SEEKDUR]", Type = typeof(int) },
                new Column { Name = "[METHODA]", Type = typeof(int) },
                new Column { Name = "[METHODB]", Type = typeof(int) },
                new Column { Name = "[METHODC]", Type = typeof(int) },
                new Column { Name = "[METHODD]", Type = typeof(int) },
                new Column { Name = "[METHODE]", Type = typeof(int) },
                new Column { Name = "[METHODF]", Type = typeof(int) },
                new Column { Name = "[METHODG]", Type = typeof(int) },
                new Column { Name = "[METHODH]", Type = typeof(int) },
                new Column { Name = "[METHODI]", Type = typeof(int) },
                new Column { Name = "[METHODJ]", Type = typeof(int) },
                new Column { Name = "[METHODK]", Type = typeof(int) },
                new Column { Name = "[METHODL]", Type = typeof(int) },
                new Column { Name = "[METHODM]", Type = typeof(int) },
                new Column { Name = "[WANTWORK]", Type = typeof(int) },
                new Column { Name = "[AVAILBLE]", Type = typeof(int) },
                new Column { Name = "[EDUCSTAT]", Type = typeof(int) },
                new Column { Name = "[EDUCLEVL]", Type = typeof(int) },
                new Column { Name = "[COURATT]", Type = typeof(int) },
                new Column { Name = "[COURLEN]", Type = typeof(int) },
                new Column { Name = "[HAT97LEV]", Type = typeof(string) },
                new Column { Name = "[ILOSTAT]", Type = typeof(int) },
                new Column { Name = "[NA111D]", Type = typeof(string) },
                new Column { Name = "[NA11S]", Type = typeof(string) },
                new Column { Name = "[ISCO1D]", Type = typeof(int) },
                new Column { Name = "[NA112J1D]", Type = typeof(string) },
                new Column { Name = "[NA112JS]", Type = typeof(string) },
                new Column { Name = "[NA11PR1D]", Type = typeof(string) },
                new Column { Name = "[NA11PRS]", Type = typeof(string) },
                new Column { Name = "[ISCOPR1D]", Type = typeof(int) },
                new Column { Name = "[DURUNE]", Type = typeof(int) },
                new Column { Name = "[EDUC4WN]", Type = typeof(int) },
                new Column { Name = "[HATLEV1D]", Type = typeof(string) },
                new Column { Name = "[ISCO3D]", Type = typeof(string) },
                new Column { Name = "[STARTIME]", Type = typeof(int) },
                new Column { Name = "[LEAVTIME]", Type = typeof(int) },
                new Column { Name = "[LEAVCLAS]", Type = typeof(int) },
                new Column { Name = "[NACE1D]", Type = typeof(string) },
                new Column { Name = "[NACE2J1D]", Type = typeof(int) },
                new Column { Name = "[NACEPR1D]", Type = typeof(int) },
                new Column { Name = "[AGERESID]", Type = typeof(string) },
                new Column { Name = "[IS881D]", Type = typeof(string) },
                new Column { Name = "[IS88PR3D]", Type = typeof(string) },
                new Column { Name = "[IS88PR1D]", Type = typeof(string) },
                new Column { Name = "[IS883D]", Type = typeof(string) },
            };
        }

        public bool HasHeaders => true;
        public char Separator => ',';

        public string TableName => "LFS";
    }
}
