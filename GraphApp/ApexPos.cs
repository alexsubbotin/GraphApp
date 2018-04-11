using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    class ApexPos // Класс вершин графа
    {
        int name; // Имя вершины
        int x; // Координата Х
        int y; // Координата У

        public int Name { get; set; }
        public int X { get; set; }

        public int Y { get; set; }

        public ApexPos(int name, int x, int y) // Конструктор
        {
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return Convert.ToString(Name + " " + X + " " + Y);
        }
    }
}
