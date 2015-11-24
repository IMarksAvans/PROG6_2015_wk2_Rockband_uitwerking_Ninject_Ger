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
            var rockBand = new RockBand();
            rockBand.DoSoundCheck();
            Console.ReadLine();
        }
    }
}
