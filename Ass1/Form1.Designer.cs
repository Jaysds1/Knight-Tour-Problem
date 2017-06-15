namespace KnightTour
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
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.NumericUpDown();
            this.col = new System.Windows.Forms.NumericUpDown();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nonSmart = new System.Windows.Forms.RadioButton();
            this.smart = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.avg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(399, 367);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Computer Mind:";
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(479, 274);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(77, 20);
            this.row.TabIndex = 21;
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(479, 232);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(77, 20);
            this.col.TabIndex = 20;
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(479, 186);
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(77, 20);
            this.trials.TabIndex = 19;
            this.trials.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trials";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(428, 356);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 23);
            this.start.TabIndex = 17;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Row";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Column";
            // 
            // nonSmart
            // 
            this.nonSmart.AutoSize = true;
            this.nonSmart.Location = new System.Drawing.Point(428, 129);
            this.nonSmart.Name = "nonSmart";
            this.nonSmart.Size = new System.Drawing.Size(93, 17);
            this.nonSmart.TabIndex = 14;
            this.nonSmart.Text = "Non-Intelligent";
            this.nonSmart.UseVisualStyleBackColor = true;
            // 
            // smart
            // 
            this.smart.AutoSize = true;
            this.smart.Checked = true;
            this.smart.Location = new System.Drawing.Point(428, 85);
            this.smart.Name = "smart";
            this.smart.Size = new System.Drawing.Size(70, 17);
            this.smart.TabIndex = 13;
            this.smart.TabStop = true;
            this.smart.Text = "Intelligent";
            this.smart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Standard Deviation:";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(532, 313);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(13, 13);
            this.sd.TabIndex = 24;
            this.sd.Text = "0";
            // 
            // avg
            // 
            this.avg.AutoSize = true;
            this.avg.Location = new System.Drawing.Point(532, 326);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(13, 13);
            this.avg.TabIndex = 26;
            this.avg.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 391);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.row);
            this.Controls.Add(this.col);
            this.Controls.Add(this.trials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nonSmart);
            this.Controls.Add(this.smart);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.NumericUpDown col;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nonSmart;
        private System.Windows.Forms.RadioButton smart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.Label avg;
        private System.Windows.Forms.Label label7;


    }
}

