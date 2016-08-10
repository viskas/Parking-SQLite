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
    public partial class fmCar : Form
    {
        public fmCar()
        {
            InitializeComponent();
            FilterString = "";
            pnInsertEdit.Visible = false;
        }

        public String FilterString;

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


        private void fmCar_Load(object sender, EventArgs e)
        {
            m_Connect = new ConnSqlLite();
            LoadData();
        }

        private void bDelType_Click(object sender, EventArgs e)
        {
            eTypeCar.Text = String.Empty;
            eTypeCar.Tag = (Int64)0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eColorCar.Text = String.Empty;
            eColorCar.Tag = (Int64)0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new fmCarColor();
            if (f.ShowDialog() == DialogResult.OK)
            {
                eColorCar.Text = f.ExportName;
                eColorCar.Tag = f.ExportId;
            }
            f.Dispose();
        }

        private void LoadData()
        {
            var str = " select Car.* , coalesce(CarType.Type, '') Type, coalesce(CarColor.Color,'') Color"
                   + " from Car "
                   + " left join CarType on Car.CarType_ID =  CarType.ID"
                   + " left join CarColor on Car.CarColor_ID =  CarColor.ID"
                   + " "+FilterString;
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
            eFirstName.Text = String.Empty;
            eSecondName.Text = String.Empty;
            bDelType_Click(null, new EventArgs());
            button1_Click(null, new EventArgs());
            eRegNumber.Text = String.Empty;
            eDescr.Text = String.Empty;
        }

        private void FillFields(Int64 id)
        {
            ///Определяю индекс строки, по которой буду отображать данные
            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + id.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            if (!DBNull.Value.Equals(m_row["FirstName"]))
                eFirstName.Text = m_row["FirstName"].ToString();

            if (!DBNull.Value.Equals(m_row["SecondName"]))
                eSecondName.Text = m_row["SecondName"].ToString();

            if (!DBNull.Value.Equals(m_row["CarType_ID"]))
            {
                eTypeCar.Text = m_row["Type"].ToString();
                eTypeCar.Tag = (Int64)m_row["CarType_ID"];
            }

            if (!DBNull.Value.Equals(m_row["CarColor_ID"]))
            {
                eColorCar.Text = m_row["Color"].ToString();
                eColorCar.Tag = (Int64)m_row["CarColor_ID"];
            }

            if (!DBNull.Value.Equals(m_row["Description"]))
                eDescr.Text = m_row["Description"].ToString();

            if (!DBNull.Value.Equals(m_row["RegNumber"]))
                eRegNumber.Text = m_row["RegNumber"].ToString();
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
                    eFirstName.Focus();
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

            if (eRegNumber.Text == "")
            {
                MessageBox.Show("Внесите регистрацционный №");
                return;
            }


            str = String.Format("select ID from Car where RegNumber='{0}'", eRegNumber.Text);
            if (!m_Insert)
                str = str + String.Format(" and id<>{0}", m_ID);
            if (m_Connect.IfExistData(str))
            {
                MessageBox.Show("Такой регистрацционный № уже внесен");
                return;
            }

            Int64 type_id = 0;
            if (eTypeCar.Tag != null)
                type_id = (Int64)eTypeCar.Tag;
            var type_id_str = type_id > 0 ? type_id.ToString() : "null";


            Int64 color_id = 0;
            if (eColorCar.Tag != null)
                color_id = (Int64)eColorCar.Tag;
            var color_id_str = color_id > 0 ? color_id.ToString() : "null";


            if (m_Insert)
            {
                str = " insert into Car(FirstName, SecondName, CarType_ID, CarColor_ID, RegNumber, Description)"
                    + " values ('{0}','{1}',{2},{3},'{4}','{5}')";
                str = String.Format(str, eFirstName.Text, eSecondName.Text, type_id_str, color_id_str, eRegNumber.Text, eDescr.Text);
            }

            else
                str = "update Car set FirstName = '{0}', SecondName = '{1}', CarType_ID = {2}, CarColor_ID = {3}, RegNumber='{4}', Description = '{5}'"
                    + " where ID = {6}";
             str = String.Format(str, eFirstName.Text, eSecondName.Text, type_id_str, color_id_str, eRegNumber.Text, eDescr.Text, m_ID);
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
            str = String.Format("delete from Car where ID = {0}", id);
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
