using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pouch_controller.Models
{
    class CsvRecordContainer
    {
        private string Way;
        public List<Record> recs;

        public CsvRecordContainer(string way = "stupid_program.csv")
        {
            Way = way;
            //recs = new List<Record>();
            //recs.Add(new Record(100, DateTime.UtcNow, 100));
            //recs.Add(new Record(140, DateTime.UtcNow, 160,"sd", new List<string>(new string[] { "title" })));
            //recs.Add(new Record(10, DateTime.UtcNow, 110, new List<string>(new string[] { "title", "213123" })));
            try
            {
                LoadData();
            }
            catch{
                SaveUpdates();
            }
        }
        public void SaveUpdates()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("ID,Count,Describtion,Date,Tegs");
            foreach (var item in recs)
            {
                sb.AppendLine(item.ToString());
            }
            System.IO.File.WriteAllText(
                System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, Way),
                sb.ToString());
        }
        public void LoadData()
        {
            if(recs != null)
                recs.Clear();
            recs  = File.ReadLines(Way).Skip(1).Select(line => new Record(line)).ToList();
        }
        public void Add(Record rec)
        {
            recs.Add(rec);
            SaveUpdates();
        }
        public void Delete(uint Id)
        {
            foreach(var i in recs)
            {
                if(i.ID == Id)
                {
                    recs.Remove(i);
                    break;
                }
            }
            SaveUpdates();
        }
    }
}
