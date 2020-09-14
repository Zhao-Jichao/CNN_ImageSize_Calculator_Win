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

        //程序初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Conv2d");
            this.comboBox1.Items.Add("Pool2d");
            this.comboBox1.Items.Add("Deconv2d");
            this.comboBox1.Items.Add("Null");
            this.comboBox1.SelectedItem = "Null";

            this.comboBox2.Items.Add("Conv2d");
            this.comboBox2.Items.Add("Pool2d");
            this.comboBox2.Items.Add("Deconv2d");
            this.comboBox2.Items.Add("Null");
            this.comboBox2.SelectedItem = "Null";

            this.comboBox3.Items.Add("Conv2d");
            this.comboBox3.Items.Add("Pool2d");
            this.comboBox3.Items.Add("Deconv2d");
            this.comboBox3.Items.Add("Null");
            this.comboBox3.SelectedItem = "Null";

            this.comboBox4.Items.Add("Conv2d");
            this.comboBox4.Items.Add("Pool2d");
            this.comboBox4.Items.Add("Deconv2d");
            this.comboBox4.Items.Add("Null");
            this.comboBox4.SelectedItem = "Null";

            this.comboBox5.Items.Add("Conv2d");
            this.comboBox5.Items.Add("Pool2d");
            this.comboBox5.Items.Add("Deconv2d");
            this.comboBox5.Items.Add("Null");
            this.comboBox5.SelectedItem = "Null";

            this.comboBox6.Items.Add("Conv2d");
            this.comboBox6.Items.Add("Pool2d");
            this.comboBox6.Items.Add("Deconv2d");
            this.comboBox6.Items.Add("Null");
            this.comboBox6.SelectedItem = "Null";

            this.comboBox7.Items.Add("Conv2d");
            this.comboBox7.Items.Add("Pool2d");
            this.comboBox7.Items.Add("Deconv2d");
            this.comboBox7.Items.Add("Null");
            this.comboBox7.SelectedItem = "Null";


            this.comboBox8.Items.Add("Conv2d");
            this.comboBox8.Items.Add("Pool2d");
            this.comboBox8.Items.Add("Deconv2d");
            this.comboBox8.Items.Add("Null");
            this.comboBox8.SelectedItem = "Null";

            this.comboBox9.Items.Add("Conv2d");
            this.comboBox9.Items.Add("Pool2d");
            this.comboBox9.Items.Add("Deconv2d");
            this.comboBox9.Items.Add("Null");
            this.comboBox9.SelectedItem = "Null";

            this.comboBox10.Items.Add("Conv2d");
            this.comboBox10.Items.Add("Pool2d");
            this.comboBox10.Items.Add("Deconv2d");
            this.comboBox10.Items.Add("Null");
            this.comboBox10.SelectedItem = "Null";

            this.comboBox11.Items.Add("Conv2d");
            this.comboBox11.Items.Add("Pool2d");
            this.comboBox11.Items.Add("Deconv2d");
            this.comboBox11.Items.Add("Null");
            this.comboBox11.SelectedItem = "Null";

            this.comboBox12.Items.Add("Conv2d");
            this.comboBox12.Items.Add("Pool2d");
            this.comboBox12.Items.Add("Deconv2d");
            this.comboBox12.Items.Add("Null");
            this.comboBox12.SelectedItem = "Null";

            this.comboBox13.Items.Add("Conv2d");
            this.comboBox13.Items.Add("Pool2d");
            this.comboBox13.Items.Add("Deconv2d");
            this.comboBox13.Items.Add("Null");
            this.comboBox13.SelectedItem = "Null";

            this.comboBox14.Items.Add("Conv2d");
            this.comboBox14.Items.Add("Pool2d");
            this.comboBox14.Items.Add("Deconv2d");
            this.comboBox14.Items.Add("Null");
            this.comboBox14.SelectedItem = "Null";

            this.comboBox15.Items.Add("Conv2d");
            this.comboBox15.Items.Add("Pool2d");
            this.comboBox15.Items.Add("Deconv2d");
            this.comboBox15.Items.Add("Null");
            this.comboBox15.SelectedItem = "Null";

            this.comboBox16.Items.Add("Conv2d");
            this.comboBox16.Items.Add("Pool2d");
            this.comboBox16.Items.Add("Deconv2d");
            this.comboBox16.Items.Add("Null");
            this.comboBox16.SelectedItem = "Null";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //Reset复位按键
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInWidth.Clear();
            textBoxInHeight.Clear();
            textBoxOutWidth.Clear();
            textBoxOutHeight.Clear();
            textBoxInChannel.Text = 3.ToString();
            textBoxOutChannel.Text = 3.ToString();

            textBoxHid1K.Text = 1.ToString();
            textBoxHid1S.Text = 1.ToString();
            textBoxHid1P.Text = 0.ToString();
            textBoxHid2K.Text = 1.ToString();
            textBoxHid2S.Text = 1.ToString();
            textBoxHid2P.Text = 0.ToString();
            textBoxHid3K.Text = 1.ToString();
            textBoxHid3S.Text = 1.ToString();
            textBoxHid3P.Text = 0.ToString();
            textBoxHid4K.Text = 1.ToString();
            textBoxHid4S.Text = 1.ToString();
            textBoxHid4P.Text = 0.ToString();
            textBoxHid5K.Text = 1.ToString();
            textBoxHid5S.Text = 1.ToString();
            textBoxHid5P.Text = 0.ToString();
            textBoxHid6K.Text = 1.ToString();
            textBoxHid6S.Text = 1.ToString();
            textBoxHid6P.Text = 0.ToString();
            textBoxHid7K.Text = 1.ToString();
            textBoxHid7S.Text = 1.ToString();
            textBoxHid7P.Text = 0.ToString();
            textBoxHid8K.Text = 1.ToString();
            textBoxHid8S.Text = 1.ToString();
            textBoxHid8P.Text = 0.ToString();
            textBoxHid9K.Text = 1.ToString();
            textBoxHid9S.Text = 1.ToString();
            textBoxHid9P.Text = 0.ToString();
            textBoxHid10K.Text = 1.ToString();
            textBoxHid10S.Text = 1.ToString();
            textBoxHid10P.Text = 0.ToString();
            textBoxHid11K.Text = 1.ToString();
            textBoxHid11S.Text = 1.ToString();
            textBoxHid11P.Text = 0.ToString();
            textBoxHid12K.Text = 1.ToString();
            textBoxHid12S.Text = 1.ToString();
            textBoxHid12P.Text = 0.ToString();
            textBoxHid13K.Text = 1.ToString();
            textBoxHid13S.Text = 1.ToString();
            textBoxHid13P.Text = 0.ToString();
            textBoxHid14K.Text = 1.ToString();
            textBoxHid14S.Text = 1.ToString();
            textBoxHid14P.Text = 0.ToString();
            textBoxHid15K.Text = 1.ToString();
            textBoxHid15S.Text = 1.ToString();
            textBoxHid15P.Text = 0.ToString();
            textBoxHid16K.Text = 1.ToString();
            textBoxHid16S.Text = 1.ToString();
            textBoxHid16P.Text = 0.ToString();

        }

        //Calculate计算按钮
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch
            {
                MessageBox.Show("Please input Width and Height");
            }
            
        }

        //计算过程函数
        private void Calculate()
        {
            //获取输入数据
            float InWidth = float.Parse(textBoxInWidth.Text);
            float InHeight = float.Parse(textBoxInHeight.Text);

            //获取第一层参数
            float Hid1K = float.Parse(textBoxHid1K.Text);
            float Hid1S = float.Parse(textBoxHid1S.Text);
            float Hid1P = float.Parse(textBoxHid1P.Text);
            string str1 = comboBox1.Text;
            float Width1 = 0.00F;
            float Height1 = 0.00F;
            //第一层计算
            switch (str1)
            {
                case "Conv2d":
                    //第一层卷积运算结果
                    Width1 = (InWidth + (2 * Hid1P) - Hid1K) / Hid1S + 1;
                    Height1 = (InHeight + (2 * Hid1P) - Hid1K) / Hid1S + 1;
                    break;
                case "Pool2d":
                    //第一层池化运算结果
                    Width1 = (InWidth + (2 * Hid1P) - Hid1K) / Hid1S + 1;
                    Height1 = (InHeight + (2 * Hid1P) - Hid1K) / Hid1S + 1;
                    break;
                case "Deconv2d":
                    //第一层反卷积运算结果
                    Width1 = (InWidth - 1) * Hid1S - 2 * Hid1P + Hid1K;
                    Height1 = (InHeight - 1) * Hid1S - 2 * Hid1P + Hid1K;
                    break;
                //case "Null":
                //    //第一层无运算结果
                //    Width1 = 0;
                //    Height1 = 0;
                //    break;
            }
            textBoxHid1Width.Text = Width1.ToString();
            textBoxHid1Height.Text = Height1.ToString();
            if (str1 == "Null")
            {
                textBoxHid1Width.Clear();
                textBoxHid1Height.Clear();
            }


            //获取第二层参数
            float Hid2K = float.Parse(textBoxHid2K.Text);
            float Hid2S = float.Parse(textBoxHid2S.Text);
            float Hid2P = float.Parse(textBoxHid2P.Text);
            string str2 = comboBox2.Text;
            float Width2 = 0.00F;
            float Height2 = 0.00F;
            //第二层计算
            switch (str2)
            {
                case "Conv2d":
                    //第二层卷积运算结果
                    Width2 = (Width1 + (2 * Hid2P) - Hid2K) / Hid2S + 1;
                    Height2 = (Height1 + (2 * Hid2P) - Hid2K) / Hid2S + 1;
                    break;
                case "Pool2d":
                    //第二层池化运算结果
                    Width2 = (Width1 + (2 * Hid2P) - Hid2K) / Hid2S + 1;
                    Height2 = (Height1 + (2 * Hid2P) - Hid2K) / Hid2S + 1;
                    break;
                case "Deconv2d":
                    //第二层反卷积运算结果
                    Width2 = (Width1 - 1) * Hid2S - 2 * Hid2P + Hid2K;
                    Height2 = (Height1 - 1) * Hid2S - 2 * Hid2P + Hid2K;
                    break;
                //case "Null":
                //    //第二层无运算结果
                //    Width2 = 0;
                //    Height2 = 0;
                //    break;
            }
            textBoxHid2Width.Text = Width2.ToString();
            textBoxHid2Height.Text = Height2.ToString();
            if (str2 == "Null")
            {
                textBoxHid2Width.Clear();
                textBoxHid2Height.Clear();
            }


            //获取第三层参数
            float Hid3K = float.Parse(textBoxHid3K.Text);
            float Hid3S = float.Parse(textBoxHid3S.Text);
            float Hid3P = float.Parse(textBoxHid3P.Text);
            string str3 = comboBox3.Text;
            float Width3 = 0.00F;
            float Height3 = 0.00F;
            //第三层计算
            switch (str3)
            {
                case "Conv2d":
                    //第三层卷积运算结果
                    Width3 = (Width2 + (2 * Hid3P) - Hid3K) / Hid3S + 1;
                    Height3 = (Height2 + (2 * Hid3P) - Hid3K) / Hid3S + 1;
                    break;
                case "Pool2d":
                    //第三层池化运算结果
                    Width3 = (Width2 + (2 * Hid3P) - Hid3K) / Hid3S + 1;
                    Height3 = (Height2 + (2 * Hid3P) - Hid3K) / Hid3S + 1;
                    break;
                case "Deconv2d":
                    //第三层反卷积运算结果
                    Width3 = (Width2 - 1) * Hid3S - 2 * Hid3P + Hid3K;
                    Height3 = (Height2 - 1) * Hid3S - 2 * Hid3P + Hid3K;
                    break;
                //case "Null":
                //    //第三层无运算结果
                //    Width3 = 0;
                //    Height3 = 0;
                //    break;
            }
            textBoxHid3Width.Text = Width3.ToString();
            textBoxHid3Height.Text = Height3.ToString();
            if (str3 == "Null")
            {
                textBoxHid3Width.Clear();
                textBoxHid3Height.Clear();
            }


            //获取第四层参数
            float Hid4K = float.Parse(textBoxHid4K.Text);
            float Hid4S = float.Parse(textBoxHid4S.Text);
            float Hid4P = float.Parse(textBoxHid4P.Text);
            string str4 = comboBox4.Text;
            float Width4 = 0.00F;
            float Height4 = 0.00F;
            //第四层计算
            switch (str4)
            {
                case "Conv2d":
                    //第四层卷积运算结果
                    Width4 = (Width3 + (2 * Hid4P) - Hid4K) / Hid4S + 1;
                    Height4 = (Height3 + (2 * Hid4P) - Hid4K) / Hid4S + 1;
                    break;
                case "Pool2d":
                    //第四层池化运算结果
                    Width4 = (Width3 + (2 * Hid4P) - Hid4K) / Hid4S + 1;
                    Height4 = (Height3 + (2 * Hid4P) - Hid4K) / Hid4S + 1;
                    break;
                case "Deconv2d":
                    //第四层反卷积运算结果
                    Width4 = (Width3 - 1) * Hid4S - 2 * Hid4P + Hid4K;
                    Height4 = (Height3 - 1) * Hid4S - 2 * Hid4P + Hid4K;
                    break;
                //case "Null":
                //    //第四层无运算结果
                //    Width4 = 0;
                //    Height4 = 0;
                //    break;
            }
            textBoxHid4Width.Text = Width4.ToString();
            textBoxHid4Height.Text = Height4.ToString();
            if (str4 == "Null")
            {
                textBoxHid4Width.Clear();
                textBoxHid4Height.Clear();
            }


            //获取第五层参数
            float Hid5K = float.Parse(textBoxHid5K.Text);
            float Hid5S = float.Parse(textBoxHid5S.Text);
            float Hid5P = float.Parse(textBoxHid5P.Text);
            string str5 = comboBox5.Text;
            float Width5 = 0.00F;
            float Height5 = 0.00F;
            //第五层计算
            switch (str5)
            {
                case "Conv2d":
                    //第五层卷积运算结果
                    Width5 = (Width4 + (2 * Hid5P) - Hid5K) / Hid5S + 1;
                    Height5 = (Height4 + (2 * Hid5P) - Hid5K) / Hid5S + 1;
                    break;
                case "Pool2d":
                    //第五层池化运算结果
                    Width5 = (Width4 + (2 * Hid5P) - Hid5K) / Hid5S + 1;
                    Height5 = (Height4 + (2 * Hid5P) - Hid5K) / Hid5S + 1;
                    break;
                case "Deconv2d":
                    //第五层反卷积运算结果
                    Width5 = (Width4 - 1) * Hid5S - 2 * Hid5P + Hid5K;
                    Height5 = (Height4 - 1) * Hid5S - 2 * Hid5P + Hid5K;
                    break;
                //case "Null":
                //    //第五层无运算结果
                //    Width5 = 0;
                //    Height5 = 0;
                //    break;
            }
            textBoxHid5Width.Text = Width5.ToString();
            textBoxHid5Height.Text = Height5.ToString();
            if (str5 == "Null")
            {
                textBoxHid5Width.Clear();
                textBoxHid5Height.Clear();
            }


            //获取第六层参数
            float Hid6K = float.Parse(textBoxHid6K.Text);
            float Hid6S = float.Parse(textBoxHid6S.Text);
            float Hid6P = float.Parse(textBoxHid6P.Text);
            string str6 = comboBox6.Text;
            float Width6 = 0.00F;
            float Height6 = 0.00F;
            //第六层计算
            switch (str6)
            {
                case "Conv2d":
                    //第六层卷积运算结果
                    Width6 = (Width5 + (2 * Hid6P) - Hid6K) / Hid6S + 1;
                    Height6 = (Height5 + (2 * Hid6P) - Hid6K) / Hid6S + 1;
                    break;
                case "Pool2d":
                    //第六层池化运算结果
                    Width6 = (Width5 + (2 * Hid6P) - Hid6K) / Hid6S + 1;
                    Height6 = (Height5 + (2 * Hid6P) - Hid6K) / Hid6S + 1;
                    break;
                case "Deconv2d":
                    //第六层反卷积运算结果
                    Width6 = (Width5 - 1) * Hid6S - 2 * Hid6P + Hid6K;
                    Height6 = (Height5 - 1) * Hid6S - 2 * Hid6P + Hid6K;
                    break;
                //case "Null":
                //    //第六层无运算结果
                //    Width6 = 0;
                //    Height6 = 0;
                //    break;
            }
            textBoxHid6Width.Text = Width6.ToString();
            textBoxHid6Height.Text = Height6.ToString();
            if (str6 == "Null")
            {
                textBoxHid6Width.Clear();
                textBoxHid6Height.Clear();
            }


            //获取第七层参数
            float Hid7K = float.Parse(textBoxHid7K.Text);
            float Hid7S = float.Parse(textBoxHid7S.Text);
            float Hid7P = float.Parse(textBoxHid7P.Text);
            string str7 = comboBox7.Text;
            float Width7 = 0.00F;
            float Height7 = 0.00F;
            //第七层计算
            switch (str7)
            {
                case "Conv2d":
                    //第七层卷积运算结果
                    Width7 = (Width6 + (2 * Hid7P) - Hid7K) / Hid7S + 1;
                    Height7 = (Height6 + (2 * Hid7P) - Hid7K) / Hid7S + 1;
                    break;
                case "Pool2d":
                    //第七层池化运算结果
                    Width7 = (Width6 + (2 * Hid7P) - Hid7K) / Hid7S + 1;
                    Height7 = (Height6 + (2 * Hid7P) - Hid7K) / Hid7S + 1;
                    break;
                case "Deconv2d":
                    //第七层反卷积运算结果
                    Width7 = (Width6 - 1) * Hid7S - 2 * Hid7P + Hid7K;
                    Height7 = (Height6 - 1) * Hid7S - 2 * Hid7P + Hid7K;
                    break;
                //case "Null":
                //    //第七层无运算结果
                //    Width7 = 0;
                //    Height7 = 0;
                //    break;
            }
            textBoxHid7Width.Text = Width7.ToString();
            textBoxHid7Height.Text = Height7.ToString();
            if (str7 == "Null")
            {
                textBoxHid7Width.Clear();
                textBoxHid7Height.Clear();
            }


            //获取第八层参数
            float Hid8K = float.Parse(textBoxHid8K.Text);
            float Hid8S = float.Parse(textBoxHid8S.Text);
            float Hid8P = float.Parse(textBoxHid8P.Text);
            string str8 = comboBox8.Text;
            float Width8 = 0.00F;
            float Height8 = 0.00F;
            //第八层计算
            switch (str8)
            {
                case "Conv2d":
                    //第八层卷积运算结果
                    Width8 = (Width7 + (2 * Hid8P) - Hid8K) / Hid8S + 1;
                    Height8 = (Height7 + (2 * Hid8P) - Hid8K) / Hid8S + 1;
                    break;
                case "Pool2d":
                    //第八层池化运算结果
                    Width8 = (Width7 + (2 * Hid8P) - Hid8K) / Hid8S + 1;
                    Height8 = (Height7 + (2 * Hid8P) - Hid8K) / Hid8S + 1;
                    break;
                case "Deconv2d":
                    //第八层反卷积运算结果
                    Width8 = (Width7 - 1) * Hid8S - 2 * Hid8P + Hid8K;
                    Height8 = (Height7 - 1) * Hid8S - 2 * Hid8P + Hid8K;
                    break;
                //case "Null":
                //    //第八层无运算结果
                //    Width8 = 0;
                //    Height8 = 0;
                //    break;
            }
            textBoxHid8Width.Text = Width8.ToString();
            textBoxHid8Height.Text = Height8.ToString();
            if (str8 == "Null")
            {
                textBoxHid8Width.Clear();
                textBoxHid8Height.Clear();
            }


            //获取第九层参数
            float Hid9K = float.Parse(textBoxHid9K.Text);
            float Hid9S = float.Parse(textBoxHid9S.Text);
            float Hid9P = float.Parse(textBoxHid9P.Text);
            string str9 = comboBox9.Text;
            float Width9 = 0.00F;
            float Height9 = 0.00F;
            //第九层计算
            switch (str9)
            {
                case "Conv2d":
                    //第九层卷积运算结果
                    Width9 = (Width8 + (2 * Hid9P) - Hid9K) / Hid9S + 1;
                    Height9 = (Height8 + (2 * Hid9P) - Hid9K) / Hid9S + 1;
                    break;
                case "Pool2d":
                    //第九层池化运算结果
                    Width9 = (Width8 + (2 * Hid9P) - Hid9K) / Hid9S + 1;
                    Height9 = (Height8 + (2 * Hid9P) - Hid9K) / Hid9S + 1;
                    break;
                case "Deconv2d":
                    //第九层反卷积运算结果
                    Width9 = (Width8 - 1) * Hid9S - 2 * Hid9P + Hid9K;
                    Height9 = (Height8 - 1) * Hid9S - 2 * Hid9P + Hid9K;
                    break;
                //case "Null":
                //    //第九层无运算结果
                //    Width9 = 0;
                //    Height9 = 0;
                //    break;
            }
            textBoxHid9Width.Text = Width9.ToString();
            textBoxHid9Height.Text = Height9.ToString();
            if (str9 == "Null")
            {
                textBoxHid9Width.Clear();
                textBoxHid9Height.Clear();
            }


            //获取第十层参数
            float Hid10K = float.Parse(textBoxHid10K.Text);
            float Hid10S = float.Parse(textBoxHid10S.Text);
            float Hid10P = float.Parse(textBoxHid10P.Text);
            string str10 = comboBox10.Text;
            float Width10 = 0.00F;
            float Height10 = 0.00F;
            //第十层计算
            switch (str10)
            {
                case "Conv2d":
                    //第十层卷积运算结果
                    Width10 = (Width9 + (2 * Hid10P) - Hid10K) / Hid10S + 1;
                    Height10 = (Height9 + (2 * Hid10P) - Hid10K) / Hid10S + 1;
                    break;
                case "Pool2d":
                    //第十层池化运算结果
                    Width10 = (Width9 + (2 * Hid10P) - Hid10K) / Hid10S + 1;
                    Height10 = (Height9 + (2 * Hid10P) - Hid10K) / Hid10S + 1;
                    break;
                case "Deconv2d":
                    //第十层反卷积运算结果
                    Width10 = (Width9 - 1) * Hid10S - 2 * Hid10P + Hid10K;
                    Height10 = (Height9 - 1) * Hid10S - 2 * Hid10P + Hid10K;
                    break;
                //case "Null":
                //    //第十层无运算结果
                //    Width10 = 0;
                //    Height10 = 0;
                //    break;
            }
            textBoxHid10Width.Text = Width10.ToString();
            textBoxHid10Height.Text = Height10.ToString();
            if (str10 == "Null")
            {
                textBoxHid10Width.Clear();
                textBoxHid10Height.Clear();
            }


            //获取第十一层参数
            float Hid11K = float.Parse(textBoxHid11K.Text);
            float Hid11S = float.Parse(textBoxHid11S.Text);
            float Hid11P = float.Parse(textBoxHid11P.Text);
            string str11 = comboBox11.Text;
            float Width11 = 0.00F;
            float Height11 = 0.00F;
            //第十一层计算
            switch (str11)
            {
                case "Conv2d":
                    //第十一层卷积运算结果
                    Width11 = (Width10 + (2 * Hid11P) - Hid11K) / Hid11S + 1;
                    Height11 = (Height10 + (2 * Hid11P) - Hid11K) / Hid11S + 1;
                    break;
                case "Pool2d":
                    //第十一层池化运算结果
                    Width11 = (Width10 + (2 * Hid11P) - Hid11K) / Hid11S + 1;
                    Height11 = (Height10 + (2 * Hid11P) - Hid11K) / Hid11S + 1;
                    break;
                case "Deconv2d":
                    //第十一层反卷积运算结果
                    Width11 = (Width10 - 1) * Hid11S - 2 * Hid11P + Hid11K;
                    Height11 = (Height10 - 1) * Hid11S - 2 * Hid11P + Hid11K;
                    break;
                //case "Null":
                //    //第十一层无运算结果
                //    Width11 = 0;
                //    Height11 = 0;
                //    break;
            }
            textBoxHid11Width.Text = Width11.ToString();
            textBoxHid11Height.Text = Height11.ToString();
            if (str11 == "Null")
            {
                textBoxHid11Width.Clear();
                textBoxHid11Height.Clear();
            }


            //获取第十二层参数
            float Hid12K = float.Parse(textBoxHid12K.Text);
            float Hid12S = float.Parse(textBoxHid12S.Text);
            float Hid12P = float.Parse(textBoxHid12P.Text);
            string str12 = comboBox12.Text;
            float Width12 = 0.00F;
            float Height12 = 0.00F;
            //第十二层计算
            switch (str12)
            {
                case "Conv2d":
                    //第十二层卷积运算结果
                    Width12 = (Width11 + (2 * Hid12P) - Hid12K) / Hid12S + 1;
                    Height12 = (Height11 + (2 * Hid12P) - Hid12K) / Hid12S + 1;
                    break;
                case "Pool2d":
                    //第十二层池化运算结果
                    Width12 = (Width11 + (2 * Hid12P) - Hid12K) / Hid12S + 1;
                    Height12 = (Height11 + (2 * Hid12P) - Hid12K) / Hid12S + 1;
                    break;
                case "Deconv2d":
                    //第十二层反卷积运算结果
                    Width12 = (Width11 - 1) * Hid12S - 2 * Hid12P + Hid12K;
                    Height12 = (Height11 - 1) * Hid12S - 2 * Hid12P + Hid12K;
                    break;
                //case "Null":
                //    //第十二层无运算结果
                //    Width12 = 0;
                //    Height12 = 0;
                //    break;
            }
            textBoxHid12Width.Text = Width12.ToString();
            textBoxHid12Height.Text = Height12.ToString();
            if (str12 == "Null")
            {
                textBoxHid12Width.Clear();
                textBoxHid12Height.Clear();
            }


            //获取第十三层参数
            float Hid13K = float.Parse(textBoxHid13K.Text);
            float Hid13S = float.Parse(textBoxHid13S.Text);
            float Hid13P = float.Parse(textBoxHid13P.Text);
            string str13 = comboBox13.Text;
            float Width13 = 0.00F;
            float Height13 = 0.00F;
            //第十三层计算
            switch (str13)
            {
                case "Conv2d":
                    //第十三层卷积运算结果
                    Width13 = (Width12 + (2 * Hid13P) - Hid13K) / Hid13S + 1;
                    Height13 = (Height12 + (2 * Hid13P) - Hid13K) / Hid13S + 1;
                    break;
                case "Pool2d":
                    //第十三层池化运算结果
                    Width13 = (Width12 + (2 * Hid13P) - Hid13K) / Hid13S + 1;
                    Height13 = (Height12 + (2 * Hid13P) - Hid13K) / Hid13S + 1;
                    break;
                case "Deconv2d":
                    //第十三层反卷积运算结果
                    Width13 = (Width12 - 1) * Hid13S - 2 * Hid13P + Hid13K;
                    Height13 = (Height12 - 1) * Hid13S - 2 * Hid13P + Hid13K;
                    break;
                //case "Null":
                //    //第十三层无运算结果
                //    Width13 = 0;
                //    Height13 = 0;
                //    break;
            }
            textBoxHid13Width.Text = Width13.ToString();
            textBoxHid13Height.Text = Height13.ToString();
            if (str13 == "Null")
            {
                textBoxHid13Width.Clear();
                textBoxHid13Height.Clear();
            }


            //获取第十四层参数
            float Hid14K = float.Parse(textBoxHid14K.Text);
            float Hid14S = float.Parse(textBoxHid14S.Text);
            float Hid14P = float.Parse(textBoxHid14P.Text);
            string str14 = comboBox14.Text;
            float Width14 = 0.00F;
            float Height14 = 0.00F;
            //第十四层计算
            switch (str14)
            {
                case "Conv2d":
                    //第十四层卷积运算结果
                    Width14 = (Width13 + (2 * Hid14P) - Hid14K) / Hid14S + 1;
                    Height14 = (Height13 + (2 * Hid14P) - Hid14K) / Hid14S + 1;
                    break;
                case "Pool2d":
                    //第十四层池化运算结果
                    Width14 = (Width13 + (2 * Hid14P) - Hid14K) / Hid14S + 1;
                    Height14 = (Height13 + (2 * Hid14P) - Hid14K) / Hid14S + 1;
                    break;
                case "Deconv2d":
                    //第十四层反卷积运算结果
                    Width14 = (Width13 - 1) * Hid14S - 2 * Hid14P + Hid14K;
                    Height14 = (Height13 - 1) * Hid14S - 2 * Hid14P + Hid14K;
                    break;
                //case "Null":
                //    //第十四层无运算结果
                //    Width14 = 0;
                //    Height14 = 0;
                //    break;
            }
            textBoxHid14Width.Text = Width14.ToString();
            textBoxHid14Height.Text = Height14.ToString();
            if (str14 == "Null")
            {
                textBoxHid14Width.Clear();
                textBoxHid14Height.Clear();
            }


            //获取第十五层参数
            float Hid15K = float.Parse(textBoxHid15K.Text);
            float Hid15S = float.Parse(textBoxHid15S.Text);
            float Hid15P = float.Parse(textBoxHid15P.Text);
            string str15 = comboBox15.Text;
            float Width15 = 0.00F;
            float Height15 = 0.00F;
            //第十五层计算
            switch (str15)
            {
                case "Conv2d":
                    //第十五层卷积运算结果
                    Width15 = (Width14 + (2 * Hid15P) - Hid15K) / Hid15S + 1;
                    Height15 = (Height14 + (2 * Hid15P) - Hid15K) / Hid15S + 1;
                    break;
                case "Pool2d":
                    //第十五层池化运算结果
                    Width15 = (Width14 + (2 * Hid15P) - Hid15K) / Hid15S + 1;
                    Height15 = (Height14 + (2 * Hid15P) - Hid15K) / Hid15S + 1;
                    break;
                case "Deconv2d":
                    //第十五层反卷积运算结果
                    Width15 = (Width14 - 1) * Hid15S - 2 * Hid15P + Hid15K;
                    Height15 = (Height14 - 1) * Hid15S - 2 * Hid15P + Hid15K;
                    break;
                //case "Null":
                //    //第十五层无运算结果
                //    Width15 = 0;
                //    Height15 = 0;
                //    break;
            }
            textBoxHid15Width.Text = Width15.ToString();
            textBoxHid15Height.Text = Height15.ToString();
            if (str15 == "Null")
            {
                textBoxHid15Width.Clear();
                textBoxHid15Height.Clear();
            }


            //获取第十六层参数
            float Hid16K = float.Parse(textBoxHid16K.Text);
            float Hid16S = float.Parse(textBoxHid16S.Text);
            float Hid16P = float.Parse(textBoxHid16P.Text);
            string str16 = comboBox16.Text;
            float Width16 = 0.00F;
            float Height16 = 0.00F;
            //第十六层计算
            switch (str16)
            {
                case "Conv2d":
                    //第十六层卷积运算结果
                    Width16 = (Width15 + (2 * Hid16P) - Hid16K) / Hid16S + 1;
                    Height16 = (Height15 + (2 * Hid16P) - Hid16K) / Hid16S + 1;
                    break;
                case "Pool2d":
                    //第十六层池化运算结果
                    Width16 = (Width15 + (2 * Hid16P) - Hid16K) / Hid16S + 1;
                    Height16 = (Height15 + (2 * Hid16P) - Hid16K) / Hid16S + 1;
                    break;
                case "Deconv2d":
                    //第十六层反卷积运算结果
                    Width16 = (Width15 - 1) * Hid16S - 2 * Hid16P + Hid16K;
                    Height16 = (Height15 - 1) * Hid16S - 2 * Hid16P + Hid16K;
                    break;
                //case "Null":
                //    //第十六层无运算结果
                //    Width16 = 0;
                //    Height16 = 0;
                //    break;
            }
            textBoxHid16Width.Text = Width16.ToString();
            textBoxHid16Height.Text = Height16.ToString();
            if (str16 == "Null")
            {
                textBoxHid16Width.Clear();
                textBoxHid16Height.Clear();
            }

        }

    }
}
