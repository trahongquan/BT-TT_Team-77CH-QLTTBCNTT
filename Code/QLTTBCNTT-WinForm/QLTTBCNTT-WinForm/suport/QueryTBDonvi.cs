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
    internal class QueryTBDonvi
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_TBDonvi()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from TB_Donvi";// * se lay tat ca cac cot
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

        public void Insert(TBDonvi TBDV) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into TB_Donvi values " +
                "(@IdDV, @IdTB, @DateBorrow, @DateReturn)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdDV", SqlDbType.Int).Value = TBDV.IdDV;   // gan cu the
                sqlCMD.Parameters.Add("@IdTB", SqlDbType.Int).Value = TBDV.IdTB;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBDV.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBDV.DateReturn1;

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
        public void Modify(TBDonvi TBDV, int IdTBDonvi) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE TB_Donvi SET " +
                "idDonvi=@idDonvi, idThietbi=@idThietbi, DateBorrow=@DateBorrow, DateReturn=@DateReturn " +
                " Where IdTBDonvi = " + IdTBDonvi;
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = TBDV.IdDV;   // gan cu the
                sqlCMD.Parameters.Add("@idThietbi", SqlDbType.NChar).Value = TBDV.IdTB;
                sqlCMD.Parameters.Add("@DateBorrow", SqlDbType.NChar).Value = TBDV.DateBorrow1;
                sqlCMD.Parameters.Add("@DateReturn", SqlDbType.NChar).Value = TBDV.DateReturn1;

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

        public void Delete(int IdTBDonvi)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete TB_Donvi Where IdTBDonvi = @IdTBDonvi";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdTBDonvi", SqlDbType.Int).Value = IdTBDonvi;
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

        #region query TB, ĐV theo id
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
        public string getTBDV_idDV(string IdDV)
        {
            DataSet bangDV = new DataSet();
            string query = "select Doi, TieuDoan, LuDoan from DM_Donvi " +
                            "where IdDonvi = " + IdDV;
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
            DV = bangDV.Tables[0].Rows[0][0].ToString() + ", " + bangDV.Tables[0].Rows[0][1].ToString() + ", " + bangDV.Tables[0].Rows[0][2].ToString();
            return DV;
        }

        public string getTBDV_idTB_check(string idTB)
        {
            string kq = "";
            DataSet bangDV = new DataSet();
            string query = "select * from TB_QN where idThietbi = '" + idTB + "'";
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
                
                return kq;
            }
        }
        #endregion
    }
}
