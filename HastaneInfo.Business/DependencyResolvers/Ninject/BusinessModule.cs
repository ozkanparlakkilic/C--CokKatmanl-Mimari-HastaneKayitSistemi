using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Business.Abstract;
using HastaneInfo.Business.Concrete;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace HastaneInfo.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelService>().To<PersonelManager>().InSingletonScope();
            Bind<IPersonelDal>().To<EfPersonelDal>().InSingletonScope();

            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();

            Bind<IPolyclinicDal>().To<EfPolyclinicDal>().InSingletonScope();
            Bind<IPolyclinicService>().To<PolyclinicManager>().InSingletonScope();

            Bind<IAppointmentDal>().To<EfAppointmentDal>().InSingletonScope();
            Bind<IAppointmentService>().To<AppoinmentManager>().InSingletonScope();
        }
    }
}
