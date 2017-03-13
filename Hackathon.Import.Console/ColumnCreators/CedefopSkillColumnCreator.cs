using LumenWorks.Framework.IO.Csv;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class CedefopSkillColumnCreator : IColumnCreator
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
                new Column { Name = "[Skill_Esco_Level_4]", Type = typeof(string) },
                new Column { Name = "[Skill_Esco_Level_3]", Type = typeof(string) },
                new Column { Name = "[Skill_Esco_Level_2]", Type = typeof(string) },
                new Column { Name = "[Skill_Esco_Level_1]", Type = typeof(string) },
                new Column { Name = "[Skill_Esco_Level_0]", Type = typeof(string) },
            };
        }

        public bool HasHeaders => false;
        public char Separator => ';';
        public string TableName => "ft_skill_profession";
    }
}
