namespace ChildrenCanteenSystem
{
    partial class ReviewMeals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.recipes = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealsLabel = new System.Windows.Forms.Label();
            this.meals = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meals)).BeginInit();
            this.SuspendLayout();
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.Location = new System.Drawing.Point(389, 278);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(106, 29);
            this.recipesLabel.TabIndex = 3;
            this.recipesLabel.Text = "Рецепти";
            // 
            // recipes
            // 
            this.recipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.recipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.MeasurementUnit,
            this.Quantity});
            this.recipes.Location = new System.Drawing.Point(59, 328);
            this.recipes.Name = "recipes";
            this.recipes.ReadOnly = true;
            this.recipes.RowTemplate.Height = 28;
            this.recipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipes.Size = new System.Drawing.Size(780, 197);
            this.recipes.TabIndex = 2;
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // MeasurementUnit
            // 
            this.MeasurementUnit.HeaderText = "Мярка";
            this.MeasurementUnit.Name = "MeasurementUnit";
            this.MeasurementUnit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // mealsLabel
            // 
            this.mealsLabel.AutoSize = true;
            this.mealsLabel.Location = new System.Drawing.Point(400, 23);
            this.mealsLabel.Name = "mealsLabel";
            this.mealsLabel.Size = new System.Drawing.Size(80, 29);
            this.mealsLabel.TabIndex = 1;
            this.mealsLabel.Text = "Ястия";
            // 
            // meals
            // 
            this.meals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.meals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MealName,
            this.Type});
            this.meals.Location = new System.Drawing.Point(154, 70);
            this.meals.Name = "meals";
            this.meals.ReadOnly = true;
            this.meals.RowTemplate.Height = 28;
            this.meals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.meals.Size = new System.Drawing.Size(578, 177);
            this.meals.TabIndex = 0;
            this.meals.SelectionChanged += new System.EventHandler(this.meals_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MealName
            // 
            this.MealName.HeaderText = "Ястие";
            this.MealName.Name = "MealName";
            this.MealName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // ReviewMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 548);
            this.Controls.Add(this.recipesLabel);
            this.Controls.Add(this.recipes);
            this.Controls.Add(this.mealsLabel);
            this.Controls.Add(this.meals);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReviewMeals";
            this.Text = "ReviewMeals";
            this.Load += new System.EventHandler(this.ReviewMeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView meals;
        private System.Windows.Forms.Label mealsLabel;
        private System.Windows.Forms.DataGridView recipes;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}