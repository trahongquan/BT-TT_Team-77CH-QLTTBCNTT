using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Model.ModelTB
{
    internal class ThietBiReport
    {
/*        public int IdThietBi { get; set; }
*/
        public string LoaiTB { get; set; }

        public string TenTB { get; set; }

        public string Seri { get; set; }

        public string MAC { get; set; }

        public string CoreCPU { get; set; }

        public string RAM { get; set; }

        public string HardDisk { get; set; }

        public string Monitor { get; set; }

        public string Quannhan { get; set; }

        public string Donvi { get; set; }

        public string TinhTrang { get; set; }

        public string Kho { get; set; }

        public ThietBiReport(string loaiTB, string tenTB, string seri, string mAC, string coreCPU, string rAM, string hardDisk, string monitor, string quannhan, string donvi, string tinhTrang, string kho)
        {
            LoaiTB = loaiTB;
            TenTB = tenTB;
            Seri = seri;
            MAC = mAC;
            CoreCPU = coreCPU;
            RAM = rAM;
            HardDisk = hardDisk;
            Monitor = monitor;
            Quannhan = quannhan;
            Donvi = donvi;
            TinhTrang = tinhTrang;
            Kho = kho;
        }

        public ThietBiReport()
        {
        }

        /*        public virtual DM_Donvi DM_Donvi { get; set; }

                public virtual DM_LoaiThietBi DM_LoaiThietBi { get; set; }

                public virtual DM_QuanNhan DM_QuanNhan { get; set; }*/


    }
}
