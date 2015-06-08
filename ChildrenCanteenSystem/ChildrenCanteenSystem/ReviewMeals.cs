namespace ChildrenCanteenSystem
{
    using System.Linq;
    using Models;

    public partial class ReviewMeals : BaseForm
    {
        public ReviewMeals(User userprofile) : base(userprofile)
        {
            InitializeComponent();

            #region Form settings

            this.Text = "Ястия преглед";

            #endregion
        }

        private void ReviewMeals_Load(object sender, System.EventArgs e)
        {
            var mealsEntities = this.data.Meals
                .All()
                .Select(m => new
                {
                    MealId = m.Id,
                    MealName = m.Name,
                    MealTType = m.MealType.Name
                });

            foreach (var meal in mealsEntities)
            {
                this.meals.Rows.Add(meal.MealId, meal.MealName, meal.MealTType);
            }
        }

        private void meals_SelectionChanged(object sender, System.EventArgs e)
        {
            if (meals.SelectedRows.Count > 0)
            {
                int lastRowIndex = meals.RowCount - 1;
                var mealSelectedRowIndex = meals.SelectedRows[0].Index;
                bool rowCanBeSelected = mealSelectedRowIndex < lastRowIndex;
                if (rowCanBeSelected)
                {
                    var mealId = (int)meals.SelectedRows[0].Cells[0].Value;
                    var recipe = this.data.Recipes
                        .All()
                        .Where(r => r.MealId == mealId)
                        .Select(r => new
                        {
                            ProductName = r.Product.Name,
                            MeasurementUnit = r.Product.MeasurementUnit.Name,
                            Quantity = r.Quantity
                        });

                    recipes.Rows.Clear();
                    foreach (var product in recipe)
                    {
                        recipes.Rows.Add(product.ProductName, product.MeasurementUnit, product.Quantity);
                    }
                }
            }
        }
    }
}
