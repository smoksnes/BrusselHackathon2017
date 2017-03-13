using LumenWorks.Framework.IO.Csv;

namespace Hackathon.Import.Console
{
    public interface IColumnCreator
    {
        Column[] GetColumns();
        bool HasHeaders { get; }
        char Separator { get; }
        string TableName { get; }
    }
}