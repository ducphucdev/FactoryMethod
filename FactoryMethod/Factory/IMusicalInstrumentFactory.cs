using FactoryMethod.MusicalInstrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    interface IMusicalInstrumentFactory
    {
        IMusicalInstrument CreateMusicalInstrument();
    }
}
