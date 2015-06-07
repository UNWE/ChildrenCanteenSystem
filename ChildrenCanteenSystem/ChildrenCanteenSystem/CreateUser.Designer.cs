namespace ChildrenCanteenSystem
{
    partial class CreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.newUserButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(252, 34);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(220, 35);
            this.firstName.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(68, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(178, 29);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Собствено име";
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(400, 270);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(216, 33);
            this.isAdmin.TabIndex = 2;
            this.isAdmin.Text = "Администратор";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(513, 37);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(167, 29);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Фамилно име";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(706, 34);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(220, 35);
            this.lastName.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(583, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 29);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Парола";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(706, 147);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(220, 35);
            this.password.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 150);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(234, 29);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Потребителско име";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(252, 144);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(220, 35);
            this.username.TabIndex = 5;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(318, 377);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(154, 54);
            this.newUserButton.TabIndex = 9;
            this.newUserButton.Text = "Създай";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(509, 377);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 54);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Откажи";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 486);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstName);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreateUser";
            this.Text = "Нов потребител";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button cancelButton;
    }
}