namespace TypeVibe2026Form
{
    partial class MainForm
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
            BTNmusic = new Button();
            BTNsave = new Button();
            BTNopenfile = new Button();
            RTBeditor = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(BTNmusic);
            panel1.Controls.Add(BTNsave);
            panel1.Controls.Add(BTNopenfile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 51);
            panel1.TabIndex = 0;
            // 
            // BTNmusic
            // 
            BTNmusic.BackColor = Color.Indigo;
            BTNmusic.FlatStyle = FlatStyle.Popup;
            BTNmusic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BTNmusic.ForeColor = SystemColors.ButtonHighlight;
            BTNmusic.Location = new Point(174, 12);
            BTNmusic.Name = "BTNmusic";
            BTNmusic.Size = new Size(75, 23);
            BTNmusic.TabIndex = 3;
            BTNmusic.Text = "_PlayMusic";
            BTNmusic.UseVisualStyleBackColor = false;
            BTNmusic.Click += BTNmusic_Click;
            // 
            // BTNsave
            // 
            BTNsave.BackColor = Color.Indigo;
            BTNsave.FlatStyle = FlatStyle.Popup;
            BTNsave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BTNsave.ForeColor = SystemColors.ButtonHighlight;
            BTNsave.Location = new Point(93, 12);
            BTNsave.Name = "BTNsave";
            BTNsave.Size = new Size(75, 23);
            BTNsave.TabIndex = 2;
            BTNsave.Text = "_SaveFile";
            BTNsave.UseVisualStyleBackColor = false;
            BTNsave.Click += BTNsave_Click;
            // 
            // BTNopenfile
            // 
            BTNopenfile.BackColor = Color.Indigo;
            BTNopenfile.FlatStyle = FlatStyle.Popup;
            BTNopenfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            BTNopenfile.ForeColor = SystemColors.ButtonHighlight;
            BTNopenfile.Location = new Point(12, 12);
            BTNopenfile.Name = "BTNopenfile";
            BTNopenfile.Size = new Size(75, 23);
            BTNopenfile.TabIndex = 1;
            BTNopenfile.Text = "_OpenFile";
            BTNopenfile.UseVisualStyleBackColor = false;
            BTNopenfile.Click += BTNopenfile_Click;
            // 
            // RTBeditor
            // 
            RTBeditor.BackColor = Color.FromArgb(64, 0, 64);
            RTBeditor.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            RTBeditor.ForeColor = SystemColors.ButtonHighlight;
            RTBeditor.Location = new Point(110, 227);
            RTBeditor.Name = "RTBeditor";
            RTBeditor.Size = new Size(611, 159);
            RTBeditor.TabIndex = 1;
            RTBeditor.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TypeVibeBG;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(835, 450);
            Controls.Add(RTBeditor);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BTNsave;
        private Button BTNopenfile;
        private Button BTNmusic;
        private RichTextBox RTBeditor;
    }
}
