namespace ChildrenCanteenSystem
{
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Enumerations;
    using Events;

    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();

            this.DataSelected += this.SelectData;
            this.enterButton.Enabled = false;
        }

        private event DataSelectedEventHandler DataSelected;

        private void OnDataSelected(DataSelectedEventArgs e)
        {
            DataSelectedEventHandler handler = DataSelected;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void enterButton_Click(object sender, System.EventArgs e)
        {
            var passwordInput = password.Text;
            var usernameInput = username.Text;
            bool loginSuccessful = this.AuthoriseUserAccess(usernameInput, passwordInput);
            if (loginSuccessful)
            {
                this.Hide();
                var userProfile = this.data.Users.All().First(u => u.Username == usernameInput);
                var mainScreen = new MainScreen(userProfile);
                mainScreen.Show();
            }
            else
            {
                MessageBox.Show(ErrorMessages.LoginFailedMessage, MessageBoxesTitles.AttentionTitle);
                username.Clear();
                password.Clear();
            }
        }

        private void SelectData(object sender, DataSelectedEventArgs e)
        {
            if (e.SaveButtonState == SaveButtonState.Enabled)
            {
                this.enterButton.Enabled = true;
            }
            else
            {
                this.enterButton.Enabled = false;
            }
        }

        private void username_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.username.Text) && !string.IsNullOrEmpty(this.password.Text))
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }

        private void password_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.username.Text) && !string.IsNullOrEmpty(this.password.Text))
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }
    }
}
