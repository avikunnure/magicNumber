using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool CheckNumber(int num) {
            string input=num.ToString();
            char ch = input[0];
            int count = 0;
            for (int i = 0; i < input.Length; i++) {
                if (ch == input[i]) { 
                count++;
                }
            }
            return count==input.Length; 
            
        }

        static void Main(string[] args)
        {
            int result = 6174;
            Console.WriteLine("Hello World!");
            for (int i = 1000; i < 9999; i++)
            {
                int count = 0;
                
                if (CheckNumber(i) != true) {
                    int res = i;
                    while (result != res  && res>999)
                    {
                        
                        count++;
                        string asd = ""; (res.ToString()).OrderBy(x=>x).Reverse().ToList().ForEach(x => asd += x); ;
                        int AsdNum = int.Parse(asd);
                        string dsc = ""; (res.ToString()).OrderByDescending(x => x).Reverse().ToList().ForEach(x => dsc += x); ;
                        int DscNum = int.Parse(dsc);
                        res = AsdNum > DscNum? AsdNum - DscNum: DscNum- AsdNum;
                        if(res == result)
                        {
                            break;
                        }
                    }
                    if (res == result)
                    {
                        Console.WriteLine($"{i} count {count}");
                    }
                }
            }
        }
    }
}