using System;

namespace liczenie_calek
{
    public class IntDif
    {
        int n = 1;
        static double calka = 0;
        double sum_ = 0, roznica;
        public void  intRec(double x0, double xk, int blad)
        {
            
            
            double trapezy_sum = 0, trapezy_sumpodowjna = 0;
             
            double h = (xk - x0) / n;

            for (int i = 0; i < n; i++)

            {

                trapezy_sum = ((function1(x0 + i * h) + function1(x0 + (i + 0.5) * h)) / 2 )* h;
                trapezy_sum = trapezy_sum + (function1(x0 + (i+0.5) * h) + function1(x0 + (i + 1) * h)) / 2;
                trapezy_sumpodowjna = ((function1(x0 + i * h) + function1(x0 + (i + 1) * h)) / 2)*h;

                sum_ = trapezy_sum*h;
                roznica = Math.Abs(trapezy_sumpodowjna-sum_);
                if (roznica < blad) {
                    calka = calka + trapezy_sumpodowjna;
                     x0 = x0 + (i) * h;
                        }
                else
                {
                    n = n * 2;
                    intRec(x0, xk, blad);

                }
           

            }
            
            Console.WriteLine("metoda trapezów" + trapezy_sum);
            

        }
        public static double function1(double x)
        {
            return x;
        }
       



        /*  Console.WriteLine("pochodna lewostronna");
          for (double i = -10; i < 0; i = i + 0.5)
          {
              double delta = i + x0;
              pochodna = (function1(x0 + delta) - function1(x0)) / delta;
              Console.WriteLine(delta + "   |   " + pochodna);

          }*/


    }
    class Program
    {
        static void Main(string[] args)

        {
            double res_;
            /* IntDiff id1=new IntDiff ()
             {
              public Double function1
             }*/
            IntDif id1 = new IntDif();
            id1.intRec(0, 10, 10);
           

            Console.ReadKey();
        }
    }
}
