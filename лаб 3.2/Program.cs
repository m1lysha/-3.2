class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
            return;
        }

       
        int[] oddHundreds = { 100, 300, 500, 700, 900 };

       
        Console.WriteLine("Результаты целочисленного деления нечетных сотен на m:");
        foreach (int number in oddHundreds)
        {
            int result = number / m;
            Console.WriteLine($"{number} / {m} = {result}");
        }
    }
}