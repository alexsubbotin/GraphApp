using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    [Serializable]
    public class PracticeGraph // Класс для графов из файла
    {
        string[] floors; // Информация о ярусах
        bool[,] adjMatrix; // Матрица смежности

        public string[] Floors { get; set; } // Не проверяется, т.к. в программе уже все учтено
        public bool[,] AdjMatrix { get; set; } // Не проверяется, т.к. в программе уже все учтено

        public PracticeGraph(string[] floors, bool[,] adjM) // Конструктор с параметрами
        {
            Floors = floors;
            AdjMatrix = adjM;
        }

        public PracticeGraph() // Конструктор без параметров
        {
            Floors = null;
            AdjMatrix = null;
        }
    }
}
