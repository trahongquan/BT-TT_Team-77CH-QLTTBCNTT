using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class DMLoaiTB
    {
        private int idLoaiTB;
        private string loai;

        public DMLoaiTB()
        {
        }

        public DMLoaiTB(string loai)
        {
            this.loai = loai;
        }
    }
}
