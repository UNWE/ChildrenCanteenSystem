namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;

    using Data.Data;
    using Models;

    public class BaseForm : Form
    {
        protected IChildrenCanteenSystemData data;
        protected User UserProfile { get; set; }

        protected BaseForm () : this(new User())
        {
        }

        protected BaseForm(User userProfile)
        {
            this.data = new ChildrenCanteenSystemData();
            this.UserProfile = userProfile;
        }

        protected string GetPasswordHash(string passwordInput)
        {
            HashAlgorithm hash = new MD5CryptoServiceProvider();

            string hashPass =
                Convert.ToBase64String(hash.ComputeHash(Encoding.ASCII.GetBytes(passwordInput)));

            return hashPass;
        }

        protected bool AuthoriseUserAccess(string username, string password)
        {
            User userProfile = this.data.Users
                .All()
                .FirstOrDefault(u => u.Username == username);
            if (userProfile != null)
            {
                string userPassword = userProfile.Password;

                return VerifyHashedPassword(password, userPassword);
            }

            return false;
        }

        private bool VerifyHashedPassword(string password, string profilePassword)
        {
            if (string.IsNullOrEmpty(profilePassword) ||
                string.IsNullOrEmpty(password))
            {
                return false;
            }

            string hashedPassword = this.GetPasswordHash(password);
            if (profilePassword.Equals(hashedPassword, StringComparison.Ordinal))
            {
                return true; 
            }
                    
            return false;
        }
    }
}
