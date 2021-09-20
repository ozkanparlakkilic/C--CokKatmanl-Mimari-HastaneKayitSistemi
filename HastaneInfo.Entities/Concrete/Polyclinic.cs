using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Abstract;

namespace HastaneInfo.Entities.Concrete
{
    public class Polyclinic : IEntity
    {
        public int ID { get; set; }
        public string POLYCLINICS_NAME { get; set; }
        public string DOCTOR_NAME { get; set; }

    }
}
