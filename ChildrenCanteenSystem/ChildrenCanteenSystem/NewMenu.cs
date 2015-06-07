namespace ChildrenCanteenSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Enumerations;
    using Events;
    using Models;

    public partial class NewMenu : BaseForm
    {
        public NewMenu(User userProfile) : base(userProfile)
        {
            InitializeComponent();

            this.DataSelected += this.SelectData;

            #region Form settings

            this.Text = FormsTitles.NewMenuTitle;

            this.StartPosition = FormStartPosition.CenterParent;

            #endregion
        }

        public NewMenu(User userProfile, DateTime dateSearchTerm)
            : this(userProfile)
        {
            this.datePicker.Value = dateSearchTerm;
        }

        private event DataSelectedEventHandler DataSelected;

        protected virtual void OnDataSelected(DataSelectedEventArgs e)
        {
            DataSelectedEventHandler handler = DataSelected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            #region Load first meals
            var mealsWithRecipes = data.Recipes.All().Select(r => r.MealId).ToList();
            var firstMeals = base.data.Meals
                .All()
                .Include(m => m.MealType)
                .Where(m => m.MealType.Name == "Предястие")
                .Where(m => mealsWithRecipes.Contains(m.Id))
                .Select(m => new
                {
                    m.Id,
                    m.Name
                })
                .ToDictionary(k => k.Id, v => v.Name);

            firstMeal.DataSource = new BindingSource(firstMeals, null);
            firstMeal.DisplayMember = "Value";
            firstMeal.ValueMember = "Key";
            #endregion

            #region Load second meals

            var secondMeals = base.data.Meals
               .All()
               .Include(m => m.MealType)
               .Where(m => m.MealType.Name == "Основно")
               .Where(m => mealsWithRecipes.Contains(m.Id))
               .Select(m => new
               {
                   m.Id,
                   m.Name
               })
               .ToDictionary(k => k.Id, v => v.Name);

            secondMeal.DataSource = new BindingSource(secondMeals, null);
            secondMeal.DisplayMember = "Value";
            secondMeal.ValueMember = "Key";
            #endregion

            #region Load third meals

            var thirdMeals = base.data.Meals
               .All()
               .Include(m => m.MealType)
               .Where(m => m.MealType.Name == "Десерт")
               .Where(m => mealsWithRecipes.Contains(m.Id))
               .Select(m => new
               {
                   m.Id,
                   m.Name
               })
               .ToDictionary(k => k.Id, v => v.Name);

            thirdMeal.DataSource = new BindingSource(thirdMeals, null);
            thirdMeal.DisplayMember = "Value";
            thirdMeal.ValueMember = "Key";
     
            #endregion

            firstMeal.SelectedIndex = -1;
            secondMeal.SelectedIndex = -1;
            thirdMeal.SelectedIndex = -1;
        }

        private void SelectData(object sender, DataSelectedEventArgs e)
        {
            if (e.SaveButtonState == SaveButtonState.Enabled)
            {
                this.saveButton.Enabled = true;
            }
            else
            {
                this.saveButton.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.firstMeal.SelectedIndex <= -1 ||
                this.secondMeal.SelectedIndex <= -1 ||
                this.thirdMeal.SelectedIndex <= -1)
            {
                MessageBox.Show(ErrorMessages.AllMealsNotSelectedErrorMessage);
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    ConfirmMessages.ConfirmSaveMenuMessage,
                    MessageBoxesTitles.ConfirmTitle,
                    MessageBoxButtons.YesNo);
                var date = this.datePicker.Value.Date;
                if (!base.data.Menus.All().Any(m => m.Date == date))
                 {
                    if (result == DialogResult.Yes)
                    {

                        var firstMealId = this.firstMeal.SelectedValue;
                        var secondMealId = this.secondMeal.SelectedValue;
                        var thirdMealId = this.thirdMeal.SelectedValue;

                        base.data.Menus.Add(
                            new Models.Menu
                            {
                                Date = date,
                                Meals =
                                {
                                    base.data.Meals.Find(firstMealId),
                                    base.data.Meals.Find(secondMealId),
                                    base.data.Meals.Find(thirdMealId)
                                }
                            });

                        var saveResult = base.data.SaveChanges();
                        if (saveResult > 0)
                        {
                            MessageBox.Show(SuccessMessages.MenuSavedSuccessfullyMessage);
                        }
                        else
                        {
                            MessageBox.Show(ErrorMessages.MenuNotSavedErrorMessage);
                        }
                    }
                }
                else
                {
                    var dialogResult = MessageBox.Show(
                        ConfirmMessages.ExistingMenuConfirmCreateNewPrelimianryCalculationMessage,
                        MessageBoxesTitles.AttentionTitle,
                        MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var newPreliminaryCalculationForm =
                            new ReviewPreliminaryCalculation(this.UserProfile, date);
                        newPreliminaryCalculationForm.Show();
                        this.Close();
                    }
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.secondMeal.SelectedIndex > -1 && this.thirdMeal.SelectedIndex > -1)
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }

        private void secondMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.firstMeal.SelectedIndex > -1 && this.thirdMeal.SelectedIndex > -1)
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }

        private void thirdMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.firstMeal.SelectedIndex > -1 && this.secondMeal.SelectedIndex > -1)
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            var menuExists = base.data.Menus.All().Any(m => m.Date == datePicker.Value.Date);
            if (menuExists)
            {
                var result = MessageBox.Show(
                    ConfirmMessages.ConfirmPreviewMenuMessage,
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var reviewMenuForm = new ReviewMenu(this.UserProfile, datePicker.Value.Date);
                    reviewMenuForm.Show();
                    this.Close();
                }
            }
        }
    }
}
