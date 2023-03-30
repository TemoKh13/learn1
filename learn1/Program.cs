using System;
using System.Data.Common;
using System.IO;

namespace learn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(TemukaMoqmedeba.damtvleli);
            //TemukaMoqmedeba.StaticAchkebisMoxsna();
            //Console.WriteLine(TemukaMoqmedeba.damtvleli);

            //TemukaMoqmedeba class1 = new TemukaMoqmedeba();
            //class1.AchkebisMoxsna();
            //Console.WriteLine(TemukaMoqmedeba.damtvleli);

            //int damtvleliLocal = TemukaMoqmedeba.damtvleli;
            //Console.ReadLine();


            /*            Jariskaci[] otxiJariskaci = new Jariskaci[] 
                        {
                            new Jariskaci(),
                            new Jariskaci(),
                            new Jariskaci(),
                            new Jariskaci()
                        };

                        for (int index = 0; index <= 4; index++)
                        {
                            otxiJariskaci[index].QvisSrola();
                        }*/

            /*            Console.WriteLine(Jariskaci.qvisSrolisRaodenoba);*/

            /*            var str = "Me var {0} mqvia {1} gvari";
                        string.Format(str, "Aleko", "Gvinefadze kai bichia");

                        Console.WriteLine(str);*/


/*            string stringValue = "Baro bichebi";
            int indexOf = stringValue.IndexOf("bichebi");
            string saxeli = "Bacho";
            string gvari = " Gigiadze";
            string concat = string.Concat(saxeli, gvari);
            int index = 5;
            string str1 = "temuka";
            string str2 = "temuka";

            bool udris1 = str1 == str2;
            bool udirs2 = str1.Equals(str2);

            string enumator = @"red,green,black,grey";
            string[] splitedEnumator = enumator.Split(',');
            foreach (var item in splitedEnumator)
            {
                Console.Write($"{item},");    
            }

            if (5 == 7)
                Console.WriteLine("ar sheva");
            else 
                Console.WriteLine("sheva");

            int pasuxiShedarebis = 5 == 7 
                ? 1 
                : 0;

            double myDouble = 9.78;
            int myInt = (int)myDouble;
            double roundedDouble = Math.Round(myDouble);

            string doubleStr = "9.78";
            string strD = "9,4b";
            var sum = doubleStr + 3;*/
/*            try
            {
                int x = 0;
                var cvaladi = 2 / x;
            }
            catch (Exception exception)
            {
                DivideByZeroException divideByZeroException = (DivideByZeroException)exception;
                DivideByZeroException divideByZeroException2 = exception as DivideByZeroException;
                Console.WriteLine("zogadi shecdoma");
                throw;
            }
            finally
            {
                Console.WriteLine("Uechveli aq var me dzma ver gameqcevi");
            }*/



            //bool isParsed = double.TryParse(strD, out var dob);
/*            decimal cvladi = 7.0m / 9.0m;
            decimal damrgvaleba = Math.Round(cvladi, 2);*/



            string nikusha = "NIKU";
            nikusha.GetHashCode();


            Console.ReadLine();
        }

    }


}
