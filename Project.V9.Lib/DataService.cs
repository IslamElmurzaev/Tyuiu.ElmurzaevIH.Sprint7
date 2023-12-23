using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project.V9.Lib
{
    public class DataService
    {
        public int GetMaxVideoDuration(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Преобразование данных в двумерный массив
            string[][] dataArray = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = lines[i].Split(';');
            }

            // Находим максимальную длительность (предполагаем, что длительность в третьем столбце)
            int maxDuration = 0;
            for (int i = 0; i < dataArray.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                if (dataArray[i].Length > 2 && int.TryParse(dataArray[i][2], out int duration))
                {
                    maxDuration = Math.Max(maxDuration, duration);
                }
            }

            return maxDuration;
        }

        public int GetMinVideoDuration(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Преобразование данных в двумерный массив
            string[][] dataArray = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = lines[i].Split(';');
            }

            // Находим минимальную длительность (предполагаем, что длительность в третьем столбце)
            int minDuration = int.MaxValue;
            for (int i = 0; i < dataArray.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                if (dataArray[i].Length > 2 && int.TryParse(dataArray[i][2], out int duration))
                {
                    minDuration = Math.Min(minDuration, duration);
                }
            }

            // Если minDuration не изменилась, значит не было найдено подходящих значений
            return minDuration == int.MaxValue ? 0 : minDuration;
        }

        public int GetMaxVideoPrice(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Преобразование данных в двумерный массив
            string[][] dataArray = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = lines[i].Split(';');
            }

            // Находим максимальную длительность (предполагаем, что длительность в третьем столбце)
            int maxDuration = 0;
            for (int i = 0; i < dataArray.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                if (dataArray[i].Length > 2 && int.TryParse(dataArray[i][4], out int duration))
                {
                    maxDuration = Math.Max(maxDuration, duration);
                }
            }

            return maxDuration;
        }

        public int GetMinVideoPrice(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Преобразование данных в двумерный массив
            string[][] dataArray = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = lines[i].Split(';');
            }

            // Находим минимальную длительность (предполагаем, что длительность в третьем столбце)
            int minDuration = int.MaxValue;
            for (int i = 0; i < dataArray.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                if (dataArray[i].Length > 2 && int.TryParse(dataArray[i][4], out int duration))
                {
                    minDuration = Math.Min(minDuration, duration);
                }
            }

            // Если minDuration не изменилась, значит не было найдено подходящих значений
            return minDuration == int.MaxValue ? 0 : minDuration;
        }

        public int GetVideoCount(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Подсчет всех кодов видеолент (предполагаем, что код в первом столбце)
            int videoCount = 0;
            for (int i = 0; i < lines.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                string[] values = lines[i].Split(';');

                if (values.Length > 0)
                {
                    string videoCode = values[0].Trim(); // предполагаем, что код видеоленты находится в первом столбце

                    if (!string.IsNullOrEmpty(videoCode))
                    {
                        videoCount++;
                    }
                }
            }

            return videoCount;
        }

        public int GetUniqueActorCount(string filePath)
        {
            // Чтение строк из CSV файла
            string[] lines = File.ReadAllLines(filePath);

            // Подсчет уникальных актеров (предполагаем, что актеры в шестом столбце)
            HashSet<string> uniqueActors = new HashSet<string>();
            for (int i = 0; i < lines.Length; i++) // начинаем с 1, чтобы пропустить заголовок
            {
                string[] values = lines[i].Split(';');

                if (values.Length > 5)
                {
                    string actor = values[5].Trim(); // предполагаем, что актеры находятся в шестом столбце

                    if (!string.IsNullOrEmpty(actor))
                    {
                        uniqueActors.Add(actor);
                    }
                }
            }

            return uniqueActors.Count;
        }

    }
}
