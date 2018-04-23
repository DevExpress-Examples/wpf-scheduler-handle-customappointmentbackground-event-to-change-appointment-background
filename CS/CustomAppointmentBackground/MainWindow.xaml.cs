using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Scheduling;
using DevExpress.XtraScheduler;

namespace CustomAppointmentBackground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region #CustomAppointmentBackground
        private void SchedulerControl_CustomAppointmentBackground(object sender, CustomAppointmentBackgroundEventArgs e)
        {
            //Change the recurrent appointments' background to blanched almond color,
            //and other appointments - to rosy brown 
            e.Background = (e.AppointmentItem.Type == AppointmentType.Occurrence) ?
            new SolidColorBrush(Colors.BlanchedAlmond) : new SolidColorBrush(Colors.RosyBrown);

            //Change all-day appointments' background:
            e.Background = (e.AppointmentItem.AllDay == true) ? new SolidColorBrush(Colors.Tomato) : e.Background;
        }
        #endregion #CustomAppointmentBackground
    }
}
