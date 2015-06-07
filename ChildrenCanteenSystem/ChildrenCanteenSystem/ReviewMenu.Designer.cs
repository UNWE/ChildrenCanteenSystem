namespace ChildrenCanteenSystem
{
    partial class ReviewMenu
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
            this.reviewButton = new System.Windows.Forms.Button();
            this.firstMealLabel = new System.Windows.Forms.Label();
            this.secondMealLabel = new System.Windows.Forms.Label();
            this.thirdMealLabel = new System.Windows.Forms.Label();
            this.foodCardsCountLabel = new System.Windows.Forms.Label();
            this.foodCardsCount = new System.Windows.Forms.TextBox();
            this.firstMeal = new System.Windows.Forms.ComboBox();
            this.secondMeal = new System.Windows.Forms.ComboBox();
            this.thirdMeal = new System.Windows.Forms.ComboBox();
            this.firstMealTextBox = new System.Windows.Forms.TextBox();
            this.secondMealTextBox = new System.Windows.Forms.TextBox();
            this.thirdMealTextBox = new System.Windows.Forms.TextBox();
            this.menuDateLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(67, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 35);
            this.datePicker.TabIndex = 0;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(332, 28);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(180, 39);
            this.reviewButton.TabIndex = 1;
            this.reviewButton.Text = "Преглед";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // firstMealLabel
            // 
            this.firstMealLabel.AutoSize = true;
            this.firstMealLabel.Location = new System.Drawing.Point(78, 173);
            this.firstMealLabel.Name = "firstMealLabel";
            this.firstMealLabel.Size = new System.Drawing.Size(133, 29);
            this.firstMealLabel.TabIndex = 5;
            this.firstMealLabel.Text = "Предястие";
            // 
            // secondMealLabel
            // 
            this.secondMealLabel.AutoSize = true;
            this.secondMealLabel.Location = new System.Drawing.Point(405, 173);
            this.secondMealLabel.Name = "secondMealLabel";
            this.secondMealLabel.Size = new System.Drawing.Size(110, 29);
            this.secondMealLabel.TabIndex = 6;
            this.secondMealLabel.Text = "Основно";
            // 
            // thirdMealLabel
            // 
            this.thirdMealLabel.AutoSize = true;
            this.thirdMealLabel.Location = new System.Drawing.Point(726, 173);
            this.thirdMealLabel.Name = "thirdMealLabel";
            this.thirdMealLabel.Size = new System.Drawing.Size(90, 29);
            this.thirdMealLabel.TabIndex = 7;
            this.thirdMealLabel.Text = "Десерт";
            // 
            // foodCardsCountLabel
            // 
            this.foodCardsCountLabel.AutoSize = true;
            this.foodCardsCountLabel.Location = new System.Drawing.Point(384, 339);
            this.foodCardsCountLabel.Name = "foodCardsCountLabel";
            this.foodCardsCountLabel.Size = new System.Drawing.Size(269, 29);
            this.foodCardsCountLabel.TabIndex = 8;
            this.foodCardsCountLabel.Text = "Брой закупени купони";
            // 
            // foodCardsCount
            // 
            this.foodCardsCount.Location = new System.Drawing.Point(301, 395);
            this.foodCardsCount.Name = "foodCardsCount";
            this.foodCardsCount.ReadOnly = true;
            this.foodCardsCount.Size = new System.Drawing.Size(328, 35);
            this.foodCardsCount.TabIndex = 9;
            this.foodCardsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstMeal
            // 
            this.firstMeal.FormattingEnabled = true;
            this.firstMeal.Location = new System.Drawing.Point(19, 263);
            this.firstMeal.Name = "firstMeal";
            this.firstMeal.Size = new System.Drawing.Size(284, 37);
            this.firstMeal.TabIndex = 10;
            // 
            // secondMeal
            // 
            this.secondMeal.FormattingEnabled = true;
            this.secondMeal.Location = new System.Drawing.Point(320, 263);
            this.secondMeal.Name = "secondMeal";
            this.secondMeal.Size = new System.Drawing.Size(284, 37);
            this.secondMeal.TabIndex = 11;
            // 
            // thirdMeal
            // 
            this.thirdMeal.FormattingEnabled = true;
            this.thirdMeal.Location = new System.Drawing.Point(631, 263);
            this.thirdMeal.Name = "thirdMeal";
            this.thirdMeal.Size = new System.Drawing.Size(284, 37);
            this.thirdMeal.TabIndex = 12;
            // 
            // firstMealTextBox
            // 
            this.firstMealTextBox.Location = new System.Drawing.Point(19, 265);
            this.firstMealTextBox.Name = "firstMealTextBox";
            this.firstMealTextBox.ReadOnly = true;
            this.firstMealTextBox.Size = new System.Drawing.Size(284, 35);
            this.firstMealTextBox.TabIndex = 13;
            this.firstMealTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondMealTextBox
            // 
            this.secondMealTextBox.Location = new System.Drawing.Point(320, 265);
            this.secondMealTextBox.Name = "secondMealTextBox";
            this.secondMealTextBox.ReadOnly = true;
            this.secondMealTextBox.Size = new System.Drawing.Size(284, 35);
            this.secondMealTextBox.TabIndex = 14;
            this.secondMealTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thirdMealTextBox
            // 
            this.thirdMealTextBox.Location = new System.Drawing.Point(631, 263);
            this.thirdMealTextBox.Name = "thirdMealTextBox";
            this.thirdMealTextBox.ReadOnly = true;
            this.thirdMealTextBox.Size = new System.Drawing.Size(284, 35);
            this.thirdMealTextBox.TabIndex = 15;
            this.thirdMealTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuDateLabel
            // 
            this.menuDateLabel.AutoSize = true;
            this.menuDateLabel.Location = new System.Drawing.Point(361, 37);
            this.menuDateLabel.Name = "menuDateLabel";
            this.menuDateLabel.Size = new System.Drawing.Size(125, 29);
            this.menuDateLabel.TabIndex = 16;
            this.menuDateLabel.Text = "MenuDate";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(376, 468);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(180, 39);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактиране";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(291, 468);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 39);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Запис";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(493, 468);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(147, 39);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Изтриване";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            // 
            // ReviewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 519);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.menuDateLabel);
            this.Controls.Add(this.thirdMealTextBox);
            this.Controls.Add(this.secondMealTextBox);
            this.Controls.Add(this.firstMealTextBox);
            this.Controls.Add(this.thirdMeal);
            this.Controls.Add(this.secondMeal);
            this.Controls.Add(this.firstMeal);
            this.Controls.Add(this.foodCardsCount);
            this.Controls.Add(this.foodCardsCountLabel);
            this.Controls.Add(this.thirdMealLabel);
            this.Controls.Add(this.secondMealLabel);
            this.Controls.Add(this.firstMealLabel);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.datePicker);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReviewMenu";
            this.Text = "ReviewMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Label firstMealLabel;
        private System.Windows.Forms.Label secondMealLabel;
        private System.Windows.Forms.Label thirdMealLabel;
        private System.Windows.Forms.Label foodCardsCountLabel;
        private System.Windows.Forms.TextBox foodCardsCount;
        private System.Windows.Forms.ComboBox firstMeal;
        private System.Windows.Forms.ComboBox secondMeal;
        private System.Windows.Forms.ComboBox thirdMeal;
        private System.Windows.Forms.TextBox firstMealTextBox;
        private System.Windows.Forms.TextBox secondMealTextBox;
        private System.Windows.Forms.TextBox thirdMealTextBox;
        private System.Windows.Forms.Label menuDateLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}