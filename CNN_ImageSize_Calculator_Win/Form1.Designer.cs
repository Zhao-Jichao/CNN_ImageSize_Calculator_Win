namespace CNN_ImageSize_Calculator_Win
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxInChannel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInWidth = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxOutChannel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxOutHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOutWidth = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxConv1P = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxConv1S = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxConv1K = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxConv2P = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxConv2S = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxConv2K = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxDeconv3P = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDeconv3S = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDeconv3K = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxInChannel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxInHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxInWidth);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 141);
            this.panel1.TabIndex = 0;
            // 
            // textBoxInChannel
            // 
            this.textBoxInChannel.Location = new System.Drawing.Point(67, 99);
            this.textBoxInChannel.Name = "textBoxInChannel";
            this.textBoxInChannel.Size = new System.Drawing.Size(100, 21);
            this.textBoxInChannel.TabIndex = 7;
            this.textBoxInChannel.Text = "3";
            this.textBoxInChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Channel:";
            // 
            // textBoxInHeight
            // 
            this.textBoxInHeight.Location = new System.Drawing.Point(67, 72);
            this.textBoxInHeight.Name = "textBoxInHeight";
            this.textBoxInHeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxInHeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input_Image_Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInWidth
            // 
            this.textBoxInWidth.Location = new System.Drawing.Point(67, 45);
            this.textBoxInWidth.Name = "textBoxInWidth";
            this.textBoxInWidth.Size = new System.Drawing.Size(100, 21);
            this.textBoxInWidth.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(662, 364);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 60);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxOutChannel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.textBoxOutHeight);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxOutWidth);
            this.panel2.Location = new System.Drawing.Point(430, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 139);
            this.panel2.TabIndex = 2;
            // 
            // textBoxOutChannel
            // 
            this.textBoxOutChannel.Location = new System.Drawing.Point(67, 99);
            this.textBoxOutChannel.Name = "textBoxOutChannel";
            this.textBoxOutChannel.Size = new System.Drawing.Size(100, 21);
            this.textBoxOutChannel.TabIndex = 6;
            this.textBoxOutChannel.Text = "3";
            this.textBoxOutChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Channel:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(208, 36);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 90);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxOutHeight
            // 
            this.textBoxOutHeight.Location = new System.Drawing.Point(67, 72);
            this.textBoxOutHeight.Name = "textBoxOutHeight";
            this.textBoxOutHeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxOutHeight.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Output_Image_Size";
            // 
            // textBoxOutWidth
            // 
            this.textBoxOutWidth.Location = new System.Drawing.Point(67, 45);
            this.textBoxOutWidth.Name = "textBoxOutWidth";
            this.textBoxOutWidth.Size = new System.Drawing.Size(100, 21);
            this.textBoxOutWidth.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.textBoxConv1P);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxConv1S);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBoxConv1K);
            this.panel3.Location = new System.Drawing.Point(253, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 141);
            this.panel3.TabIndex = 6;
            // 
            // textBoxConv1P
            // 
            this.textBoxConv1P.Location = new System.Drawing.Point(94, 99);
            this.textBoxConv1P.Name = "textBoxConv1P";
            this.textBoxConv1P.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv1P.TabIndex = 7;
            this.textBoxConv1P.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "Padding:";
            // 
            // textBoxConv1S
            // 
            this.textBoxConv1S.Location = new System.Drawing.Point(94, 72);
            this.textBoxConv1S.Name = "textBoxConv1S";
            this.textBoxConv1S.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv1S.TabIndex = 4;
            this.textBoxConv1S.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Stride:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "KernalSize:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Conv1";
            // 
            // textBoxConv1K
            // 
            this.textBoxConv1K.Location = new System.Drawing.Point(94, 45);
            this.textBoxConv1K.Name = "textBoxConv1K";
            this.textBoxConv1K.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv1K.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.textBoxConv2P);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.textBoxConv2S);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.textBoxConv2K);
            this.panel4.Location = new System.Drawing.Point(253, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 141);
            this.panel4.TabIndex = 7;
            // 
            // textBoxConv2P
            // 
            this.textBoxConv2P.Location = new System.Drawing.Point(94, 99);
            this.textBoxConv2P.Name = "textBoxConv2P";
            this.textBoxConv2P.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv2P.TabIndex = 7;
            this.textBoxConv2P.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Padding:";
            // 
            // textBoxConv2S
            // 
            this.textBoxConv2S.Location = new System.Drawing.Point(94, 72);
            this.textBoxConv2S.Name = "textBoxConv2S";
            this.textBoxConv2S.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv2S.TabIndex = 4;
            this.textBoxConv2S.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 3;
            this.label14.Text = "Stride:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "KernalSize:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "Conv2";
            // 
            // textBoxConv2K
            // 
            this.textBoxConv2K.Location = new System.Drawing.Point(94, 45);
            this.textBoxConv2K.Name = "textBoxConv2K";
            this.textBoxConv2K.Size = new System.Drawing.Size(73, 21);
            this.textBoxConv2K.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.textBoxDeconv3P);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.textBoxDeconv3S);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.textBoxDeconv3K);
            this.panel5.Location = new System.Drawing.Point(253, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 141);
            this.panel5.TabIndex = 8;
            // 
            // textBoxDeconv3P
            // 
            this.textBoxDeconv3P.Location = new System.Drawing.Point(94, 99);
            this.textBoxDeconv3P.Name = "textBoxDeconv3P";
            this.textBoxDeconv3P.Size = new System.Drawing.Size(73, 21);
            this.textBoxDeconv3P.TabIndex = 7;
            this.textBoxDeconv3P.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "Padding:";
            // 
            // textBoxDeconv3S
            // 
            this.textBoxDeconv3S.Location = new System.Drawing.Point(94, 72);
            this.textBoxDeconv3S.Name = "textBoxDeconv3S";
            this.textBoxDeconv3S.Size = new System.Drawing.Size(73, 21);
            this.textBoxDeconv3S.TabIndex = 4;
            this.textBoxDeconv3S.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 3;
            this.label18.Text = "Stride:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "KernalSize:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "DeConv3";
            // 
            // textBoxDeconv3K
            // 
            this.textBoxDeconv3K.Location = new System.Drawing.Point(94, 45);
            this.textBoxDeconv3K.Name = "textBoxDeconv3K";
            this.textBoxDeconv3K.Size = new System.Drawing.Size(73, 21);
            this.textBoxDeconv3K.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = "CNN_ImageSize_Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxInHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInWidth;
        private System.Windows.Forms.TextBox textBoxInChannel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxOutChannel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxOutHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOutWidth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxConv1P;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConv1S;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxConv1K;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxConv2P;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxConv2S;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxConv2K;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxDeconv3P;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxDeconv3S;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDeconv3K;
    }
}

