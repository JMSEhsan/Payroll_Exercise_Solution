
namespace Payroll_Exercise
{
    partial class PayrollForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollForm));
            this.HrsWorkedIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HrRateIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OvertimeP = new System.Windows.Forms.Label();
            this.RegularP = new System.Windows.Forms.Label();
            this.TotalP = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HrsWorkedIn
            // 
            this.HrsWorkedIn.Location = new System.Drawing.Point(252, 35);
            this.HrsWorkedIn.Name = "HrsWorkedIn";
            this.HrsWorkedIn.Size = new System.Drawing.Size(125, 27);
            this.HrsWorkedIn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(79, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer of Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly Rate";
            // 
            // HrRateIn
            // 
            this.HrRateIn.Location = new System.Drawing.Point(252, 85);
            this.HrRateIn.Name = "HrRateIn";
            this.HrRateIn.Size = new System.Drawing.Size(125, 27);
            this.HrRateIn.TabIndex = 3;
            this.HrRateIn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Overtime pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Regular pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total pay";
            // 
            // OvertimeP
            // 
            this.OvertimeP.AutoSize = true;
            this.OvertimeP.ForeColor = System.Drawing.Color.Blue;
            this.OvertimeP.Location = new System.Drawing.Point(126, 44);
            this.OvertimeP.Name = "OvertimeP";
            this.OvertimeP.Size = new System.Drawing.Size(0, 20);
            this.OvertimeP.TabIndex = 7;
            // 
            // RegularP
            // 
            this.RegularP.AutoSize = true;
            this.RegularP.Location = new System.Drawing.Point(126, 93);
            this.RegularP.Name = "RegularP";
            this.RegularP.Size = new System.Drawing.Size(0, 20);
            this.RegularP.TabIndex = 8;
            // 
            // TotalP
            // 
            this.TotalP.AutoSize = true;
            this.TotalP.ForeColor = System.Drawing.Color.Blue;
            this.TotalP.Location = new System.Drawing.Point(126, 140);
            this.TotalP.Name = "TotalP";
            this.TotalP.Size = new System.Drawing.Size(0, 20);
            this.TotalP.TabIndex = 9;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(252, 131);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(125, 29);
            this.Button1.TabIndex = 15;
            this.Button1.Text = "Calculate";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HrsWorkedIn);
            this.groupBox1.Controls.Add(this.HrRateIn);
            this.groupBox1.Location = new System.Drawing.Point(53, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 179);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OvertimeP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TotalP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.RegularP);
            this.groupBox2.Location = new System.Drawing.Point(53, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 181);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ehsan Jalali                       Assignment 1, Part 1                         A" +
    "pr. 19. 2021";
            // 
            // PayrollForm
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayrollForm";
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HrsWorkedIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HrRateIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OvertimeP;
        private System.Windows.Forms.Label RegularP;
        private System.Windows.Forms.Label TotalP;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}

