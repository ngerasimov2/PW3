namespace PW3._5
{
    class SmsMessage
    {
        // Приватные поля
        private string messageText = "";
        private double price;

        private int maxLength = 250;
        private double startPrice = 1.5;
        private double tax = 0.5;

        // Конструктор
        public SmsMessage(string messageText)
        {
            MessageText = messageText;
            CalculatePrice();
        }

        // Конструктор с параметрами
        public SmsMessage(string messageText, int maxLength, double startPrice, double tax)
        {
            this.maxLength = maxLength;
            this.startPrice = startPrice;
            this.tax = tax;
            MessageText = messageText;
            CalculatePrice();
        }

        // Свойство MessageText
        public string MessageText
        {
            get { return messageText; }
            set
            {
                if (value.Length > maxLength)
                {
                    Console.WriteLine($"Ваше сообщение превышает лимит в {maxLength} символов. Оно будет обрезано до {maxLength} символов.");
                    messageText = value.Substring(0, maxLength);
                }
                else
                {
                    messageText = value;
                }
                CalculatePrice();
            }
        }

        // Свойство Price
        public double Price
        {
            get { return price; }
        }

        // Метод расчёта цены
        private void CalculatePrice()
        {
            int messageLength = Math.Min(messageText.Length, maxLength); // Длина строки
            if (messageLength <= 65)
            {
                price = startPrice;
            }
            else
            {
                int additionalChars = messageLength - 65;
                double additionalPrice = additionalChars * tax;
                price = startPrice + additionalPrice;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 300;
            Console.WriteLine("Введите сообщение");
            string text = Console.ReadLine();
            SmsMessage newSms = new SmsMessage(text, maxLength, 10, 4); // Экземпляр класса SmsMessage

            Console.WriteLine($"Длина сообщения: {newSms.MessageText.Length}");
            Console.WriteLine($"Цена сообщения: {newSms.Price}");

            if (newSms.MessageText.Length > maxLength)
            {
                Console.WriteLine("Обрезанное сообщение:");
            }
            Console.WriteLine(newSms.MessageText);
        }
    }
}