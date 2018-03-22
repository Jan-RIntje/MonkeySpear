namespace MonkeySpear
{
    partial class Form1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(16, 15);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(100, 28);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(48, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 489);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPanel.Controls.Add(this.OutputLabel);
            this.mainPanel.Location = new System.Drawing.Point(118, 102);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(802, 378);
            this.mainPanel.TabIndex = 3;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Segoe Mono Boot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(-2, -8);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(25, 19);
            this.OutputLabel.TabIndex = 2;
            this.OutputLabel.Text = "\"\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.start_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Monkey Typewriter";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label OutputLabel;
    }
}

