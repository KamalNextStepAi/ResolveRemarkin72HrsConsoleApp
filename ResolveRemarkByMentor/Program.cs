using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveRemarkByMentor
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            try
            {
                
                    con = new SqlConnection(Properties.Settings.Default.ConnectionString);

                    con.Open();
                    SqlCommand sql_cmnd = new SqlCommand("EXEC [mentor].[ResolveRemarkByMentor]", con);
                    sql_cmnd.ExecuteNonQuery();
                    con.Close();
               
            }
            catch (Exception ex)
            {
                //throw ex;
                Console.ForegroundColor
                     = ConsoleColor.Red;

                Console.WriteLine("process cancelled due to this Error:"+ ex.Message);
                Console.ReadLine();
            }
        }
    }
}
