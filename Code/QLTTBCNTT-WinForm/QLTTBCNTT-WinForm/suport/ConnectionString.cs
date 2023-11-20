using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.suport
{
    internal class ConnectionString
    {
        public static string Connectionstring = "Server = TRHQUAN\\TRHQUANMS;" + "uid=sa;pwd=1;" + "database=QLTTBCNTT";
        //public static string Connectionstring = "Server = TRHQUAN\\TRHQUANMS;" + "uid=sa;pwd=1;" + "database=QLTTBCNTT";
        public ConnectionString() { }
        public static SqlConnection getConnection(){
            SqlConnection conn = new SqlConnection();
            try{
                conn = new SqlConnection(Connectionstring);
            }
            catch (Exception ex){
                throw ex;
            }
            return conn;
        }
    }
}
