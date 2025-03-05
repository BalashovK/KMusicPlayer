using NAudio.Wave;
using NAudio.Wave.SampleProviders;


namespace KMusicPlayer
{
    public partial class Form1 : Form
    {
        string[] args;
        private FileController ctrl;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private VolumeSampleProvider volumeProvider;

        public Form1(string[] a_args)
        {
            InitializeComponent();
            this.args = a_args;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("File Name", -2, HorizontalAlignment.Left);

            if (args.Length > 0)
            {
                ctrl = new FileController(args[0]);
                if (ctrl.files.Count == 0)
                {
                    MessageBox.Show("No music files found in the folder");
                    Application.Exit();
                }

                foreach (string file in ctrl.files)
                {
                    listView1.Items.Add(Path.GetFileName(file));
                }
                listView1.ItemActivate += ListView1_ItemActivate;

                // now find and select the file provided as argument
                string fileName = Path.GetFileName(args[0]);
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Text == fileName)
                    {
                        listView1.Items[i].Selected = true;
                        listView1.Items[i].EnsureVisible();
                        PlayAudioFile(ctrl.files[i]);
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("No file was passed as argument");
                Application.Exit();
            }
        }

        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedFile = ctrl.files[listView1.SelectedItems[0].Index];
                PlayAudioFile(selectedFile);
            }
        }

        private void PlayAudioFile(string filePath)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }

            audioFileReader = new AudioFileReader(filePath);
            volumeProvider = new VolumeSampleProvider(audioFileReader);
            volumeProvider.Volume = volumeTrackBar.Value / 100f; // Set initial volume
            waveOut = new WaveOutEvent();
            waveOut.Init(volumeProvider);
            waveOut.Play();
            waveOut.PlaybackStopped += OnPlaybackStopped;
            b_pause.Text = "Pause";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.PlaybackStopped -= OnPlaybackStopped;
                waveOut.Stop();
                waveOut.Dispose();
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
            }

            base.OnFormClosing(e);
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (volumeProvider != null)
            {
                volumeProvider.Volume = volumeTrackBar.Value / 100f;
            }
        }

        private void b_pause_Click(object sender, EventArgs e)
        {

            if (waveOut != null)
            {
                if (b_pause.Text == "Pause")
                {
                    // pause the playback
                    waveOut.Pause();
                    b_pause.Text = "Resume";
                }
                else
                {
                    // resume the playback
                    waveOut.Play();
                    b_pause.Text = "Pause";
                }
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int currentIndex = listView1.SelectedItems[0].Index;
                int nextIndex = currentIndex + 1;

                if (nextIndex >= ctrl.files.Count)
                {
                    nextIndex = 0;
                }
                listView1.Items[nextIndex].Selected = true;
                listView1.Items[nextIndex].EnsureVisible();
                PlayAudioFile(ctrl.files[nextIndex]);
            }
        }
    }
}
