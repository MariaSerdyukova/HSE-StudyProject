using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pouch_controller.Models
{
    /// <summary>
    /// Класс, описывающий запись
    /// </summary>
    internal class Record
    {
        // Id записи
        public uint ID;
        // сумма
        public uint Count;
        // описание
        public string Describtion;
        // дата совершения
        public DateTime Date;
        // теги для поиска
        public List<string> Tags;

        public Record(uint iD, DateTime date, uint count, string describe, List<string> tags = null)
        {
            Date = date;
            Describtion = describe;
            Count = count;
            ID = iD;
            Tags = tags ?? new List<string>();
        }
        
        public Record(uint iD, DateTime date, uint count, List<string> tags = null) : this(iD, date, count, date.ToShortDateString(), tags) { }

        public Record(string Data)
        {
            var elems = Data.Split(',');
            ID = Convert.ToUInt32(elems[0]);
            Count = Convert.ToUInt32(elems[1]);
            Describtion = (elems[2]);
            Date = Convert.ToDateTime(elems[3]);
            Tags = new List<string>(elems[4].Split(';'));

        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4}", ID, Count, Describtion, Date.ToShortDateString(), string.Join(";", Tags));
        }
    }
}
