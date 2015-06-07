namespace ChildrenCanteenSystem
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewCalculationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCalculationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewRequestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRequestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsByCalculationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsByRequestsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ястияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прегледToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прегледToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новаРецептаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationStatus = new System.Windows.Forms.StatusStrip();
            this.applicationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.applicationStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ястияToolStripMenuItem,
            this.рецептиToolStripMenuItem,
            this.menusMenuItem,
            this.calculationsMenuItem,
            this.requestsMenuItem,
            this.reportsMenuItem,
            this.newUserMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(978, 37);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // menusMenuItem
            // 
            this.menusMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewMenuMenuItem,
            this.newMenuMenuItem});
            this.menusMenuItem.Name = "menusMenuItem";
            this.menusMenuItem.Size = new System.Drawing.Size(116, 33);
            this.menusMenuItem.Text = "Менюта";
            // 
            // reviewMenuMenuItem
            // 
            this.reviewMenuMenuItem.Name = "reviewMenuMenuItem";
            this.reviewMenuMenuItem.Size = new System.Drawing.Size(213, 34);
            this.reviewMenuMenuItem.Text = "Преглед";
            this.reviewMenuMenuItem.Click += new System.EventHandler(this.reviewMenuMenuItem_Click);
            // 
            // newMenuMenuItem
            // 
            this.newMenuMenuItem.Name = "newMenuMenuItem";
            this.newMenuMenuItem.Size = new System.Drawing.Size(213, 34);
            this.newMenuMenuItem.Text = "Ново меню";
            this.newMenuMenuItem.Click += new System.EventHandler(this.newMenuMenuItem_Click);
            // 
            // calculationsMenuItem
            // 
            this.calculationsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewCalculationMenuItem,
            this.newCalculationMenuItem});
            this.calculationsMenuItem.Name = "calculationsMenuItem";
            this.calculationsMenuItem.Size = new System.Drawing.Size(163, 33);
            this.calculationsMenuItem.Text = "Калкулации";
            // 
            // reviewCalculationMenuItem
            // 
            this.reviewCalculationMenuItem.Name = "reviewCalculationMenuItem";
            this.reviewCalculationMenuItem.Size = new System.Drawing.Size(281, 34);
            this.reviewCalculationMenuItem.Text = "Преглед";
            this.reviewCalculationMenuItem.Click += new System.EventHandler(this.reviewCalculationMenuItem_Click);
            // 
            // newCalculationMenuItem
            // 
            this.newCalculationMenuItem.Name = "newCalculationMenuItem";
            this.newCalculationMenuItem.Size = new System.Drawing.Size(281, 34);
            this.newCalculationMenuItem.Text = "Нова калкулация";
            this.newCalculationMenuItem.Click += new System.EventHandler(this.newCalculationMenuItem_Click);
            // 
            // requestsMenuItem
            // 
            this.requestsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reviewRequestMenuItem,
            this.newRequestMenuItem});
            this.requestsMenuItem.Name = "requestsMenuItem";
            this.requestsMenuItem.Size = new System.Drawing.Size(124, 33);
            this.requestsMenuItem.Text = "Искания";
            // 
            // reviewRequestMenuItem
            // 
            this.reviewRequestMenuItem.Name = "reviewRequestMenuItem";
            this.reviewRequestMenuItem.Size = new System.Drawing.Size(228, 34);
            this.reviewRequestMenuItem.Text = "Преглед";
            this.reviewRequestMenuItem.Click += new System.EventHandler(this.reviewRequestMenuItem_Click);
            // 
            // newRequestMenuItem
            // 
            this.newRequestMenuItem.Name = "newRequestMenuItem";
            this.newRequestMenuItem.Size = new System.Drawing.Size(228, 34);
            this.newRequestMenuItem.Text = "Ново искане";
            this.newRequestMenuItem.Click += new System.EventHandler(this.newRequestMenuItem_Click);
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsByCalculationsMenuItem,
            this.reportsByRequestsMenuItem});
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(120, 33);
            this.reportsMenuItem.Text = "Справки";
            // 
            // reportsByCalculationsMenuItem
            // 
            this.reportsByCalculationsMenuItem.Name = "reportsByCalculationsMenuItem";
            this.reportsByCalculationsMenuItem.Size = new System.Drawing.Size(258, 34);
            this.reportsByCalculationsMenuItem.Text = "По калкулации";
            // 
            // reportsByRequestsMenuItem
            // 
            this.reportsByRequestsMenuItem.Name = "reportsByRequestsMenuItem";
            this.reportsByRequestsMenuItem.Size = new System.Drawing.Size(258, 34);
            this.reportsByRequestsMenuItem.Text = "По искания";
            // 
            // ястияToolStripMenuItem
            // 
            this.ястияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прегледToolStripMenuItem,
            this.новоToolStripMenuItem});
            this.ястияToolStripMenuItem.Name = "ястияToolStripMenuItem";
            this.ястияToolStripMenuItem.Size = new System.Drawing.Size(92, 33);
            this.ястияToolStripMenuItem.Text = "Ястия";
            // 
            // прегледToolStripMenuItem
            // 
            this.прегледToolStripMenuItem.Name = "прегледToolStripMenuItem";
            this.прегледToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.прегледToolStripMenuItem.Text = "Преглед";
            // 
            // новоToolStripMenuItem
            // 
            this.новоToolStripMenuItem.Name = "новоToolStripMenuItem";
            this.новоToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.новоToolStripMenuItem.Text = "Ново ястие";
            // 
            // рецептиToolStripMenuItem
            // 
            this.рецептиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прегледToolStripMenuItem1,
            this.новаРецептаToolStripMenuItem});
            this.рецептиToolStripMenuItem.Name = "рецептиToolStripMenuItem";
            this.рецептиToolStripMenuItem.Size = new System.Drawing.Size(118, 33);
            this.рецептиToolStripMenuItem.Text = "Рецепти";
            // 
            // прегледToolStripMenuItem1
            // 
            this.прегледToolStripMenuItem1.Name = "прегледToolStripMenuItem1";
            this.прегледToolStripMenuItem1.Size = new System.Drawing.Size(238, 34);
            this.прегледToolStripMenuItem1.Text = "Преглед";
            // 
            // новаРецептаToolStripMenuItem
            // 
            this.новаРецептаToolStripMenuItem.Name = "новаРецептаToolStripMenuItem";
            this.новаРецептаToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.новаРецептаToolStripMenuItem.Text = "Нова рецепта";
            // 
            // newUserMenuItem
            // 
            this.newUserMenuItem.Name = "newUserMenuItem";
            this.newUserMenuItem.Size = new System.Drawing.Size(205, 33);
            this.newUserMenuItem.Text = "Нов потребител";
            this.newUserMenuItem.Click += new System.EventHandler(this.newUserMenuItem_Click);
            // 
            // applicationStatus
            // 
            this.applicationStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.applicationStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationStatusLabel});
            this.applicationStatus.Location = new System.Drawing.Point(0, 718);
            this.applicationStatus.Name = "applicationStatus";
            this.applicationStatus.Size = new System.Drawing.Size(978, 26);
            this.applicationStatus.TabIndex = 3;
            this.applicationStatus.Text = "statusStrip1";
            // 
            // applicationStatusLabel
            // 
            this.applicationStatusLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applicationStatusLabel.Name = "applicationStatusLabel";
            this.applicationStatusLabel.Size = new System.Drawing.Size(181, 21);
            this.applicationStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.applicationStatus);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.applicationStatus.ResumeLayout(false);
            this.applicationStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menusMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewCalculationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCalculationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewRequestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRequestMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsByCalculationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsByRequestsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ястияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прегледToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прегледToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новаРецептаToolStripMenuItem;
        private System.Windows.Forms.StatusStrip applicationStatus;
        private System.Windows.Forms.ToolStripStatusLabel applicationStatusLabel;
    }
}