using System;

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


            Jariskaci[] otxiJariskaci = new Jariskaci[] 
            {
                new Jariskaci(),
                new Jariskaci(),
                new Jariskaci(),
                new Jariskaci()
            };

            for (int index = 0; index <= 4; index++)
            {
                otxiJariskaci[index].QvisSrola();
            }

            Console.WriteLine(Jariskaci.qvisSrolisRaodenoba);
            Console.ReadLine();
        }

    }
}
