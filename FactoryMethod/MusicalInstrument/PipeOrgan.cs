using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MusicalInstrument
{
    class PipeOrgan : IMusicalInstrument
    {
        public string GetNameMusicalInstrument()
        {
            return "I'm a PIPEORGAN";
        }
    }
}
