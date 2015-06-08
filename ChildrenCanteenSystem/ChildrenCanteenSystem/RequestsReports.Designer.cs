namespace ChildrenCanteenSystem
{
    partial class RequestsReports
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
            this.reportButton = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.DataGridView();
            this.reportLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromDataLabel = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityForThePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(426, 177);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(173, 43);
            this.reportButton.TabIndex = 13;
            this.reportButton.Text = "Генерирай";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
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
            this.ProductId,
            this.ProductName,
            this.MeasurementUnit,
            this.Batch,
            this.QuantityForThePeriod});
            this.products.Location = new System.Drawing.Point(90, 244);
            this.products.Name = "products";
            this.products.RowTemplate.Height = 28;
            this.products.Size = new System.Drawing.Size(861, 270);
            this.products.TabIndex = 12;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(464, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(105, 29);
            this.reportLabel.TabIndex = 11;
            this.reportLabel.Text = "Справка";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(670, 59);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(97, 29);
            this.toDateLabel.TabIndex = 10;
            this.toDateLabel.Text = "До дата";
            // 
            // fromDataLabel
            // 
            this.fromDataLabel.AutoSize = true;
            this.fromDataLabel.Location = new System.Drawing.Point(291, 59);
            this.fromDataLabel.Name = "fromDataLabel";
            this.fromDataLabel.Size = new System.Drawing.Size(96, 29);
            this.fromDataLabel.TabIndex = 9;
            this.fromDataLabel.Text = "От дата";
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(573, 117);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(274, 35);
            this.toDate.TabIndex = 8;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(194, 117);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(274, 35);
            this.fromDate.TabIndex = 7;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Код";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
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
            // Batch
            // 
            this.Batch.HeaderText = "Партида";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // QuantityForThePeriod
            // 
            this.QuantityForThePeriod.HeaderText = "Количество за периода";
            this.QuantityForThePeriod.Name = "QuantityForThePeriod";
            this.QuantityForThePeriod.ReadOnly = true;
            // 
            // RequestsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 536);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.products);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromDataLabel);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RequestsReports";
            this.Text = "Справки искания";
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityForThePeriod;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.Label fromDataLabel;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
    }
}