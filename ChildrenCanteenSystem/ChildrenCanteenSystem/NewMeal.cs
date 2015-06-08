namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Enumerations;
    using Events;
    using Models;

    public partial class NewMeal : BaseForm
    {
        private int productRowEditingIndex = -1;

        public NewMeal()
        {
            InitializeComponent();

            this.DataSelected += this.SelectData;

            this.saveButton.Enabled = false;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMeal_Load(object sender, EventArgs e)
        {
            var mealTypes = this.data.MealTypes
                .All()
                .Select(t => new
                {
                    t.Id,
                    t.Name
                })
                .ToDictionary(k => k.Id, v => v.Name);

            mealType.DataSource = new BindingSource(mealTypes, null);
            mealType.DisplayMember = "Value";
            mealType.ValueMember = "Key"; ;

            var productsEntities = this.data.Products
                .All()
                .Select(p => new
                {
                    p.Id,
                    p.Name,
                    MeasurementUnit = p.MeasurementUnit.Name
                });

            foreach (var product in productsEntities)
            {
                products.Rows.Add(product.Id, product.Name, product.MeasurementUnit, 0f);
            }
        }

        private void mealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void mealName_TextChanged(object sender, EventArgs e)
        {
            this.CheckForEmptyData();
        }

        private void CheckForEmptyData()
        {
            var hasSelectedProducts = products.Rows
                                .Cast<DataGridViewRow>()
                                .Take(products.RowCount - 1)
                                .Any(r => float.Parse(r.Cells[3].Value.ToString()) > 0);

            if (!string.IsNullOrEmpty(mealName.Text) && mealType.SelectedIndex > -1 && hasSelectedProducts)
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Enabled));
            }
            else
            {
                this.OnDataSelected(new DataSelectedEventArgs(SaveButtonState.Disabled));
            }
        }

        private void products_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (this.productRowEditingIndex > -1)
            {
                var cellValue = products.Rows[productRowEditingIndex].Cells[3].Value.ToString();
                float cellValueAsNumber;
                var isNumber = float.TryParse(cellValue, out cellValueAsNumber);
                if (!isNumber)
                {
                    products.Rows[productRowEditingIndex].Cells[3].Value = 0f;
                }

                this.CheckForEmptyData();
            }
        }

        private void products_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.productRowEditingIndex = products.SelectedRows[0].Index;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Желаете ли да запазите ястието",
                "",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var mealExists = this.data.Meals
                    .All()
                    .Any(m => m.Name == mealName.Text);
                if (!mealExists)
                {
                    var newMeal = new Meal
                    {
                        Name = this.mealName.Text,
                        MealTypeId = (int) this.mealType.SelectedValue
                    };

                    this.data.Meals.Add(newMeal);

                    var recipeProducts = this.products.Rows
                                .Cast<DataGridViewRow>()
                                .Take(products.RowCount - 1)
                                .Where(r => float.Parse(r.Cells[3].Value.ToString()) > 0);

                    foreach (var product in recipeProducts)
                    {
                        var newRecipeProduct = new Recipe
                        {
                            MealId = newMeal.Id,
                            ProductId = (int) product.Cells[0].Value
                        };

                        this.data.Recipes.Add(newRecipeProduct);
                    }

                    var saveResult = this.data.SaveChanges();
                    if (saveResult > 0)
                    {
                        MessageBox.Show("Ястието бе запазено успешно", "");
                    }
                    else
                    {
                        MessageBox.Show("Ястието ke бе запазено успешно. Моля опитайте отново", "");
                    }
                }
                else
                {
                    MessageBox.Show(
                        string.Format("Ястие с име {0} вече съществува", mealType.Text),
                        "");
                }
            }
        }
    }
}
