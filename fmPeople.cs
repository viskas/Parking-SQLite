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
    public partial class fmPeople : Form
    {
        public fmPeople()
        {
            InitializeComponent();
            pnInsertEdit.Visible = false;
        }

        private DataTable dtData;
        private DataTable dtDataDop;
        private Boolean m_Insert;
        private Int64 m_ID;
        private ConnSqlLite m_Connect;
        private ConnSqlLite m_ConnectDop;

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

        private void LoadData()
        {
            var str = " select * from People ";
            dtData = m_Connect.GetDataTable(str);
            grData.DataSource = dtData;
            foreach (DataGridViewColumn col in grDataDop.Columns)
            {
                var x = col.Name.ToLower();
                if (x.IndexOf("id") != -1) col.Visible = false;
            }
            LoadDataDop();
        }
        private void LoadDataDop()
        {
            var id = GetId();

            var str = "select PeopleCar.*, Car.FirstName, Car.SecondName, CarType.Type, CarColor.Color, "
                    + "       Car.RegNumber, Car.Description "
                    + " from PeopleCar "                  
                    + " left join Car on PeopleCar.Car_ID = Car.Id"
                    + " left join CarType on Car.CarType_ID =  CarType.ID"
                    + " left join CarColor on Car.CarColor_ID =  CarColor.ID"
                    + " where PeopleCar.People_ID={0}" ;
            str = String.Format(str, id);
            dtDataDop = m_ConnectDop.GetDataTable(str);
            grDataDop.DataSource = dtDataDop;
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

        private Int64 GetIdDop()
        {
            Int64 id = 0;
            if (grDataDop.CurrentRow != null)
                id = (Int64)((grDataDop.CurrentRow.DataBoundItem as DataRowView).Row)[0];
            return id;
        }



        private void fmPeople_Load(object sender, EventArgs e)
        {
            m_Connect = new ConnSqlLite();
            m_ConnectDop = new ConnSqlLite();
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

        private void tbEdit_Click(object sender, EventArgs e)
        {
            InsertEditData(false);
        }

        private void tbDel_Click(object sender, EventArgs e)
        {
            var id = GetId();
            if (id == 0) return;

            var str = "";
            str = String.Format("delete from People where ID = {0}", id);
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

        private void tbRefreshDop_Click(object sender, EventArgs e)
        {
            LoadDataDop();
        }

        private void tbAddDop_Click(object sender, EventArgs e)
        {
            var id = GetId();
            if (id == 0) return;
            var str = "";
            var f = new fmCar();
            f.FilterString = "where Car.ID not in (select Car_ID from PeopleCar where People_ID=" + id.ToString() + ")";
            if (f.ShowDialog() == DialogResult.OK)
                if (f.ExportId > 0)
            {
                str = String.Format("Insert into PeopleCar (People_ID, Car_ID) values ({0},{1})", id, f.ExportId);
            }
            f.Dispose();
           
            if (str != "")
            {
                var i = m_Connect.ExecuteNonQuery(str);
                LoadDataDop();
            }
        }

        private void tbDelDop_Click(object sender, EventArgs e)
        {
            var id = GetId();
            if (id == 0) return;

            var str = "";
            str = String.Format("delete from PeopleCar where ID = {0}", id);
            try
            {
                var i = m_Connect.ExecuteNonQuery(str);
                LoadDataDop();
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


        #region Add

        private void EnableComponents(Boolean enb)
        {
            grData.Enabled = enb;
            tbarMain.Enabled = enb;
            bbOK.Enabled = enb;
            tbarDop.Enabled = enb;
            grDataDop.Enabled = enb;
        }

        private void ClearFields()
        {
            ePeople.Text = String.Empty;
            ePhone.Text = String.Empty;
            eAddress.Text = String.Empty;
        }

        private void FillFields(Int64 id)
        {
            ///Определяю индекс строки, по которой буду отображать данные
            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + id.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            if (!DBNull.Value.Equals(m_row["People"]))
                ePeople.Text = m_row["People"].ToString();

            if (!DBNull.Value.Equals(m_row["Phone"]))
                ePhone.Text = m_row["Phone"].ToString();

            if (!DBNull.Value.Equals(m_row["Address"]))
                eAddress.Text = m_row["Address"].ToString();
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
                    ePeople.Focus();
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


        #endregion

        private void bCancelInsert_Click(object sender, EventArgs e)
        {
            CloseInsert(true);
        }

        private void bOkInsert_Click(object sender, EventArgs e)
        {
            var str = "";

            if (ePeople.Text == "")
            {
                MessageBox.Show("Внесите ФИО владельца");
                return;
            }
           
            if (m_Insert)
            {
                str = " insert into People(People, Phone, Address) values ('{0}','{1}','{2}')";
                str = String.Format(str, ePeople.Text, ePhone.Text, eAddress.Text);
            }

            else
            {
                str = "update People set People = '{0}', Phone = '{1}', Address = '{2}' where ID = {3}";
                str = String.Format(str, ePeople.Text, ePhone.Text, eAddress.Text, m_ID);
            }
            var i = m_Connect.ExecuteNonQuery(str);
            CloseInsert(true);
        }

        private void grData_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataDop();
        }



    }
}
