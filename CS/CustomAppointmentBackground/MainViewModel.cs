#region #viewmodel
using System;
using System.Collections.ObjectModel;

namespace CustomAppointmentBackground
{
    public class MainViewModel {
        public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }
      
        protected MainViewModel() {
            CreateDoctors();
            CreateMedicalAppointments();
        }
       
        private void CreateDoctors() {
            Doctors = new ObservableCollection<Doctor>();
            Doctors.Add(Doctor.Create(Id:1,Name:"Stomatologist"));
            Doctors.Add(Doctor.Create(Id:2, Name:"Ophthalmologist"));
            Doctors.Add(Doctor.Create(Id:3, Name:"Surgeon"));
        }
        private void CreateMedicalAppointments() {
            Appointments = new ObservableCollection<MedicalAppointment>();
            Appointments.Add(MedicalAppointment.Create(
                StartTime : DateTime.Now.Date.AddHours(10), EndTime : DateTime.Now.Date.AddHours(11),
                DoctorId : 1, Notes : "", Location : "101", PatientName : "Dave Murrel", 
                InsuranceNumber : "111111111", FirstVisit : true, AllDay:false));
            Appointments.Add(MedicalAppointment.Create(
                StartTime: DateTime.Now.Date.AddHours(11), EndTime: DateTime.Now.Date.AddHours(12),
                DoctorId: 2, Notes: "", Location: "", PatientName: "Day-off",
                InsuranceNumber: "111111111", FirstVisit: true, AllDay: true));
        }
    }
}
#endregion #viewmodel
