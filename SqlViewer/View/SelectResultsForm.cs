using System.Data;

namespace SqlViewer.View
{
    public partial class SelectResultsForm : Form
    {
        public SelectResultsForm(DataTable table)
        {
            InitializeComponent();
            Text = table.TableName;
            dgResults.DataSource = table;
        }
    }
}
