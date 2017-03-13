using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class CedefopProfessionExperienceColumnCreator : IColumnCreator
    {
        public Column[] GetColumns()
        {
            return new[]
            {
                new Column { Name = "[GeneralId]", Type = typeof(int) },
                new Column { Name = "[PublicationCountry]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_4]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_3]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_2]", Type = typeof(string) },
                new Column { Name = "[Esco_Level_1]", Type = typeof(string) },
                new Column { Name = "[IdEsco_Skill]", Type = typeof(string) },
                new Column { Name = "[NGram]", Type = typeof(string) },
            };
        }

        public bool HasHeaders => false;
        public char Separator => ';';
        public string TableName => "ft_skill_profession_experience";
    }
}
