using DependencyInjectionStarter.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionStarter
{
    public class ModuleColdplay: Ninject.Modules.NinjectModule
    {
        /*
         * Coldplay deze band heeft de volgende instrumenten: (Gitaar, Basgitaar, Drums, Vocals en Keyboard)
         */
        

        public override void Load()
        {
            Bind<IInstrument>().To<Guitar>();
            Bind<IInstrument>().To<BassGuitar>();
            Bind<IInstrument>().To<Drums>();
            Bind<IInstrument>().To<Vocal>();
            Bind<IInstrument>().To<Keyboard>();
        }
    }
}
