namespace ChildrenCanteenSystem
{
    partial class PreviewPreliminaryCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewPreliminaryCalculation));
            this.dateLabel = new System.Windows.Forms.Label();
            this.exportToPdfButton = new System.Windows.Forms.PictureBox();
            this.productsDatagrid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCardsLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exportToPdfButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(424, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(121, 29);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "DateLabel";
            // 
            // exportToPdfButton
            // 
            this.exportToPdfButton.Image = ((System.Drawing.Image)(resources.GetObject("exportToPdfButton.Image")));
            this.exportToPdfButton.Location = new System.Drawing.Point(12, 12);
            this.exportToPdfButton.Name = "exportToPdfButton";
            this.exportToPdfButton.Size = new System.Drawing.Size(77, 83);
            this.exportToPdfButton.TabIndex = 1;
            this.exportToPdfButton.TabStop = false;
            this.exportToPdfButton.Click += new System.EventHandler(this.exportToPdfButton_Click);
            // 
            // productsDatagrid
            // 
            this.productsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.MeasurementType,
            this.Quantity});
            this.productsDatagrid.Location = new System.Drawing.Point(135, 129);
            this.productsDatagrid.MultiSelect = false;
            this.productsDatagrid.Name = "productsDatagrid";
            this.productsDatagrid.RowTemplate.Height = 28;
            this.productsDatagrid.Size = new System.Drawing.Size(708, 377);
            this.productsDatagrid.TabIndex = 2;
            this.productsDatagrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.productsDatagrid_CellBeginEdit);
            this.productsDatagrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDatagrid_CellEndEdit);
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // MeasurementType
            // 
            this.MeasurementType.HeaderText = "Мярка";
            this.MeasurementType.Name = "MeasurementType";
            this.MeasurementType.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            // 
            // foodCardsLabel
            // 
            this.foodCardsLabel.AutoSize = true;
            this.foodCardsLabel.Location = new System.Drawing.Point(389, 77);
            this.foodCardsLabel.Name = "foodCardsLabel";
            this.foodCardsLabel.Size = new System.Drawing.Size(186, 29);
            this.foodCardsLabel.TabIndex = 3;
            this.foodCardsLabel.Text = "FoodCardsLabel";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(272, 535);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(171, 53);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Запиши";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(509, 535);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 53);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Откажи";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ReviewPreliminaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 611);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.foodCardsLabel);
            this.Controls.Add(this.productsDatagrid);
            this.Controls.Add(this.exportToPdfButton);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReviewPreliminaryCalculation";
            this.Text = "Преглед предватителна калкулация";
            this.Load += new System.EventHandler(this.ReviewPreliminaryCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportToPdfButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox exportToPdfButton;
        private System.Windows.Forms.DataGridView productsDatagrid;
        private System.Windows.Forms.Label foodCardsLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}