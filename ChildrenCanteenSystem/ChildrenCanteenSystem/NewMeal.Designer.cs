namespace ChildrenCanteenSystem
{
    partial class NewMeal
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.DataGridView();
            this.ProducytId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealType = new System.Windows.Forms.ComboBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.mealTypeLabel = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(414, 458);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 57);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Откажи";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(200, 458);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 57);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(366, 173);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(123, 29);
            this.productsLabel.TabIndex = 5;
            this.productsLabel.Text = "Продукти";
            // 
            // products
            // 
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProducytId,
            this.ProductName,
            this.MeasurementUnit,
            this.Quantity});
            this.products.Location = new System.Drawing.Point(50, 232);
            this.products.Name = "products";
            this.products.RowTemplate.Height = 28;
            this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products.Size = new System.Drawing.Size(704, 195);
            this.products.TabIndex = 4;
            this.products.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.products_CellBeginEdit);
            this.products.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_CellValueChanged);
            // 
            // ProducytId
            // 
            this.ProducytId.HeaderText = "Код";
            this.ProducytId.Name = "ProducytId";
            this.ProducytId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Продукт";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
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
            // 
            // mealType
            // 
            this.mealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealType.FormattingEnabled = true;
            this.mealType.Location = new System.Drawing.Point(528, 53);
            this.mealType.Name = "mealType";
            this.mealType.Size = new System.Drawing.Size(226, 37);
            this.mealType.TabIndex = 3;
            this.mealType.SelectedIndexChanged += new System.EventHandler(this.mealType_SelectedIndexChanged);
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(45, 56);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(79, 29);
            this.mealNameLabel.TabIndex = 2;
            this.mealNameLabel.Text = "Ястие";
            // 
            // mealTypeLabel
            // 
            this.mealTypeLabel.AutoSize = true;
            this.mealTypeLabel.Location = new System.Drawing.Point(431, 56);
            this.mealTypeLabel.Name = "mealTypeLabel";
            this.mealTypeLabel.Size = new System.Drawing.Size(57, 29);
            this.mealTypeLabel.TabIndex = 1;
            this.mealTypeLabel.Text = "Тип";
            // 
            // mealName
            // 
            this.mealName.Location = new System.Drawing.Point(148, 53);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(226, 35);
            this.mealName.TabIndex = 0;
            this.mealName.TextChanged += new System.EventHandler(this.mealName_TextChanged);
            // 
            // NewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 537);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.products);
            this.Controls.Add(this.mealType);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.mealTypeLabel);
            this.Controls.Add(this.mealName);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewMeal";
            this.Text = "Ново ястие";
            this.Load += new System.EventHandler(this.NewMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mealName;
        private System.Windows.Forms.Label mealTypeLabel;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.ComboBox mealType;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducytId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}