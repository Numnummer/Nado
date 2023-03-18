using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ForMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            teacher.StudentJournal.LoadJournalData("Test.csv");
        }
    }
}
