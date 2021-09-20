using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Abstract;

namespace HastaneInfo.Entities.Concrete
{
    public class Personel : IEntity
    {
        public int ID { get; set; }
        public string TC_NO { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public string YEAR_OF_BIRTH { get; set; }
        public string NATIONALITY { get; set; }
        public string GENDER { get; set; }
        public string POSITION { get; set; } = "AUTHORIZED";



    }
}
