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
    public partial class fmHistory : Form
    {
        public fmHistory()
        {
            InitializeComponent();
        }

        private DataTable dtData;
        private ConnSqlLite m_Connect;

        private void fmHistory_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            m_Connect = new ConnSqlLite();
            LoadData();
        }


        private void LoadData()
        {
            var str = " select Registration.*,"
                    + " Location.ParkingNum, Car.FirstName, Car.SecondName, CarType.Type, "
                    + "        CarColor.Color, Car.RegNumber, Car.Description"
                    + " from Registration "
                    + " left join Location on Registration.Location_ID = Location.ID"
                    + " left join Car on Registration.Car_ID = Car.Id"
                    + " left join CarType on Car.CarType_ID =  CarType.ID"
                    + " left join CarColor on Car.CarColor_ID =  CarColor.ID"
                    + " where Registration.DateStart is not null and Registration.DateEnd is not null";
            dtData = m_Connect.GetDataTable(str);
            grData.DataSource = dtData;
            foreach (DataGridViewColumn col in grData.Columns)
            {
                var s = col.Name.ToLower();
                if (s.IndexOf("id") != -1) col.Visible = false;
            }
        }
    }
}
