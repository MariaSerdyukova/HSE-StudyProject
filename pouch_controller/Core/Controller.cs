using System;
using System.Collections.Generic;
using System.Linq;
using pouch_controller.Models;

namespace pouch_controller.Core
{
    /// <summary>
    /// класс управляющйи записями
    /// </summary>
    internal class Controller
    {
        // id последней записи
        private uint startId = 0;
        // csv контейнер, содержащий записи
        private CsvRecordContainer recs;
        // список записей
        public IReadOnlyList<Record> Records => recs?.recs ?? new List<Record>();

        public Controller(string name = "admin")
        {
            recs = new CsvRecordContainer(name + ".csv");
            startId = (recs.recs?.Max(r => r.ID) ?? 0) + 1;
        }

        // добавление новой записи
        public void AddRecord(
            DateTime date, 
            uint count, 
            string describe, 
            string tags = null)
        {
            var full_tags = tags == null ? new List<string>() : new List<string>(tags
                        .Replace(" ", string.Empty)
                        .Replace("\r\n", string.Empty)
                        .Replace("\n", string.Empty)
                        .Split('#'));
            full_tags.Add(date.Year.ToString());
            full_tags.Add(date.Month.ToString());
            full_tags.Add(date.Day.ToString());
            recs.Add(
                new Record(startId++, date, count, full_tags) { Describtion = describe});
        }

        // удаление записи
        public void DeleteRecord(uint Id)
        {
            recs.Delete(Id);
        }
    }
}
