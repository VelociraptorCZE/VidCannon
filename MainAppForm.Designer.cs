namespace VidCannon
{
    partial class MainAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.openVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveVideoDialog = new System.Windows.Forms.SaveFileDialog();
            this.crfTrackBar = new System.Windows.Forms.TrackBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.crfLabel = new System.Windows.Forms.Label();
            this.fastLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.fpsInput = new System.Windows.Forms.NumericUpDown();
            this.cutLabel = new System.Windows.Forms.Label();
            this.cutStartInput = new System.Windows.Forms.TextBox();
            this.cutStartLabel = new System.Windows.Forms.Label();
            this.cutEndLabel = new System.Windows.Forms.Label();
            this.cutEndInput = new System.Windows.Forms.TextBox();
            this.transposeLabel = new System.Windows.Forms.Label();
            this.transposeInput = new System.Windows.Forms.NumericUpDown();
            this.transposeCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.crfTrackBar)).BeginInit();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transposeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // crfTrackBar
            // 
            this.crfTrackBar.Location = new System.Drawing.Point(15, 528);
            this.crfTrackBar.Name = "crfTrackBar";
            this.crfTrackBar.Size = new System.Drawing.Size(237, 56);
            this.crfTrackBar.TabIndex = 1;
            this.crfTrackBar.Value = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(757, 30);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportMenuItemClick);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportMenuItemClick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 31);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(566, 365);
            this.mediaPlayer.TabIndex = 3;
            // 
            // crfLabel
            // 
            this.crfLabel.AutoSize = true;
            this.crfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crfLabel.Location = new System.Drawing.Point(21, 500);
            this.crfLabel.Name = "crfLabel";
            this.crfLabel.Size = new System.Drawing.Size(73, 25);
            this.crfLabel.TabIndex = 4;
            this.crfLabel.Text = "Quality";
            // 
            // fastLabel
            // 
            this.fastLabel.AutoSize = true;
            this.fastLabel.Location = new System.Drawing.Point(209, 568);
            this.fastLabel.Name = "fastLabel";
            this.fastLabel.Size = new System.Drawing.Size(33, 16);
            this.fastLabel.TabIndex = 5;
            this.fastLabel.Text = "Fast";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(23, 568);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(61, 16);
            this.qualityLabel.TabIndex = 6;
            this.qualityLabel.Text = "Lossless";
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsLabel.Location = new System.Drawing.Point(282, 500);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(51, 25);
            this.fpsLabel.TabIndex = 7;
            this.fpsLabel.Text = "FPS";
            // 
            // fpsInput
            // 
            this.fpsInput.Location = new System.Drawing.Point(287, 528);
            this.fpsInput.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.fpsInput.Name = "fpsInput";
            this.fpsInput.Size = new System.Drawing.Size(120, 22);
            this.fpsInput.TabIndex = 8;
            // 
            // cutLabel
            // 
            this.cutLabel.AutoSize = true;
            this.cutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutLabel.Location = new System.Drawing.Point(444, 500);
            this.cutLabel.Name = "cutLabel";
            this.cutLabel.Size = new System.Drawing.Size(43, 25);
            this.cutLabel.TabIndex = 9;
            this.cutLabel.Text = "Cut";
            // 
            // cutStartInput
            // 
            this.cutStartInput.Location = new System.Drawing.Point(489, 528);
            this.cutStartInput.Name = "cutStartInput";
            this.cutStartInput.Size = new System.Drawing.Size(100, 22);
            this.cutStartInput.TabIndex = 10;
            this.cutStartInput.Text = "00:00:00";
            // 
            // cutStartLabel
            // 
            this.cutStartLabel.AutoSize = true;
            this.cutStartLabel.Location = new System.Drawing.Point(449, 533);
            this.cutStartLabel.Name = "cutStartLabel";
            this.cutStartLabel.Size = new System.Drawing.Size(34, 16);
            this.cutStartLabel.TabIndex = 11;
            this.cutStartLabel.Text = "Start";
            // 
            // cutEndLabel
            // 
            this.cutEndLabel.AutoSize = true;
            this.cutEndLabel.Location = new System.Drawing.Point(449, 561);
            this.cutEndLabel.Name = "cutEndLabel";
            this.cutEndLabel.Size = new System.Drawing.Size(31, 16);
            this.cutEndLabel.TabIndex = 13;
            this.cutEndLabel.Text = "End";
            // 
            // cutEndInput
            // 
            this.cutEndInput.Location = new System.Drawing.Point(489, 556);
            this.cutEndInput.Name = "cutEndInput";
            this.cutEndInput.Size = new System.Drawing.Size(100, 22);
            this.cutEndInput.TabIndex = 12;
            this.cutEndInput.Text = "00:00:00";
            // 
            // transposeLabel
            // 
            this.transposeLabel.AutoSize = true;
            this.transposeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transposeLabel.Location = new System.Drawing.Point(618, 500);
            this.transposeLabel.Name = "transposeLabel";
            this.transposeLabel.Size = new System.Drawing.Size(106, 25);
            this.transposeLabel.TabIndex = 14;
            this.transposeLabel.Text = "Transpose";
            // 
            // transposeInput
            // 
            this.transposeInput.Location = new System.Drawing.Point(623, 555);
            this.transposeInput.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.transposeInput.Name = "transposeInput";
            this.transposeInput.Size = new System.Drawing.Size(101, 22);
            this.transposeInput.TabIndex = 15;
            // 
            // transposeCheckbox
            // 
            this.transposeCheckbox.AutoSize = true;
            this.transposeCheckbox.Location = new System.Drawing.Point(623, 529);
            this.transposeCheckbox.Name = "transposeCheckbox";
            this.transposeCheckbox.Size = new System.Drawing.Size(100, 20);
            this.transposeCheckbox.TabIndex = 16;
            this.transposeCheckbox.Text = "is Enabled?";
            this.transposeCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 611);
            this.Controls.Add(this.transposeCheckbox);
            this.Controls.Add(this.transposeInput);
            this.Controls.Add(this.transposeLabel);
            this.Controls.Add(this.cutEndLabel);
            this.Controls.Add(this.cutEndInput);
            this.Controls.Add(this.cutStartLabel);
            this.Controls.Add(this.cutStartInput);
            this.Controls.Add(this.cutLabel);
            this.Controls.Add(this.fpsInput);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.fastLabel);
            this.Controls.Add(this.crfLabel);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.crfTrackBar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainAppForm";
            this.Text = "VidCannon";
            ((System.ComponentModel.ISupportInitialize)(this.crfTrackBar)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transposeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openVideoDialog;
        private System.Windows.Forms.SaveFileDialog saveVideoDialog;
        private System.Windows.Forms.TrackBar crfTrackBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Label crfLabel;
        private System.Windows.Forms.Label fastLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.NumericUpDown fpsInput;
        private System.Windows.Forms.Label cutLabel;
        private System.Windows.Forms.TextBox cutStartInput;
        private System.Windows.Forms.Label cutStartLabel;
        private System.Windows.Forms.Label cutEndLabel;
        private System.Windows.Forms.TextBox cutEndInput;
        private System.Windows.Forms.Label transposeLabel;
        private System.Windows.Forms.NumericUpDown transposeInput;
        private System.Windows.Forms.CheckBox transposeCheckbox;
    }
}

