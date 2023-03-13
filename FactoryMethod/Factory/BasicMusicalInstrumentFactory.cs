using FactoryMethod.MusicalInstrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    class BasicMusicalInstrumentFactory : IMusicalInstrumentFactory
    {
        int index = 0;
        public IMusicalInstrument CreateMusicalInstrument()
        {
            if (index == 0)
            {
                index++;
                return new Piano();
            }
            if (index == 1)
            {
                index++;
                return new PipeOrgan();
            }
            if (index == 2)
            {
                index++;
                return new Guitar();
            }
            if (index == 3)
            {
                index = 0;
                return new Violin();
            }
            return null;
        }
    }
}
