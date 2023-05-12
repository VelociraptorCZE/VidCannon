/**
 * VidCannon
 * Copyright (c) Simon Raichl 2023
 */

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VidCannon
{
    public partial class MainAppForm : Form
    {
        private const string DEFAULT_CUT_TIMESTAMP = "00:00:00";

        public MainAppForm()
        {
            InitializeComponent();
        }

        private void ImportMenuItemClick(object sender, EventArgs e)
        {
            DialogResult openVideoResult = openVideoDialog.ShowDialog();

            if (openVideoResult != DialogResult.OK)
            {
                return;
            }

            saveVideoDialog.FileName = openVideoDialog.FileName.Split('\\').Last();
            mediaPlayer.URL = openVideoDialog.FileName;
        }

        private void ExportMenuItemClick(object sender, EventArgs e)
        {
            DialogResult saveVideoResult = saveVideoDialog.ShowDialog();

            if (saveVideoResult == DialogResult.OK)
            {
                Process videoRenderer = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg.exe",
                        Arguments = GetRenderArguments(),
                    }
                };

                videoRenderer.Start();
            }
        }

        private string GetRenderArguments()
        {
            string transpose = transposeCheckbox.Checked
                ? $"-vf transpose={transposeInput.Value}"
                : "";

            string cut = cutStartInput.Text != DEFAULT_CUT_TIMESTAMP || cutEndInput.Text != DEFAULT_CUT_TIMESTAMP
                ? $"-ss {cutStartInput.Text} -to {cutEndInput.Text}"
                : "";

            string fps = fpsInput.Value > 0
                ? $"-filter:v fps={fpsInput.Value}"
                : "";

            string args = $" -i {openVideoDialog.FileName}" +
            $" {fps} {transpose} {cut}" +
            $" -map 0:v -map 0:a -c:v libx264" +
            $" -crf {crfTrackBar.Value * 5}" +
            $" -c:a aac {saveVideoDialog.FileName}";

            return args;
        }
    }
}
