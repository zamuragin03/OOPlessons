using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account2 account = new Account2(200);
            // Добавляем в делегат ссылку на метод PrintSimpleMessage
            account.RegisterHandler(PrintSimpleMessage);
            // Два раза подряд пытаемся снять деньги
            account.Take(100);
            account.Take(150);

            void PrintSimpleMessage(string message) => Console.WriteLine(message);
        }
    }
    public class Account
    {
        int sum;
        public Account(int sum) => this.sum = sum;
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                Console.WriteLine($"Со счета списано {sum} у.е.");
            }
        }
    }
    public delegate void AccountHandler(string message);
    public class Account2
    {
        int sum;
        // Создаем переменную делегата
        AccountHandler? taken;
        public Account2(int sum) => this.sum = sum;
        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken = del;
        }
        public void Add(int sum) => this.sum += sum;
        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                // вызываем делегат, передавая ему сообщение
                taken?.Invoke($"Со счета списано {sum} у.е.");
            }
            else
            {
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
            }
        }
    }
}
