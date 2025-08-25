// See https://aka.ms/new-console-template for more information
// 3. Работа с классами, типами
// Параметризируй класс Solution так, чтобы метод GetData принимал любой тип
// и печатал результат метода ToString() переданного типа  


using ConsoleApp3;


class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        
        // Тестирование с разными типами данных
        solution.GetData(42);                    // int
        solution.GetData(3.14);                  // double
        solution.GetData("Hello World");         // string
        solution.GetData(DateTime.Now);          // DateTime
        solution.GetData<int?>(null);            // nullable int
        solution.GetData<string>(null);          // null string
        

    }
}