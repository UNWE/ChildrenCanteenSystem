namespace ChildrenCanteenSystem
{
    partial class NewPreliminaryCalculation
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
            this.components = new System.ComponentModel.Container();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.foodCardsCountLabel = new System.Windows.Forms.Label();
            this.foodCardsCount = new System.Windows.Forms.TextBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(454, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 35);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(256, 73);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 29);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // foodCardsCountLabel
            // 
            this.foodCardsCountLabel.AutoSize = true;
            this.foodCardsCountLabel.Location = new System.Drawing.Point(162, 158);
            this.foodCardsCountLabel.Name = "foodCardsCountLabel";
            this.foodCardsCountLabel.Size = new System.Drawing.Size(159, 29);
            this.foodCardsCountLabel.TabIndex = 2;
            this.foodCardsCountLabel.Text = "Брой купони";
            // 
            // foodCardsCount
            // 
            this.foodCardsCount.Location = new System.Drawing.Point(454, 158);
            this.foodCardsCount.Name = "foodCardsCount";
            this.foodCardsCount.Size = new System.Drawing.Size(200, 35);
            this.foodCardsCount.TabIndex = 3;
            this.foodCardsCount.TextChanged += new System.EventHandler(this.foodCardsCount_TextChanged);
            // 
            // previewButton
            // 
            this.previewButton.Enabled = false;
            this.previewButton.Location = new System.Drawing.Point(294, 255);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(218, 52);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Преглед";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewPreliminaryCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 376);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.foodCardsCount);
            this.Controls.Add(this.foodCardsCountLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.datePicker);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewPreliminaryCalculation";
            this.Text = "NewPreliminaryCalcularion";
            this.Load += new System.EventHandler(this.NewPreliminaryCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label foodCardsCountLabel;
        private System.Windows.Forms.TextBox foodCardsCount;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}