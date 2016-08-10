namespace Parking
{
    partial class fmMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.nReferences = new System.Windows.Forms.ToolStripMenuItem();
            this.nCarType = new System.Windows.Forms.ToolStripMenuItem();
            this.nCarColor = new System.Windows.Forms.ToolStripMenuItem();
            this.nCar = new System.Windows.Forms.ToolStripMenuItem();
            this.nPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.nPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.nLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.nRegistartion = new System.Windows.Forms.ToolStripMenuItem();
            this.nHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nReferences,
            this.nRegistartion,
            this.nHistory});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(742, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // nReferences
            // 
            this.nReferences.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nCarType,
            this.nCarColor,
            this.nCar,
            this.nPeople,
            this.nPrice,
            this.nLocation});
            this.nReferences.Name = "nReferences";
            this.nReferences.Size = new System.Drawing.Size(94, 20);
            this.nReferences.Text = "Справочники";
            // 
            // nCarType
            // 
            this.nCarType.Name = "nCarType";
            this.nCarType.Size = new System.Drawing.Size(163, 22);
            this.nCarType.Text = "Типы машин";
            this.nCarType.Click += new System.EventHandler(this.nCarType_Click);
            // 
            // nCarColor
            // 
            this.nCarColor.Name = "nCarColor";
            this.nCarColor.Size = new System.Drawing.Size(163, 22);
            this.nCarColor.Text = "Цвета машин";
            this.nCarColor.Click += new System.EventHandler(this.nCarColor_Click);
            // 
            // nCar
            // 
            this.nCar.Name = "nCar";
            this.nCar.Size = new System.Drawing.Size(163, 22);
            this.nCar.Text = "Машины";
            this.nCar.Click += new System.EventHandler(this.nCar_Click);
            // 
            // nPeople
            // 
            this.nPeople.Name = "nPeople";
            this.nPeople.Size = new System.Drawing.Size(163, 22);
            this.nPeople.Text = "Владельцы";
            this.nPeople.Click += new System.EventHandler(this.nPeople_Click);
            // 
            // nPrice
            // 
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(163, 22);
            this.nPrice.Text = "Цена";
            this.nPrice.Click += new System.EventHandler(this.nPrice_Click);
            // 
            // nLocation
            // 
            this.nLocation.Name = "nLocation";
            this.nLocation.Size = new System.Drawing.Size(163, 22);
            this.nLocation.Text = "Места парковки";
            this.nLocation.Click += new System.EventHandler(this.nLocation_Click);
            // 
            // nRegistartion
            // 
            this.nRegistartion.Name = "nRegistartion";
            this.nRegistartion.Size = new System.Drawing.Size(72, 20);
            this.nRegistartion.Text = "Парковка";
            this.nRegistartion.Click += new System.EventHandler(this.nRegistartion_Click);
            // 
            // nHistory
            // 
            this.nHistory.Name = "nHistory";
            this.nHistory.Size = new System.Drawing.Size(66, 20);
            this.nHistory.Text = "История";
            this.nHistory.Click += new System.EventHandler(this.nHistory_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 514);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "fmMain";
            this.Text = "Парковка";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem nReferences;
        private System.Windows.Forms.ToolStripMenuItem nCarType;
        private System.Windows.Forms.ToolStripMenuItem nCarColor;
        private System.Windows.Forms.ToolStripMenuItem nCar;
        private System.Windows.Forms.ToolStripMenuItem nPeople;
        private System.Windows.Forms.ToolStripMenuItem nPrice;
        private System.Windows.Forms.ToolStripMenuItem nLocation;
        private System.Windows.Forms.ToolStripMenuItem nRegistartion;
        private System.Windows.Forms.ToolStripMenuItem nHistory;
    }
}