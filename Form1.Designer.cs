namespace KMusicPlayer
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            progress = new HScrollBar();
            l_duration = new Label();
            label1 = new Label();
            b_pause = new Button();
            volumeTrackBar = new TrackBar();
            listView1 = new ListView();
            durationTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(progress);
            panel1.Controls.Add(l_duration);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(b_pause);
            panel1.Controls.Add(volumeTrackBar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 724);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 146);
            panel1.TabIndex = 0;
            // 
            // progress
            // 
            progress.Location = new Point(183, 98);
            progress.Name = "progress";
            progress.Size = new Size(431, 39);
            progress.TabIndex = 4;
            progress.Scroll += progress_Scroll;
            // 
            // l_duration
            // 
            l_duration.AutoSize = true;
            l_duration.Location = new Point(34, 106);
            l_duration.Name = "l_duration";
            l_duration.Size = new Size(36, 25);
            l_duration.TabIndex = 3;
            l_duration.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Volume:";
            // 
            // b_pause
            // 
            b_pause.Location = new Point(34, 24);
            b_pause.Name = "b_pause";
            b_pause.Size = new Size(116, 56);
            b_pause.TabIndex = 1;
            b_pause.Text = "Pause";
            b_pause.UseVisualStyleBackColor = true;
            b_pause.Click += b_pause_Click;
            // 
            // volumeTrackBar
            // 
            volumeTrackBar.Location = new Point(296, 19);
            volumeTrackBar.Maximum = 100;
            volumeTrackBar.Name = "volumeTrackBar";
            volumeTrackBar.Size = new Size(336, 69);
            volumeTrackBar.TabIndex = 0;
            volumeTrackBar.Value = 33;
            volumeTrackBar.Scroll += volumeTrackBar_Scroll;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.LabelWrap = false;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(644, 724);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // durationTimer
            // 
            durationTimer.Interval = 1000;
            durationTimer.Tick += durationTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 870);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "K Music Player";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView listView1;
        private TrackBar volumeTrackBar;
        private Button b_pause;
        private Label l_duration;
        private Label label1;
        private System.Windows.Forms.Timer durationTimer;
        private HScrollBar progress;
    }
}
