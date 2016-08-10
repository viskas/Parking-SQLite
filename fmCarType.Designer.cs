namespace Parking
{
    partial class fmCarType
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
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbDel = new System.Windows.Forms.ToolStripButton();
            this.pnInsertEdit = new System.Windows.Forms.Panel();
            this.bOkInsert = new System.Windows.Forms.Button();
            this.bCancelInsert = new System.Windows.Forms.Button();
            this.eDescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eTypeCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bbOK = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.grData = new System.Windows.Forms.DataGridView();
            this.tbarMain.SuspendLayout();
            this.pnInsertEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grData)).BeginInit();
            this.SuspendLayout();
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
            this.tbarMain.Size = new System.Drawing.Size(524, 25);
            this.tbarMain.TabIndex = 0;
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
            // pnInsertEdit
            // 
            this.pnInsertEdit.Controls.Add(this.bOkInsert);
            this.pnInsertEdit.Controls.Add(this.bCancelInsert);
            this.pnInsertEdit.Controls.Add(this.eDescr);
            this.pnInsertEdit.Controls.Add(this.label2);
            this.pnInsertEdit.Controls.Add(this.eTypeCar);
            this.pnInsertEdit.Controls.Add(this.label1);
            this.pnInsertEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInsertEdit.Location = new System.Drawing.Point(0, 25);
            this.pnInsertEdit.Name = "pnInsertEdit";
            this.pnInsertEdit.Size = new System.Drawing.Size(524, 88);
            this.pnInsertEdit.TabIndex = 1;
            // 
            // bOkInsert
            // 
            this.bOkInsert.Location = new System.Drawing.Point(356, 59);
            this.bOkInsert.Name = "bOkInsert";
            this.bOkInsert.Size = new System.Drawing.Size(75, 23);
            this.bOkInsert.TabIndex = 5;
            this.bOkInsert.Text = "OK";
            this.bOkInsert.UseVisualStyleBackColor = true;
            this.bOkInsert.Click += new System.EventHandler(this.bOkInsert_Click);
            // 
            // bCancelInsert
            // 
            this.bCancelInsert.Location = new System.Drawing.Point(437, 59);
            this.bCancelInsert.Name = "bCancelInsert";
            this.bCancelInsert.Size = new System.Drawing.Size(75, 23);
            this.bCancelInsert.TabIndex = 4;
            this.bCancelInsert.Text = "Отмена";
            this.bCancelInsert.UseVisualStyleBackColor = true;
            this.bCancelInsert.Click += new System.EventHandler(this.bCancelInsert_Click);
            // 
            // eDescr
            // 
            this.eDescr.Location = new System.Drawing.Point(89, 33);
            this.eDescr.Name = "eDescr";
            this.eDescr.Size = new System.Drawing.Size(423, 20);
            this.eDescr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Примечания";
            // 
            // eTypeCar
            // 
            this.eTypeCar.Location = new System.Drawing.Point(89, 7);
            this.eTypeCar.Name = "eTypeCar";
            this.eTypeCar.Size = new System.Drawing.Size(423, 20);
            this.eTypeCar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип машины";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bbOK);
            this.panel2.Controls.Add(this.bbCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 37);
            this.panel2.TabIndex = 2;
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
            // grData
            // 
            this.grData.AllowUserToAddRows = false;
            this.grData.AllowUserToDeleteRows = false;
            this.grData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grData.Location = new System.Drawing.Point(0, 113);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(524, 148);
            this.grData.TabIndex = 3;
            // 
            // fmCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 298);
            this.Controls.Add(this.grData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnInsertEdit);
            this.Controls.Add(this.tbarMain);
            this.Name = "fmCarType";
            this.Text = "Типы машин";
            this.Load += new System.EventHandler(this.fmCarType_Load);
            this.tbarMain.ResumeLayout(false);
            this.tbarMain.PerformLayout();
            this.pnInsertEdit.ResumeLayout(false);
            this.pnInsertEdit.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbDel;
        private System.Windows.Forms.Panel pnInsertEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbOK;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.DataGridView grData;
        private System.Windows.Forms.Button bOkInsert;
        private System.Windows.Forms.Button bCancelInsert;
        private System.Windows.Forms.TextBox eDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eTypeCar;
        private System.Windows.Forms.Label label1;
    }
}