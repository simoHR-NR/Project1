using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1.Forms
{
    class ADO
    {
        //Objet sql
        public SqlConnection cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public SqlDataAdapter dap = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DataRow lign;
        public SqlCommandBuilder bc;


        // open connection

        public void connected()
        {
            if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)

            {
                cn.ConnectionString = "Data Source=.;Initial Catalog=BirdDB;Integrated Security=True";
                cn.Open();
            }

        }
        public void deconnected()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        //Calculate Age
        public int  calculateage(string dte)
        {
            DateTime birthday = DateTime.Parse(dte);

            int x= (DateTime.Today.Year - birthday.Year) * 12 + (DateTime.Today.Month - birthday.Month);
            return x;
        }

    }
}
