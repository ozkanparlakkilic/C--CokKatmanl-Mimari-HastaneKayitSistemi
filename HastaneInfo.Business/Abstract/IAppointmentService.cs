using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneInfo.Entities.Concrete;

namespace HastaneInfo.Business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        List<Appointment> DateCheckAppointment(string doctorName, string appointmentDate);
        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(Appointment appointment);
    }
}
