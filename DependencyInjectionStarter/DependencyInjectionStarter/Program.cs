using DependencyInjectionStarter.Library;
using Ninject;
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

            Ninject.IKernel kernel;

            kernel = new StandardKernel(new ModuleMetallica());

            var metallica = kernel.Get<RockBand>();

            kernel = new StandardKernel(new ModuleColdplay());

            var coldplay = kernel.Get<RockBand>();

       

          
            Console.WriteLine("Metallica");
            metallica.DoSoundCheck();

            Console.WriteLine("---");


            Console.WriteLine("Coldplay");
            coldplay.DoSoundCheck();

            Console.ReadLine();


        }
    }
}
