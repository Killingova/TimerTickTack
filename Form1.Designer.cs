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
            SuspendLayout();
            // 
            // CmdStartX
            // 
            CmdStartX.Location = new Point(52, 303);
            CmdStartX.Name = "CmdStartX";
            CmdStartX.Size = new Size(94, 29);
            CmdStartX.TabIndex = 0;
            CmdStartX.Text = "Start";
            CmdStartX.UseVisualStyleBackColor = true;
            CmdStartX.Click += CmdStartX_Click;
            // 
            // CmdStopX
            // 
            CmdStopX.Location = new Point(52, 358);
            CmdStopX.Name = "CmdStopX";
            CmdStopX.Size = new Size(94, 29);
            CmdStopX.TabIndex = 1;
            CmdStopX.Text = "Stop";
            CmdStopX.UseVisualStyleBackColor = true;
            CmdStopX.Click += CmdStopX_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeige.Location = new Point(64, 155);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(2, 22);
            LblAnzeige.TabIndex = 2;
            // 
            // TimAnzeige
            // 
            TimAnzeige.Interval = 500;
            TimAnzeige.Tick += TimAnzeige_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdStopX);
            Controls.Add(CmdStartX);
            Name = "Form1";
            Text = "SteuerelementTimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdStartX;
        private Button CmdStopX;
        private Label LblAnzeige;
        private System.Windows.Forms.Timer TimAnzeige;
    }
}
