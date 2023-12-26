using System;
using Xamarin.Forms;

namespace FrameOtpCircleAnim.Views
{
    public partial class AboutPage : ContentPage
    {

        private double _ProgressValue;

        public double ProgressValue
        {
            get { return _ProgressValue; }
            set
            {
                _ProgressValue = value;
                OnPropertyChanged(nameof(ProgressValue));
            }
        }

        private double _Minimun;

        public double Minimun
        {
            get { return _Minimun; }
            set
            {
                _Minimun = value;
                OnPropertyChanged(nameof(Minimun));
            }
        }
        private double _Maximun;

        public double Maximun
        {
            get { return _Maximun; }
            set
            {
                _Maximun = value;
                OnPropertyChanged($"{nameof(Maximun)}");
            }
        }

        private System.Timers.Timer time = new System.Timers.Timer();
        private bool timerRunning;

        public AboutPage()
        {

            InitializeComponent();
            BindingContext = this;
            Minimun = 0;
            Maximun = 30;
            ProgressValue = 30;
            timerRunning = true;
            time.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (ProgressValue > Minimun)
                {
                    ProgressValue--;
                    return true;
                }
                else if (ProgressValue == Minimun)
                {
                    time.Stop();
                    timerRunning = false;
                    return false;
                }
                else
                {
                    return true;
                }
            });
        }
    }
}