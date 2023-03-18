using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe
{
    public class Teacher
    {
        public StudentJournal StudentJournal { get; private set; }
        public Teacher()
        {
            StudentJournal = new StudentJournal(_loadData);
        }

        private List<StudentJournalData> _loadData(string path)
        {
            using (var stream = new StreamReader(path))
            {
                var csvReader = new CsvHelper.CsvReader(stream, new CsvConfiguration(System.Globalization.CultureInfo.CurrentCulture) { Delimiter = ";" });
                return csvReader.GetRecords<StudentJournalData>().ToList();
            }
        }

    }
}
