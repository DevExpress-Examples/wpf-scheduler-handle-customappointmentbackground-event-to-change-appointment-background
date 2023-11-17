using DevExpress.Xpf.Core;
using DevExpress.Xpf.Scheduling;
using DevExpress.XtraScheduler;
using System.Windows.Media;

namespace CustomAppointmentBackground {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }
        private void SchedulerControl_CustomAppointmentBackground(object sender, CustomAppointmentBackgroundEventArgs e) {
            //Change the recurrent appointment background to blanched almond color,
            //and background of other appointments - to rosy brown:
            e.Background = (e.AppointmentItem.Type == AppointmentType.Occurrence) ?
            new SolidColorBrush(Colors.BlanchedAlmond) : new SolidColorBrush(Colors.RosyBrown);

            //Change the all-day appointment background:
            e.Background = (e.AppointmentItem.AllDay == true) ? new SolidColorBrush(Colors.Tomato) : e.Background;
        }
    }
}
