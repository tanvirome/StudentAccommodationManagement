using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace StudentAccommodation
{
    class DBConnect
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adp;

        public DBConnect()
        {
            string connect = "Data Source=DESKTOP-Q4DILNB\\SQLEXPRESS;Initial Catalog=Student Accommodation;Integrated Security=True";
            try
            {
                con = new SqlConnection(connect);
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Coonect Exception : " + e);
            }
        }

        public void OwnerSignIn(ArrayList row)
        {
            try
            {
                string query = "insert into OwnerDetails(name, email, username, phonenumber, password) values('"
                    + row[0] + "','" + row[1] + "','" + row[2] + "','" + row[3] + "','" + row[4] + "' " + ");";

                cmd = new SqlCommand(query, this.con);
                cmd.ExecuteNonQuery();
                this.con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            
        }

        public void StudentSignIn(ArrayList row)
        {
            try
            {
                string query = "insert into StudentDetails(name, email, username, phonenumber, password) values('"
                    + row[0] + "','" + row[1] + "','" + row[2] + "','" + row[3] + "','" + row[4] + "' " + ");";

                cmd = new SqlCommand(query, this.con);
                cmd.ExecuteNonQuery();
                this.con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public DataSet CheckEmail(string query)
        {
            cmd = new SqlCommand(query, this.con);
            DataSet ds = new DataSet();

            adp = new SqlDataAdapter(cmd);
            //SqlDataReader dr = cmd.ExecuteReader();
            adp.Fill(ds);
            //adp.read
            //DataTable dt = ds.Tables[0];

            //this.con.Close();
            //dr.Close();
            return ds;
        }

        public DataSet CheckUsername(string query)
        {
            cmd = new SqlCommand(query, this.con);
            DataSet ds = new DataSet();

            adp = new SqlDataAdapter(cmd);
            //SqlDataReader dr = cmd.ExecuteReader();
            adp.Fill(ds);
            //adp.read
            //DataTable dt = ds.Tables[0];

            //this.con.Close();
            return ds;
        }

        public DataSet GetInfo(string query)
        {
            cmd = new SqlCommand(query, this.con);
            DataSet ds = new DataSet();

            adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            return ds;
        }

        public DataTable GetTable(string query)
        {
            cmd = new SqlCommand(query, this.con);
            DataTable dt = new DataTable();

            adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        public void InsertIntoDatabase(string query)
        {
            try
            {
                cmd = new SqlCommand(query, this.con);
                cmd.ExecuteNonQuery();
                this.con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
    }
}
