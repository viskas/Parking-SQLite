using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Parking
{
    public class ConnSqlLite
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter sql_adp;
        private DataSet DS = new DataSet();
        //private DataTable DT = new DataTable();
        public String DBPath;

        public ConnSqlLite()
        {
            String app_path = Application.ExecutablePath;
            DBPath = System.IO.Path.GetDirectoryName(app_path) + "\\" + System.IO.Path.GetFileNameWithoutExtension(app_path) + ".db";   // каталог программы
        }

        private void SetConnection()
        {
           // sql_con = new SQLiteConnection("Data Source=DemoT.db;Version=3;New=False;Compress=True;");
            sql_con = new SQLiteConnection(string.Format("Data Source={0}", DBPath));
        }

        public DataTable GetDataTable(String sqltext)
        {
            var dt = new DataTable();
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_adp = new SQLiteDataAdapter(sqltext, sql_con);
                DS.Reset();
                sql_adp.Fill(DS);


                dt = DS.Tables[0];
                /*  Grid.DataSource = DT;*/
                sql_con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }

        public Boolean IfExistData(String sqltext)
        {
            var b = false;
           
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_adp = new SQLiteDataAdapter(sqltext, sql_con);
                DS.Reset();
                sql_adp.Fill(DS);

                var dt = new DataTable();
                dt = DS.Tables[0];
                if (dt!=null)
                if (dt.Rows.Count>0) 
                    b = true;
                /*  Grid.DataSource = DT;*/
                sql_con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return b;
        }



        public int ExecuteNonQuery(String sqltext)
        {
            SetConnection();
            sql_con.Open();
            SQLiteCommand mycommand = new SQLiteCommand(sql_con);
            mycommand.CommandText = sqltext;
            int rowsUpdated = mycommand.ExecuteNonQuery();
            sql_con.Close();
            return rowsUpdated;
        }

        public String ToDateSQLite(DateTime value, bool include_time)
        {
            string format_date = "yyyy-MM-dd HH:mm:ss.fff";
            if (!include_time)
                format_date = "yyyy-MM-dd 00:00:00.000";

            return value.ToString(format_date);
        }

    }
}
