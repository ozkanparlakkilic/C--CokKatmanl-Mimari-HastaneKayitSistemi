using HastaneInfo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HastaneInfo.Business.Abstract;
using HastaneInfo.Business.Utilities;
using HastaneInfo.Business.ValidationRules.FluentValidation;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.DataAccess.Concrete.EntityFramework;

namespace HastaneInfo.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelDal _personelDal;
        private readonly HastaneDbContext _hastaneDbContext;

        public PersonelManager(IPersonelDal personelDal, HastaneDbContext hastaneDbContext)
        {
            _personelDal = personelDal;
            _hastaneDbContext = hastaneDbContext;
        }

        public List<Personel> GetAll()
        {
            //Business kode
            return _personelDal.GetAll();
        }

        public List<Personel> GetPersonelsByPersonelTcNo(string personelTcNo)
        {
            return _personelDal.GetAll(p => p.TC_NO.ToLower().Contains(personelTcNo.ToLower()));
        }

        public List<Personel> Login(string email, string password, string position)
        {
            return _personelDal.GetAll(p => p.EMAIL.ToLower().Contains(email.ToLower()) && p.PASSWORD.ToLower().Contains(password.ToLower()) && p.POSITION.ToLower().Contains(position.ToLower()));
        }

        public List<Personel> CheckTcNoAndMail(string TcNO, string email)
        {
            return _personelDal.GetAll(p =>
                p.TC_NO.ToLower().Contains(TcNO.ToLower()) && p.EMAIL.ToLower().Contains(email.ToLower()));
        }

        public List<Personel> CheckMail(string email)
        {
            return _personelDal.GetAll(p => p.EMAIL.ToLower().Contains(email.ToLower()));
        }

        public void Add(Personel personel)
        {
            ValidationTool.Validate(new PersonelValidator(_hastaneDbContext), personel);
            _personelDal.Add(personel);
        }

        public void Update(Personel personel)
        {
            ValidationTool.Validate(new PersonelValidator(_hastaneDbContext), personel);
            _personelDal.Update(personel);
        }

        public void Delete(Personel personel)
        {
            try
            {
                _personelDal.Delete(personel);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi");
            }

        }
    }
}
