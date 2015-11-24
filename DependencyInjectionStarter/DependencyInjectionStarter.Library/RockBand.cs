using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        public List<IInstrument> Instruments { get; set; }


        public RockBand(List<IInstrument> instruments)
        {
            this.Instruments = instruments;
        }

        public void DoSoundCheck()
        {
            foreach(IInstrument instrument in Instruments)
            {
                if(instrument != null)
                {
                    Console.WriteLine(instrument.Play());
                }
            }
        }
    }
}
