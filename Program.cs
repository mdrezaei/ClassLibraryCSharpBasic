using MyNameSpace;
using System;
using System.Globalization;


namespace ConsoleApp10_NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //PersianCalendar persian = new PersianCalendar();
            //string PersianDate = persian.GetYear(DateTime.Now).ToString();
            //Console.WriteLine(PersianDate);
            //Console.WriteLine(persian.GetYear(DateTime.Now).ToString());

            //ChineseLunisolarCalendar C = new ChineseLunisolarCalendar();
            //string c = C.GetYear(DateTime.Now).ToString();
            //Console.WriteLine(c);

            //GregorianCalendar Miladi = new GregorianCalendar();

            //string MiladiCalendar = Miladi.GetYear(DateTime.Now).ToString() + "/" + Miladi.GetMonth(DateTime.Now).ToString() + "/" + Miladi.GetDayOfMonth(DateTime.Now).ToString();
            //string MCal = Miladi.GetYear(DateTime.Now).ToString() + "/";
            //Console.WriteLine(MiladiCalendar);
            //Console.WriteLine(MCal);

            MyProp MP = new MyProp();
            MP.MyFirstProp = "a";
            Console.WriteLine(MP.MyFirstProp);
            



        }
    }
}
