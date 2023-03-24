namespace PW3._4
{
    class MyIntList
    {
        // Приватный список и поле
        private List<int> numbersList = new List<int>();
        private int sum = 0;
        // Свойтсво Average
        public double Average
        {
            get { return CalculateAverage(); }
        }
        // Свойство Sum
        public double Sum
        {
            get { return CalculateSum(); }
        }
        // Свойство Min
        public int Min
        {
            get { return numbersList.Min(); }
        }
        // Max
        public int Max
        {
            get { return numbersList.Max(); }
        }
        // Метод добавления цифры в список
        public void AddNumber(int number)
        {
            numbersList.Add(number);
            CalculateSum();
        }
        // Метод удаления цифры из списка
        public void RemoveNumber(int number)
        {
            numbersList.Remove(number);
            CalculateSum();
        }
        // Расчёт среднего числа
        private double CalculateAverage()
        {
            if (numbersList.Count == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (int number in numbersList)
            {
                sum += number;
            }

            return (double)sum / numbersList.Count;
        }
        // Расчёт суммы
        private int CalculateSum()
        {
            sum = 0;
            foreach (int number in numbersList)
            {
                sum += number;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();
            numbers.AddNumber(1);
            numbers.AddNumber(2);
            numbers.AddNumber(8);

            Console.WriteLine(numbers.Average); // 3.6
            Console.WriteLine(numbers.Sum); // 11
            Console.WriteLine(numbers.Max); // 8
            Console.WriteLine(numbers.Min); // 1

            Console.ReadKey();
        }
    }
}