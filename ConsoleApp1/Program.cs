using ConsoleApp1;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] mas = { 1, 2, 3,4, 5, 6,7,8,9 ,10 };
            for(int i = 0; i< mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }
            int sum = 0;
            sum = mas.Sum();
            Console.WriteLine();
            Console.WriteLine("Суммма чисел:" + sum);
            //Console.ReadLine();

            CheckIsEvenNumber checkIsEvenNumber = new CheckIsEvenNumber();
            checkIsEvenNumber.IsEvenNumber();
        }
    }
}