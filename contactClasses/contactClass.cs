using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ContactsBook_Project.contactClasses
{
    internal class contactClass
    {
        // Getter setter Properties
        // Acts as Data Carrier in Our Application
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        // Selecting Data from Database
        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                // Step 2: Writing SQL Query
                string sql = "Select * FROM tbl_contact";
                // Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            { 
                conn.Close();
            }
            return dt;
        }

        // Inserting Data into Database
        public bool Insert(contactClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            // Step 1: Conntect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // Step 2: Create a SQL Query to insert Data
                string sql = "INSERT INTO tbl_contact (FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";

                //Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                // Connection Open Here
                conn.Open() ;
                int rows = cmd.ExecuteNonQuery();

                // If the query runs successfully then the value of rows will be grater than zero else its value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        // Method to update in database from our application
        public bool Update(contactClass c)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // SQL to update data in out Database
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Addtess, Gender=@Gender WHERE ContactID=@ContactID";

                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);

                // Open Database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if(rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        // Method to Delete Data from Database
        public bool Delete(contactClass c)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                // SQL to update data in out Database
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);

                // Open Database connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
