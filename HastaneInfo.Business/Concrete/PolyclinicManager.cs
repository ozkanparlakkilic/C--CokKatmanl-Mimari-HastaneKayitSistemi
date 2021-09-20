using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Business.Abstract;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Concrete
{
    public class PolyclinicManager : IPolyclinicService
    {
        private IPolyclinicDal _polyclinicDal;

        public PolyclinicManager(IPolyclinicDal polyclinicDal)
        {
            _polyclinicDal = polyclinicDal;
        }

        public List<Polyclinic> GetAll()
        {
            return _polyclinicDal.GetAll();
        }

        public List<Polyclinic> GetDoctor(string polyclinicName)
        {
            return _polyclinicDal.GetAll(p => p.POLYCLINICS_NAME.ToLower().Contains(polyclinicName.ToLower()));
        }

        public void Add(Polyclinic polyclinic)
        {
            _polyclinicDal.Add(polyclinic);
        }

        public void Update(Polyclinic polyclinic)
        {
            _polyclinicDal.Update(polyclinic);
        }

        public void Delete(Polyclinic polyclinic)
        {
            try
            {
                _polyclinicDal.Delete(polyclinic);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi");
            }
        }
    }
}
