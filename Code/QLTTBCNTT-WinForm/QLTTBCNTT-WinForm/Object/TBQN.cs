using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTTBCNTT_WinForm.Object
{
    internal class TBQN
    {
        private int idTBQN, idQuannhan, idThietbi;
        private string DateBorrow, DateRrturn;

        public TBQN()
        {
        }

        public TBQN(/*int idTBQN,*/ int idQuannhan, int idThietbi, string dateBorrow, string dateRrturn)
        {
            //this.idTBQN = idTBQN;
            this.idQuannhan = idQuannhan;
            this.idThietbi = idThietbi;
            DateBorrow = dateBorrow;
            DateRrturn = dateRrturn;
        }

        public int IdTBQN { get => idTBQN; set => idTBQN = value; }
        public int IdQuannhan { get => idQuannhan; set => idQuannhan = value; }
        public int IdThietbi { get => idThietbi; set => idThietbi = value; }
        public string DateBorrow1 { get => DateBorrow; set => DateBorrow = value; }
        public string DateRrturn1 { get => DateRrturn; set => DateRrturn = value; }
    }
}
