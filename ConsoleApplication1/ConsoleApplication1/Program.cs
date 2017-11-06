using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*5.	Написать приложение, которое выведет на экран
             *  Ваше имя и фамилию. (Жду что у вас будет приложение,
             *   которое я сам запущу и где у меня попросят ввести ФИО,
             *    после я нажму Enter и мне выдастся сообщение
             *     – «Приветствую тебя - ФИО»)*/

            Console.WriteLine("Введите ФИО ");
            string name;
            name = Console.ReadLine();
            if (name == "")
                Console.WriteLine("Попробуй еще раз..");
            else
                Console.WriteLine("Приветствую тебя - " + name + "!");

            /*6.	Написать приложение, которое ожидает 
             * ввода нескольких чисел и выводит на экран
             *  их сумму. (Так же как и в предыдущем примере,
             *   только с цифрами. Мы проходили как можно из 
             *   строки перевести в число.)*/

            Console.WriteLine("Введите число");
            string num1 = Console.ReadLine();
            Console.Write("+ ");
            string num2 = Console.ReadLine();
            Console.Write("= ");
            int nn1 = Int32.Parse(num1);
            int nn2 = Int32.Parse(num2);
            int sum = nn1 + nn2;
            Console.WriteLine(sum);
        }
    }
}
