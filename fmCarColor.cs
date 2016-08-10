using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parking
{
    public partial class fmCarColor : Form
    {
        public fmCarColor()
        {
            InitializeComponent();
            pnInsertEdit.Visible = false;
        }

        private DataTable dtData;
        private Boolean m_Insert;
        private Int64 m_ID;
        private ConnSqlLite m_Connect;

        public Int64 ExportId;
        public String ExportName;

        private void ExportData()
        {
            ExportId = GetId();
            ExportName = "";


            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + ExportId.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            if (!DBNull.Value.Equals(m_row["Color"]))
                ExportName = m_row["Color"].ToString();
        }


        private void fmCarColor_Load(object sender, EventArgs e)
        {
            m_Connect = new ConnSqlLite();
            LoadData();
        }

        private void LoadData()
        {
            var str = "select * from carcolor";
            dtData = m_Connect.GetDataTable(str);
            grData.DataSource = dtData;
            foreach(DataGridViewColumn col in grData.Columns)
            {
                var s = col.Name.ToLower();
                if (s.IndexOf("id") != -1) col.Visible = false;
            }
        }


        private Int64 GetId()
        {
            Int64 id = 0;
            if (grData.CurrentRow != null)
                id = (Int64)((grData.CurrentRow.DataBoundItem as DataRowView).Row)[0];
            m_ID = id;
            return id;
        }

        private void ClearFields()
        {
            eDescr.Text = String.Empty;
            eColorCar.Text = String.Empty;
        }

        private void FillFields(Int64 id)
        {
            ///Определяю индекс строки, по которой буду отображать данные
            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + id.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            if (!DBNull.Value.Equals(m_row["Color"]))
                eColorCar.Text = m_row["Color"].ToString();
            if (!DBNull.Value.Equals(m_row["Description"]))
                eDescr.Text = m_row["Description"].ToString();
        }

        private void EnableComponents(Boolean enb)
        {
            grData.Enabled = enb;
            tbarMain.Enabled = enb;
            bbOK.Enabled = enb;

        }

        private void InsertEditData(Boolean isInsert)
        {
            pnInsertEdit.Visible = true;
            EnableComponents(false);
            m_Insert = isInsert;

            if (isInsert)
                ClearFields();
            else
            {
                Int64 id = GetId();
                if (id > 0)
                    FillFields(id);
                else
                    CloseInsert(false);
                if (pnInsertEdit.Visible)
                    eColorCar.Focus();
            }
        }

        private void CloseInsert(Boolean isload = true)
        {
            m_Insert = false;
            m_ID = 0;
            pnInsertEdit.Visible = false;
            EnableComponents(true);
            if (isload)
                LoadData();
        }


        private void tbRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            InsertEditData(true);
        }

        private void bCancelInsert_Click(object sender, EventArgs e)
        {
            CloseInsert(true);
        }

        private void bOkInsert_Click(object sender, EventArgs e)
        {
            if (eColorCar.Text == "")
            {
                MessageBox.Show("Внесите цвет");
                return;
            }

            var str = "";
            str = String.Format("select ID from CarColor where Color='{0}'",eColorCar.Text);
            if (!m_Insert)
                str = str+String.Format(" and id<>{0}",m_ID);
            if (m_Connect.IfExistData(str))
            {
                MessageBox.Show("Такой цвет уже внесен");
                return;
            }
            
            if (m_Insert)
                str = String.Format("insert into CarColor(Color,Description) values('{0}','{1}')", eColorCar.Text, eDescr.Text);
            else
                str = String.Format("update CarColor set Color = '{0}', Description = '{1}' where ID = {2}", eColorCar.Text, eDescr.Text, m_ID);
            var i = m_Connect.ExecuteNonQuery(str);
            CloseInsert(true);
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            InsertEditData(false);
        }

        private void tbDel_Click(object sender, EventArgs e)
        {
            var id = GetId();
            if (id == 0) return;

            var str = "";
            str = String.Format("delete from CarColor where ID = {0}", id);
            try
            {
                var i = m_Connect.ExecuteNonQuery(str);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить данные");
            }
        }

        private void bbOK_Click(object sender, EventArgs e)
        {
            ExportData();
        }


    }
}
