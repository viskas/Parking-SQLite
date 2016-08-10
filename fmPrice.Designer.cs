namespace Parking
{
    partial class fmPrice
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
            this.ePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDelType = new System.Windows.Forms.Button();
            this.bAddType = new System.Windows.Forms.Button();
            this.eCountDayPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eTypeCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bOkInsert = new System.Windows.Forms.Button();
            this.bCancelInsert = new System.Windows.Forms.Button();
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbDel = new System.Windows.Forms.ToolStripButton();
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
            this.grData.Location = new System.Drawing.Point(0, 114);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(541, 320);
            this.grData.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bbOK);
            this.panel2.Controls.Add(this.bbCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 37);
            this.panel2.TabIndex = 18;
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
            this.pnInsertEdit.Controls.Add(this.ePrice);
            this.pnInsertEdit.Controls.Add(this.label1);
            this.pnInsertEdit.Controls.Add(this.bDelType);
            this.pnInsertEdit.Controls.Add(this.bAddType);
            this.pnInsertEdit.Controls.Add(this.eCountDayPrice);
            this.pnInsertEdit.Controls.Add(this.label6);
            this.pnInsertEdit.Controls.Add(this.eTypeCar);
            this.pnInsertEdit.Controls.Add(this.label4);
            this.pnInsertEdit.Controls.Add(this.bOkInsert);
            this.pnInsertEdit.Controls.Add(this.bCancelInsert);
            this.pnInsertEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInsertEdit.Location = new System.Drawing.Point(0, 25);
            this.pnInsertEdit.Name = "pnInsertEdit";
            this.pnInsertEdit.Size = new System.Drawing.Size(541, 89);
            this.pnInsertEdit.TabIndex = 17;
            // 
            // ePrice
            // 
            this.ePrice.Location = new System.Drawing.Point(89, 34);
            this.ePrice.Name = "ePrice";
            this.ePrice.Size = new System.Drawing.Size(132, 20);
            this.ePrice.TabIndex = 16;
            this.ePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ePrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Цена 1 дня";
            // 
            // bDelType
            // 
            this.bDelType.Location = new System.Drawing.Point(486, 8);
            this.bDelType.Name = "bDelType";
            this.bDelType.Size = new System.Drawing.Size(26, 23);
            this.bDelType.TabIndex = 15;
            this.bDelType.Text = "X";
            this.bDelType.UseVisualStyleBackColor = true;
            this.bDelType.Click += new System.EventHandler(this.bDelType_Click);
            // 
            // bAddType
            // 
            this.bAddType.Location = new System.Drawing.Point(460, 8);
            this.bAddType.Name = "bAddType";
            this.bAddType.Size = new System.Drawing.Size(26, 23);
            this.bAddType.TabIndex = 14;
            this.bAddType.Text = "...";
            this.bAddType.UseVisualStyleBackColor = true;
            this.bAddType.Click += new System.EventHandler(this.bAddType_Click);
            // 
            // eCountDayPrice
            // 
            this.eCountDayPrice.Location = new System.Drawing.Point(324, 34);
            this.eCountDayPrice.Name = "eCountDayPrice";
            this.eCountDayPrice.Size = new System.Drawing.Size(188, 20);
            this.eCountDayPrice.TabIndex = 5;
            this.eCountDayPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eCountDayPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Для кол-ва дней";
            // 
            // eTypeCar
            // 
            this.eTypeCar.Location = new System.Drawing.Point(89, 8);
            this.eTypeCar.Name = "eTypeCar";
            this.eTypeCar.Size = new System.Drawing.Size(374, 20);
            this.eTypeCar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Тип";
            // 
            // bOkInsert
            // 
            this.bOkInsert.Location = new System.Drawing.Point(356, 60);
            this.bOkInsert.Name = "bOkInsert";
            this.bOkInsert.Size = new System.Drawing.Size(75, 23);
            this.bOkInsert.TabIndex = 7;
            this.bOkInsert.Text = "OK";
            this.bOkInsert.UseVisualStyleBackColor = true;
            this.bOkInsert.Click += new System.EventHandler(this.bOkInsert_Click);
            // 
            // bCancelInsert
            // 
            this.bCancelInsert.Location = new System.Drawing.Point(437, 60);
            this.bCancelInsert.Name = "bCancelInsert";
            this.bCancelInsert.Size = new System.Drawing.Size(75, 23);
            this.bCancelInsert.TabIndex = 8;
            this.bCancelInsert.Text = "Отмена";
            this.bCancelInsert.UseVisualStyleBackColor = true;
            this.bCancelInsert.Click += new System.EventHandler(this.bCancelInsert_Click);
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
            this.tbarMain.Size = new System.Drawing.Size(541, 25);
            this.tbarMain.TabIndex = 16;
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
            // fmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 471);
            this.Controls.Add(this.grData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnInsertEdit);
            this.Controls.Add(this.tbarMain);
            this.Name = "fmPrice";
            this.Text = "Прайс";
            this.Load += new System.EventHandler(this.fmPrice_Load);
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
        private System.Windows.Forms.TextBox ePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDelType;
        private System.Windows.Forms.Button bAddType;
        private System.Windows.Forms.TextBox eCountDayPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eTypeCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bOkInsert;
        private System.Windows.Forms.Button bCancelInsert;
        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbDel;
    }
}