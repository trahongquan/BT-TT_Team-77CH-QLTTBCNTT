using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Model.ModelTBDV
{
    internal class TBDVReport
    {
        public string Thietbi { get; set; }

        public string LoaiTB { get; set; }

        public string Donvi { get; set; }
        
        public string DateBorrow { get; set; }

        public string DateReturn { get; set; }

    }
}
