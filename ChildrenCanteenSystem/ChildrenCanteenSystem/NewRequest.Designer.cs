namespace ChildrenCanteenSystem
{
    partial class NewRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsLabel = new System.Windows.Forms.Label();
            this.availabilities = new System.Windows.Forms.DataGridView();
            this.AvailabilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQiantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequatedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilitiesLabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(530, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(270, 32);
            this.date.TabIndex = 0;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(443, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 27);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // products
            // 
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
            this.QuantityNeeded,
            this.RequestedQuantity});
            this.products.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.products.Location = new System.Drawing.Point(11, 140);
            this.products.Name = "products";
            this.products.RowTemplate.Height = 28;
            this.products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products.Size = new System.Drawing.Size(547, 289);
            this.products.TabIndex = 2;
            this.products.SelectionChanged += new System.EventHandler(this.products_SelectionChanged);
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
            // QuantityNeeded
            // 
            this.QuantityNeeded.HeaderText = "Количество по калкулация";
            this.QuantityNeeded.Name = "QuantityNeeded";
            this.QuantityNeeded.ReadOnly = true;
            // 
            // RequestedQuantity
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.RequestedQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.RequestedQuantity.HeaderText = "Искано количество";
            this.RequestedQuantity.Name = "RequestedQuantity";
            this.RequestedQuantity.ReadOnly = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(167, 98);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(269, 27);
            this.productsLabel.TabIndex = 3;
            this.productsLabel.Text = "Продукти по калкулация";
            // 
            // availabilities
            // 
            this.availabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availabilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.availabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AvailabilityId,
            this.ProductId,
            this.Batch,
            this.UnitPrice,
            this.AvailableQiantity,
            this.RequatedQuantity});
            this.availabilities.Location = new System.Drawing.Point(587, 140);
            this.availabilities.Name = "availabilities";
            this.availabilities.RowTemplate.Height = 28;
            this.availabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availabilities.Size = new System.Drawing.Size(650, 289);
            this.availabilities.TabIndex = 4;
            this.availabilities.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.availabilities_CellBeginEdit);
            this.availabilities.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.availabilities_CellValueChanged);
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
            this.UnitPrice.HeaderText = "Ед.цена";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // AvailableQiantity
            // 
            this.AvailableQiantity.HeaderText = "Налично количество";
            this.AvailableQiantity.Name = "AvailableQiantity";
            this.AvailableQiantity.ReadOnly = true;
            // 
            // RequatedQuantity
            // 
            this.RequatedQuantity.HeaderText = "Искано количество";
            this.RequatedQuantity.Name = "RequatedQuantity";
            // 
            // availabilitiesLabel
            // 
            this.availabilitiesLabel.AutoSize = true;
            this.availabilitiesLabel.Location = new System.Drawing.Point(869, 98);
            this.availabilitiesLabel.Name = "availabilitiesLabel";
            this.availabilitiesLabel.Size = new System.Drawing.Size(138, 27);
            this.availabilitiesLabel.TabIndex = 5;
            this.availabilitiesLabel.Text = "Наличности";
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(489, 449);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(167, 55);
            this.previewButton.TabIndex = 6;
            this.previewButton.Text = "Преглед";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // NewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 516);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.availabilitiesLabel);
            this.Controls.Add(this.availabilities);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.products);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.date);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewRequest";
            this.Text = "Ново искане";
            this.Load += new System.EventHandler(this.NewRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.DataGridView availabilities;
        private System.Windows.Forms.Label availabilitiesLabel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityNeeded;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailabilityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQiantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequatedQuantity;
    }
}