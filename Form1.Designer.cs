namespace ThreadTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.chkLoopState = new System.Windows.Forms.CheckBox();
            this.lblLoopDisplay = new System.Windows.Forms.Label();
            this.btnToggleLoop = new System.Windows.Forms.Button();
            this.btnNoAwait = new System.Windows.Forms.Button();
            this.btnWithAwait = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblSleepOver = new System.Windows.Forms.Label();
            this.lblClicked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(492, 124);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(138, 34);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test THreading";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(492, 269);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(59, 25);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Time?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(736, 269);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            // 
            // chkLoopState
            // 
            this.chkLoopState.AutoSize = true;
            this.chkLoopState.Location = new System.Drawing.Point(171, 198);
            this.chkLoopState.Name = "chkLoopState";
            this.chkLoopState.Size = new System.Drawing.Size(121, 29);
            this.chkLoopState.TabIndex = 4;
            this.chkLoopState.Text = "checkBox1";
            this.chkLoopState.UseVisualStyleBackColor = true;
            // 
            // lblLoopDisplay
            // 
            this.lblLoopDisplay.AutoSize = true;
            this.lblLoopDisplay.Location = new System.Drawing.Point(187, 296);
            this.lblLoopDisplay.Name = "lblLoopDisplay";
            this.lblLoopDisplay.Size = new System.Drawing.Size(59, 25);
            this.lblLoopDisplay.TabIndex = 5;
            this.lblLoopDisplay.Text = "label1";
            // 
            // btnToggleLoop
            // 
            this.btnToggleLoop.Location = new System.Drawing.Point(171, 111);
            this.btnToggleLoop.Name = "btnToggleLoop";
            this.btnToggleLoop.Size = new System.Drawing.Size(138, 34);
            this.btnToggleLoop.TabIndex = 6;
            this.btnToggleLoop.Text = "Stop Loop";
            this.btnToggleLoop.UseVisualStyleBackColor = true;
            this.btnToggleLoop.Click += new System.EventHandler(this.btnToggleLoop_Click);
            // 
            // btnNoAwait
            // 
            this.btnNoAwait.Location = new System.Drawing.Point(386, 504);
            this.btnNoAwait.Name = "btnNoAwait";
            this.btnNoAwait.Size = new System.Drawing.Size(112, 34);
            this.btnNoAwait.TabIndex = 7;
            this.btnNoAwait.Text = "No Await";
            this.btnNoAwait.UseVisualStyleBackColor = true;
            this.btnNoAwait.Click += new System.EventHandler(this.btnNoAwait_Click);
            // 
            // btnWithAwait
            // 
            this.btnWithAwait.Location = new System.Drawing.Point(229, 504);
            this.btnWithAwait.Name = "btnWithAwait";
            this.btnWithAwait.Size = new System.Drawing.Size(112, 34);
            this.btnWithAwait.TabIndex = 8;
            this.btnWithAwait.Text = "With Await";
            this.btnWithAwait.UseVisualStyleBackColor = true;
            this.btnWithAwait.Click += new System.EventHandler(this.btnWithAwait_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(233, 568);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(59, 25);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "label1";
            // 
            // lblSleepOver
            // 
            this.lblSleepOver.AutoSize = true;
            this.lblSleepOver.Location = new System.Drawing.Point(250, 632);
            this.lblSleepOver.Name = "lblSleepOver";
            this.lblSleepOver.Size = new System.Drawing.Size(59, 25);
            this.lblSleepOver.TabIndex = 10;
            this.lblSleepOver.Text = "label1";
            // 
            // lblClicked
            // 
            this.lblClicked.AutoSize = true;
            this.lblClicked.Location = new System.Drawing.Point(233, 681);
            this.lblClicked.Name = "lblClicked";
            this.lblClicked.Size = new System.Drawing.Size(59, 25);
            this.lblClicked.TabIndex = 11;
            this.lblClicked.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 784);
            this.Controls.Add(this.lblClicked);
            this.Controls.Add(this.lblSleepOver);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnWithAwait);
            this.Controls.Add(this.btnNoAwait);
            this.Controls.Add(this.btnToggleLoop);
            this.Controls.Add(this.lblLoopDisplay);
            this.Controls.Add(this.chkLoopState);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTest;
        private Label lblTest;
        private Button button1;
        private Label lblTime;
        private CheckBox chkLoopState;
        private Label lblLoopDisplay;
        private Button btnToggleLoop;
        private Button btnNoAwait;
        private Button btnWithAwait;
        private Label lblTimer;
        private Label lblSleepOver;
        private Label lblClicked;
    }
}