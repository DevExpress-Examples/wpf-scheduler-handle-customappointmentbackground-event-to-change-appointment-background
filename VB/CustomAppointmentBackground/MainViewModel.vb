Imports System.Collections.ObjectModel

Namespace CustomAppointmentBackground

    Public Class MainViewModel

        Public Overridable Property Doctors As ObservableCollection(Of Doctor)

        Public Overridable Property Appointments As ObservableCollection(Of MedicalAppointment)

        Protected Sub New()
            CreateDoctors()
            CreateMedicalAppointments()
        End Sub

        Private Sub CreateDoctors()
            Doctors = New ObservableCollection(Of Doctor) From {Doctor.Create(Id:=1, Name:="Stomatologist"), Doctor.Create(Id:=2, Name:="Ophthalmologist"), Doctor.Create(Id:=3, Name:="Surgeon")}
        End Sub

        Private Sub CreateMedicalAppointments()
            Appointments = New ObservableCollection(Of MedicalAppointment) From {MedicalAppointment.Create(StartTime:=Date.Now.Date.AddHours(10), EndTime:=Date.Now.Date.AddHours(11), DoctorId:=1, Notes:="", Location:="101", PatientName:="Dave Murrel", InsuranceNumber:="111111111", FirstVisit:=True, AllDay:=False), MedicalAppointment.Create(StartTime:=Date.Now.Date.AddHours(11), EndTime:=Date.Now.Date.AddHours(12), DoctorId:=2, Notes:="", Location:="", PatientName:="Day-off", InsuranceNumber:="111111111", FirstVisit:=True, AllDay:=True)}
        End Sub
    End Class
End Namespace
