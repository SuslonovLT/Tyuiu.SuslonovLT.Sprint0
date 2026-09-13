using Tyuiu.SuslonovLT.Sprint0.Task7.V0.Lib;
class Program()
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Суслонов Л. Т. | ПКТб-26-1";
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("* Спринт #0                                                          *");
        Console.WriteLine("* Тема: Создание итогового решения по скрипту                        *");
        Console.WriteLine("* Задание #7                                                         *");
        Console.WriteLine("* Вариант #0                                                         *");
        Console.WriteLine("* Выполнил: Суслонов Леонид Тимофеевич | ПКТб-26-1                   *");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                           *");
        Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения    *");
        Console.WriteLine("* двух одинаковых массивов по длине                                  *");
        Console.WriteLine("*                                                                    *");
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
        Console.WriteLine("**********************************************************************");

        int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Значения элементов массива N1");
        for (int i = 0; i < arrayNums1.Length; i++)
        {
            Console.Write(arrayNums1[i] + ", ");
        }

        Console.WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Значения элементов массива N2");
        for (int i = 0; i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("**********************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                         *");
        Console.WriteLine("**********************************************************************");
        if (arrayNums1.Length == arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

            Console.WriteLine("Сумма элементов массива равна: ");
            for (int i = 0;i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + ", ");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
        }
        Console.ReadKey();

    }
}