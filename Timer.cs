using System;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Timer : Form
    {
        private System.Windows.Forms.Timer t;
        
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, System.EventArgs e)
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value >= 100) t.Stop();
        }
    }
}
