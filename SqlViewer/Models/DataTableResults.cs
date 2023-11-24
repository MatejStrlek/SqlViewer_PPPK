namespace SqlViewer.Models
{
    public class DataTableResults
    {
        public string columnName { get; set; }
        public string columnValue { get; set; }

        public override string ToString()
        => $"{columnName} {columnValue}";
    }
}
