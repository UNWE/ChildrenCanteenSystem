namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Enumerations;
    using Events;
    using Models;

    public partial class CreateUser : BaseForm
    {
        public CreateUser(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();
            this.DataSelected += this.SelectData;
            newUserButton.Enabled = false;
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

        private void SelectData(object sender, DataSelectedEventArgs e)
        {
            if (e.SaveButtonState == SaveButtonState.Enabled)
            {
                this.newUserButton.Enabled = true;
            }
            else
            {
                this.newUserButton.Enabled = false;
            }
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            var usernameInput = username.Text;
            if (!this.data.Users.All().Any(u => u.Username == usernameInput))
            {
                var firstNameInput = firstName.Text;
                var lastNameInput = lastName.Text;
                var passwordInput = password.Text;
                var isAdminInput = isAdmin.Checked;

                var newUser = new User
                {
                    FirstName = firstNameInput,
                    LastName = lastNameInput,
                    Username = usernameInput,
                    Password = this.GetPasswordHash(passwordInput)
                };

                if (isAdminInput)
                {
                    var adminRole = this.data.Roles.All().First(r => r.Name == "Administrator");
                    newUser.Roles.Add(adminRole);
                }

                this.data.Users.Add(newUser);
                var saveResult = this.data.SaveChanges();
                if (saveResult > 0)
                {
                    MessageBox.Show(
                        SuccessMessages.UserCteatedSuccessfullyMessage,
                        MessageBoxesTitles.SuccessTitle);
                    firstName.Clear();
                    lastName.Clear();
                    password.Clear();
                    isAdmin.Checked = false;
                }
                else
                {
                    MessageBox.Show(
                        ErrorMessages.UserCreateErrorMessage,
                        MessageBoxesTitles.AttentionTitle);
                }
            }
            else
            {
                MessageBox.Show(
                    string.Format(ErrorMessages.UsernameIsAlreadyTaken, usernameInput),
                    MessageBoxesTitles.AttentionTitle);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void CheckForEmptyData()
        {
            if (!string.IsNullOrEmpty(this.firstName.Text) &&
                !string.IsNullOrEmpty(this.lastName.Text) &&
                !string.IsNullOrEmpty(this.username.Text) &&
                !string.IsNullOrEmpty(this.password.Text))
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
