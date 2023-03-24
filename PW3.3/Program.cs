namespace PW3._3
{
    class SQLCommand
    {
        // Приватное поле
        private string commandText;

        // Конструктор
        public SQLCommand(string commantText)
        {
            this.commandText = commantText;
            SQLToUpper();
        }

        // Метод, который сначала делит строку на элементы массива и переводит слова insert, into и values в верхний регистр
        public void SQLToUpper()
        {
            string[] SQLCommand = commandText.Split(' ');
            for (int i = 0; i < SQLCommand.Length; i++)
            {
                if (SQLCommand[i] == "insert" || SQLCommand[i] == "into" || SQLCommand[i] == "values")
                {
                    SQLCommand[i] = SQLCommand[i].ToUpper();
                }
            }
            string output = string.Join(" ", SQLCommand);
            Console.WriteLine(output);

        }

        internal class Program
        {
            static void Main(string[] args)
            {
                SQLCommand newSQLCommand = new SQLCommand("insert into orders (user_id, total_price, address) values (1, 20000, 'asdfg')");// Запрос
            }
        }
    }
}