using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Import.Console.ColumnCreators
{
    public class SilcColumnCreator : IColumnCreator
    {
        public Column[] GetColumns()
        {
            return new[]
            {
                new Column { Name = "[DB010]", Type = typeof(int) },
            new Column { Name = "[DB010]", Type = typeof(int) },
            new Column { Name = "[DB020]", Type = typeof(string) },
            new Column { Name = "[DB030]", Type = typeof(int) },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },
            new Column { Name = "[DB040]", Type = typeof(float), NumberStyles = System.Globalization.NumberStyles.Float, Culture = new System.Globalization.CultureInfo("en-US") },

            };
        }

        public bool HasHeaders => true;
        public char Separator => ',';
        public string TableName => "silc";
    }
}
