using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe
{
    public class StudentJournalData
    {
        public Guid Id { get; set; }
        public int Score { get; set; }
        public string StudentName { get; set; }
        public SchoolSubject Subject { get; set; }
    }
}
