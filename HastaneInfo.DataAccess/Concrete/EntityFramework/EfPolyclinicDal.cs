using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.DataAccess.Concrete.EntityFramework
{
    public class EfPolyclinicDal : EfEntityRepositoryBase<Polyclinic, HastaneDbContext>, IPolyclinicDal
    {
    }
}
