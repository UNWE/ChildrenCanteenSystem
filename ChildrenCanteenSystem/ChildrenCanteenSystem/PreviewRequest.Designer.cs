namespace ChildrenCanteenSystem
{
    partial class PreviewRequest
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
            this.saveButton = new System.Windows.Forms.Button();
            this.availabilitiesLabel = new System.Windows.Forms.Label();
            this.availabilities = new System.Windows.Forms.DataGridView();
            this.productsLabel = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.DataGridView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailabilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(392, 422);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 55);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Запис";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // availabilitiesLabel
            // 
            this.availabilitiesLabel.AutoSize = true;
            this.availabilitiesLabel.Location = new System.Drawing.Point(854, 57);
            this.availabilitiesLabel.Name = "availabilitiesLabel";
            this.availabilitiesLabel.Size = new System.Drawing.Size(138, 27);
            this.availabilitiesLabel.TabIndex = 12;
            this.availabilitiesLabel.Text = "Наличности";
            // 
            // availabilities
            // 
            this.availabilities.AllowUserToAddRows = false;
            this.availabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availabilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.availabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvailabilityId,
            this.ProductId,
            this.Batch,
            this.UnitPrice,
            this.RequatedQuantity});
            this.availabilities.Location = new System.Drawing.Point(586, 111);
            this.availabilities.Name = "availabilities";
            this.availabilities.RowTemplate.Height = 28;
            this.availabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availabilities.Size = new System.Drawing.Size(650, 289);
            this.availabilities.TabIndex = 11;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(249, 57);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(113, 27);
            this.productsLabel.TabIndex = 10;
            this.productsLabel.Text = "Продукти";
            // 
            // products
            // 
            this.products.AllowUserToAddRows = false;
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Product,
            this.MeasurementUnit,
            this.TotalQuantity});
            this.products.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.products.Location = new System.Drawing.Point(12, 111);
            this.products.Name = "products";
            this.products.RowTemplate.Height = 28;
            this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products.Size = new System.Drawing.Size(547, 289);
            this.products.TabIndex = 9;
            this.products.SelectionChanged += new System.EventHandler(this.products_SelectionChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(453, 19);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 27);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Дата";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(586, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 55);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Отказ";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
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
            // TotalQuantity
            // 
            this.TotalQuantity.HeaderText = "Общо количество";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // AvailabilityId
            // 
            this.AvailabilityId.HeaderText = "Код наличност";
            this.AvailabilityId.Name = "AvailabilityId";
            this.AvailabilityId.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код продукт";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Партида";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Ед. цена";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // RequatedQuantity
            // 
            this.RequatedQuantity.HeaderText = "Искано количество";
            this.RequatedQuantity.Name = "RequatedQuantity";
            this.RequatedQuantity.ReadOnly = true;
            // 
            // PreviewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 516);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.availabilitiesLabel);
            this.Controls.Add(this.availabilities);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.products);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PreviewRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преглед искане";
            this.Load += new System.EventHandler(this.PreviewRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label availabilitiesLabel;
        private System.Windows.Forms.DataGridView availabilities;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailabilityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequatedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;

    }
}