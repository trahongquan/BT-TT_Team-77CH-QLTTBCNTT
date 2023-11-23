using Microsoft.Reporting.WinForms;
using QLTTBCNTT_WinForm.Model.ModelTB;
using QLTTBCNTT_WinForm.Model.ModelTBDV;
using QLTTBCNTT_WinForm.Object;
using QLTTBCNTT_WinForm.suport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTBCNTT_WinForm
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReportTB_Click(object sender, EventArgs e)
        {
            ModelTB modelTB = new ModelTB();
            List<DM_ThietBi> listTB = modelTB.DM_ThietBi.ToList();
            List<ThietBiReport> ListThietBiReports = new List<ThietBiReport>();

            foreach (DM_ThietBi tb in listTB)
            {
                ThietBiReport tbrp = new ThietBiReport();
                tbrp.LoaiTB = tb.DM_LoaiThietBi != null ? tb.DM_LoaiThietBi.loai : "Không có thông tin";
                tbrp.TenTB = tb.TenTB;
                tbrp.Seri = tb.Seri;
                tbrp.MAC = tb.MAC;
                tbrp.CoreCPU = tb.CoreCPU;
                tbrp.RAM = tb.RAM;
                tbrp.HardDisk = tb.HardDisk;
                tbrp.Monitor = tb.Monitor;
                tbrp.TinhTrang = tb.TinhTrang;
                if (tb.Kho == 1) { tbrp.Kho = "Còn tồn"; } else { tbrp.Kho = "Đã xuất"; }

                if (tb.DM_QuanNhan != null)
                {
                    tbrp.Quannhan = tb.DM_QuanNhan.Ten;
                }
                else
                {
                    tbrp.Quannhan = "Chưa biên chế";
                }

                if (tb.DM_Donvi != null)
                {
                    tbrp.Donvi = tb.DM_Donvi.Doi + ", " + tb.DM_Donvi.TieuDoan + ", " + tb.DM_Donvi.LuDoan;
                }
                else
                {
                    tbrp.Donvi = "Chưa biên chế";
                }

                ListThietBiReports.Add(tbrp);
            }

            reportTB.LocalReport.ReportPath = "DsTB.rdlc";
            var source = new ReportDataSource("DataSetThietBiReport", ListThietBiReports);
            reportTB.LocalReport.DataSources.Clear();
            reportTB.LocalReport.DataSources.Add(source);
            this.reportTB.RefreshReport();
            this.reportTB.RefreshReport();
        }

        private void btnTB_tonkho_Click(object sender, EventArgs e)
        {
            ModelTB modelTB = new ModelTB();
            List<DM_ThietBi> listTB = modelTB.DM_ThietBi.ToList();
            List<ThietBiReport> ListThietBiReports = new List<ThietBiReport>();

            foreach (DM_ThietBi tb in listTB)
            {
                if (tb.Kho == 1) { 
                    
                    ThietBiReport tbrp = new ThietBiReport();
                    tbrp.LoaiTB = tb.DM_LoaiThietBi != null ? tb.DM_LoaiThietBi.loai : "Không có thông tin";
                    tbrp.TenTB = tb.TenTB;
                    tbrp.Seri = tb.Seri;
                    tbrp.MAC = tb.MAC;
                    tbrp.CoreCPU = tb.CoreCPU;
                    tbrp.RAM = tb.RAM;
                    tbrp.HardDisk = tb.HardDisk;
                    tbrp.Monitor = tb.Monitor;
                    tbrp.TinhTrang = tb.TinhTrang;
                    tbrp.Kho = "Còn tồn";

                    if (tb.DM_QuanNhan != null)
                    {
                        tbrp.Quannhan = tb.DM_QuanNhan.Ten;
                    }
                    else
                    {
                        tbrp.Quannhan = "Chưa biên chế";
                    }

                    if (tb.DM_Donvi != null)
                    {
                        tbrp.Donvi = tb.DM_Donvi.Doi + ", " + tb.DM_Donvi.TieuDoan + ", " + tb.DM_Donvi.LuDoan;
                    }
                    else
                    {
                        tbrp.Donvi = "Chưa biên chế";
                    }

                ListThietBiReports.Add(tbrp);
                }
            }

            reportTB.LocalReport.ReportPath = "DsTB.rdlc";
            var source = new ReportDataSource("DataSetThietBiReport", ListThietBiReports);
            reportTB.LocalReport.DataSources.Clear();
            reportTB.LocalReport.DataSources.Add(source);
            this.reportTB.RefreshReport();
            this.reportTB.RefreshReport();
        }

        private void btnTBQN_Click(object sender, EventArgs e)
        {

        }

        private void btnTBDV_Click(object sender, EventArgs e)
        {
            ModelTBDV modelTBDV = new ModelTBDV();
            List<TB_Donvi> TB_Donvis = modelTBDV.TB_Donvi.ToList();
            List<TBDVReport> TBDVReports = new List<TBDVReport>();

            foreach (TB_Donvi tbdv in TB_Donvis)
            {
                TBDVReport tbdvrp = new TBDVReport();
                tbdvrp.LoaiTB = new QueryLoaiTB().getLoaiThietbi(tbdv.idThietbi.ToString());
                tbdvrp.Thietbi = tbdv.DM_ThietBi.TenTB;
                tbdvrp.Donvi = new QueryDonvi().getDonvi(tbdv.idDonvi.ToString());
                tbdvrp.DateBorrow = tbdv.DateBorrow;
                tbdvrp.DateReturn = tbdv.DateReturn;

                TBDVReports.Add(tbdvrp);
            }

            reportTB.LocalReport.ReportPath = "DsTBDV.rdlc";
            var source = new ReportDataSource("DataSetTBDV", TBDVReports);
            reportTB.LocalReport.DataSources.Clear();
            reportTB.LocalReport.DataSources.Add(source);
            this.reportTB.RefreshReport();
            this.reportTB.RefreshReport();
        }
    }
}
