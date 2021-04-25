using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            //x=19 ,y=2.2
            // int name =value;
            //string name = "mohamed";
            int x = 19;
            int y = 5;
            //int z = x + y;

            //Console.WriteLine(z+name);

            //if (x == 18)
            //{
            //    Console.WriteLine("x=19");
            //}
            //else
            //{
            //    Console.WriteLine("no value");
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[] numbers = { 1,2,3,4};

            string[] names = { "mohamed", "ali","ahmed"};
            Console.WriteLine(names.Length);
        
            for (int i = 0; i <names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Hello World!");



        }
    }
}
