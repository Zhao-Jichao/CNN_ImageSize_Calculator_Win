using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CNN_ImageSize_Calculator_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInWidth.Clear();
            textBoxInHeight.Clear();
            textBoxOutWidth.Clear();
            textBoxOutHeight.Clear();
            textBoxInChannel.Text = 3.ToString();
            textBoxOutChannel.Text = 3.ToString();
            textBoxConv1S.Text = 1.ToString();
            textBoxConv1P.Text = 0.ToString();
            textBoxConv2S.Text = 1.ToString();
            textBoxConv2P.Text = 0.ToString();
            textBoxDeconv3S.Text = 1.ToString();
            textBoxDeconv3P.Text = 0.ToString();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //string InWidth = textBoxInWidth.Text;
            float InWidth = float.Parse(textBoxInWidth.Text);
            float InHeight = float.Parse(textBoxInHeight.Text);

            //第一层卷积层
            float Conv1K = float.Parse(textBoxConv1K.Text);
            float Conv1S = float.Parse(textBoxConv1S.Text);
            float Conv1P = float.Parse(textBoxConv1P.Text);
            //第一层卷积层运算结果
            float Width1 = (InWidth + (2 * Conv1P) - Conv1K) / Conv1S;
            float Height1 = (InHeight + (2 * Conv1P) - Conv1K) / Conv1S;

            //第二层卷积层参数
            float Conv2K = float.Parse(textBoxConv2K.Text);
            float Conv2S = float.Parse(textBoxConv2S.Text);
            float Conv2P = float.Parse(textBoxConv2P.Text);
            //第二层卷积层运算结果
            float Width2 = (Width1 + (2 * Conv2P) - Conv2K) / Conv2S;
            float Height2 = (Height1 + (2 * Conv2P) - Conv2K) / Conv2S;

            //第三层反卷积层参数
            float Deconv3K = float.Parse(textBoxDeconv3K.Text);
            float Deconv3S = float.Parse(textBoxDeconv3S.Text);
            float Deconv3P = float.Parse(textBoxDeconv3P.Text);
            //第三层卷积层运算结果
            float Width3 = (Width2 + (2 * Deconv3P) - Deconv3K) / Deconv3S;
            float Height3 = (Height2 + (2 * Deconv3P) - Deconv3K) / Deconv3S;

            //显示输出结果
            textBoxOutWidth.Text = Width3.ToString();
            textBoxOutHeight.Text = Height3.ToString();
        }
    }
}
