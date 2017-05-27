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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.row = new System.Windows.Forms.NumericUpDown();
            this.col = new System.Windows.Forms.NumericUpDown();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nonSmart = new System.Windows.Forms.RadioButton();
            this.smart = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.row);
            this.tabPage1.Controls.Add(this.col);
            this.tabPage1.Controls.Add(this.trials);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nonSmart);
            this.tabPage1.Controls.Add(this.smart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chess";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(335, 201);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(55, 20);
            this.row.TabIndex = 11;
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(335, 174);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(55, 20);
            this.col.TabIndex = 10;
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(335, 137);
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(55, 20);
            this.trials.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trials";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(297, 301);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(91, 23);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Row";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column";
            // 
            // nonSmart
            // 
            this.nonSmart.AutoSize = true;
            this.nonSmart.Location = new System.Drawing.Point(297, 95);
            this.nonSmart.Name = "nonSmart";
            this.nonSmart.Size = new System.Drawing.Size(93, 17);
            this.nonSmart.TabIndex = 1;
            this.nonSmart.Text = "Non-Intelligent";
            this.nonSmart.UseVisualStyleBackColor = true;
            // 
            // smart
            // 
            this.smart.AutoSize = true;
            this.smart.Checked = true;
            this.smart.Location = new System.Drawing.Point(297, 71);
            this.smart.Name = "smart";
            this.smart.Size = new System.Drawing.Size(70, 17);
            this.smart.TabIndex = 0;
            this.smart.TabStop = true;
            this.smart.Text = "Intelligent";
            this.smart.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OutputBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OutputBox
            // 
            this.OutputBox.Enabled = false;
            this.OutputBox.Location = new System.Drawing.Point(3, 6);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(382, 329);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Computer Mind:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton smart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton nonSmart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.NumericUpDown col;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Label label4;


    }
}

