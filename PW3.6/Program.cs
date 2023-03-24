using System;
using System.Linq;

namespace PW3._6
{
    public class RandomNumberGenerator
    {
        private int length;
        private int[] sequence;
        private int? variance;
        private double? standardDeviation;
        private int? median;
        // Конструктор
        public RandomNumberGenerator(int length)
        {
            this.length = length;
            sequence = GenerateSequence();
        }

        private int[] GenerateSequence()
        {
            // Рандом определенной длины
            Random random = new Random();
            return Enumerable.Range(0, length)
                .Select(_ => random.Next(0, 100)) // Случайное число от 0 до 100
                .ToArray(); // Заполнение в массив
        }

        public int GetVariance()
        {
            // Вычисление дисперсии
            double avg = sequence.Average();
            variance = (int)sequence.Select(x => Math.Pow(x - avg, 2)).Average();
            return variance.Value;
        }

        public double GetStandardDeviation()
        {
            // Вычисление среднеквадратического отклонения
            standardDeviation = Math.Sqrt(GetVariance());
            return standardDeviation.Value;
        }

        public int GetMedian()
        {
            // Вычисление медианы
            int[] sortedSequence = sequence.OrderBy(x => x).ToArray();
            int mid = sortedSequence.Length / 2;
            if (sortedSequence.Length % 2 != 0)
            {
                median = sortedSequence[mid];
            }
            else
            {
                median = (sortedSequence[mid - 1] + sortedSequence[mid]) / 2;
            }
            return median.Value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumberGenerator myGenerator = new RandomNumberGenerator(100);

            Console.WriteLine(myGenerator.GetVariance());
            Console.WriteLine(myGenerator.GetStandardDeviation());
            Console.WriteLine(myGenerator.GetMedian());

            Console.ReadKey(true);
        }
    }
}