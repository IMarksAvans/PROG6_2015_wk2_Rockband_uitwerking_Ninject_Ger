using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    class Program
    {
        static void Main(string[] args)
        {

            Guitar guitar1 = new Guitar();
            Guitar guitar2 = new Guitar();
            BassGuitar bassGuitar = new BassGuitar();
            Drums drums = new Drums();
            Vocal vocal = new Vocal();
            Keyboard keyboard = new Keyboard();

            RockBand metallica = new RockBand();

            metallica.AddInstrument(guitar1);
            metallica.AddInstrument(guitar2);
            metallica.AddInstrument(bassGuitar);
            metallica.AddInstrument(drums);
            metallica.AddInstrument(vocal);

            Console.WriteLine("Metallica");
            metallica.DoSoundCheck();

            Console.WriteLine("---");

            RockBand coldplay = new RockBand();

            coldplay.AddInstrument(guitar1);
            coldplay.AddInstrument(bassGuitar);
            coldplay.AddInstrument(drums);
            coldplay.AddInstrument(vocal);
            coldplay.AddInstrument(keyboard);

   
            Console.WriteLine("Coldplay");
            coldplay.DoSoundCheck();

            Console.ReadLine();

            /*
             
    Metallica deze band heeft de volgende instrumenten: (2x Gitaar, Basgitaar, Drums en Vocals)
    Coldplay deze band heeft de volgende instrumenten: (Gitaar, Basgitaar, Drums, Vocals en Keyboard)
*/
        }
    }
}
