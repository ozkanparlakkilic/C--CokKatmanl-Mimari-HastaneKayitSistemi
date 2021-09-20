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
    public class AppoinmentManager : IAppointmentService
    {
        private IAppointmentDal _appointment;

        public AppoinmentManager(IAppointmentDal appointment)
        {
            _appointment = appointment;
        }

        public List<Appointment> GetAll()
        {
            return _appointment.GetAll();
        }

        public List<Appointment> DateCheckAppointment(string doctorName, string appointmentDate)
        {
            return _appointment.GetAll(a =>
                a.DOCTOR_NAME.ToLower().Contains(doctorName.ToLower()) && a.APPOINTMENT_DATE.ToLower().Contains(appointmentDate.ToLower()));
        }

        public void Add(Appointment appointment)
        {
            _appointment.Add(appointment);
        }

        public void Update(Appointment appointment)
        {
            _appointment.Update(appointment);
        }

        public void Delete(Appointment appointment)
        {
            try
            {
                _appointment.Delete(appointment);
            }
            catch
            {
                throw new Exception("Silme işlemi gerçekleşemedi");
            }
        }
    }
}
