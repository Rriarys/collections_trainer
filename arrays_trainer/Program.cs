namespace arrays_trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Reverse --------------------------------------
            int[] base_arr = { 1, 2, 3, 4, 5 };
            var arr = base_arr.Reverse().ToArray(); // так получим новый перевернутый массив
            Array.Reverse(base_arr); // так получим тот же, но перевернутый; и так же убедимся что оригинальный массив не затрронут
            
            Console.WriteLine("New reversed array: " + string.Join(", ", arr));
            Console.WriteLine("Base reversed array: " + string.Join(", ", base_arr)); */

            /*//Min, Max ------------------------------------
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            int min = arr.Min();
            int max = arr.Max();

            Console.WriteLine($"Min: {min}, Max: {max}");*/

            /*//Sum ----------------------------------------------
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            int sum = arr.Sum();

            Console.WriteLine($"Sum: {sum}");*/

            /*//Average -------------------------------------------------
            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            double avg = arr.Average();

            Console.WriteLine($"Average: {avg:f2}");*/

            /*//Any - позволяет узнать есть ли хоть один элемент который нам нужен, true - есть, false - нет, либо коллекция пуста ---------------------------------------------------

            int[] arr = { 1, 8, 2, 9, -3, 17, 5, 5, 4, 4, 0 };

            bool isEmpty = !arr.Any(); // без ! - буедт true, потому что коллекция не пуста но и параметров поиска нет
            Console.WriteLine($"Any: {isEmpty}");

            bool isNegative = arr.Any(x => x < 0);
            Console.WriteLine($"Any negative: {isNegative}"); // true - потому что есть одно ниже нуля*/

            /* //Where - как Any, только круче; получим новую коллекцию которая будет вмещать подходящие данные; можно создавать цепочку вычислений -------------------------------------------------------------
             int[] arr = { 1, -8, 2, 9, -3, 17, 5, 5, 4, 4, 0, -6 };

             var negatives = arr.Where(x => x < 0).ToArray();
             int sum = negatives.Sum();

             Console.WriteLine("Where: " + string.Join(", ", negatives) + $" | Sum: {sum} \n");

             //Все выполняется на основе изначального массива, поскольку методы возвращают новые коллекции
             //Хочу узнать сколько четных, без учета дубликатов
             Console.WriteLine(arr.Where(x => x > 0).Distinct().Count()); // в данной коллекции чисел больше 0 -> 8, но -2, за дубликат => 6

             //Отфильтровать по возрастанию только положительные и взять первые 3 элемента без учета дубликатов
             Console.WriteLine("\n" + string.Join(", ", arr.Where(x => x > 0).Distinct().OrderBy(x => x).Take(3)));

             //Отфильтровать, преобразовать и просуммировать
             Console.WriteLine("\n" + arr.Where(x => x < 0).Select(n => n * -7).Sum());

             //Найти индексы всех вхождений элемента ------------------------------
             string[] fruits = { "apple", "banana", "ccherry", "apple", "pineaple" };

             Console.WriteLine($"\nApple have index: {string
                 .Join(", ", fruits
                 .Select((value, index) => new {value, index }) // создаем анонимный обьект, Select спроецирует на него элемент коллекции и можно будет работать дальше со значениями или индексами
                 .Where(x => x.value == "apple") // отбираем те обьекты, у которых поле значения нам подходит
                 .Select(x => x.index) // у полученной коллекции обьектов берем индексы
                 .ToArray())}"); // собираем в массив и джойним*/

            /*//Concat - обьеденияет массивы, на тупую приклеивает второй в конец первого; --------------------------------
            //Union -//-, но удаляет дубликаты

            string[] fruits1 = { "apple", "banana", "mango" };
            string[] fruits2 = { "mango", "cherry", "pineapple", "mango", "apple" };

            Console.WriteLine($"Concat list: \n{string.Join("\n", fruits1.Concat(fruits2).ToArray())}");
            Console.WriteLine($"\nUnion list: \n{string.Join("\n", fruits1.Union(fruits2).ToArray())}"); // список меньше*/

            /* //OrderByDescending ----------------------------------------------
             int[] arr = { 1, -8, 2, 9, -3, 17, 5, 5, 4, 4, 0, -6 };

             Console.WriteLine(string.Join(", ", arr.OrderDescending().ToArray()));*/

            /*//Distinct - дропает дубликаты --------------------------------------
            int[] arr = { 1, -8, 2, 9, -3, 17, 5, 5, 4, 4, 0, -6 };

            Console.WriteLine(string.Join(", ", arr.Distinct().ToArray()));*/

            /*//Select - был выше, выполняет преобразования над каждым элементом --------------------------------
            string[] fruits = { "mango", "cherry", "pineapple", "mango", "apple" };

            Console.WriteLine(string.Join("\n", fruits.Select(x => x.ToUpper()).ToArray()));*/

            /*//Take - был выше, берет первые сколько-то элементов ------------------------------------------
            //TakeLast - берет последние

            // ^ - отсчет индексов с конца, но отсчет нес 0 а с 1 -> ^1 - это первый с конца, ^0 - ошибка

            // ..^2 - взять все элементы, кроме последних двух -> этот и следующий удобно юзать если не знаешь 
            // ^3.. - взять последние 3 элемента               -> размер массива

            int[] arr = { 1, -8, 2, 9, -3, 17, 5, 5, 4, 4, 0, -6 };

            Console.WriteLine("Last 5 pos: " + string.Join(", ", arr.TakeLast(5)));
            Console.WriteLine($"\nThird pos from end: {arr[^3]}");
            Console.WriteLine($"\nAll except 4 last pos: {string.Join(", ", arr[..^5])}");
            Console.WriteLine($"\nLast 7 pos: {string.Join(", ", arr[^7..])}");

            //Contains - как Any, но профитней если ищем конкретный элемент, для тсрок учитывает регистр  ------------------------------------
            string[] fruits = { "mango", "cherry", "pineapple", "mango", "apple" };

            Console.WriteLine(fruits.Contains("cherry")); // true - потому что есть*/

           /* //GroupBy - потужна хуйня; организовывает данные в группы по заданым параметрам ---------------------------
            string[] fruits = { "apple", "banana", "cherry", "avocado", "blueberry", "apricot" };

            var groupedFruits = fruits.GroupBy(fruit => fruit[0]); // fruit[0] - это ключ группировки, первая буква слова, если будет fruit[2], то группировка будет по тртьей букве слова, если букв в слове не будет хватать -> исключение 

            foreach (var group in groupedFruits) // шаримся по группам ("группа В группированных фруктах")
            {
                Console.WriteLine($"Fruits wich starts with '{group.Key}' :  {string.Join(", ", group)}");
            }

            Console.WriteLine("\n----------------------------\n");

            // пример с обьектами
            var people = new[]
            {
              new { Name = "Alice", Age = 25 },
              new { Name = "Bob", Age = 30 },
              new { Name = "Charlie", Age = 25 },
              new { Name = "Dave", Age = 30 },
              new { Name = "Eve", Age = 35 }
            };

            *//* var groupedByAge = people.GroupBy(person => person.Age);

             foreach (var group in groupedByAge)
             {
                 Console.WriteLine($"People of age {group.Key} : {string.Join(", ", group.Select(p => p.Name))}");
             }*/

            /*// ключ и селектор (чтобы не тащить весь обьект а сразу взять имена)

            var groupedByAge = people.GroupBy(
                person => person.Age, // ключ
                person => person.Name // берем имена
                );

            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"People of age {group.Key} : {string.Join(", ", group)}");
            }*//*

            // совместно методами агрегации, чтобы не тащить все обьекты раз за разом в случае если проводим какие-то операции над данными

            var ageStatistics = people.GroupBy(person => person.Age) // группировка по возрасту
                .Select(group => new // анонимный обьект который содержит наши расчетные данные в виде свойств обьекта, к которым удобно обращаться
                {
                    Age = group.Key,
                    Count = group.Count(),
                    AvgNameLength = group.Average(p => p.Name.Length) // среднее по длинне имен
                }
                );

            foreach (var stat in ageStatistics)
            {
                Console.WriteLine($"Age: {stat.Age}, Count: {stat.Count}, Average name length: {stat.AvgNameLength}.");
            }
            //GroupBy - сам не сортирует элементы, он группирует по очереди что ему попадется, например первый элемент мог быть групповой категории 35, потом 25, потом 30, он бы так и сортировал, если нужно еще и отсортировать -> .OrderBy(group => group.Key)*/
        }
    }
}
