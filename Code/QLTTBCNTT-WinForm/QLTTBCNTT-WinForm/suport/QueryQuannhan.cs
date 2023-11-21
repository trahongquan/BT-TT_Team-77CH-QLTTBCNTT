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
    internal class QueryQuannhan
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_Quannhan()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from DM_QuanNhan";// * se lay tat ca cac cot
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

        public void Insert(Quannhan Quannhan) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into DM_QuanNhan values " +
                "( @CMTQD, @Ten, @Capbac, @Chucvu, @idDonvi)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@CMTQD", SqlDbType.NChar).Value = Quannhan.CMTQD1;   // gan cu the
                sqlCMD.Parameters.Add("@Ten", SqlDbType.NChar).Value = Quannhan.Ten1;
                sqlCMD.Parameters.Add("@Capbac", SqlDbType.NChar).Value = Quannhan.Capbac1;
                sqlCMD.Parameters.Add("@Chucvu", SqlDbType.NChar).Value = Quannhan.Chucvu1;
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Quannhan.IdDonvi;

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
        public void Modify(Quannhan Quannhan, int IdQuannhan) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE DM_QuanNhan SET " +
                "CMTQD=@CMTQD, Ten=@Ten, Capbac=@Capbac, Chucvu=@Chucvu, idDonvi=@idDonvi " +
                "Where IdQuannhan = " + IdQuannhan;
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@CMTQD", SqlDbType.NChar).Value = Quannhan.CMTQD1;   // gan cu the
                sqlCMD.Parameters.Add("@Ten", SqlDbType.NChar).Value = Quannhan.Ten1;
                sqlCMD.Parameters.Add("@Capbac", SqlDbType.NChar).Value = Quannhan.Capbac1;
                sqlCMD.Parameters.Add("@Chucvu", SqlDbType.NChar).Value = Quannhan.Chucvu1;
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Quannhan.IdDonvi;


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

        public void Delete(int IdQuannhan)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete DM_QuanNhan Where IdQuannhan = @IdQuannhan";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdQuannhan", SqlDbType.Int).Value = IdQuannhan;
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

        #region query đơn vị theo id
        public string getDV_Quannhan(string idDonvi)
        {
            DataSet bangDV = new DataSet();
            string query = "select Doi, TieuDoan, LuDoan from DM_Donvi " +
                            "where IdDonvi = " + idDonvi;
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

        public string FindCMTQDbyidQN(int idQN)
        {
            DataTable bangXM = new DataTable();
            string CMTQD = "";
            string query = "select CMTQD from DM_QuanNhan where IDQuannhan = '" + idQN + "'";// * se lay tat ca cac cot
            try
            {
                using (SqlConnection sqlConnection = ConnectionString.getConnection())
                {
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi
                    dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                    sqlConnection.Close();
                    CMTQD = bangXM.Rows[0][0].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến Cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return CMTQD;
        }
        #endregion

    }
}
