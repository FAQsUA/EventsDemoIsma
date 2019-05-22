namespace EventsDemo
{
    partial class MainForm
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
            L1 = new System.Windows.Forms.Label();
            L2 = new System.Windows.Forms.Label();
            L3 = new System.Windows.Forms.Label();
            L4 = new System.Windows.Forms.Label();
            B1 = new System.Windows.Forms.Button();
            B2 = new System.Windows.Forms.Button();
            Panel = new System.Windows.Forms.Panel();
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Location = new System.Drawing.Point(6, 11);
            L1.Name = "L1";
            L1.Size = new System.Drawing.Size(14, 13);
            L1.Text = "X";
            // 
            // L2
            // 
            L2.AutoSize = true;
            L2.Location = new System.Drawing.Point(6, 36);
            L2.Name = "L2";
            L2.Size = new System.Drawing.Size(14, 13);
            L2.Text = "Y";
            // 
            // L3
            // 
            L3.AutoSize = true;
            L3.Location = new System.Drawing.Point(22, 11);
            L3.Name = "L3";
            L3.Size = new System.Drawing.Size(25, 13);
            L3.Text = "000";
            // 
            // L4
            // 
            L4.AutoSize = true;
            L4.Location = new System.Drawing.Point(22, 36);
            L4.Name = "L4";
            L4.Size = new System.Drawing.Size(25, 13);
            L4.Text = "000";
            // 
            // B1
            // 
            B1.Location = new System.Drawing.Point(57, 6);
            B1.Name = "B1";
            B1.Size = new System.Drawing.Size(75, 23);
            B1.TabIndex = 0;
            B1.Text = "New";
            B1.Click += new System.EventHandler(B1_Click);
            // 
            // B2
            // 
            B2.Location = new System.Drawing.Point(57, 31);
            B2.Name = "B2";
            B2.Size = new System.Drawing.Size(75, 23);
            B2.TabIndex = 1;
            B2.Text = "Exit";
            B2.Click += new System.EventHandler(B2_Click);

            /////////////////////////////////////////////////
            B2.MouseEnter += new System.EventHandler(B2_M);
            B2.MouseLeave += new System.EventHandler(B2_L);
            B2.BackColor = System.Drawing.Color.Green; ;
            /////////////////////////////////////////////////
            
            // 
            // Panel
            // 
            Panel.BackColor = System.Drawing.Color.Black;
            Panel.Location = new System.Drawing.Point(138, 6);
            Panel.Name = "Panel";
            Panel.Size = new System.Drawing.Size(43, 48);

            /////////////////////////////////////////////////
            Panel.Cursor = System.Windows.Forms.Cursors.No;
            /////////////////////////////////////////////////
            
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(184, 61);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "Main Form";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Controls.Add(L1);
            Controls.Add(L2);
            Controls.Add(L3);
            Controls.Add(L4);
            Controls.Add(B1);
            Controls.Add(B2);
            Controls.Add(Panel);
            MouseMove += new System.Windows.Forms.MouseEventHandler(MainForm_MouseMove);
            Move += new System.EventHandler(MainForm_Move);
        }
        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Panel Panel;
    }
}

