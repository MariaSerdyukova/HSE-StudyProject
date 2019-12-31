using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pouch_controller.Models
{
    class Record
    {
        public uint ID;
        public uint Count;
        public string Describtion;
        public DateTime Date;
        public List<string> Tegs;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="date"></param>
        /// <param name="count"></param>
        /// <param name="describe"></param>
        /// <param name="tegs"></param>
        public Record(uint iD, DateTime date, uint count, string describe, List<string> tegs = null)
        {
            Date = date;
            Describtion = describe;
            Count = count;
            ID = iD;
            if (tegs == null)
            {
                Tegs = new List<string>();
            }
            else
            {
                Tegs = tegs;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="date"></param>
        /// <param name="count"></param>
        /// <param name="tegs"></param>
        public Record(uint iD, DateTime date, uint count, List<string> tegs = null):this(iD, date, count, date.ToShortDateString(), tegs){}

        public Record(string Data)
        {
            var elems = Data.Split(',');
            ID = Convert.ToUInt32(elems[0]);
            Count = Convert.ToUInt32(elems[1]);
            Describtion = (elems[2]);
            Date = Convert.ToDateTime(elems[3]);
            Tegs = new List<string>(elems[4].Split(';'));

        }
        public override string ToString() {
            return String.Format("{0},{1},{2},{3},{4}", ID, Count, Describtion, Date.ToShortDateString(), string.Join(";", Tegs));
        }
    }
}
