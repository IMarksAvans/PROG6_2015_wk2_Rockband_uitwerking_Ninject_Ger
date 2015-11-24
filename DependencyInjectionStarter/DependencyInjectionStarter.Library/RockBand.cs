using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private List<IInstrument> instruments = new List<IInstrument>();

        public void DoSoundCheck()
        {
            foreach(IInstrument instrument in instruments)
            {
                if(instrument != null)
                {
                    Console.WriteLine(instrument.Play());
                }
            }
        }

        public void AddInstrument(IInstrument instrument)
        {
            instruments.Add(instrument);
        }
    }
}
