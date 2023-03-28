using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        private Looper looper = null;
        private Timer timer = null;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.looper = new Looper(this.GetRunningState, this.LoopIterationAction, this.Form1_LoopStoppedEvent);
            Task.Run(this.looper.Loop);

            //this.LoopIterationEvent += Form1_LoopIterationEvent;
            //this.LoopStoppedEvent += Form1_LoopStoppedEvent;

            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private int timercount = 0;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timercount++;
            this.lblTimer.Text = timercount.ToString();
        }

        private async void btnWithAwait_Click(object sender, EventArgs e)
        {
            this.lblClicked.Text = "";
            //await this.Sleep();
            await Task.Run(this.Sleep);
            this.lblClicked.Text = "Click over with await";
        }

        private void btnNoAwait_Click(object sender, EventArgs e)
        {
            this.lblClicked.Text = "";
            //this.Sleep().Wait();
            Task.Run(this.Sleep);
            this.lblClicked.Text = "Click over without await";
        }

        private async Task Sleep()
        {
            this.Invoke(delegate { this.lblSleepOver.Text = "sleeping"; });
            Thread.Sleep(3000);
            this.Invoke(() => this.lblSleepOver.Text = "sleep over");
        }

        private void Form1_LoopStoppedEvent(object? sender, EventArgs e)
        {
            this.Invoke(() => this.lblLoopDisplay.Text = $"Stopped {DateTime.Now.ToString()}");
        }

        private void Form1_LoopIterationEvent(object? sender, EventArgs e)
        {
            this.LoopIterationAction();
        }

        private void LoopIterationAction()
        {
            this.Invoke(() => this.lblLoopDisplay.Text = $"Updated {DateTime.Now.ToString()}");
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>
            {
                this.Invoke(new Action(() => this.lblTest.Text = "testing" ));
                
                Thread.Sleep(3000);
             });

            this.lblTest.Text = "tested";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }

        private bool runLoop = true;
        private void btnToggleLoop_Click(object sender, EventArgs e)
        {
            this.runLoop = !this.runLoop;

            if (this.runLoop)
                Task.Run(this.looper.Loop);
        }

        private bool GetRunningState()
        {
            return this.runLoop;
        }

        private class Looper
        {
            public delegate bool GetRunningState();
            public delegate void LoopIterationDelegate();

            private LoopIterationDelegate LoopIterationAction;
            private GetRunningState GetRunningStateAction;

            //private event EventHandler? LoopIterationEvent;
            private event EventHandler? LoopStoppedEvent;

            public Looper(GetRunningState getrunningstateaction, LoopIterationDelegate iterationaction, Action<object?, EventArgs> stoppedaction)
            {
                this.GetRunningStateAction = getrunningstateaction;
                this.LoopIterationAction = iterationaction;

                if (stoppedaction != null) 
                    this.LoopStoppedEvent += new EventHandler(stoppedaction);
            }

            public void Loop()
            {
                while (this.GetRunningStateAction?.Invoke() ?? false)
                {
                    Thread.Sleep(1000);
                    //this.LoopIterationEvent?.Invoke(this, new EventArgs());                
                    this.LoopIterationAction?.Invoke();
                }

                this.LoopStoppedEvent?.Invoke(this, new EventArgs());

                return;
            }
        }
    }
}