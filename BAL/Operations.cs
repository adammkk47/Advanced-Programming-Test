using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();

        DataSet ds;

        public DataTable Login(Informations info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_Login";
                cmd.Parameters.AddWithValue("@username", info.username);
                cmd.Parameters.AddWithValue("@password", info.password);
                cmd.CommandType = CommandType.StoredProcedure;
                return db.ExeReader(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
                return null;
            }
        }

        public void Gridview(DataGridView dataGridView, string command)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = command;
                cmd.Connection = db.getCon();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
            }
        }

        public DataSet SaveToXml(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "sp_StudentSearch";
            cmd.Parameters.AddWithValue("@studentId", info.studentNumber);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = db.getCon();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dt;
                if (ds == null)
                {
                    ds = new DataSet("Students");
                    dt = new DataTable("Student_Details");
                    dt.Columns.Add("FirstName");
                    dt.Columns.Add("Surname");
                    dt.Columns.Add("Email");
                    dt.Columns.Add("Phone");
                    dt.Columns.Add("AddressLine1");
                    dt.Columns.Add("AddressLine2");
                    dt.Columns.Add("City");
                    dt.Columns.Add("County");
                    dt.Columns.Add("Level");
                    dt.Columns.Add("Course");
                    dt.Columns.Add("StudentId");
                    ds.Tables.Add(dt);
                }

                while (dr.Read())
                {
                    dt = ds.Tables["Student_Details"];
                    DataRow row = dt.NewRow();
                    row["FirstName"] = dr["FirstName"].ToString();
                    row["Surname"] = dr["Surname"].ToString();
                    row["Email"] = dr["Email"].ToString();
                    row["Phone"] = dr["Phone"].ToString();
                    row["AddressLine1"] = dr["AddressLine1"].ToString();
                    row["AddressLine2"] = dr["AddressLine2"].ToString();
                    row["City"] = dr["City"].ToString();
                    row["County"] = dr["County"];
                    row["Level"] = dr["Level"];
                    row["Course"] = dr["Course"].ToString();
                    row["StudentId"] = dr["StudentId"].ToString();
                    dt.Rows.Add(row);
                    dt.AcceptChanges();
             }
            db.con.Close();
            return ds;
        }

        public DataTable StudentSearch(Informations info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_StudentSearch";
                cmd.Parameters.AddWithValue("@studentId", info.studentNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                return db.ExeReader(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
                return null;
            }
        }

        public DataTable PopulateStudentDetails(Informations info)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "sp_StudentSearch";
            cmd.Parameters.Add(new SqlParameter("@studentId", info.studentNumber));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = db.getCon();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    info.firstName = dr["FirstName"].ToString();
                    info.surname = dr["Surname"].ToString();
                    info.email = dr["Email"].ToString();
                    info.phone = dr["Phone"].ToString();
                    info.addressLine1 = dr["AddressLine1"].ToString();
                    info.addressLine2 = dr["AddressLine2"].ToString();
                    info.city = dr["City"].ToString();
                    info.county = dr["County"].ToString();
                    info.level = dr["Level"].ToString();
                    info.course = dr["Course"].ToString();
                }
                cmd.Connection.Close();
            }
            return db.ExeReader(cmd);
        }


        public int InsertData(Informations info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_InsertStudent";
                cmd.Parameters.AddWithValue("@firstName", info.firstName);
                cmd.Parameters.AddWithValue("@surname", info.surname);
                cmd.Parameters.AddWithValue("@email", info.email);
                cmd.Parameters.AddWithValue("@phone", info.phone);
                cmd.Parameters.AddWithValue("@address1", info.addressLine1);
                cmd.Parameters.AddWithValue("@address2", info.addressLine2);
                cmd.Parameters.AddWithValue("@city", info.city);
                cmd.Parameters.AddWithValue("@county", info.county);
                cmd.Parameters.AddWithValue("@level", info.level);
                cmd.Parameters.AddWithValue("@course", info.course);
                cmd.Parameters.AddWithValue("@studentId", info.studentNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                return db.ExeNonQuery(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
                return 0;
            }
        }

        public int UpdateStudentDetails(Informations info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_UpdateStudent";
                cmd.Parameters.AddWithValue("@email", info.email);
                cmd.Parameters.AddWithValue("@phone", info.phone);
                cmd.Parameters.AddWithValue("@address1", info.addressLine1);
                cmd.Parameters.AddWithValue("@address2", info.addressLine2);
                cmd.Parameters.AddWithValue("@city", info.city);
                cmd.Parameters.AddWithValue("@county", info.county);
                cmd.Parameters.AddWithValue("@level", info.level);
                cmd.Parameters.AddWithValue("@studentId", info.studentNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                return db.ExeNonQuery(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
                return 0;
            }
        }

        public int DeleteStudent(Informations info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "sp_DeleteStudent";
                cmd.Parameters.AddWithValue("@studentId", info.studentNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                return db.ExeNonQuery(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please try again.");
                return 0;
            }
        }
    }
}
