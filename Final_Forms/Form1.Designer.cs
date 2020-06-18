namespace Final_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ssq = new System.Windows.Forms.Button();
            this.dq = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.rotate = new System.Windows.Forms.Button();
            this.serve = new System.Windows.Forms.Button();
            this.ds = new System.Windows.Forms.Button();
            this.lineup = new System.Windows.Forms.Button();
            this.snap = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.nrtb = new System.Windows.Forms.RichTextBox();
            this.srtb = new System.Windows.Forms.RichTextBox();
            this.fullnrtb = new System.Windows.Forms.RichTextBox();
            this.fullsrtb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.served = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRAZY DRUGSTORE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // ssq
            // 
            this.ssq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ssq.Location = new System.Drawing.Point(147, 25);
            this.ssq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssq.Name = "ssq";
            this.ssq.Size = new System.Drawing.Size(163, 34);
            this.ssq.TabIndex = 5;
            this.ssq.Text = "Sort Senior Queue";
            this.ssq.UseVisualStyleBackColor = true;
            this.ssq.Click += new System.EventHandler(this.ssq_Click);
            // 
            // dq
            // 
            this.dq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dq.Location = new System.Drawing.Point(147, 68);
            this.dq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dq.Name = "dq";
            this.dq.Size = new System.Drawing.Size(163, 34);
            this.dq.TabIndex = 6;
            this.dq.Text = "Display Queues";
            this.dq.UseVisualStyleBackColor = true;
            this.dq.Click += new System.EventHandler(this.dq_Click);
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ageBox.Location = new System.Drawing.Point(108, 70);
            this.ageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(244, 26);
            this.ageBox.TabIndex = 4;
            this.ageBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameBox.Location = new System.Drawing.Point(108, 28);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(244, 26);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rotate
            // 
            this.rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rotate.Location = new System.Drawing.Point(13, 64);
            this.rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(96, 38);
            this.rotate.TabIndex = 7;
            this.rotate.Text = "Rotate";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // serve
            // 
            this.serve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serve.Location = new System.Drawing.Point(13, 107);
            this.serve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serve.Name = "serve";
            this.serve.Size = new System.Drawing.Size(96, 39);
            this.serve.TabIndex = 8;
            this.serve.Text = "Serve";
            this.serve.UseVisualStyleBackColor = true;
            this.serve.Click += new System.EventHandler(this.serve_Click);
            // 
            // ds
            // 
            this.ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ds.Location = new System.Drawing.Point(147, 113);
            this.ds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(163, 33);
            this.ds.TabIndex = 9;
            this.ds.Text = "Display Served";
            this.ds.UseVisualStyleBackColor = true;
            this.ds.Click += new System.EventHandler(this.ds_Click);
            // 
            // lineup
            // 
            this.lineup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lineup.Location = new System.Drawing.Point(13, 23);
            this.lineup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineup.Name = "lineup";
            this.lineup.Size = new System.Drawing.Size(96, 38);
            this.lineup.TabIndex = 10;
            this.lineup.Text = "Line Up";
            this.lineup.UseVisualStyleBackColor = true;
            this.lineup.Click += new System.EventHandler(this.button6_Click);
            // 
            // snap
            // 
            this.snap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.snap.Location = new System.Drawing.Point(341, 25);
            this.snap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snap.Name = "snap";
            this.snap.Size = new System.Drawing.Size(95, 34);
            this.snap.TabIndex = 11;
            this.snap.Text = "Reset";
            this.snap.UseVisualStyleBackColor = true;
            this.snap.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button8.Location = new System.Drawing.Point(341, 68);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 34);
            this.button8.TabIndex = 12;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // nrtb
            // 
            this.nrtb.Location = new System.Drawing.Point(11, 52);
            this.nrtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nrtb.Name = "nrtb";
            this.nrtb.Size = new System.Drawing.Size(215, 413);
            this.nrtb.TabIndex = 13;
            this.nrtb.Text = "";
            // 
            // srtb
            // 
            this.srtb.Location = new System.Drawing.Point(289, 52);
            this.srtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.srtb.Name = "srtb";
            this.srtb.Size = new System.Drawing.Size(223, 413);
            this.srtb.TabIndex = 14;
            this.srtb.Text = "";
            // 
            // fullnrtb
            // 
            this.fullnrtb.Location = new System.Drawing.Point(577, 52);
            this.fullnrtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullnrtb.Name = "fullnrtb";
            this.fullnrtb.Size = new System.Drawing.Size(235, 413);
            this.fullnrtb.TabIndex = 15;
            this.fullnrtb.Text = "";
            // 
            // fullsrtb
            // 
            this.fullsrtb.Location = new System.Drawing.Point(878, 52);
            this.fullsrtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullsrtb.Name = "fullsrtb";
            this.fullsrtb.Size = new System.Drawing.Size(235, 413);
            this.fullsrtb.TabIndex = 16;
            this.fullsrtb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Operations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Operations (Priority):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Customer Queue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(875, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Priority Customer Queue:";
            // 
            // served
            // 
            this.served.Location = new System.Drawing.Point(1178, 52);
            this.served.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.served.Name = "served";
            this.served.Size = new System.Drawing.Size(235, 413);
            this.served.TabIndex = 21;
            this.served.Text = "";
            this.served.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1175, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Served:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srtb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nrtb);
            this.groupBox1.Controls.Add(this.served);
            this.groupBox1.Controls.Add(this.fullnrtb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.fullsrtb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 285);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1424, 471);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drugstore Visuals";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ssq);
            this.groupBox2.Controls.Add(this.dq);
            this.groupBox2.Controls.Add(this.lineup);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.serve);
            this.groupBox2.Controls.Add(this.ds);
            this.groupBox2.Controls.Add(this.rotate);
            this.groupBox2.Controls.Add(this.snap);
            this.groupBox2.Location = new System.Drawing.Point(876, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(452, 159);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drugstore Operations";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nameBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ageBox);
            this.groupBox3.Location = new System.Drawing.Point(32, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(376, 111);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 769);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ssq;
        private System.Windows.Forms.Button dq;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button serve;
        private System.Windows.Forms.Button ds;
        private System.Windows.Forms.Button lineup;
        private System.Windows.Forms.Button snap;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RichTextBox nrtb;
        private System.Windows.Forms.RichTextBox srtb;
        private System.Windows.Forms.RichTextBox fullnrtb;
        private System.Windows.Forms.RichTextBox fullsrtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox served;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

