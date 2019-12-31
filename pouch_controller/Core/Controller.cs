using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pouch_controller.Models;

namespace pouch_controller.Core
{
    class Controller
    {
        private string Name;
        private uint startId = 0;
        private CsvRecordContainer recs;
        public Controller(string _name = "admin")
        {
            Name = _name;
            recs = new CsvRecordContainer(_name + ".csv");
            setStartId();
        }
        public void AddData(DateTime date, uint count, string describe, string tegs = null)
        {
            var full_tegs = tegs == null ? new List<string>() : new List<string>(tegs
                        .Replace(" ", string.Empty)
                        .Replace("\r\n", string.Empty)
                        .Replace("\n", string.Empty)
                        .Split('#'));
            full_tegs.Add(date.Year.ToString());
            full_tegs.Add(date.Month.ToString());
            full_tegs.Add(date.Day.ToString());
            recs.Add(new Record(startId++, date, count, full_tegs));
        }
        public void DeleteData(uint Id)
        {
            recs.Delete(Id);
        }
        public List<Record> GetAllRecords()
        {
            return new List<Record>(recs.recs);
        }
        private void setStartId()
        {
            foreach(var i in recs.recs)
            {
                if(startId <= i.ID)
                {
                    startId = i.ID + 1;
                }
            }
        }
    }
}
