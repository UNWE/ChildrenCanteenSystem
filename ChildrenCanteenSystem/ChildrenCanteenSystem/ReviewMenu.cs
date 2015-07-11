namespace ChildrenCanteenSystem
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Models;

    public partial class ReviewMenu : BaseForm
    {
        private DateTime date;
        private Models.Menu menuSelected;

        public ReviewMenu(User userProfile, DateTime date)
            : base(userProfile)
        {
            InitializeComponent();

            this.date = date;
            this.LoadMenuData(date);

            #region Form settings

            this.datePicker.Visible = false;
            this.reviewButton.Visible = false;
            this.Text = FormsTitles.ReviewMenu;
            this.StartPosition = FormStartPosition.CenterParent;
            this.firstMeal.Visible = false;
            this.secondMeal.Visible = false;
            this.thirdMeal.Visible = false;
            this.menuDateLabel.Text = string.Format("Меню за дата {0}", this.date.ToLongDateString());
            this.editButton.Visible = true;
            this.saveButton.Visible = false;
            this.deleteButton.Visible = false;

            #endregion
        }

        public ReviewMenu(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();

            #region Form settings

            this.Text = FormsTitles.ReviewMenu;
            this.StartPosition = FormStartPosition.CenterParent;
            this.firstMeal.Visible = false;
            this.secondMeal.Visible = false;
            this.thirdMeal.Visible = false;
            this.menuDateLabel.Visible = false;
            this.editButton.Visible = false;
            this.saveButton.Visible = false;
            this.deleteButton.Visible = false;

            #endregion
        }

        private void reviewButton_Click(object sender, System.EventArgs e)
        {
            this.firstMealTextBox.Clear();
            this.secondMealTextBox.Clear();
            this.thirdMealTextBox.Clear();
            this.foodCardsCount.Clear();

            var dateSelected = this.datePicker.Value.Date;
            this.date = dateSelected;
            var menuExists = this.LoadMenuData(dateSelected);

            if (!menuExists)
            {
                var dialogResult = MessageBox.Show(
                      string.Format(
                        ConfirmMessages.NotExistingMenuConfirmCreateNew,
                        dateSelected.ToLongDateString()),
                      MessageBoxesTitles.AttentionTitle,
                      MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var newMenuForm = new NewMenu(this.UserProfile, this.date);
                    newMenuForm.Show();
                    this.Close();
                }
            }
            else
            {
                this.editButton.Visible = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var preliminaryCalculation =
                base.data.PreliminaryCalculations
                .All()
                .FirstOrDefault(p => p.Menu.Date == this.date);

            if (preliminaryCalculation != null)
            {
                var result = MessageBox.Show(
                    string.Format(
                    ConfirmMessages.ConfirmReviewPrelimianryCalculationMessage,
                    this.date.ToLongDateString()),
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var reviewPreliminaryCalculationForm =
                        new ReviewPreliminaryCalculation(this.UserProfile, date);
                    reviewPreliminaryCalculationForm.Show();
                    this.Close();
                }
            }
            else
            {
                this.saveButton.Visible = true;
                this.deleteButton.Visible = true;
                this.editButton.Visible = false;
                this.firstMealTextBox.Visible = false;
                this.secondMealTextBox.Visible = false;
                this.thirdMealTextBox.Visible = false;
                this.firstMeal.Visible = true;
                this.secondMeal.Visible = true;
                this.thirdMeal.Visible = true;

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
            }
        }

        private bool LoadMenuData(DateTime date)
        {
            var menu = base.data.Menus
                .All()
                .Select(m => new
                {
                    m.Id,
                    m.Date,
                    m.FoodCards,
                    Meals = m.Meals.Select(meal => meal.Name).ToList()
                })
                .FirstOrDefault(m => m.Date == date);

            if (menu != null)
            {
                this.menuSelected = this.data.Menus.Find(menu.Id);
                this.firstMealTextBox.Text = menu.Meals[0];
                this.secondMealTextBox.Text = menu.Meals[1];
                this.thirdMealTextBox.Text = menu.Meals[2];
                this.foodCardsCount.Text = menu.FoodCards != null
                    ? menu.FoodCards.ToString()
                    : "Няма данни за закупени купони";

                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                ConfirmMessages.ConfirmSaveMenuMessage,
                MessageBoxesTitles.ConfirmTitle,
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int firstMealId = (int)this.firstMeal.SelectedValue;
                int secondMealId = (int)this.secondMeal.SelectedValue;
                int thirdMealId = (int)this.thirdMeal.SelectedValue;

                this.menuSelected.Meals.Clear();
                this.menuSelected.Meals = new List<Meal>
                {
                    this.data.Meals.Find(firstMealId),
                    this.data.Meals.Find(secondMealId),
                    this.data.Meals.Find(thirdMealId)
                };

                this.data.Menus.Update(this.menuSelected);
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
    }
}
