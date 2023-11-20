using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class Donvi
    {
        private int idDonvi;
        private string Doi, TieuDoan, LuDoan;

        public Donvi()
        {
        }

        public Donvi(string doi, string tieuDoan, string luDoan)
        {
            Doi = doi;
            TieuDoan = tieuDoan;
            LuDoan = luDoan;
        }

        public int IdDonvi { get => idDonvi; set => idDonvi = value; }
        public string Doi1 { get => Doi; set => Doi = value; }
        public string TieuDoan1 { get => TieuDoan; set => TieuDoan = value; }
        public string LuDoan1 { get => LuDoan; set => LuDoan = value; }
    }
}
