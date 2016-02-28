using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndreyBiryulin.ViewModels
{
    public class DI { public string Name => GetType().Name; }
    public class DI_A : DI { }
    public class DI_B : DI { }
    public class DI_C : DI { }
    public class DI_D : DI { }
    public class DIModelFactory
    {
        public static DIModelFactory Instance {  get { return new DIModelFactory(); } }
        DIModelFactory() { }
    }
    public class DIModelCtor
    {
        public DIModelCtor(DI_D di_d)
        {
            this.DI_D = di_d;
        }
        public DI_D DI_D { get; set; }

    }
}
