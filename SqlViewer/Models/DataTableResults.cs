namespace SqlViewer.Models
{
    public class DataTableResults
    {
        public string? ColumnName { get; set; }
        public string? ColumnValue { get; set; }

        public override string ToString()
        => $"{ColumnName} {ColumnValue}";
    }
}
