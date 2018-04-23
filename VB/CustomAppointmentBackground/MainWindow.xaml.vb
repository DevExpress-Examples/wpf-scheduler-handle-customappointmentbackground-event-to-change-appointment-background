Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Scheduling
Imports DevExpress.XtraScheduler

Namespace CustomAppointmentBackground
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#CustomAppointmentBackground"
        Private Sub SchedulerControl_CustomAppointmentBackground(ByVal sender As Object, ByVal e As CustomAppointmentBackgroundEventArgs)
            'Change the recurrent appointments' background to blanched almond color,
            'and other appointments - to rosy brown 
            e.Background = If(e.AppointmentItem.Type = AppointmentType.Occurrence, New SolidColorBrush(Colors.BlanchedAlmond), New SolidColorBrush(Colors.RosyBrown))

            'Change all-day appointments' background:
            e.Background = If(e.AppointmentItem.AllDay = True, New SolidColorBrush(Colors.Tomato), e.Background)
        End Sub
        #End Region ' #CustomAppointmentBackground
    End Class
End Namespace
