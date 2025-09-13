namespace WFPLAY
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMain = new Panel();
            panelContent = new Panel();
            progBar = new ProgressBar();
            btnImport = new Button();
            picBoxFolder = new PictureBox();
            lblChoice = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lblWfplay = new Label();
            picBoxLogo = new PictureBox();
            toolTipDesc = new ToolTip(components);
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFolder).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = SystemColors.ControlLightLight;
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Controls.Add(progBar);
            panelContent.Controls.Add(btnImport);
            panelContent.Controls.Add(picBoxFolder);
            panelContent.Controls.Add(lblChoice);
            panelContent.Location = new Point(163, 83);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(468, 317);
            panelContent.TabIndex = 2;
            // 
            // progBar
            // 
            progBar.Location = new Point(179, 255);
            progBar.MarqueeAnimationSpeed = 520;
            progBar.Name = "progBar";
            progBar.Size = new Size(118, 23);
            progBar.Style = ProgressBarStyle.Marquee;
            progBar.TabIndex = 3;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(191, 202);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(92, 23);
            btnImport.TabIndex = 2;
            btnImport.Text = "IMPORTAR";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // picBoxFolder
            // 
            picBoxFolder.Image = (Image)resources.GetObject("picBoxFolder.Image");
            picBoxFolder.Location = new Point(191, 90);
            picBoxFolder.Name = "picBoxFolder";
            picBoxFolder.Size = new Size(92, 79);
            picBoxFolder.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxFolder.TabIndex = 1;
            picBoxFolder.TabStop = false;
            // 
            // lblChoice
            // 
            lblChoice.AutoSize = true;
            lblChoice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChoice.Location = new Point(92, 46);
            lblChoice.Name = "lblChoice";
            lblChoice.Size = new Size(284, 17);
            lblChoice.TabIndex = 0;
            lblChoice.Text = "Escolha um arquivo para converter em áudio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 425);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 25);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(335, 5);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "2025 - All rights reserved";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(lblWfplay);
            panel1.Controls.Add(picBoxLogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 0;
            // 
            // lblWfplay
            // 
            lblWfplay.AutoSize = true;
            lblWfplay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWfplay.ForeColor = SystemColors.ControlLightLight;
            lblWfplay.Location = new Point(52, 15);
            lblWfplay.Name = "lblWfplay";
            lblWfplay.Size = new Size(51, 15);
            lblWfplay.TabIndex = 1;
            lblWfplay.Text = "WF Play";
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new Point(3, 3);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(35, 36);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 0;
            picBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panelMain);
            MinimumSize = new Size(816, 490);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WFPLAY";
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxFolder).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel1;
        private PictureBox picBoxLogo;
        private Label lblWfplay;
        private Panel panel2;
        private Label label1;
        private Panel panelContent;
        private Label lblChoice;
        private Button btnImport;
        private PictureBox picBoxFolder;
        private ProgressBar progBar;
        private ToolTip toolTipDesc;
    }
}
