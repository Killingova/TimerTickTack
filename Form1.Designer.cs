namespace TimerTick
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
            CmdStartX = new Button();
            CmdStopX = new Button();
            LblAnzeige = new Label();
            TimAnzeige = new System.Windows.Forms.Timer(components);
            PanelBlau = new Panel();
            PanelGelb = new Panel();
            PanelRot = new Panel();
            PanelGruen = new Panel();
            CmdLetsPlay = new Button();
            TimPlay = new System.Windows.Forms.Timer(components);
            CmdLetsPause = new Button();
            SuspendLayout();
            // 
            // CmdStartX
            // 
            CmdStartX.Location = new Point(333, 768);
            CmdStartX.Name = "CmdStartX";
            CmdStartX.Size = new Size(95, 53);
            CmdStartX.TabIndex = 0;
            CmdStartX.Text = "Start";
            CmdStartX.UseVisualStyleBackColor = true;
            CmdStartX.Click += CmdStartX_Click;
            // 
            // CmdStopX
            // 
            CmdStopX.Location = new Point(445, 768);
            CmdStopX.Name = "CmdStopX";
            CmdStopX.Size = new Size(95, 53);
            CmdStopX.TabIndex = 1;
            CmdStopX.Text = "Stop";
            CmdStopX.UseVisualStyleBackColor = true;
            CmdStopX.Click += CmdStopX_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeige.Location = new Point(573, 768);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(2, 22);
            LblAnzeige.TabIndex = 2;
            // 
            // TimAnzeige
            // 
            TimAnzeige.Interval = 500;
            TimAnzeige.Tick += TimAnzeige_Tick;
            // 
            // PanelBlau
            // 
            PanelBlau.BackColor = Color.FromArgb(192, 255, 255);
            PanelBlau.Location = new Point(410, 324);
            PanelBlau.Name = "PanelBlau";
            PanelBlau.Size = new Size(30, 30);
            PanelBlau.TabIndex = 4;
            PanelBlau.Paint += PanelBlau_Paint;
            // 
            // PanelGelb
            // 
            PanelGelb.BackColor = Color.FromArgb(255, 224, 192);
            PanelGelb.Location = new Point(312, 423);
            PanelGelb.Name = "PanelGelb";
            PanelGelb.Size = new Size(30, 30);
            PanelGelb.TabIndex = 5;
            PanelGelb.Paint += PanelGelb_Paint;
            // 
            // PanelRot
            // 
            PanelRot.BackColor = Color.FromArgb(255, 192, 192);
            PanelRot.Location = new Point(312, 324);
            PanelRot.Name = "PanelRot";
            PanelRot.Size = new Size(30, 30);
            PanelRot.TabIndex = 6;
            PanelRot.Paint += PanelRot_Paint;
            // 
            // PanelGruen
            // 
            PanelGruen.BackColor = Color.FromArgb(192, 255, 192);
            PanelGruen.Location = new Point(410, 423);
            PanelGruen.Name = "PanelGruen";
            PanelGruen.Size = new Size(30, 30);
            PanelGruen.TabIndex = 7;
            PanelGruen.Paint += PanelGruen_Paint;
            // 
            // CmdLetsPlay
            // 
            CmdLetsPlay.Location = new Point(205, 768);
            CmdLetsPlay.Name = "CmdLetsPlay";
            CmdLetsPlay.Size = new Size(95, 53);
            CmdLetsPlay.TabIndex = 8;
            CmdLetsPlay.Text = "Play";
            CmdLetsPlay.UseVisualStyleBackColor = true;
            CmdLetsPlay.Click += CmdLetsPlay_Click;
            // 
            // TimPlay
            // 
            TimPlay.Interval = 1000;
            TimPlay.Tick += TimPlay_Tick;
            // 
            // CmdLetsPause
            // 
            CmdLetsPause.Location = new Point(70, 768);
            CmdLetsPause.Name = "CmdLetsPause";
            CmdLetsPause.Size = new Size(95, 53);
            CmdLetsPause.TabIndex = 9;
            CmdLetsPause.Text = "Pause";
            CmdLetsPause.UseVisualStyleBackColor = true;
            CmdLetsPause.Click += CmdLetsPause_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 853);
            Controls.Add(CmdLetsPause);
            Controls.Add(CmdLetsPlay);
            Controls.Add(PanelGruen);
            Controls.Add(PanelRot);
            Controls.Add(PanelGelb);
            Controls.Add(PanelBlau);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdStopX);
            Controls.Add(CmdStartX);
            Name = "Form1";
            Text = "SteuerelementTimer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdStartX;
        private Button CmdStopX;
        private Label LblAnzeige;
        private System.Windows.Forms.Timer TimAnzeige;
        private Panel PanelBlau;
        private Panel PanelGelb;
        private Panel PanelRot;
        private Panel PanelGruen;
        private Button CmdLetsPlay;
        private System.Windows.Forms.Timer TimPlay;
        private Button CmdLetsPause;
    }
}
