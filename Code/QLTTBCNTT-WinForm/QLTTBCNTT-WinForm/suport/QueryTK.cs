using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using QLTTBCNTT_WinForm.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm.suport
{
    internal class QueryTK
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCMD;

        public QueryTK() { }
        
        public DataTable getTableAccount()
        {
            DataTable accountTab = new DataTable();
            string query = "select * from AccLogin WHERE Active = 1";

            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(accountTab);
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return accountTab;
        }

        public DataTable getTabDeletedAcc()
        {
            DataTable DeletedAccTab = new DataTable();
            string query = "select * from AccLogin WHERE Active = 0";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(DeletedAccTab);
                sqlConnection.Close();
            }
            return DeletedAccTab;
        }

        public DataTable FindByUser(string userLogin)
        {
            DataTable accountTab = new DataTable();
            string query = "select KindOfAcc, userLogin from AccLogin WHERE Active = 1 and userLogin = '" + userLogin + "'";

            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    //sqlCMD.Parameters.Add("@UserLogin", SqlDbType.NVarChar).Value = userLogin;
                    dataAdapter = new SqlDataAdapter(query, sqlConnection);
                    dataAdapter.Fill(accountTab);
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return accountTab;
        }

        public void Insert(Account user)
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into AccLogin values (@IDQuannhan, @UserLogin, @PassLogin, 1, @KindOfAcc, @TenQN, @CMTQD)";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);

                sqlCMD.Parameters.Add("@IDQuannhan", SqlDbType.Int).Value = user.IDQuannhan1;
                sqlCMD.Parameters.Add("@UserLogin", SqlDbType.NVarChar).Value = user.UserLogin1;
                sqlCMD.Parameters.Add("@PassLogin", SqlDbType.NVarChar).Value = user.PassLogin1;
                sqlCMD.Parameters.Add("@KindOfAcc", SqlDbType.Int).Value = user.KindOfAcc1;
                sqlCMD.Parameters.Add("@TenQN", SqlDbType.NVarChar).Value = user.TenQN1;
                sqlCMD.Parameters.Add("@CMTQD", SqlDbType.NVarChar).Value = user.CMTQD1;


                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Delete(string ID)
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Update AccLogin set PassLogin = 0, Active = 0 WHERE idAcc = @ID";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);

                sqlCMD.Parameters.Add("@ID", SqlDbType.Char).Value = ID;

                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void ModifyPass(string user, string pass)
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Update AccLogin set PassLogin = @pass WHERE UserLogin = @name";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);

                sqlCMD.Parameters.Add("@name", SqlDbType.Char).Value = user;
                sqlCMD.Parameters.Add("@pass", SqlDbType.Char).Value = pass;

                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void ModifyInfo(string UserLogin, string TenQN, string CMTQD, string KindOfAcc, string ID)
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Update AccLogin set UserLogin = @UserLogin, TenQN = @TenQN, CMTQD = @CMTQD, KindOfAcc = @KindOfAcc WHERE idAcc = @ID";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);

                sqlCMD.Parameters.Add("@UserLogin", SqlDbType.NChar).Value = UserLogin;
                sqlCMD.Parameters.Add("@TenQN", SqlDbType.NChar).Value = TenQN;
                sqlCMD.Parameters.Add("@CMTQD", SqlDbType.NChar).Value = CMTQD;
                sqlCMD.Parameters.Add("@KindOfAcc", SqlDbType.NChar).Value = KindOfAcc;
                sqlCMD.Parameters.Add("@ID", SqlDbType.NChar).Value = ID;

                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool isTruePassword(string user, string password)
        {
            try
            {
                SqlConnection adminCnt = ConnectionString.getConnection();
                adminCnt.Open();

                string query = "select Active from AccLogin WHERE UserLogin = '" + user + "'and PassLogin = '" + password + "' and Active = 1";

                SqlCommand cmd = new SqlCommand(query, adminCnt);

                SqlDataReader data = cmd.ExecuteReader();

                bool b = data.Read();
               

                adminCnt.Close();

                return b;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

    }
}
