using System;
using System.Collections;
using System.Linq;
using System.Xml.Linq;

namespace Program
{
    internal class something
    {
        //public static void Main()
        //{
        //    Console.WriteLine("1st");
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
        //    }

        //    Console.WriteLine("2nd");
        //    List<int> a = new List<int>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        a.Add(int.Parse(Console.ReadLine()));
        //        a[i] = a[i] * a[i];
        //    }
        //    foreach (int i in a)
        //        Console.Write("{0} ", i);

        //    Console.WriteLine("3rd");
        //    string s = Console.ReadLine();
        //    List<char> b = new List<char>();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] != ' ')
        //            b.Add(s[i]);
        //    }
        //    b.Sort();
        //    foreach (char i in b)
        //        Console.Write(i+" ");

        //    Console.WriteLine("4th");
        //    HashSet<int> c = new HashSet<int>();
        //    for (int i = 0; i < 10; i++)
        //        c.Add(int.Parse(Console.ReadLine()));
        //    foreach (int i in c)
        //        Console.Write("{0} ", i);

        //}
        
        //abstract class hello
        //{
        //    void display()
        //    {
        //        Console.WriteLine("vamsi");
        //    }
        //    public abstract void display1();
        //}

        //class hello1 : hello  // should not write public because if we write public the hello1 class will be more
        //                       //accessible than hello class
        //{
        //    public override void display1()
        //    {
        //        Console.WriteLine("Should use ");
        //    }
        //}


        public static void Main()
        {
            //int a = 5;
            //a = addition(a);
            //static int addition(int b)
            //{ return b + b; }

            //Console.WriteLine(a);
            LinqReadXml();

        }

        public static void LinqReadXml()
        {
            string Xml = @"<Departments>
                        <Department>Account</Department>
                        <Department>Sales</Department>
                        <Department>Pre-Sales</Department>
                        <Department>Marketing</Department>
                        <something1>
                        <something>cool</something>
                        <something>vamsi</something>
                        </something1>
                        </Departments>
                        ";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(Xml);


            //adds new node in the end
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //adds new node at the start
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Data Science"));

            foreach(XElement item in xdoc.Descendants())
            {
                Console.WriteLine("Departments - "+ item.Value);
            }

            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            //Console.WriteLine("After removing the sales de"
        }

    }
}
