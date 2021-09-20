using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, HastaneDbContext>, IPersonelDal
    {

    }
}
