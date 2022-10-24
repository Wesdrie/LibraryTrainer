namespace LibraryTrainer
{
    partial class WindowAreas
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
            this.SplitAreas = new System.Windows.Forms.SplitContainer();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SplitAreas)).BeginInit();
            this.SplitAreas.Panel1.SuspendLayout();
            this.SplitAreas.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitAreas
            // 
            this.SplitAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitAreas.Location = new System.Drawing.Point(0, 0);
            this.SplitAreas.Margin = new System.Windows.Forms.Padding(0);
            this.SplitAreas.Name = "SplitAreas";
            // 
            // SplitAreas.Panel1
            // 
            this.SplitAreas.Panel1.Controls.Add(this.ButtonBack);
            this.SplitAreas.Panel1.Controls.Add(this.button1);
            this.SplitAreas.Panel1.Controls.Add(this.ButtonReset);
            // 
            // SplitAreas.Panel2
            // 
            this.SplitAreas.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SplitAreas.Size = new System.Drawing.Size(634, 361);
            this.SplitAreas.SplitterDistance = 200;
            this.SplitAreas.SplitterWidth = 1;
            this.SplitAreas.TabIndex = 0;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Location = new System.Drawing.Point(0, 0);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(200, 45);
            this.ButtonReset.TabIndex = 0;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Location = new System.Drawing.Point(0, 316);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(200, 45);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // WindowAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.SplitAreas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WindowAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Identify Areas";
            this.SplitAreas.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitAreas)).EndInit();
            this.SplitAreas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitAreas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonBack;
    }
}