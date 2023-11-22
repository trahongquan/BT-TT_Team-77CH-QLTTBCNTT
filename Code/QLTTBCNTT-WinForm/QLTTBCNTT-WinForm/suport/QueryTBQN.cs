using QLTTBCNTT_WinForm.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm.suport
{
    internal class QueryTBQN
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_TBQN()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from TB_QN";// * se lay tat ca cac cot
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return bangXM;
        }

        public void Insert(TBQN TBQN) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into TB_QN values " +
                "(@idQuannhan, @idThietbi, @DateBorrow, @DateReturn)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = TBQN.IdQuannhan;   // gan cu the
                sqlCMD.Parameters.Add("@idThietbi", SqlDbType.NChar).Value = TBQN.IdThietbi;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBQN.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBQN.DateRrturn1;

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
        public void Modify(TBQN TBQN, int IdTBQN) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE TB_QN SET " +
                "idQuannhan=@idQuannhan, idThietbi=@idThietbi, DateBorrow=@DateBorrow, DateReturn=@DateReturn " +
                "Where IdTBQN = " + IdTBQN;
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = TBQN.IdQuannhan;   // gan cu the
                sqlCMD.Parameters.Add("@idThietbi", SqlDbType.NChar).Value = TBQN.IdThietbi;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBQN.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBQN.DateRrturn1;

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

        public void Delete(int IdTBQN)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete TB_QN Where IdTBQN = @IdTBQN";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdTBQN", SqlDbType.Int).Value = IdTBQN;
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
        #endregion
        #region query TB, QN theo id
        public string getTBDV_idTB(string idTB)
        {
            DataSet bangTB = new DataSet();
            string query = "select TenTB from DM_ThietBi " +
                            "where IdThietBi = " + idTB;
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangTB);   // dien du lieu vao bang
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string DV;
            DV = bangTB.Tables[0].Rows[0][0].ToString();
            return DV;
        }
        public string getTBQN_idQN(string idQN)
        {
            DataSet bangDV = new DataSet();
            string query = "select Ten from DM_Quannhan " +
                            "where IDQuannhan = " + idQN;
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangDV);   // dien du lieu vao bang
                    sqlConnection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            string DV;
            DV = bangDV.Tables[0].Rows[0][0].ToString();
            return DV;
        }

        public string getTBQN_idTB_check(string idTB)
        {
            string kq = "";
            DataSet bangDV = new DataSet();
            string query = "select * from TB_Donvi where idThietbi = " + idTB;
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangDV);   // dien du lieu vao bang
                    sqlConnection.Close();
                    kq = bangDV.Tables[0].Rows[0][2].ToString();
                    return kq;
                }
            }
            catch
            {
                //MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Thiết bị hợp lệ, chưa được biên chế hoặc cho mượn");
                return kq;
            }
        }
        #endregion
    }
}
