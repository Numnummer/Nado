using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMe
{
    public interface IJournalManager<T>
    {
        void AddJournalItem(T item);
        bool ChangeItem(T item, Guid id);
        List<T> GetAllJournalItemsByFilter(Func<List<T>, List<T>> filter);
        T GetItemById(Guid id);
        void LoadJournalData(string path);
        List<T> GetJournalItemsByName(string name);
    }
}
