using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class CedefopProfessionColumnCreator : IColumnCreator
    {
        public Column[] GetColumns()
        {
            return new[]
            {
                new Column { Name = "[GeneralId]", Type = typeof(int) },
                new Column { Name = "[PublicationCountry]", Type = typeof(string) },
                new Column { Name = "[GrabDate]", Type = typeof(string) },
                new Column { Name = "[YearGrabDate]", Type = typeof(int) },
                new Column { Name = "[MonthGrabDate]", Type = typeof(int) },
                new Column { Name = "[DayGrabDate]", Type = typeof(int) },
                new Column { Name = "[ExpireDate]", Type = typeof(string) },
                new Column { Name = "[YearExpireDate]", Type = typeof(int) },
                new Column { Name = "[MonthExpireDate]", Type = typeof(int) },
                new Column { Name = "[DayExpireDate]", Type = typeof(int) },
                new Column { Name = "[Esco_Level_4]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_3]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_2]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_1]", Type = typeof(string) },
                new Column { Name = "[Nut_Level_3]", Type = typeof(string) },
                new Column { Name = "[Nut_Level_2]", Type = typeof(string) },
                new Column { Name = "[Nut_Level_1]", Type = typeof(string) },
                new Column { Name = "[Nut_Level_0]", Type = typeof(string) },
                new Column { Name = "[Contract]", Type = typeof(int) },
                new Column { Name = "[EducationalLevel]", Type = typeof(int) },
                new Column { Name = "[Industry_Level_2]", Type = typeof(int) },
                new Column { Name = "[Industry_Level_1]", Type = typeof(int) },
                new Column { Name = "[WorkingHours]", Type = typeof(int) },
            };
        }

        public bool HasHeaders => false;
        public char Separator => ';';
        public string TableName => "ft_document";
    }
}
