using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Business.Abstract;
using HastaneInfo.Business.Utilities;
using HastaneInfo.Business.ValidationRules.FluentValidation;
using HastaneInfo.DataAccess.Abstract;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetAll()
        {
            return _memberDal.GetAll();
        }

        public List<Member> GetMembersByMemberTcNo(string memberTcNo)
        {
            return _memberDal.GetAll(p => p.TC_NO.ToLower().Contains(memberTcNo.ToLower()));
        }

        public List<Member> Login(string email, string password)
        {
            return _memberDal.GetAll(p => p.EMAIL.ToLower().Contains(email.ToLower()) && p.PASSWORD.ToLower().Contains(password.ToLower()));
        }

        public List<Member> CheckTcNoAndMail(string TcNO, string email)
        {
            return _memberDal.GetAll(p =>
                p.TC_NO.ToLower().Contains(TcNO.ToLower()) && p.EMAIL.ToLower().Contains(email.ToLower()));
        }

        public List<Member> CheckMail(string email)
        {
            return _memberDal.GetAll(p => p.EMAIL.ToLower().Contains(email.ToLower()));
        }

        public void Add(Member member)
        {
            ValidationTool.Validate(new MemberValidator(), member);
            _memberDal.Add(member);
        }

        public void Update(Member member)
        {
            ValidationTool.Validate(new MemberValidator(), member);
            _memberDal.Update(member);
        }

        public void Delete(Member member)
        {
            try
            {
                _memberDal.Delete(member);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi");
            }
        }
    }
}
