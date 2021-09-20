using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Abstract;

namespace HastaneInfo.Entities.Concrete
{
    public class Member : IEntity
    {
        public int ID { get; set; }
        public string TC_NO { get; set; }
        public string MEMBER_NAME { get; set; }
        public string MEMBER_SURNAME { get; set; }
        public string USERNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }

    }
}
