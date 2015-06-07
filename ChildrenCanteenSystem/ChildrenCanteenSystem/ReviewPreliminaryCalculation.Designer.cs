namespace ChildrenCanteenSystem
{
    partial class ReviewPreliminaryCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewPreliminaryCalculation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateLabel = new System.Windows.Forms.Label();
            this.productsDatagrid = new System.Windows.Forms.DataGridView();
            this.exportCalculationButton = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.reviewButton = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCalculationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(294, 34);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 29);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Date";
            // 
            // productsDatagrid
            // 
            this.productsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.MeasurementUnit,
            this.Quantity});
            this.productsDatagrid.Location = new System.Drawing.Point(95, 108);
            this.productsDatagrid.Name = "productsDatagrid";
            this.productsDatagrid.RowTemplate.Height = 28;
            this.productsDatagrid.Size = new System.Drawing.Size(781, 399);
            this.productsDatagrid.TabIndex = 4;
            // 
            // exportCalculationButton
            // 
            this.exportCalculationButton.Image = ((System.Drawing.Image)(resources.GetObject("exportCalculationButton.Image")));
            this.exportCalculationButton.Location = new System.Drawing.Point(12, 12);
            this.exportCalculationButton.Name = "exportCalculationButton";
            this.exportCalculationButton.Size = new System.Drawing.Size(77, 78);
            this.exportCalculationButton.TabIndex = 2;
            this.exportCalculationButton.TabStop = false;
            this.exportCalculationButton.Click += new System.EventHandler(this.exportCalculationButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(381, 522);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(181, 56);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактиране";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(263, 522);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 56);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Запис";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(496, 522);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(181, 56);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(263, 34);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 35);
            this.datePicker.TabIndex = 9;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(496, 30);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(143, 39);
            this.reviewButton.TabIndex = 10;
            this.reviewButton.Text = "Преглед";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // Product
            // 
            dataGridViewCellStyle1.Format = "#.##";
            dataGridViewCellStyle1.NullValue = null;
            this.Product.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity.HeaderText = "Количество";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // ReviewPreliminaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 590);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.productsDatagrid);
            this.Controls.Add(this.exportCalculationButton);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReviewPreliminaryCalculation";
            this.Text = "ReviewPreliminaryCalculation";
            ((System.ComponentModel.ISupportInitialize)(this.productsDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportCalculationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exportCalculationButton;
        private System.Windows.Forms.DataGridView productsDatagrid;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}