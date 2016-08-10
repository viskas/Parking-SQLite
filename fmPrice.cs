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
    public partial class fmPrice : Form
    {
        public fmPrice()
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

            if (!DBNull.Value.Equals(m_row["Type"]))
                ExportName = m_row["Type"].ToString();
        }

        private void fmPrice_Load(object sender, EventArgs e)
        {
            m_Connect = new ConnSqlLite();
            LoadData();
        }

        private void bDelType_Click(object sender, EventArgs e)
        {
            eTypeCar.Text = String.Empty;
            eTypeCar.Tag = (Int64)0;
        }

        private void bAddType_Click(object sender, EventArgs e)
        {
            var f = new fmCarType();
            if (f.ShowDialog() == DialogResult.OK)
            {
                eTypeCar.Text = f.ExportName;
                eTypeCar.Tag = f.ExportId;
            }
            f.Dispose();
        }


        private void LoadData()
        {
            var str = " select Price.*, coalesce(CarType.Type,'') Type"
                   + " from Price "
                   + " left join CarType on Price.CarType_ID = CarType.Id";
            dtData = m_Connect.GetDataTable(str);
            grData.DataSource = dtData;
            foreach (DataGridViewColumn col in grData.Columns)
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
            bDelType_Click(null, new EventArgs());
            ePrice.Text = String.Empty;
            eCountDayPrice.Text = String.Empty;
        }

        private void FillFields(Int64 id)
        {
            ///Определяю индекс строки, по которой буду отображать данные
            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + id.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            if (!DBNull.Value.Equals(m_row["Price"]))
                ePrice.Text = m_row["Price"].ToString();

            if (!DBNull.Value.Equals(m_row["CountDayPrice"]))
                eCountDayPrice.Text = m_row["CountDayPrice"].ToString();

            if (!DBNull.Value.Equals(m_row["CarType_ID"]))
            {
                eTypeCar.Text = m_row["Type"].ToString();
                eTypeCar.Tag = (Int64)m_row["CarType_ID"];
            }
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
                    eTypeCar.Focus();
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

            var str = "";

            if (eTypeCar.Text == "")
            {
                MessageBox.Show("Внесите тип");
                return;
            }
            if (ePrice.Text == "")
            {
                MessageBox.Show("Внесите цену");
                return;
            }

            Int64 type_id = 0;
            if (eTypeCar.Tag!=null)
             type_id = (Int64)eTypeCar.Tag;
            var type_id_str = type_id > 0 ? type_id.ToString() : "null";

            str = String.Format("select ID from Price where CarType_ID={0}", type_id_str);
            if (!m_Insert)
                str = str + String.Format(" and id<>{0}", m_ID);
            if (m_Connect.IfExistData(str))
            {
                MessageBox.Show("Такой тип уже внесен");
                return;
            }

            var price_str = "0.00";
            price_str = ePrice.Text.Replace(",", ".");
            var countdaypriceday_str = "0";
            if (eCountDayPrice.Text != "")
                countdaypriceday_str = eCountDayPrice.Text;


            if (m_Insert)
            {
                str = " insert into Price(Price, CountDayPrice, CarType_ID) values ({0},{1},{2})";
                str = String.Format(str, price_str, countdaypriceday_str, type_id_str);
            }

            else
                str = "update Price set Price = {0}, CountDayPrice = {1}, CarType_ID = {2} where ID = {3}";
            str = String.Format(str, price_str, countdaypriceday_str, type_id_str, m_ID);
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
            str = String.Format("delete from Price where ID = {0}", id);
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

        private void ePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            ePrice.EditKeyPress(e, true, false);
        }

        private void eCountDayPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            eCountDayPrice.EditKeyPress(e, false, false);
        }
        
    }
}
