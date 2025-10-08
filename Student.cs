using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab2 {
    public class Student {
        private string _name;
        private int[] _grades;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public int[] Grades {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(string name, int[] grades) {
            _name = name;
            _grades = grades;
        }

        public override string ToString() {
            string gradesString = _grades != null && _grades.Length > 0
                ? string.Join(", ", _grades)
                : "оценок нет";
            return $"Имя: {_name}, Оценки: [{gradesString}]";
        }
    }
}
