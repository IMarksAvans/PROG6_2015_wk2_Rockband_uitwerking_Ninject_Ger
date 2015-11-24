using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    public class ModuleMetallica: Ninject.Modules.NinjectModule
    {
        /*
         * Metallica deze band heeft de volgende instrumenten: (2x Gitaar, Basgitaar, Drums en Vocals)
         * 
         */

        public override void Load()
        {
            Bind<IInstrument>().To<Guitar>();
            Bind<IInstrument>().To<Guitar>();
            Bind<IInstrument>().To<BassGuitar>();
            Bind<IInstrument>().To<Drums>();
            Bind<IInstrument>().To<Vocal>();
        }
    }
}
