Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Scheduling
Imports DevExpress.XtraScheduler
Imports System.Windows.Media

Namespace CustomAppointmentBackground

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub SchedulerControl_CustomAppointmentBackground(ByVal sender As Object, ByVal e As CustomAppointmentBackgroundEventArgs)
            'Change the recurrent appointment background to blanched almond color,
            'and background of other appointments - to rosy brown:
            e.Background = If(e.AppointmentItem.Type = AppointmentType.Occurrence, New SolidColorBrush(Colors.BlanchedAlmond), New SolidColorBrush(Colors.RosyBrown))
            'Change the all-day appointment background:
            e.Background = If(e.AppointmentItem.AllDay = True, New SolidColorBrush(Colors.Tomato), e.Background)
        End Sub
    End Class
End Namespace
