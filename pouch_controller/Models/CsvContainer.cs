using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pouch_controller.Models
{
    internal class CsvRecordContainer
    {
        // путь к файлу - контейнеру
        private string Way;
        // список записей
        public List<Record> recs = new List<Record>();

        public CsvRecordContainer(string way = "stupid_program.csv")
        {
            Way = way;
            try
            {
                LoadData();
            }
            catch{
                SaveUpdates();
            }
        }

        // сохранение изменений
        public void SaveUpdates()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("ID,Count,Describtion,Date,Tags");
            foreach (var item in recs)
            {
                sb.AppendLine(item.ToString());
            }
            System.IO.File.WriteAllText(
                System.IO.Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, Way),
                sb.ToString());
        }

        // загрузка из файла
        public void LoadData()
        {
            if(recs != null)
                recs.Clear();
            recs  = File.ReadLines(Way).Skip(1).Select(line => new Record(line)).ToList();
        }

        // добавление новой записи
        public void Add(Record rec)
        {
            recs.Add(rec);
            SaveUpdates();
        }

        //удаление записи
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
