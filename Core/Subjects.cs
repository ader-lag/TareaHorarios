using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Subjects
    {
        private string writing;

        private int IdSubject { get; set; }
        private string NameSubject { get; set; }
        private string Group { get; set; }
        private List<Schedule> Schedules { get; set; }

        public Subjects()
        {
            IdSubject = 0000000;
            NameSubject = "";
            Group = "";
            Schedules = new List<Schedule>();
        }

        public Subjects(int id, string name, string group, List<Schedule> schedules)
        {
            IdSubject = id;
            NameSubject = name;
            Group = group;
            Schedules = schedules;
        }

        public override string ToString()
        {
            writing = string.Empty;
            foreach (Schedule schedule in Schedules)
            {
                writing += string.Format("Id:{0}\tSignature:{1}\tGroup:{2}\t{3}", IdSubject, NameSubject, Group, Schedules.ToString());
            }
            return writing;
        }
    }
}
