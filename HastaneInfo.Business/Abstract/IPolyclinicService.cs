using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Abstract
{
    public interface IPolyclinicService
    {
        List<Polyclinic> GetAll();
        List<Polyclinic> GetDoctor(string policlinicName);
        void Add(Polyclinic policlinic);
        void Update(Polyclinic policlinic);
        void Delete(Polyclinic policlinic);
    }
}
