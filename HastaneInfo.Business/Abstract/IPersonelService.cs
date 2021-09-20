using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        List<Personel> GetPersonelsByPersonelTcNo(string personelTcNo);
        List<Personel> Login(string email, string password, string position);
        List<Personel> CheckTcNoAndMail(string TcNO, string email);
        List<Personel> CheckMail(string email);
        void Add(Personel personel);
        void Update(Personel personel);
        void Delete(Personel personel);
    }
}
