
using FactoryMethod.Factory;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] arg)
        {
            IMusicalInstrumentFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);
            if(type == 0)
            {
                factory = new BasicMusicalInstrumentFactory();
                Console.WriteLine("This is BasicFactory");
            }    
            else
            {
                factory = new RandomMusicalInstrumentFactory();
                Console.WriteLine("This is RandomFactory");
            }

            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
            Console.WriteLine(factory.CreateMusicalInstrument().GetNameMusicalInstrument());
        }
    }
}