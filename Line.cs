using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab2 {
    public class Line {
        
        private Point _start;
        private Point _end;
        
        public Point Start {
            get { return _start; }
            set { _start = value; }
        }

        public Point End {
            get { return _end; }
            set { _end = value; }
        }

        public Line(Point start, Point end) {
            _start = start;
            _end = end;
        }

        public Line(double x1, double y1, double x2, double y2)
            : this(new Point(x1, y1), new Point(x2, y2)) {}

        public int Length {
            get
            {
                double dx = _end.X - _start.X;
                double dy = _end.Y - _start.Y;
                return (int)Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public override string ToString() {
            return $"Линия от {_start} до {_end}";
        }
    }
}
