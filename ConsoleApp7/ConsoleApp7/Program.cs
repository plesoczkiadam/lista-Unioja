using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 3,2,1 };
            int[] b = { 6, 2, 7,8,9 };
            List<int> c = new List<int>();
            
            for (int i = 0; i < a.Length-1; i++) 
            {
               int j = 0;
                while (j < b.Length && b[j] != a[i])
                {
                    j++;
                }
                if(j< b.Length)
                    {
                    c.Add(a[i]);
                    
                    

                }
                
            }
            foreach (var item in c)
            {
                Console.WriteLine(item + " " );
            }
            Console.ReadLine();
        }
    }
}
