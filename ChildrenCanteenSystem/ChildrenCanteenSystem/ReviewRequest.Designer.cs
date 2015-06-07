namespace ChildrenCanteenSystem
{
    partial class ReviewRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewRequest));
            this.dateLabel = new System.Windows.Forms.Label();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridView();
            this.productsLabel = new System.Windows.Forms.Label();
            this.RequatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailabilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilities = new System.Windows.Forms.DataGridView();
            this.availabilitiesLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.requestDataLabel = new System.Windows.Forms.Label();
            this.pdfExportButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfExportButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(453, 29);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 27);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "Дата";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.HeaderText = "Общо количество";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // MeasurementUnit
            // 
            this.MeasurementUnit.HeaderText = "Мярка";
            this.MeasurementUnit.Name = "MeasurementUnit";
            this.MeasurementUnit.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Продукт";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // products
            // 
            this.products.AllowUserToAddRows = false;
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Product,
            this.MeasurementUnit,
            this.TotalQuantity});
            this.products.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.products.Location = new System.Drawing.Point(12, 121);
            this.products.Name = "products";
            this.products.RowTemplate.Height = 28;
            this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products.Size = new System.Drawing.Size(547, 289);
            this.products.TabIndex = 16;
            this.products.SelectionChanged += new System.EventHandler(this.products_SelectionChanged);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(249, 67);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(113, 27);
            this.productsLabel.TabIndex = 17;
            this.productsLabel.Text = "Продукти";
            // 
            // RequatedQuantity
            // 
            this.RequatedQuantity.HeaderText = "Искано количество";
            this.RequatedQuantity.Name = "RequatedQuantity";
            this.RequatedQuantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Ед. цена";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Batch
            // 
            this.Batch.HeaderText = "Партида";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код продукт";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // AvailabilityId
            // 
            this.AvailabilityId.HeaderText = "Код наличност";
            this.AvailabilityId.Name = "AvailabilityId";
            this.AvailabilityId.ReadOnly = true;
            // 
            // availabilities
            // 
            this.availabilities.AllowUserToAddRows = false;
            this.availabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availabilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.availabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvailabilityId,
            this.ProductId,
            this.Batch,
            this.UnitPrice,
            this.RequatedQuantity});
            this.availabilities.Location = new System.Drawing.Point(586, 121);
            this.availabilities.Name = "availabilities";
            this.availabilities.RowTemplate.Height = 28;
            this.availabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availabilities.Size = new System.Drawing.Size(650, 289);
            this.availabilities.TabIndex = 18;
            // 
            // availabilitiesLabel
            // 
            this.availabilitiesLabel.AutoSize = true;
            this.availabilitiesLabel.Location = new System.Drawing.Point(854, 67);
            this.availabilitiesLabel.Name = "availabilitiesLabel";
            this.availabilitiesLabel.Size = new System.Drawing.Size(138, 27);
            this.availabilitiesLabel.TabIndex = 19;
            this.availabilitiesLabel.Text = "Наличности";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(543, 24);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(244, 32);
            this.date.TabIndex = 20;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // requestDataLabel
            // 
            this.requestDataLabel.AutoSize = true;
            this.requestDataLabel.Location = new System.Drawing.Point(499, 29);
            this.requestDataLabel.Name = "requestDataLabel";
            this.requestDataLabel.Size = new System.Drawing.Size(60, 27);
            this.requestDataLabel.TabIndex = 21;
            this.requestDataLabel.Text = "Дата";
            // 
            // pdfExportButton
            // 
            this.pdfExportButton.Image = ((System.Drawing.Image)(resources.GetObject("pdfExportButton.Image")));
            this.pdfExportButton.Location = new System.Drawing.Point(23, 12);
            this.pdfExportButton.Name = "pdfExportButton";
            this.pdfExportButton.Size = new System.Drawing.Size(78, 82);
            this.pdfExportButton.TabIndex = 22;
            this.pdfExportButton.TabStop = false;
            this.pdfExportButton.Click += new System.EventHandler(this.pdfExportButton_Click);
            // 
            // ReviewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 458);
            this.Controls.Add(this.pdfExportButton);
            this.Controls.Add(this.requestDataLabel);
            this.Controls.Add(this.date);
            this.Controls.Add(this.availabilitiesLabel);
            this.Controls.Add(this.availabilities);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.products);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewRequest";
            this.Text = "Преглед искане";
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfExportButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequatedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailabilityId;
        private System.Windows.Forms.DataGridView availabilities;
        private System.Windows.Forms.Label availabilitiesLabel;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label requestDataLabel;
        private System.Windows.Forms.PictureBox pdfExportButton;

    }
}