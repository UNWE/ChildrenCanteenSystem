namespace ChildrenCanteenSystem
{
    partial class NewMenu
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.thirdMealLabel = new System.Windows.Forms.Label();
            this.secondMealLabel = new System.Windows.Forms.Label();
            this.firstMealLabel = new System.Windows.Forms.Label();
            this.firstMeal = new System.Windows.Forms.ComboBox();
            this.secondMeal = new System.Windows.Forms.ComboBox();
            this.thirdMeal = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(144, 28);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 35);
            this.datePicker.TabIndex = 0;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(34, 33);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(65, 29);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // thirdMealLabel
            // 
            this.thirdMealLabel.AutoSize = true;
            this.thirdMealLabel.Location = new System.Drawing.Point(752, 224);
            this.thirdMealLabel.Name = "thirdMealLabel";
            this.thirdMealLabel.Size = new System.Drawing.Size(90, 29);
            this.thirdMealLabel.TabIndex = 2;
            this.thirdMealLabel.Text = "Десерт";
            // 
            // secondMealLabel
            // 
            this.secondMealLabel.AutoSize = true;
            this.secondMealLabel.Location = new System.Drawing.Point(430, 224);
            this.secondMealLabel.Name = "secondMealLabel";
            this.secondMealLabel.Size = new System.Drawing.Size(110, 29);
            this.secondMealLabel.TabIndex = 3;
            this.secondMealLabel.Text = "Основно";
            // 
            // firstMealLabel
            // 
            this.firstMealLabel.AutoSize = true;
            this.firstMealLabel.Location = new System.Drawing.Point(91, 224);
            this.firstMealLabel.Name = "firstMealLabel";
            this.firstMealLabel.Size = new System.Drawing.Size(133, 29);
            this.firstMealLabel.TabIndex = 4;
            this.firstMealLabel.Text = "Предястие";
            // 
            // firstMeal
            // 
            this.firstMeal.FormattingEnabled = true;
            this.firstMeal.Location = new System.Drawing.Point(22, 307);
            this.firstMeal.Name = "firstMeal";
            this.firstMeal.Size = new System.Drawing.Size(284, 37);
            this.firstMeal.TabIndex = 5;
            this.firstMeal.SelectedIndexChanged += new System.EventHandler(this.firstMeal_SelectedIndexChanged);
            // 
            // secondMeal
            // 
            this.secondMeal.FormattingEnabled = true;
            this.secondMeal.Location = new System.Drawing.Point(342, 307);
            this.secondMeal.Name = "secondMeal";
            this.secondMeal.Size = new System.Drawing.Size(284, 37);
            this.secondMeal.TabIndex = 6;
            this.secondMeal.SelectedIndexChanged += new System.EventHandler(this.secondMeal_SelectedIndexChanged);
            // 
            // thirdMeal
            // 
            this.thirdMeal.FormattingEnabled = true;
            this.thirdMeal.Location = new System.Drawing.Point(654, 307);
            this.thirdMeal.Name = "thirdMeal";
            this.thirdMeal.Size = new System.Drawing.Size(284, 37);
            this.thirdMeal.TabIndex = 7;
            this.thirdMeal.SelectedIndexChanged += new System.EventHandler(this.thirdMeal_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(268, 435);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(171, 56);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(510, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 56);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Откажи";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 554);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.thirdMeal);
            this.Controls.Add(this.secondMeal);
            this.Controls.Add(this.firstMeal);
            this.Controls.Add(this.firstMealLabel);
            this.Controls.Add(this.secondMealLabel);
            this.Controls.Add(this.thirdMealLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.datePicker);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ново меню";
            this.Load += new System.EventHandler(this.NewMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label thirdMealLabel;
        private System.Windows.Forms.Label secondMealLabel;
        private System.Windows.Forms.Label firstMealLabel;
        private System.Windows.Forms.ComboBox firstMeal;
        private System.Windows.Forms.ComboBox secondMeal;
        private System.Windows.Forms.ComboBox thirdMeal;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}