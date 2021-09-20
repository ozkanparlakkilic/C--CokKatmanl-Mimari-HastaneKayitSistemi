using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.DataAccess.Abstract
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
    }
}
