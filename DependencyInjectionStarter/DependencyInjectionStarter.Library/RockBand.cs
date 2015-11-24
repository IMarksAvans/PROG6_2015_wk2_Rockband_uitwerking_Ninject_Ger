using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter.Library
{
    public class RockBand
    {
        private Guitar guitar = new Guitar();
        private BassGuitar bassGuitar = new BassGuitar();
        private Drums drums = new Drums();
        private Vocal vocal = new Vocal();

        public void DoSoundCheck()
        {
            Console.WriteLine(guitar.PlayRiff());
            Console.WriteLine(bassGuitar.PlayBassLine());
            Console.WriteLine(drums.Drum());
            Console.WriteLine(vocal.Sing());
        }
    }
}
