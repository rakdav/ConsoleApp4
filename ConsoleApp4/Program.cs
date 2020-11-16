using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1="hello";
            string s2 = null;
            string s3 = new string('a', 6);
            string s4 = new string(new char[] {'w','o','r','l','d' });
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            char c1 = s1[3];
            Console.WriteLine(c1);
            //конкатенация
            string s5 = s1 + " " + s4;
            Console.WriteLine(s5);
            string s6 = String.Concat(s1+" ",s4);
            Console.WriteLine(s6);
            string[] values = new string[] { s1, s3, s4, s5 };
            string s7 = String.Join(" ",values);
            Console.WriteLine(s7);
            //сравнение строк
            int result = String.Compare(s5,s6);
            if(result<0)
            {
                Console.WriteLine("s1<s2");
            }
            else if(result>0)
            {
                Console.WriteLine("s1>s2");
            }
            else
            {
                Console.WriteLine("s1=s2");
            }
            //поиск в строке
            char c = 'o';
            int index = s5.IndexOf(c);
            Console.WriteLine(index);
            Console.WriteLine(s5.IndexOf("llo"));
            Console.WriteLine(s5.LastIndexOf('o'));
            Console.WriteLine(s5.StartsWith("he"));
            Console.WriteLine(s5.EndsWith("ld"));
            //разделение строк
            string text = "А Роза упала на лапу Азора";
            Console.WriteLine(text);
            string[] worlds = text.Split(new char[] {' '});
            foreach(string i in worlds)
            {
                Console.WriteLine(i);
            }
            //Образка строк
            string txt = " hello world ";
            Console.WriteLine(txt.Trim());
            Console.WriteLine(txt.Trim(new char[] {'l','d' }));
            //вставка
            string t1 = "Хороший день";
            string t2 = "замечательный ";
            Console.WriteLine(t1.Insert(8,t2));
            //Удаление строк
            //int ind = t1.Length - 1;
            //t1 = t1.Remove(ind);
            //Console.WriteLine(t1.Remove(0,3));
            //Замена строк
            string t3 = "плохой";
            t1 = t1.Replace("Хороший",t3);
            Console.WriteLine(t1);
            //смена регистра
            Console.WriteLine(t1.ToLower());
            Console.WriteLine(t1.ToUpper());
            t1 = t1.ToUpper();
            Console.WriteLine(t1);
            StringBuilder sb1 = new StringBuilder("Hello ");
            StringBuilder sb2 = new StringBuilder("world");
            sb1.Append(sb2);
            Console.WriteLine(sb1);
            Console.ReadKey();
        }
    }
}
