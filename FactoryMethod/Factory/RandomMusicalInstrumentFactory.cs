using FactoryMethod.MusicalInstrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    class RandomMusicalInstrumentFactory : IMusicalInstrumentFactory
    {
        public IMusicalInstrument CreateMusicalInstrument()
        {
            Random random = new Random();
            int type = random.Next(0, 4);
            if (type == 0)
            {
                return new Piano();
            }
            else if (type == 1)
            {
                return new PipeOrgan();
            }

            else if (type == 2)
            {
                return new Guitar();
            }
            else
            {
                return new Violin();
            }
        }
    }
}
