using SqlViewer.Dal;

namespace SqlViewer.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            HideError();
        }

        private void HideError() => lbError.Visible = false;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                HideError();
                RepositoryFactory.Repository.Login(
                    tbServer.Text.Trim(),
                    tbUsername.Text.Trim(),
                    tbPassword.Text.Trim()
                    );
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                lbError.Visible = true;
            }
        }
    }
}
