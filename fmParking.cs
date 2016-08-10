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
    public partial class fmParking : Form
    {
        public fmParking()
        {
            InitializeComponent();
        }

        private DataTable dtData;
        private DataTable dtDataEmpty;
        private ConnSqlLite m_Connect;
        private ConnSqlLite m_ConnectEmpty;

        private void fmParking_Load(object sender, EventArgs e)
        {
            m_Connect = new ConnSqlLite();
            m_ConnectEmpty = new ConnSqlLite(); 
            LoadData();
            foreach (DataGridViewColumn col in grDataEmpty.Columns)
            {
                var x = col.Name.ToLower();
                if (x.IndexOf("id") != -1) col.Visible = false;
            }
        }


        private void LoadData()
        {
            var str = " select Registration.*,"
                    + " Location.ParkingNum, Car.FirstName, Car.SecondName, CarType.Type, "
                    + "        CarColor.Color, Car.RegNumber, Car.Description, Price.Price"
                    + " from Registration "
                    + " left join Location on Registration.Location_ID = Location.ID"
                    + " left join Car on Registration.Car_ID = Car.Id"
                    + " left join CarType on Car.CarType_ID =  CarType.ID"
                    + " left join CarColor on Car.CarColor_ID =  CarColor.ID"
                    + " left join Price on CarType.ID = Price.CarType_ID"
                    + " where Registration.DateStart is not null and Registration.DateEnd is null";
            dtData = m_Connect.GetDataTable(str);
            grData.DataSource = dtData;
            foreach (DataGridViewColumn col in grData.Columns)
            {
                var s = col.Name.ToLower();
                if (s.IndexOf("id") != -1) col.Visible = false;
            }

            str = " select * from Location "
                + " where id not in (select Location_ID from Registration "
                + "                  where Registration.DateStart is not null and Registration.DateEnd is null )";
            dtDataEmpty = m_ConnectEmpty.GetDataTable(str);
            grDataEmpty.DataSource = dtDataEmpty;
 
        }

        private Int64 GetId()
        {
            Int64 id = 0;
            if (grData.CurrentRow != null)
                id = (Int64)((grData.CurrentRow.DataBoundItem as DataRowView).Row)[0];
            return id;
        }

        private Int64 GetIdEmpty()
        {
            Int64 id = 0;
            if (grDataEmpty.CurrentRow != null)
                id = (Int64)((grDataEmpty.CurrentRow.DataBoundItem as DataRowView).Row)[0];
            return id;
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbRefreshEmpty_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbOpenLocation_Click(object sender, EventArgs e)
        {
            var id = GetId();
            if (id == 0) return;


            Int32 m_RowIndex = dtData.Rows.IndexOf(dtData.Select("[id]=" + id.ToString())[0]);
            DataRow m_row = dtData.Rows[m_RowIndex];

            var ds = (DateTime)m_row["dateStart"];
            var de = DateTime.Now;
            TimeSpan span = de - ds;
           
            Decimal price = 0;
            if (!DBNull.Value.Equals(m_row["Price"]))
                price = (Decimal)m_row["Price"];
            var dd = span.Days;
            if (dd == 0) dd = 1;
            var k = dd * price;
            var ks = k.ToString();
            ks = ks.Replace(",", ".");

            var str = "update Registration set DateEnd = '{0}', SumRegistration={1} where id = {2} ";
            str = String.Format(str, m_ConnectEmpty.ToDateSQLite(de, false), ks, id);
            var i = m_Connect.ExecuteNonQuery(str);
            LoadData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var id = GetIdEmpty();
            if (id == 0) return;
            var str = "";
            var f = new fmCar();
            f.FilterString = " where car.id not in (select Car_ID from Registration where Registration.DateStart is not null and Registration.DateEnd is null)";

            if (f.ShowDialog() == DialogResult.OK)
                if (f.ExportId > 0)
                {
                    str = String.Format("Insert into Registration (Location_ID, Car_ID, DateStart) values ({0},{1},'{2}')",
                                        id, f.ExportId, m_ConnectEmpty.ToDateSQLite(DateTime.Now, false));
                }
            f.Dispose();

            if (str != "")
            {
                var i = m_ConnectEmpty.ExecuteNonQuery(str);
                LoadData();
            }
        }




    }
}
