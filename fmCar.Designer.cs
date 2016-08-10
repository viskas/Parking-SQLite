namespace Parking
{
    partial class fmCar
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
            this.grData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bbOK = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.pnInsertEdit = new System.Windows.Forms.Panel();
            this.eRegNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eColorCar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eTypeCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eSecondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bOkInsert = new System.Windows.Forms.Button();
            this.bCancelInsert = new System.Windows.Forms.Button();
            this.eDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbDel = new System.Windows.Forms.ToolStripButton();
            this.bAddType = new System.Windows.Forms.Button();
            this.bDelType = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grData)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnInsertEdit.SuspendLayout();
            this.tbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grData
            // 
            this.grData.AllowUserToAddRows = false;
            this.grData.AllowUserToDeleteRows = false;
            this.grData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grData.Location = new System.Drawing.Point(0, 218);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(559, 278);
            this.grData.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bbOK);
            this.panel2.Controls.Add(this.bbCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 37);
            this.panel2.TabIndex = 14;
            // 
            // bbOK
            // 
            this.bbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bbOK.Location = new System.Drawing.Point(356, 7);
            this.bbOK.Name = "bbOK";
            this.bbOK.Size = new System.Drawing.Size(75, 23);
            this.bbOK.TabIndex = 1;
            this.bbOK.Text = "OK";
            this.bbOK.UseVisualStyleBackColor = true;
            this.bbOK.Click += new System.EventHandler(this.bbOK_Click);
            // 
            // bbCancel
            // 
            this.bbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bbCancel.Location = new System.Drawing.Point(437, 7);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(75, 23);
            this.bbCancel.TabIndex = 0;
            this.bbCancel.Text = "Отмена";
            this.bbCancel.UseVisualStyleBackColor = true;
            // 
            // pnInsertEdit
            // 
            this.pnInsertEdit.Controls.Add(this.button1);
            this.pnInsertEdit.Controls.Add(this.button2);
            this.pnInsertEdit.Controls.Add(this.bDelType);
            this.pnInsertEdit.Controls.Add(this.bAddType);
            this.pnInsertEdit.Controls.Add(this.eRegNumber);
            this.pnInsertEdit.Controls.Add(this.label6);
            this.pnInsertEdit.Controls.Add(this.eColorCar);
            this.pnInsertEdit.Controls.Add(this.label5);
            this.pnInsertEdit.Controls.Add(this.eTypeCar);
            this.pnInsertEdit.Controls.Add(this.label4);
            this.pnInsertEdit.Controls.Add(this.eSecondName);
            this.pnInsertEdit.Controls.Add(this.label3);
            this.pnInsertEdit.Controls.Add(this.bOkInsert);
            this.pnInsertEdit.Controls.Add(this.bCancelInsert);
            this.pnInsertEdit.Controls.Add(this.eDescr);
            this.pnInsertEdit.Controls.Add(this.label2);
            this.pnInsertEdit.Controls.Add(this.eFirstName);
            this.pnInsertEdit.Controls.Add(this.label1);
            this.pnInsertEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInsertEdit.Location = new System.Drawing.Point(0, 25);
            this.pnInsertEdit.Name = "pnInsertEdit";
            this.pnInsertEdit.Size = new System.Drawing.Size(559, 193);
            this.pnInsertEdit.TabIndex = 13;
            // 
            // eRegNumber
            // 
            this.eRegNumber.Location = new System.Drawing.Point(89, 111);
            this.eRegNumber.Name = "eRegNumber";
            this.eRegNumber.Size = new System.Drawing.Size(423, 20);
            this.eRegNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Гос. №";
            // 
            // eColorCar
            // 
            this.eColorCar.Location = new System.Drawing.Point(89, 85);
            this.eColorCar.Name = "eColorCar";
            this.eColorCar.Size = new System.Drawing.Size(374, 20);
            this.eColorCar.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цвет";
            // 
            // eTypeCar
            // 
            this.eTypeCar.Location = new System.Drawing.Point(89, 59);
            this.eTypeCar.Name = "eTypeCar";
            this.eTypeCar.Size = new System.Drawing.Size(374, 20);
            this.eTypeCar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип";
            // 
            // eSecondName
            // 
            this.eSecondName.Location = new System.Drawing.Point(89, 33);
            this.eSecondName.Name = "eSecondName";
            this.eSecondName.Size = new System.Drawing.Size(423, 20);
            this.eSecondName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Модель";
            // 
            // bOkInsert
            // 
            this.bOkInsert.Location = new System.Drawing.Point(356, 163);
            this.bOkInsert.Name = "bOkInsert";
            this.bOkInsert.Size = new System.Drawing.Size(75, 23);
            this.bOkInsert.TabIndex = 7;
            this.bOkInsert.Text = "OK";
            this.bOkInsert.UseVisualStyleBackColor = true;
            this.bOkInsert.Click += new System.EventHandler(this.bOkInsert_Click);
            // 
            // bCancelInsert
            // 
            this.bCancelInsert.Location = new System.Drawing.Point(437, 163);
            this.bCancelInsert.Name = "bCancelInsert";
            this.bCancelInsert.Size = new System.Drawing.Size(75, 23);
            this.bCancelInsert.TabIndex = 8;
            this.bCancelInsert.Text = "Отмена";
            this.bCancelInsert.UseVisualStyleBackColor = true;
            this.bCancelInsert.Click += new System.EventHandler(this.bCancelInsert_Click);
            // 
            // eDescr
            // 
            this.eDescr.Location = new System.Drawing.Point(89, 137);
            this.eDescr.Name = "eDescr";
            this.eDescr.Size = new System.Drawing.Size(423, 20);
            this.eDescr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Примечания";
            // 
            // eFirstName
            // 
            this.eFirstName.Location = new System.Drawing.Point(89, 7);
            this.eFirstName.Name = "eFirstName";
            this.eFirstName.Size = new System.Drawing.Size(423, 20);
            this.eFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // tbarMain
            // 
            this.tbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRefresh,
            this.toolStripSeparator1,
            this.tbAdd,
            this.tbEdit,
            this.tbDel});
            this.tbarMain.Location = new System.Drawing.Point(0, 0);
            this.tbarMain.Name = "tbarMain";
            this.tbarMain.Size = new System.Drawing.Size(559, 25);
            this.tbarMain.TabIndex = 12;
            this.tbarMain.Text = "toolStrip1";
            // 
            // tbRefresh
            // 
            this.tbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefresh.Image = global::Parking.Properties.Resources.refresh;
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tbRefresh.Text = "Обновить";
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbAdd
            // 
            this.tbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAdd.Image = global::Parking.Properties.Resources.add_16;
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(23, 22);
            this.tbAdd.Text = "Добавить";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEdit.Image = global::Parking.Properties.Resources.edit_16;
            this.tbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(23, 22);
            this.tbEdit.Text = "Редактировать";
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // tbDel
            // 
            this.tbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDel.Image = global::Parking.Properties.Resources.del_16;
            this.tbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(23, 22);
            this.tbDel.Text = "Удалить";
            this.tbDel.Click += new System.EventHandler(this.tbDel_Click);
            // 
            // bAddType
            // 
            this.bAddType.Location = new System.Drawing.Point(460, 59);
            this.bAddType.Name = "bAddType";
            this.bAddType.Size = new System.Drawing.Size(26, 23);
            this.bAddType.TabIndex = 14;
            this.bAddType.Text = "...";
            this.bAddType.UseVisualStyleBackColor = true;
            this.bAddType.Click += new System.EventHandler(this.bAddType_Click);
            // 
            // bDelType
            // 
            this.bDelType.Location = new System.Drawing.Point(486, 59);
            this.bDelType.Name = "bDelType";
            this.bDelType.Size = new System.Drawing.Size(26, 23);
            this.bDelType.TabIndex = 15;
            this.bDelType.Text = "X";
            this.bDelType.UseVisualStyleBackColor = true;
            this.bDelType.Click += new System.EventHandler(this.bDelType_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 533);
            this.Controls.Add(this.grData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnInsertEdit);
            this.Controls.Add(this.tbarMain);
            this.Name = "fmCar";
            this.Text = "Машины";
            this.Load += new System.EventHandler(this.fmCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnInsertEdit.ResumeLayout(false);
            this.pnInsertEdit.PerformLayout();
            this.tbarMain.ResumeLayout(false);
            this.tbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbOK;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Panel pnInsertEdit;
        private System.Windows.Forms.TextBox eRegNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eColorCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eTypeCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eSecondName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bOkInsert;
        private System.Windows.Forms.Button bCancelInsert;
        private System.Windows.Forms.TextBox eDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bDelType;
        private System.Windows.Forms.Button bAddType;
    }
}