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
    internal class QueryDashBoard
    {
        #region Cac thuoc tinh
        SqlDataAdapter dataAdapter;     // xuat du lieu vao bang
        SqlCommand sqlCMD;              // truy van, cap nhat CSDL
        #endregion

        #region Các phương thức
        public DataTable getDSTB()
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
                "(@idloaiTB, @TenTB, @Seri, @MAC, @CoreCPU, @RAM, @HardDisk, @Monitor, @idQuannhan, @idDonvi)";
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
                sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = Thietbi.IdQuannhan;
                sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Thietbi.IdDonvi;

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
                "idLoaiTB=@idloaiTB, TenTB=@TenTB, Seri=@Seri, MAC=@MAC, CoreCPU=@CoreCPU, RAM=@RAM, HardDisk=@HardDisk, Monitor=@Monitor, idQuannhan=@idQuannhan, idDonvi=@idDonvi " +
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
                if (Thietbi.IdQuannhan.ToString() != "") sqlCMD.Parameters.Add("@idQuannhan", SqlDbType.Int).Value = Thietbi.IdQuannhan;
                if (Thietbi.IdDonvi.ToString() != "") sqlCMD.Parameters.Add("@idDonvi", SqlDbType.Int).Value = Thietbi.IdDonvi;


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

        #region Query Bảng rút gọn


        public DataTable getDSLTB()
        {
            DataTable bangXM = new DataTable();

            string query = "select * from DM_LoaiThietBi";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi

                dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                sqlConnection.Close();
            }
            return bangXM;
        }
        public DataTable getDS(string s)
        {
            DataTable bangXM = new DataTable();

            string query = s;
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi

                dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                sqlConnection.Close();
            }
            return bangXM;
        }
        public DataTable Search(string col, string st)
        {
            DataTable bangXM = new DataTable();

            string query = "select TB.TenTB, LTB.loai, QN.Ten, DV.Doi, DV.TieuDoan, DV.LuDoan " +
                            "From DM_ThietBi As TB, DM_LoaiThietBi As LTB, DM_Quannhan As QN, DM_Donvi As DV " +
                            "WHERE TB.idLoaiTB = LTB.IdLoaiTB And TB.idQuannhan = QN.IDQuannhan and QN.idDonvi = DV.IdDonvi and ";

                    query += col;
                    query += " like N'%";
                    query += st + "%'";

            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();

                dataAdapter = new SqlDataAdapter(query, sqlConnection); //tao 1 ket noi CSDL moi

                dataAdapter.Fill(bangXM);   // dien du lieu vao bang
                sqlConnection.Close();
            }
            return bangXM;
        }
        #endregion

        #region Report

        // Phương thức để thực hiện truy vấn và trả về một DataTable
        public DataTable getDsReport(string query)
        {
            using (SqlConnection connection = ConnectionString.getConnection())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    Console.WriteLine(ex.Message);
                }
                return dataTable;
            }
        }


        #endregion
    }
}
