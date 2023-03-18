using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe
{
    public class StudentJournal : IJournalManager<StudentJournalData>
    {
        private List<StudentJournalData> _journals;
        public delegate List<StudentJournalData> LoadHandle(string path);
        public event LoadHandle OnLoad;

        public StudentJournal(LoadHandle loadHandle)
        {
            _journals = new List<StudentJournalData>();
            OnLoad = loadHandle;
        }
        public void AddJournalItem(StudentJournalData item)
        {
            _journals.Add(item);
        }

        public bool ChangeItem(StudentJournalData item, Guid id)
        {
            var index = _journals.FindIndex(jd => jd.Id == id);
            if (index == -1)
            {
                return false;
            }

            _journals[index] = item;

            return true;
        }

        public List<StudentJournalData> GetAllJournalItemsByFilter(Func<List<StudentJournalData>, List<StudentJournalData>> filter)
        {
            return filter?.Invoke(_journals);
        }

        public StudentJournalData GetItemById(Guid id)
        {
            return _journals.Find(jd => jd.Id == id);
        }

        public List<StudentJournalData> GetJournalItemsByName(string name)
        {
            return _journals.FindAll(jd => jd.StudentName == name);
        }

        public void LoadJournalData(string path)
        {
            _journals = OnLoad?.Invoke(path);
        }
    }
}
