using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StopWatch0
{
    public partial class FormStopWatch : Form
    {
        bool paused = true;
        DateTime start;


        public FormStopWatch()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (paused)
                StartTimer();
            else
                StopTimer();
        }

        private void StartTimer()
        {
            paused = false;
            buttonStart.Text = "Stop";
            textNotes.Enabled = false;
            start = DateTime.Now;
            labelTime.Text = "00:00:00";
            timer.Enabled = true;
        }

        private void StopTimer()
        {
            paused = true;
            timer.Enabled = false;
            AddNoteToGrid();
            SaveNoteToFile();
            labelTime.Text = "00:00:00";
            textNotes.Enabled = true;
            textNotes.Text = "";
            buttonStart.Text = "Start";
            textNotes.Focus();
        }

        private void AddNoteToGrid()
        {
            int row = grid.Rows.Count;
            grid.Rows.Add();
            grid["coStart", row].Value = start.ToString("yyyy-MM-dd HH:mm");
            grid["coTimer", row].Value = labelTime.Text;
            grid["coNotes", row].Value = textNotes.Text;
        }

        private void SaveNoteToFile()
        {
            File.AppendAllText("notes.txt", start.ToString("yyyy-MM-dd HH:mm") + "\t" +
                          labelTime.Text + "\t" +
                          textNotes.Text + Environment.NewLine,
                          Encoding.UTF8);
            
        }

        private void FormStopWatch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!paused)
                StopTimer();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (paused) return;
            TimeSpan time = (DateTime.Now - start).Duration();
            labelTime.Text = time.ToString(@"hh\:mm\:ss");
        }
    }
}
