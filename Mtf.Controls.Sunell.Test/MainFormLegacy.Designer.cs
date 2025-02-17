using Mtf.Controls.Sunell.IPR66;

namespace Mtf.Controls.Sunell.Test
{
    partial class MainFormLegacy
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormLegacy));
            sunellVideoWindow = new SunellVideoWindowLegacy();
            btnConnect = new Button();
            btnDisconnect = new Button();
            ((System.ComponentModel.ISupportInitialize)sunellVideoWindow).BeginInit();
            SuspendLayout();
            // 
            // sunellVideoWindow
            // 
            sunellVideoWindow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sunellVideoWindow.BackgroundImage = (Image)resources.GetObject("sunellVideoWindow.BackgroundImage");
            sunellVideoWindow.BackgroundImageLayout = ImageLayout.Stretch;
            sunellVideoWindow.Location = new Point(3, 2);
            sunellVideoWindow.Name = "sunellVideoWindow";
            sunellVideoWindow.OverlayFont = new Font("Arial", 32F, FontStyle.Bold);
            sunellVideoWindow.OverlayLocation = new Point(10, 10);
            sunellVideoWindow.OverlayText = "";
            sunellVideoWindow.Size = new Size(796, 410);
            sunellVideoWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            sunellVideoWindow.TabIndex = 0;
            sunellVideoWindow.TabStop = false;
            // 
            // btnConnect
            // 
            btnConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConnect.Location = new Point(7, 418);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDisconnect.Location = new Point(88, 418);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += BtnDisconnect_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(sunellVideoWindow);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Shown += MainForm_Shown;
            ((System.ComponentModel.ISupportInitialize)sunellVideoWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SunellVideoWindowLegacy sunellVideoWindow;
        private Button btnConnect;
        private Button btnDisconnect;
    }
}
