using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//Answer 01
            Console.WriteLine("Input the value of n");
            int n=Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("The Even numbers are up to " + n + ": ");
            for (int i=1;i<=n;i++)
            {
               if(i%2==0)
                { Console.WriteLine( i);}

            }*/
            /*
            //Answer 02
             for(int i=0;i<=1;i++)
             {
                 for (int x = 0; x <= 2; x++)
                 {
                     Console.Write("X0");
                 }
                 Console.WriteLine(" ");
                 for (int x = 0; x <= 2; x++)
                 {
                     Console.Write("0X");

                 }
                 Console.WriteLine(" ");
             }*/
            /*
             //Answer 03
             for(int n=1;n<=5;n++)
              {
                  int o = 0;
                  for (int k = 1; k <= 5; k++)
                  {

                      Console.Write(n + o);
                      o++;
                  }
                  Console.WriteLine("");
                  o++;
              }*/
            /*

             //Answer 04
              int sum=0;
              int sumx = 0;
              for (int i = 1; i <=100; i++)
              {

                  if (i % 2 == 0)
                  { 
                      sum = sum + i;   
                  }

                   if (i % 2 != 0)
                   {
                      sumx = sumx + i;
                   }

              }
              Console.WriteLine("The sum of Even number:");
              Console.WriteLine(sum);
              Console.WriteLine("The sum of odd number:");
            
            Console.WriteLine(sumx);
            */
            /*
            //Answer 05
             for (int i = 1; i <= 5; i++)
             {
                 Console.WriteLine(i);
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(" ");
                 }

             }
              //Answer 06
               int i, f = 1, n=5;    
               for (i = 1; i <= n; i++)
               {
                   f = f* i;

               }
               Console.Write(" Factorial of " + n + " is:  " + f);
            */
            /*  
           //Answer 07
           int i;
           for (i = 1; i <= 5; i++)
           {
               for (int j = 1; j <= i; j++)
               {
                   Console.Write("* ");
               }
               Console.Write(" \n");
           }
           for (i = 4; i >= 1; i--)
           {
               for (int j = 1; j <= i; j++)
               {
                   Console.Write("* ");
               }
               Console.Write(" \n");
           }
           */

        }
    }
}
