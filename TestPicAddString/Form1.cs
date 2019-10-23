using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestPicAddString
{
    public partial class Form1 : Form

    {
        private Image NewPic;
        Image Oldpic = Image.FromFile("./Images/Old.jpg");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowOld_Click(object sender, EventArgs e)
        {
            Oldpic = Image.FromFile("./Images/Old.jpg");

            pbxShowPic.BackgroundImage = Oldpic;
            pbxShowPic.BackgroundImageLayout = ImageLayout.Stretch;

           

        } 
        private void btnAddString_Click(object sender, EventArgs e)
        {
            colorbuf = 255;
            cuowei = 0;
            string[] strbuf = rtbxStringBuf.Lines;

            int MaxLen = 0;//半字的个数
            foreach (var stringbuf in strbuf)
            {
                char[] xx = stringbuf.ToCharArray();

                int lenbuf = xx.Length;

                //判断是否是汉字，汉字显示是字母数字的一半
                foreach (char wordBuf in xx)
                {
                    if (wordBuf > 0xff)
                    {
                        lenbuf++;
                    }
                }
                MaxLen = MaxLen > lenbuf ? MaxLen : lenbuf;

            }


            if (MaxLen == 0) return;
            int picWidth = Oldpic.Width;

            int pX= int.Parse(tbxX.Text);
            int pY= int.Parse(tbxY.Text);
            float sizePerWidth = float.Parse(tbxSize.Text);
            Point StartPointBuf = new Point(pX, pY);
            double showWidth = ((picWidth - StartPointBuf.X) * sizePerWidth);//显示一半
            float fontSizePix = (float)(showWidth / (MaxLen + 1));//尾部流出半字的空间


            float halfWordWidth = fontSizePix;
            float WordWidth = halfWordWidth * 2;



            using (Font f = new Font("黑体", WordWidth, FontStyle.Bold, GraphicsUnit.Pixel))

            {
                Graphics g = Graphics.FromImage(Oldpic);
                g.DrawImage(Oldpic, 0, 0, Oldpic.Width, Oldpic.Height);
                float idx = 0;
                int idy = 0;
                foreach (var stringbuf in rtbxStringBuf.Lines)
                {
                    idx = 0;
                    char[] xx = stringbuf.ToCharArray();
                    string xxstr = xx.ToString();
                    foreach (char wordBuf in xx)
                    {
                        int ret = 0;
                        float idxbuf = idx;
                        if (wordBuf > 0xff)//汉字
                        {
                            SizeF sbuf = new SizeF(WordWidth * 1.0f, WordWidth);
                            
                            ret = GetPicAvgRGBAtPoint(Oldpic,
                                new Point(StartPointBuf.X + (int)Math.Round(halfWordWidth * 0.3f) + (int)(idx * halfWordWidth),
                                    StartPointBuf.Y + (int)(idy * WordWidth)), sbuf);
                                    
                            idxbuf += 2f;
                        }
                        else
                        {
                            SizeF sbuf = new SizeF(halfWordWidth * 1.0f, WordWidth);
                            
                            ret = GetPicAvgRGBAtPoint(Oldpic,
                                new Point(StartPointBuf.X + (int)Math.Round(halfWordWidth * 0.3f) + (int)(idx * halfWordWidth),
                                    StartPointBuf.Y + (int)(idy * WordWidth)), sbuf);
                                    
                            idxbuf += 1.0f;
                        }
                        Brush b;
                        if (ret == 0)//黑色背景
                        {
                            b = new SolidBrush(Color.White);

                        }
                        else
                        {
                            b = new SolidBrush(Color.Black);

                        }

                        string addText = wordBuf.ToString();
                        g.DrawString(addText, f, b, StartPointBuf.X + (int)(idx * halfWordWidth),
                            StartPointBuf.Y + (int)(idy * WordWidth));


                        idx = idxbuf;


                    }




                    idy++;
                }


                string strbufx = DateTime.Now.Ticks.ToString();


                Oldpic.Save(("./Images/New" + strbufx + ".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                NewPic = Image.FromFile("./Images/New" + strbufx + ".jpg");

                pbxShowPic.BackgroundImage = NewPic;
            }

        }



        int colorbuf = 200;
        int cuowei = 0;
        //返回值：0，黑背景，1：白背景
        int GetPicAvgRGBAtPoint(Image ibuf, Point stratPoint, SizeF Size)
        {
            colorbuf = (colorbuf == 200) ? 180 : 200;
            //cuowei = (cuowei==0) ? 5:0;
            Bitmap newmap = new Bitmap(ibuf);
            Color pixel;//颜色匹对
            int width = ibuf.Width;//获取图片宽度
            int height = ibuf.Height;//获取图片高度
            double brightnessSum = 0;
            int brightnessCnt = 0;
            int andianCnt = 0;
            int mingdianCnt = 0;
            for (int i = stratPoint.X; i < stratPoint.X + Size.Width; )
            {
                for (int j = stratPoint.Y + cuowei; j < stratPoint.Y + cuowei + Size.Height; )
                {
                    if (i + 1 > width || j + 1 > height)
                        break;
                    pixel = newmap.GetPixel(i, j); //获取旧图片的颜色值（ARGB存储方式）  

                    //Color nc = Color.FromArgb(45, 45, 66);
                    //pixel = nc;

                    //float bb =Math.Max(pixel.R, Math.Max(pixel.G, pixel.B));
                    //float picHSB_B = (float)(bb/255.0); //这个是HSB/HSV 白色的程度

                    //float Graybuf = (float)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);

                    float Graybuf = 1 - (float)((0.30 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B) / 255f);

                    //newmap.SetPixel(i, j, Color.FromArgb(colorbuf, colorbuf, colorbuf));
                    //float b = pixel.GetBrightness(); //这个是HSL  亮色的程度  
                    //Console.WriteLine(picHSB_B.ToString() + "-");

                    //bri 
                    brightnessSum += Graybuf;  //HSB中的B

                    brightnessCnt++;

                    if (Graybuf > (0.5))
                    {
                        andianCnt++;
                    }
                    else
                    {
                        mingdianCnt++;
                    }
                    j += 1;
                }
                i += 1;
            }

            //oimage = newmap;
#if false

            //采用Count
            float andianPerAll = ((float)(andianCnt) )/ (andianCnt + mingdianCnt);

            Console.WriteLine(string.Format("andianCnt:{0:F2}-mingdianCnt:{0:F2}-andianPerAll:{0:F2}-", andianCnt, mingdianCnt, andianPerAll));

            if (andianPerAll > (0.7))
            {
              
                return 0; //背景为黑
            }
            else
            {
                return 1; //背景为白
            }

#else

            //采用平均
            //灰度值 0.0为白，1.0为黑
            double avggray = brightnessSum / brightnessCnt;

            //Console.WriteLine(string.Format("{0:F2}-", avggray));

            if (avggray > (0.5))
            {

                return 0; //背景为黑
            }
            else
            {
                return 1; //背景为白
            }


#endif
        }


      
        public float[] hsb2rgb(float[] hsb)
        {
            float[] rgb = new float[3];
            //先令饱和度和亮度为100%，调节色相h
            for (int offset = 240, i = 0; i < 3; i++, offset -= 120)
            {
                //算出色相h的值和三个区域中心点(即0°，120°和240°)相差多少，然后根据坐标图按分段函数算出rgb。但因为色环展开后，红色区域的中心点是0°同时也是360°，不好算，索性将三个区域的中心点都向右平移到240°再计算比较方便
                float x = Math.Abs((hsb[0] + offset) % 360 - 240);
                //如果相差小于60°则为255
                if (x <= 60) rgb[i] = 255;
                //如果相差在60°和120°之间，
                else if (60 < x && x < 120) rgb[i] = ((1 - (x - 60) / 60) * 255);
                //如果相差大于120°则为0
                else rgb[i] = 0;
            }
            //在调节饱和度s
            for (int i = 0; i < 3; i++)
                rgb[i] += (255 - rgb[i]) * (1 - hsb[1]);
            //最后调节亮度b
            for (int i = 0; i < 3; i++)
                rgb[i] *= hsb[2];
            return rgb;
        }

        public float[] rgb2hsb(float[] rgb)
        {
            float[] hsb = new float[3];
            float[] rearranged = (float[])rgb.Clone();
            int maxIndex = 0, minIndex = 0;
            float tmp;
            //将rgb的值从小到大排列，存在rearranged数组里
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2 - i; j++)
                    if (rearranged[j] > rearranged[j + 1])
                    {
                        tmp = rearranged[j + 1];
                        rearranged[j + 1] = rearranged[j];
                        rearranged[j] = tmp;
                    }
            }
            //rgb的下标分别为0、1、2，maxIndex和minIndex用于存储rgb中最大最小值的下标
            for (int i = 0; i < 3; i++)
            {
                if (rearranged[0] == rgb[i]) minIndex = i;
                if (rearranged[2] == rgb[i]) maxIndex = i;
            }
            //算出亮度
            hsb[2] = rearranged[2] / 255.0f;
            //算出饱和度
            hsb[1] = 1 - rearranged[0] / rearranged[2];
            //算出色相
            hsb[0] = maxIndex * 120 + 60 * (rearranged[1] / hsb[1] / rearranged[2] + (1 - 1 / hsb[1])) * ((maxIndex - minIndex + 3) % 3 == 1 ? 1 : -1);
            //防止色相为负值
            hsb[0] = (hsb[0] + 360) % 360;
            return hsb;
        }
        private void rtbxStringBuf_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
