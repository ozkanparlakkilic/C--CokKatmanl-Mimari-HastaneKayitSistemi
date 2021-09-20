using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Abstract
{
    public interface IMemberService
    {
        List<Member> GetAll();
        List<Member> GetMembersByMemberTcNo(string memberTcNo);
        List<Member> Login(string email, string password);
        List<Member> CheckTcNoAndMail(string TcNO, string email);
        List<Member> CheckMail(string email);
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
