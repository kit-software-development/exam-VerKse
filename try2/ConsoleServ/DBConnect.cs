using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;

namespace ConsoleServ
{
    public class DBConnect
    {
        public bool CheckLogin(ref string login, ref string password)
        {
            string path = "\\Database\\Database1.mdf";
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = (String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename{0}", path))
            };

            try
            {
                //open connection
                cn.Open();
                string select = "SELECT * FROM UsersTable WHERE userName = '" + login + "'";
                SqlCommand cmd = new SqlCommand(select, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() && Convert.ToString(dr[2]) == password) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(DateTime.Now + ":  SQL Exception");
                return false;
            }
            finally {
                cn.Close();
            }

        }

        public bool Insert( string name,  string surname, string phone1,  string phone2,  string info)
        {
            string path = "\\Database\\Database1.mdf";
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = (String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename{0}", path))
            };

            try
            {
                //open connection
                cn.Open();
                string insert = "INSERT INTO contactsTable (FirstName, Surname, Phone1, Phone1, Info, GroupId, contactId) " +
                                "VALUES ("+ name+ ", "+ surname + ", " + phone1 + ", " + phone2 + ", " + info + ", " + 1 + ")";
                SqlCommand cmd = new SqlCommand(insert, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(DateTime.Now + ":  SQL Exception");
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool Delete( string name,  string surname,  string phone1,  string phone2,  string info)
        {
            string path =  "\\Database\\Database1.mdf";
            SqlConnection cn = new SqlConnection
            {
                ConnectionString = (String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename{0}", path))
            };

            try
            {
                //open connection
                cn.Open();
                string delete = "DELETE FROM contactsTable " +
                    " WHERE FirstName = " + name + " AND Surname = " + surname +
                    " AND Phone1 = " + phone1 + " AND phone 2 = " + phone2 + " AND info = " + info +
                    " AND groupId = " + 1;
                SqlCommand cmd = new SqlCommand(delete, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(DateTime.Now + ":  SQL Exception");
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public bool Update( string name,  string surname,  string phone1,  string phone2,  string info,
             string newname,  string newsurname,  string newphone1,  string newphone2,  string newinfo)
        {
            
            try
            {
                if (Delete(name, surname, phone1, phone2, info) &
                Insert(newname, newsurname, newphone1, newphone2, newinfo))
                return true;
                else return false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(DateTime.Now + ":  SQL Exception");
                return false;
            }
            
        }
    }
}
