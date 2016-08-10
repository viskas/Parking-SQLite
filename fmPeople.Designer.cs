namespace Parking
{
    partial class fmPeople
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bbOK = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grData = new System.Windows.Forms.DataGridView();
            this.pnInsertEdit = new System.Windows.Forms.Panel();
            this.eAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bOkInsert = new System.Windows.Forms.Button();
            this.bCancelInsert = new System.Windows.Forms.Button();
            this.ePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ePeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarMain = new System.Windows.Forms.ToolStrip();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.tbDel = new System.Windows.Forms.ToolStripButton();
            this.grDataDop = new System.Windows.Forms.DataGridView();
            this.tbarDop = new System.Windows.Forms.ToolStrip();
            this.tbRefreshDop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAddDop = new System.Windows.Forms.ToolStripButton();
            this.tbDelDop = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grData)).BeginInit();
            this.pnInsertEdit.SuspendLayout();
            this.tbarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDataDop)).BeginInit();
            this.tbarDop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bbOK);
            this.panel2.Controls.Add(this.bbCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 37);
            this.panel2.TabIndex = 8;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grData);
            this.splitContainer1.Panel1.Controls.Add(this.pnInsertEdit);
            this.splitContainer1.Panel1.Controls.Add(this.tbarMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grDataDop);
            this.splitContainer1.Panel2.Controls.Add(this.tbarDop);
            this.splitContainer1.Size = new System.Drawing.Size(522, 545);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 9;
            // 
            // grData
            // 
            this.grData.AllowUserToAddRows = false;
            this.grData.AllowUserToDeleteRows = false;
            this.grData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grData.Location = new System.Drawing.Point(0, 145);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(522, 188);
            this.grData.TabIndex = 10;
            this.grData.SelectionChanged += new System.EventHandler(this.grData_SelectionChanged);
            // 
            // pnInsertEdit
            // 
            this.pnInsertEdit.Controls.Add(this.eAddress);
            this.pnInsertEdit.Controls.Add(this.label3);
            this.pnInsertEdit.Controls.Add(this.bOkInsert);
            this.pnInsertEdit.Controls.Add(this.bCancelInsert);
            this.pnInsertEdit.Controls.Add(this.ePhone);
            this.pnInsertEdit.Controls.Add(this.label2);
            this.pnInsertEdit.Controls.Add(this.ePeople);
            this.pnInsertEdit.Controls.Add(this.label1);
            this.pnInsertEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnInsertEdit.Location = new System.Drawing.Point(0, 25);
            this.pnInsertEdit.Name = "pnInsertEdit";
            this.pnInsertEdit.Size = new System.Drawing.Size(522, 120);
            this.pnInsertEdit.TabIndex = 9;
            // 
            // eAddress
            // 
            this.eAddress.Location = new System.Drawing.Point(89, 59);
            this.eAddress.Name = "eAddress";
            this.eAddress.Size = new System.Drawing.Size(423, 20);
            this.eAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адрес";
            // 
            // bOkInsert
            // 
            this.bOkInsert.Location = new System.Drawing.Point(356, 85);
            this.bOkInsert.Name = "bOkInsert";
            this.bOkInsert.Size = new System.Drawing.Size(75, 23);
            this.bOkInsert.TabIndex = 5;
            this.bOkInsert.Text = "OK";
            this.bOkInsert.UseVisualStyleBackColor = true;
            this.bOkInsert.Click += new System.EventHandler(this.bOkInsert_Click);
            // 
            // bCancelInsert
            // 
            this.bCancelInsert.Location = new System.Drawing.Point(437, 85);
            this.bCancelInsert.Name = "bCancelInsert";
            this.bCancelInsert.Size = new System.Drawing.Size(75, 23);
            this.bCancelInsert.TabIndex = 4;
            this.bCancelInsert.Text = "Отмена";
            this.bCancelInsert.UseVisualStyleBackColor = true;
            this.bCancelInsert.Click += new System.EventHandler(this.bCancelInsert_Click);
            // 
            // ePhone
            // 
            this.ePhone.Location = new System.Drawing.Point(89, 33);
            this.ePhone.Name = "ePhone";
            this.ePhone.Size = new System.Drawing.Size(423, 20);
            this.ePhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон";
            // 
            // ePeople
            // 
            this.ePeople.Location = new System.Drawing.Point(89, 7);
            this.ePeople.Name = "ePeople";
            this.ePeople.Size = new System.Drawing.Size(423, 20);
            this.ePeople.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
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
            this.tbarMain.Size = new System.Drawing.Size(522, 25);
            this.tbarMain.TabIndex = 8;
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
            // grDataDop
            // 
            this.grDataDop.AllowUserToAddRows = false;
            this.grDataDop.AllowUserToDeleteRows = false;
            this.grDataDop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDataDop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDataDop.Location = new System.Drawing.Point(0, 25);
            this.grDataDop.Name = "grDataDop";
            this.grDataDop.Size = new System.Drawing.Size(522, 183);
            this.grDataDop.TabIndex = 11;
            // 
            // tbarDop
            // 
            this.tbarDop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRefreshDop,
            this.toolStripSeparator2,
            this.tbAddDop,
            this.tbDelDop});
            this.tbarDop.Location = new System.Drawing.Point(0, 0);
            this.tbarDop.Name = "tbarDop";
            this.tbarDop.Size = new System.Drawing.Size(522, 25);
            this.tbarDop.TabIndex = 8;
            this.tbarDop.Text = "toolStrip1";
            // 
            // tbRefreshDop
            // 
            this.tbRefreshDop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefreshDop.Image = global::Parking.Properties.Resources.refresh;
            this.tbRefreshDop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefreshDop.Name = "tbRefreshDop";
            this.tbRefreshDop.Size = new System.Drawing.Size(23, 22);
            this.tbRefreshDop.Text = "Обновить";
            this.tbRefreshDop.Click += new System.EventHandler(this.tbRefreshDop_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbAddDop
            // 
            this.tbAddDop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddDop.Image = global::Parking.Properties.Resources.add_16;
            this.tbAddDop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddDop.Name = "tbAddDop";
            this.tbAddDop.Size = new System.Drawing.Size(23, 22);
            this.tbAddDop.Text = "Добавить";
            this.tbAddDop.Click += new System.EventHandler(this.tbAddDop_Click);
            // 
            // tbDelDop
            // 
            this.tbDelDop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbDelDop.Image = global::Parking.Properties.Resources.del_16;
            this.tbDelDop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelDop.Name = "tbDelDop";
            this.tbDelDop.Size = new System.Drawing.Size(23, 22);
            this.tbDelDop.Text = "Удалить";
            this.tbDelDop.Click += new System.EventHandler(this.tbDelDop_Click);
            // 
            // fmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 582);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Name = "fmPeople";
            this.Text = "Владельцы авто";
            this.Load += new System.EventHandler(this.fmPeople_Load);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grData)).EndInit();
            this.pnInsertEdit.ResumeLayout(false);
            this.pnInsertEdit.PerformLayout();
            this.tbarMain.ResumeLayout(false);
            this.tbarMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDataDop)).EndInit();
            this.tbarDop.ResumeLayout(false);
            this.tbarDop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbOK;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip tbarMain;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbDel;
        private System.Windows.Forms.ToolStrip tbarDop;
        private System.Windows.Forms.ToolStripButton tbRefreshDop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbAddDop;
        private System.Windows.Forms.ToolStripButton tbDelDop;
        private System.Windows.Forms.DataGridView grData;
        private System.Windows.Forms.Panel pnInsertEdit;
        private System.Windows.Forms.TextBox eAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bOkInsert;
        private System.Windows.Forms.Button bCancelInsert;
        private System.Windows.Forms.TextBox ePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ePeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grDataDop;
    }
}