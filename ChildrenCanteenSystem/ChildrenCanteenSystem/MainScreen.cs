﻿namespace ChildrenCanteenSystem
{
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Models;

    public partial class MainScreen : BaseForm
    {
        public MainScreen(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();

            #region Form settings 

            this.Text = FormsTitles.BeginTitle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
            this.newUserMenuItem.Visible = this.UserProfile.Roles.Any(r => r.Name == "Administrator");
            this.applicationStatusLabel.Text = "Потребител: " + this.UserProfile.Username;

            #endregion
        }

        private void reviewMenuMenuItem_Click(object sender, System.EventArgs e)
        {
            var reviewMenuForm = new ReviewMenu(this.UserProfile);
            reviewMenuForm.MdiParent = this;
            reviewMenuForm.StartPosition = FormStartPosition.CenterParent;
            reviewMenuForm.Show();
        }

        private void newMenuMenuItem_Click(object sender, System.EventArgs e)
        {
            var newMenuForm = new NewMenu(this.UserProfile);
            newMenuForm.MdiParent = this;
            newMenuForm.StartPosition = FormStartPosition.CenterParent;
            newMenuForm.Show();
        }

        private void newCalculationMenuItem_Click(object sender, System.EventArgs e)
        {
            var newPreliminaryCalculationForm = new NewPreliminaryCalculation(this.UserProfile);
            newPreliminaryCalculationForm.MdiParent = this;
            newPreliminaryCalculationForm.StartPosition = FormStartPosition.CenterParent;
            newPreliminaryCalculationForm.Show();
        }

        private void reviewCalculationMenuItem_Click(object sender, System.EventArgs e)
        {
            var reviewPreliminaryCalculationForm = new ReviewPreliminaryCalculation(this.UserProfile);
            reviewPreliminaryCalculationForm.MdiParent = this;
            reviewPreliminaryCalculationForm.Show();
        }

        private void reviewRequestMenuItem_Click(object sender, System.EventArgs e)
        {
            var reviewRequestForm = new ReviewRequest();
            reviewRequestForm.MdiParent = this;
            reviewRequestForm.Show();
        }

        private void newRequestMenuItem_Click(object sender, System.EventArgs e)
        {
            var newRequestForm = new NewRequest(this.UserProfile);
            newRequestForm.MdiParent = this;
            newRequestForm.Show();
        }

        private void newUserMenuItem_Click(object sender, System.EventArgs e)
        {
            var newUserForm = new CreateUser(this.UserProfile);
            newUserForm.MdiParent = this;
            newUserForm.Show();
        }

        private void reviewMealsMenuItem_Click(object sender, System.EventArgs e)
        {
            var reviewMealsForm = new ReviewMeals(this.UserProfile);
            reviewMealsForm.MdiParent = this;
            reviewMealsForm.Show();
        }

        private void newMealMenuItem_Click(object sender, System.EventArgs e)
        {
            var newMealForm = new NewMeal();
            newMealForm.MdiParent = this;
            newMealForm.Show();
        }

        private void reportsByCalculationsMenuItem_Click(object sender, System.EventArgs e)
        {
            var reportForm = new PreliminaryCalculationsReports();
            reportForm.MdiParent = this;
            reportForm.Show();
        }

        private void reportsByRequestsMenuItem_Click(object sender, System.EventArgs e)
        {
            var reportForm = new RequestsReports();
            reportForm.MdiParent = this;
            reportForm.Show();
        }
    }
}
