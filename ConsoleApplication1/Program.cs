using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static int a = 1;
        static int b = 5;
        static int c = 7;
        static int d = 4;
        static int e = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Wynik = " + min2(a, b));
            Console.WriteLine("Wynik = " + min3wer1a(a, b, c));
            Console.WriteLine("Wynik = " + min3wer1b(a, b, c));
            Console.WriteLine("Wynik = " + min3wer1c(a, b, c));
            Console.WriteLine("Wynik = " + min3wer2a(a, b, c));
            Console.WriteLine("Wynik = " + min3wer2b(a, b, c));
            Console.WriteLine("Wynik = " + min3wer2c(a, b, c));

            Console.WriteLine("Wynik = " + min5(a, b, c, d, e));


            int[] tablica = { 2, 5, 1, 7, 3, 9 };
            Console.WriteLine("Wynik z tablicy = " + minTab1( tablica ));
            Console.WriteLine("Wynik z tablicy = " + minTab2(tablica));
            Console.WriteLine("Wynik z params = " + minTab3(1, 2, 3, 4, 5));
            Console.WriteLine("Wynik z params double = " + indexMinTab(0.4, 1, 2.3, 4, 5.2));
        }


        //Zadanie 1
        static int min2(int a, int b)        
        {
            if (a < b) return a;
            else return b;
        }

        //Zadanie 2
        static int min3wer1a(int a, int b, int c)
        {
            if (a < b) {
                if (a < c) return a;
                else return c;

            }
            else {
                if (c < b) return c;
                else return b;
                    }
        }

        static int min3wer1b(int a, int b, int c)
        {
            return (a < b) ? ((a < c) ? a : c) : ((c < b) ? c : b);
        }

        static int min3wer1c(int a, int b, int c)
        {
            return min2(min2(a, b), min2(a, c));
        }

        //Zadanie 3
        static int min3wer2a(int a, int b, int c)
        {
            int m = a;
            if (b < m) m = b;
            if (c < m) m = c;
            return m;
        }

        static int min3wer2b(int a, int b, int c)
        {
            int m = a;
            m = (b < m) ? b : m;
            m = (c < m) ? c : m;
            return m;
            
        }
        static int min3wer2c(int a, int b, int c)
        {
            return min2(a, min2(b, c));
        }

        //Zadanie 4
        static int min5(int a, int b, int c, int d, int e)
        {
            int m = a;
            if (b < m) m = b;
            if (c < m) m = c;
            if (d < m) m = d;
            if (e < m) m = e;
            return m;
        }

        //Zadanie 5
        static int minTab1( int[] tab)
        {
            int m = tab[0];
            foreach(int x in tab)
            {
                if (x < m) m = x;
            }
            return m;
        }

        static int minTab2( int[] tab)
        {
            int m = tab[0];
            for (int i=0; i<tab.Length; i++)
            {
                if (tab[i] < m) m = tab[i];
            }
            return m;
        }  


        //Zadanie 6
        static int minTab3(params int[] tab)
        {
            int m = tab[0];
            for (int i=0; i < tab.Length; i++)
            {
                if (tab[i] < m) m = tab[i];
            }
            return m;

        }

        //Zadanie 7
        static int indexMinTab(params double[] tab)
        {
            int index = 0;
            double m = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < m)
                    m = tab[i];
                index = i;
            }
            return index;
        }
        


    }
}
