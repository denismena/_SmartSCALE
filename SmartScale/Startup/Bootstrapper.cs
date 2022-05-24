using Autofac;
using SmartScale;
using SmartSCALE.ViewModel.Nomenclatoare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSCALE.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NomenclatoareViewModel>().AsSelf();
            return builder.Build();
        }
    }
}
