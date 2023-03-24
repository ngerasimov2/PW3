namespace PW3
{
    class Color
    {
        //Приватные поля
        private int red;
        private int green;
        private int blue;
        //Свойство Red
        public int Red
        {
            get { return red; }
            set { red = NormalizeColorValue(value); }
        }
        //Свойство Green
        public int Green
        {
            get { return green; }
            set { green = NormalizeColorValue(value); }
        }
        //Свойство Blue
        public int Blue
        {
            get { return blue; }
            set { blue = NormalizeColorValue(value); }
        }
        // Конструктор, который позволяет создавать экземпляры без указания значений цветом в момент создания
        public Color() { }
        // Конструктор
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        // Метод вывода цветов
        public void DisplayColor()
        {
            Console.WriteLine($"{red}, {green}, {blue}");
        }
        // Метод, чтобы значение не выходило за пределы
        public int NormalizeColorValue(int colorValue)
        {
            if (colorValue > 255)
            {
                return 255;
            }
            if (colorValue < 0)
            {
                return 0;
            }
            return colorValue;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Color yellow = new Color(300, 300, 0);
            yellow.DisplayColor(); // 255, 255, 0

            Color pink = new Color();
            pink.Red = 255;
            pink.Green = -20;
            pink.Blue = 147;

            pink.DisplayColor(); // 255, 0, 147

            Console.ReadKey(true);
        }
    }
}