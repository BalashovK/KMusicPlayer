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
            panel1 = new Panel();
            b_pause = new Button();
            volumeTrackBar = new TrackBar();
            listView1 = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(b_pause);
            panel1.Controls.Add(volumeTrackBar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 759);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 111);
            panel1.TabIndex = 0;
            // 
            // b_pause
            // 
            b_pause.Location = new Point(34, 24);
            b_pause.Name = "b_pause";
            b_pause.Size = new Size(204, 56);
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
            listView1.Size = new Size(644, 759);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
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
    }
}
