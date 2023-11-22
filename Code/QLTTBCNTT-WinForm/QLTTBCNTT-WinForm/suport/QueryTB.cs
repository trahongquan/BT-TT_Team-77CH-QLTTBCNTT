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
    internal class QueryTB
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDS_Thietbi()
        {
            DataTable bangXM = new DataTable();
            string query = "select * from DM_ThietBi";// * se lay tat ca cac cot
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

        public void Insert(Thietbi Thietbi) // them
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Insert into DM_ThietBi values " +
                "(@idloaiTB, @TenTB, @Seri, @MAC, @CoreCPU, @RAM, @HardDisk, @Monitor, @idQuannhan, @idDonvi, @TinhTrang, @Kho)";
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idloaiTB", SqlDbType.Int).Value = Thietbi.IdloaiTB;   // gan cu the
                sqlCMD.Parameters.Add("@TenTB", SqlDbType.NChar).Value = Thietbi.TenTB1;
                sqlCMD.Parameters.Add("@Seri", SqlDbType.NChar).Value = Thietbi.Seri1;
                sqlCMD.Parameters.Add("@MAC", SqlDbType.NChar).Value = Thietbi.MAC1;
                sqlCMD.Parameters.Add("@CoreCPU", SqlDbType.NChar).Value = Thietbi.CoreCPU1;
                sqlCMD.Parameters.Add("@RAM", SqlDbType.NChar).Value = Thietbi.RAM1;
                sqlCMD.Parameters.Add("@HardDisk", SqlDbType.NChar).Value = Thietbi.HardDisk1;
                sqlCMD.Parameters.Add("@Monitor", SqlDbType.NChar).Value = Thietbi.Monitor1;
                if(Thietbi.IdQuannhan != null && Thietbi.IdQuannhan != 0 && !Thietbi.IdQuannhan.Equals("")) { 
                    sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = Thietbi.IdQuannhan;
                }else { sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = DBNull.Value; }
                if(Thietbi.IdDonvi != null && Thietbi.IdDonvi != 0 && !Thietbi.IdDonvi.Equals("")) {
                    sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Thietbi.IdDonvi; ;
                }else { sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = DBNull.Value; }
                sqlCMD.Parameters.Add("@TinhTrang", SqlDbType.NChar).Value = Thietbi.TinhTrang;
                sqlCMD.Parameters.Add("@Kho", SqlDbType.Int).Value = Thietbi.TonKho;

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
        public void Modify(Thietbi Thietbi, int IdTB) // sua theo TT
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "UPDATE DM_ThietBi SET " +
                "idLoaiTB=@idloaiTB, TenTB=@TenTB, Seri=@Seri, MAC=@MAC, CoreCPU=@CoreCPU, RAM=@RAM, HardDisk=@HardDisk, Monitor=@Monitor, idQuannhan=@idQuannhan, idDonvi=@idDonvi, TinhTrang = @TinhTrang, Kho = @Kho " +
                "Where IdThietBi = " + IdTB;
            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@idloaiTB", SqlDbType.Int).Value = Thietbi.IdloaiTB;   // gan cu the
                sqlCMD.Parameters.Add("@TenTB", SqlDbType.NChar).Value = Thietbi.TenTB1;
                sqlCMD.Parameters.Add("@Seri", SqlDbType.NChar).Value = Thietbi.Seri1;
                sqlCMD.Parameters.Add("@MAC", SqlDbType.NChar).Value = Thietbi.MAC1;
                sqlCMD.Parameters.Add("@CoreCPU", SqlDbType.NChar).Value = Thietbi.CoreCPU1;
                sqlCMD.Parameters.Add("@RAM", SqlDbType.NChar).Value = Thietbi.RAM1;
                sqlCMD.Parameters.Add("@HardDisk", SqlDbType.NChar).Value = Thietbi.HardDisk1;
                sqlCMD.Parameters.Add("@Monitor", SqlDbType.NChar).Value = Thietbi.Monitor1;
                if (Thietbi.IdQuannhan != null && Thietbi.IdQuannhan != 0 && !Thietbi.IdQuannhan.Equals(""))
                {
                    sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = Thietbi.IdQuannhan;
                }
                else { sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = DBNull.Value; }
                if (Thietbi.IdDonvi != null && Thietbi.IdDonvi != 0 && !Thietbi.IdDonvi.Equals(""))
                {
                    sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Thietbi.IdDonvi; ;
                }
                else { sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = DBNull.Value; }
                sqlCMD.Parameters.Add("@Kho", SqlDbType.Int).Value = Thietbi.TonKho;   
                sqlCMD.Parameters.Add("@TinhTrang", SqlDbType.NChar).Value = Thietbi.TinhTrang;


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
        public void Delete(int IdThieBi)    // xoa theo ma
        {
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "Delete DM_ThietBi Where IdThietBi = @IdThietBi";

            try
            {
                sqlConnection.Open();

                sqlCMD = new SqlCommand(query, sqlConnection);
                sqlCMD.Parameters.Add("@IdThietBi", SqlDbType.Int).Value = IdThieBi;
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

        #region query QN, ĐV theo id
        public DataSet getQN_Thietbi(string idQN)
        {
            DataSet bangDV = new DataSet();
            string query = "select Ten, idDonvi from DM_QuanNhan " +
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
            
            return bangDV;
        }
        
        public DataSet getDV_Thietbi(string idDonvi)
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
            //string DV;
            //DV = bangDV.Tables[0].Rows[0][0].ToString() + ", " + bangDV.Tables[0].Rows[0][1].ToString() + ", " + bangDV.Tables[0].Rows[0][2].ToString();
            return bangDV;
        }

        #endregion

        #region Tìm kiếm
        /*public DataTable getDS_TB(byte i, string st)
        {
            DataTable bangXM = new DataTable();

            string query = "select * from DM_ThietBi WHERE ";// * se lay tat ca cac cot

            switch (i)
            {
                case 1:
                    query += "TenTB like N'%";
                    break;
                case 2:
                    query += "ID like '%";
                    break;
                case 3:
                    query += "CCCD like '%";
                    break;
                case 4:
                    query += "SoTheDang like '%";
                    break;
                case 5:
                    query += "SoTheQN like '%";
                    break;
            }

            query += st + "%'";

            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi

                dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                sqlConnection.Close();
            }
            return bangXM;
        }*/
        #endregion
    }
}
