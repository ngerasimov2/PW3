namespace PW3._2
{
    class SmsMessage
    {
        // Приватные поля
        private string messageText = "";
        private double price;
        // Конструктор
        public SmsMessage(string messageText)
        {
            MessageText = messageText;
            CalculatePrice();
        }
        // Свойство MessageText
        public string MessageText
        {
            get { return messageText; }
            set
            {
                if (value.Length > 250)
                {
                    Console.WriteLine("Ваше сообщение превышает лимит в 250 символов. Оно будет обрезано до 250 символов.");
                    messageText = value.Substring(0, 250);
                }
                else
                {
                    messageText = value;
                }
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
            int messageLength = Math.Min(messageText.Length, 250); // Длина строки
            if (messageLength <= 65)
            {
                price = 1.5;
            }
            else
            {
                int additionalChars = messageLength - 65;
                double additionalPrice = additionalChars * 0.5;
                price = 1.5 + additionalPrice;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите сообщение для отправки");
                string text = Console.ReadLine();
                SmsMessage newSms = new SmsMessage(text); // Экземпляр класса SmsMessage

                Console.WriteLine($"Длина сообщения: {newSms.MessageText.Length}");
                Console.WriteLine($"Цена сообщения: {newSms.Price}");

                if (newSms.MessageText.Length > 250)
                {
                    Console.WriteLine("Обрезанное сообщение:");
                }
                Console.WriteLine(newSms.MessageText);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение для отправки");
            string text = Console.ReadLine();
            SmsMessage newSms = new SmsMessage(text); // Экземпляр класса SmsMessage

            Console.WriteLine($"Длина сообщения: {newSms.MessageText.Length}");
            Console.WriteLine($"Цена сообщения: {newSms.Price}");

            if (newSms.MessageText.Length > 300)
            {
                Console.WriteLine("Обрезанное сообщение:");
            }
            Console.WriteLine(newSms.MessageText);
        }
    }
}