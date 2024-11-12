namespace arrays_trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Reverse
            int[] base_arr = { 1, 2, 3, 4, 5 };
            var arr = base_arr.Reverse().ToArray(); // так получим новый перевернутый массив
            Array.Reverse(base_arr); // так получим тот же, но перевернутый; и так же убедимся что оригинальный массив не затрронут
            
            Console.WriteLine("New reversed array: " + string.Join(", ", arr));
            Console.WriteLine("Base reversed array: " + string.Join(", ", base_arr)); */

            /*//Min, Max
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            int min = arr.Min();
            int max = arr.Max();

            Console.WriteLine($"Min: {min}, Max: {max}");*/

            /*//Sum
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            int sum = arr.Sum();

            Console.WriteLine($"Sum: {sum}");*/

            /*//Average
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            double avg = arr.Average();

            Console.WriteLine($"Average: {avg:f2}");*/

            /*//Any - позволяет узнать есть ли хоть один элемент который нам нужен, true - есть, false - нет, либо коллекция пуста

            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            bool isEmpty = !arr.Any(); // без ! - буедт true, потому что коллекция не пуста но и параметров поиска нет
            Console.WriteLine($"Any: {isEmpty}");

            bool isNegative = arr.Any(n => n < 0);
            Console.WriteLine($"Any negative: {isNegative}"); // true - потому что есть одно ниже нуля*/


        }
    }
}
