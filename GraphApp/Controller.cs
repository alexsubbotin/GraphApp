using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphApp
{
    class Controller // Хранит функции
    {
        public static string[] Floors(bool[,] adjMatrix) // Распределение вершин по ярусам 
        {
            int k = adjMatrix.GetLength(0); // Кол-во оставшихся вершин
            string floors = ""; // Список вершин на ярусах
            string lastFloor = ""; // Список вершин на последнем ярусе
            string buf = ""; // Хранит найденные нулевые строки за один проход

            for (int i = 0; i < adjMatrix.GetLength(0); i++) // Поиск нулевых строк
            {
                bool no1InString = true; // Отвечает за наличие единицы в строке

                for (int j = 0; j < adjMatrix.GetLength(1); j++)
                {
                    if (adjMatrix[i, j])
                    {
                        no1InString = false; // Опустили флажок, единица нашлась
                        break;
                    }

                }

                if (no1InString) // Строка нулевая
                {
                    lastFloor += (i + 1) + "&"; // Добавили вершину на последний ярус
                    k--;
                }

            }

            while (k > 0) // Пока не все вершины записаны
            {
                for (int j = 0; j < adjMatrix.GetLength(1); j++) // Идем по столбцам
                {
                    if (!floors.Contains((j + 1).ToString()) && !lastFloor.Contains((j + 1).ToString())) // Если столбец не удален (не записан)
                    {
                        bool no1InColumn = true; // Флажок, говорящий об отсуствии единицы в столбце

                        for (int i = 0; i < adjMatrix.GetLength(0); i++) // Идем по ячейкам столбца
                        {
                            if (!floors.Contains((i + 1).ToString()) && !lastFloor.Contains((i + 1).ToString())) // Если строка не удалена
                            {
                                if (adjMatrix[i, j])
                                {
                                    no1InColumn = false; // Опустили флажок, единица нашлась
                                    break;
                                }
                            }
                        }

                        if (no1InColumn) // Если единиц в столбце не было
                        {
                            buf += (j + 1) + "&"; // Записали вершину
                            k--; // Уменьшили кол-во оставшихся вершин на 1
                        }
                    }
                }

                floors += buf + " "; // Записали в ярус найденные вершины
                buf = "";
            }

            floors += lastFloor; // Соединили все ярусы с последним
            string[] floorsArr = floors.Split(' ');
            //floorsArr = Mas(floorsArr);

            return floorsArr;
        }

        public static string[] Mas(string[] arr) // Запись массива без пустого последнего элемента
        {
            string[] buf = new string[arr.Length - 1];

            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = arr[i];
            }

            return buf;
        }

        public static void GraphInput(bool[,] adjMatrix, int level) // Вспомогательная функция для записи графа в БД для практики
        {
            string[] paths = new string[3]; // Три файла, в которых хрнятся графы разной сложности
            paths[0] = "Easy.bin";
            paths[1] = "Medium.bin";
            paths[2] = "Hard.bin";

            string[] floors = Floors(adjMatrix); // Получили ярусы

            PracticeGraph practiceGraph = new PracticeGraph(floors, adjMatrix); // Создали объект с информацией о графе

            FileStream f = new FileStream(paths[level], FileMode.Open); // Открыли нужный по сложности поток для чтения
            BinaryFormatter bf = new BinaryFormatter();

            //PracticeGraph[] practiceGraphArr = new PracticeGraph[1]; // Использовалось для добавления первого графа
            //practiceGraphArr[0] = practiceGraph;

            PracticeGraph[] pArr = (PracticeGraph[])bf.Deserialize(f); // Получили то, что уже лежит в файле

            f.Close();

            f = new FileStream(paths[level], FileMode.Create); // Открыли поток для перезаписи

            PracticeGraph[] practiceGraphArr = new PracticeGraph[pArr.Length + 1]; // Объявили новый массив

            for (int i = 0; i < practiceGraphArr.Length - 1; i++) // Переписали уже имеющиеся значения
            {
                practiceGraphArr[i] = pArr[i];
            }
            practiceGraphArr[practiceGraphArr.Length - 1] = practiceGraph; // Записали добавляемый элемент  

            bf.Serialize(f, practiceGraphArr); // Записали новый массив

            f.Close(); // Закрыли поток
        }

        public static Random rnd = new Random(); // ДСЧ
        public static PracticeGraph GetGraph(int level) // Получение графа нужной сложности из БД
        {
            string[] paths = new string[3]; // Три файла, в которых хрнятся графы разной сложности
            paths[0] = "Easy.bin";
            paths[1] = "Medium.bin";
            paths[2] = "Hard.bin";


            FileStream f = new FileStream(paths[level], FileMode.Open); // Открыли нужный поток
            BinaryFormatter bf = new BinaryFormatter();

            PracticeGraph[] practiceGraphArr = (PracticeGraph[])bf.Deserialize(f); // Считали массив графов

            f.Close(); // Закрыли поток

            int index = rnd.Next(0, practiceGraphArr.Length); // Формируем случайный индекс 

            return practiceGraphArr[index];

        }

    }
}
