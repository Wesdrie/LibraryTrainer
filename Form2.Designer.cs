namespace LibraryTrainer
{
    partial class WindowSort
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
            this.components = new System.ComponentModel.Container();
            this.SplitSort = new System.Windows.Forms.SplitContainer();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ListSort = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TextBeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerSort = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSort)).BeginInit();
            this.SplitSort.Panel1.SuspendLayout();
            this.SplitSort.Panel2.SuspendLayout();
            this.SplitSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitSort
            // 
            this.SplitSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitSort.Location = new System.Drawing.Point(0, 0);
            this.SplitSort.Margin = new System.Windows.Forms.Padding(0);
            this.SplitSort.Name = "SplitSort";
            // 
            // SplitSort.Panel1
            // 
            this.SplitSort.Panel1.Controls.Add(this.ButtonComplete);
            this.SplitSort.Panel1.Controls.Add(this.ButtonReset);
            this.SplitSort.Panel1.Controls.Add(this.ButtonBack);
            // 
            // SplitSort.Panel2
            // 
            this.SplitSort.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitSort.Panel2.Controls.Add(this.ListSort);
            this.SplitSort.Panel2.Controls.Add(this.label5);
            this.SplitSort.Panel2.Controls.Add(this.label4);
            this.SplitSort.Panel2.Controls.Add(this.label2);
            this.SplitSort.Panel2.Controls.Add(this.TimeLabel);
            this.SplitSort.Panel2.Controls.Add(this.TextBeat);
            this.SplitSort.Panel2.Controls.Add(this.label1);
            this.SplitSort.Size = new System.Drawing.Size(634, 361);
            this.SplitSort.SplitterDistance = 200;
            this.SplitSort.SplitterWidth = 1;
            this.SplitSort.TabIndex = 0;
            // 
            // ButtonComplete
            // 
            this.ButtonComplete.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonComplete.FlatAppearance.BorderSize = 0;
            this.ButtonComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonComplete.Location = new System.Drawing.Point(0, 45);
            this.ButtonComplete.Name = "ButtonComplete";
            this.ButtonComplete.Size = new System.Drawing.Size(200, 45);
            this.ButtonComplete.TabIndex = 0;
            this.ButtonComplete.Text = "Complete";
            this.ButtonComplete.UseVisualStyleBackColor = true;
            this.ButtonComplete.Click += new System.EventHandler(this.ButtonComplete_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Location = new System.Drawing.Point(0, 0);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(200, 45);
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(185)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Location = new System.Drawing.Point(0, 316);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 45);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ListSort
            // 
            this.ListSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ListSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ListSort.FormattingEnabled = true;
            this.ListSort.ItemHeight = 17;
            this.ListSort.Location = new System.Drawing.Point(170, 30);
            this.ListSort.Margin = new System.Windows.Forms.Padding(0);
            this.ListSort.Name = "ListSort";
            this.ListSort.Size = new System.Drawing.Size(120, 289);
            this.ListSort.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Score";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(30, 170);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(100, 19);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "0";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBeat
            // 
            this.TextBeat.Location = new System.Drawing.Point(30, 30);
            this.TextBeat.Margin = new System.Windows.Forms.Padding(0);
            this.TextBeat.Name = "TextBeat";
            this.TextBeat.Size = new System.Drawing.Size(100, 19);
            this.TextBeat.TabIndex = 0;
            this.TextBeat.Text = "Time-To-Beat";
            this.TextBeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerSort
            // 
            this.TimerSort.Interval = 1000;
            this.TimerSort.Tick += new System.EventHandler(this.TimerSort_Tick);
            // 
            // WindowSort
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitSort);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowSort_FormClosing);
            this.Load += new System.EventHandler(this.WindowSort_Load);
            this.SplitSort.Panel1.ResumeLayout(false);
            this.SplitSort.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitSort)).EndInit();
            this.SplitSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitSort;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TextBeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListSort;
        private System.Windows.Forms.Timer TimerSort;
    }
}