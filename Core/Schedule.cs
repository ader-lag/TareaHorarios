using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Schedule
    {
        private string Day { get; set; }
        private string StartOfClasses { get; set; }
        private string EndOfClass { get; set; }
        private string Classroom { get; set; }
        private string Professor { get; set; }

        public Schedule(string day, string starofclasses, string endofclass, string classroom, string professor)
        {
            Day = day;
            StartOfClasses = starofclasses;
            EndOfClass = endofclass;
            Classroom = classroom;
            Professor = professor;
        }

        public override string ToString()
        {
            return string.Format("Day:{0}\tStarts:{1}\tEnds:{2}\tClassroom:{3}\tProfessor:{4}", Day, StartOfClasses, EndOfClass, Classroom, Professor);
        }
    }
}
