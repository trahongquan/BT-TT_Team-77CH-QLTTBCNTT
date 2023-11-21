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
    internal class QueryDonvi
    {
        public QueryDonvi()
        {
        }
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_Donvi()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from DM_Donvi";// * se lay tat ca cac cot
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
        public string getDonvi(string idDV)
        {
            DataTable bangXM = new DataTable();
            string query = "select * from DM_Donvi where idDonvi = '"+idDV+"'";// * se lay tat ca cac cot
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

            return bangXM.Rows[0][1].ToString() +", "+ bangXM.Rows[0][2].ToString() + ", " + bangXM.Rows[0][3].ToString();
        }

        public void Insert(Donvi Donvi) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into DM_Donvi values " +
                "( @Doi, @TieuDoan, @LuDoan)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@Doi", SqlDbType.NChar).Value = Donvi.Doi1;   // gan cu the
                sqlCMD.Parameters.Add("@TieuDoan", SqlDbType.NChar).Value = Donvi.TieuDoan1;
                sqlCMD.Parameters.Add("@LuDoan", SqlDbType.NChar).Value = Donvi.LuDoan1;
                
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
        public void Modify(Donvi Donvi, int donviID) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE DM_Donvi SET " +
                "Doi = @Doi, TieuDoan = @TieuDoan, LuDoan = @LuDoan " +
                "Where IdDonvi = " + donviID;

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);

                sqlCMD.Parameters.Add("@Doi", SqlDbType.Int).Value = Donvi.Doi1;
                sqlCMD.Parameters.Add("@TieuDoan", SqlDbType.NChar).Value = Donvi.TieuDoan1;   // gan cu the
                sqlCMD.Parameters.Add("@LuDoan", SqlDbType.NChar).Value = Donvi.LuDoan1;

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

        public void Delete(int donviID)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete DM_Donvi Where IdDonvi = @donviID";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@donviID", SqlDbType.Char).Value = donviID;
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

    }

}
