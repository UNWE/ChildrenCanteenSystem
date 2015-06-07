namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;

    using Models;

    public partial class CreateUser : BaseForm
    {
        public CreateUser(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            var firstNameInput = firstName.Text;
            var lastNameInput = lastName.Text;
            var usernameInput = username.Text;
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
            this.data.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
