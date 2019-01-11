using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        //類別層級變數,class variables
        int 杯數1 = 0, 杯數2 = 0, 杯數3 = 0, 杯數4 = 0, 杯數5 = 0;//中間以,串接~以;結尾
        double 售價1 = 0.0, 售價2 = 0.0, 售價3 = 0.0, 售價4 = 0.0, 售價5 = 0.0;
        double 品項1總價 = 0.0, 品項2總價 = 0.0, 品項3總價 = 0.0, 品項4總價 = 0.0, 品項5總價 = 0.0;
        double 折數 = 0.0;
        double 總價 = 0.0;
        double 折扣後總價 = 0.0;
        double 六折後總價 = 0.0;                
        double[] array售價;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl品名1.Text = "麥香紅茶";
            lbl品名2.Text = "茉香綠茶";
            lbl品名3.Text = "珍珠奶茶";
            lbl品名4.Text = "玫瑰花茶";
            lbl品名5.Text = "現打西瓜汁";

            售價1 = 35.0;
            售價2 = 40.0;
            售價3 = 45.0;
            售價4 = 50.0;
            售價5 = 55.0;

            lbl售價1.Text = 售價1.ToString();
            lbl售價2.Text = 售價2.ToString();
            lbl售價3.Text = 售價3.ToString();
            lbl售價4.Text = 售價4.ToString();
            lbl售價5.Text = 售價5.ToString();

            折數 = 10.0;

            array售價 = new double[] { Convert.ToInt32(lbl售價1. Text), Convert. ToInt32(lbl售價2. Text),
                Convert. ToInt32(lbl售價3. Text) , Convert. ToInt32(lbl售價4. Text) , Convert. ToInt32(lbl售價5. Text) };


        }

        private void btn杯數1減_Click(object sender, EventArgs e)
        {
            杯數1 -= 1;
            if (杯數1<=0)
            {
                杯數1 = 0;
                btn杯數1減.Enabled = false;//杯數=0時-按鈕失效
            }
            //杯數1 -= 1;
            btn杯數1加.Enabled = true;          
            tb杯數1.Text = 杯數1.ToString();
        }
        
        private void btn杯數1加_Click(object sender, EventArgs e)
        {
            杯數1 += 1;
            btn杯數1減.Enabled = true;//杯數=1時-按鈕可用

            if (杯數1 >= 99)
            {
                杯數1 = 99;//要加上此列，數字才會只顯示到99且加符號失效
                btn杯數1加.Enabled = false;
            }
            tb杯數1.Text = 杯數1.ToString();

        }

        private void tb杯數1_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數1.Text!="")//輸入正確
            {
                bool ifNum = System.Int32.TryParse(tb杯數1.Text, out 杯數1);
                //第三種狀況<0後手動keyin,-號不會失效
                if ((ifNum==true)&&(杯數1>=0))
                {
                    //ifNum有值回傳true,開啟-號
                    btn杯數1減.Enabled = true;
                }
            }else//輸入不正確
            {
                MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                杯數1 = 0;
                tb杯數1.Text = "0";
            }
            計算總價();//呼叫計算總價

        }

        private void btn杯數2減_Click(object sender, EventArgs e)
        {
            杯數2 -= 1;
            if (杯數2 <= 0)
            {
                杯數2 = 0;

                btn杯數2減.Enabled = false;//杯數=0時-按鈕失效
            }
            btn杯數2加.Enabled = true;
            tb杯數2.Text = 杯數2.ToString();
        }

        private void btn杯數2加_Click(object sender, EventArgs e)
        {
            杯數2 += 1;
            btn杯數2減.Enabled = true;//杯數=1時-按鈕可用

            if (杯數2 >= 99)
            {
                杯數2 = 99;
                btn杯數2加.Enabled = false;                
            }

            tb杯數2.Text = 杯數2.ToString();
        }

        private void tb杯數2_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數2.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數2.Text, out 杯數2);

                if ((ifNum == true) && (杯數2 >= 0))
                {
                    //輸入正確
                    btn杯數2減.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                杯數2 = 0;
                tb杯數2.Text = "0";
            }
            計算總價();//呼叫計算總價
        }
              
        private void btn杯數3減_Click(object sender, EventArgs e)
        {
            杯數3 -= 1;
            if (杯數3 <= 0)
            {
                杯數3 = 0;

                btn杯數3減.Enabled = false;
            }
            btn杯數3加.Enabled = true;
            tb杯數3.Text = 杯數3.ToString();
        }

        private void btn杯數3加_Click(object sender, EventArgs e)
        {
            杯數3 += 1;
            btn杯數3減.Enabled = true;//杯數=1時-按鈕可用

            if (杯數3 >= 99)
            {
                杯數3 = 99;
                btn杯數3加.Enabled = false;
            }

            tb杯數3.Text = 杯數3.ToString();
        }
        private void tb杯數3_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數3.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數3.Text, out 杯數3);

                if ((ifNum == true) && (杯數3 >= 0))
                {
                    //輸入正確
                    btn杯數3減.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                杯數3 = 0;
                tb杯數3.Text = "0";
            }
            計算總價();//呼叫計算總價
        }

        private void btn杯數4減_Click(object sender, EventArgs e)
        {
            杯數4 -= 1;
            if (杯數4 <= 0)
            {
                杯數4 = 0;

                btn杯數4減.Enabled = false;
            }
            btn杯數4加.Enabled = true;
            tb杯數4.Text = 杯數4.ToString();
        }

        private void btn杯數4加_Click(object sender, EventArgs e)
        {
            杯數4 += 1;
            btn杯數4減.Enabled = true;

            if (杯數4 >= 99)
            {
                杯數4 = 99;
                btn杯數4加.Enabled = false;
            }

            tb杯數4.Text = 杯數4.ToString();
        }
        private void tb杯數4_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數4.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數4.Text, out 杯數4);

                if ((ifNum == true) && (杯數4 >= 0))
                {
                    //輸入正確
                    btn杯數4減.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                杯數4 = 0;
                tb杯數4.Text = "0";
            }
        }

        private void btn杯數5減_Click(object sender, EventArgs e)
        {
            杯數5 -= 1;
            if (杯數5 <= 0)
            {
                杯數5 = 0;

                btn杯數5減.Enabled = false;
            }
            btn杯數5加.Enabled = true;
            tb杯數5.Text = 杯數5.ToString();
        }

        private void btn杯數5加_Click(object sender, EventArgs e)
        {
            杯數5 += 1;
            btn杯數5減.Enabled = true;

            if (杯數5 >= 99)
            {
                杯數5 = 99;
                btn杯數5加.Enabled = false;
            }

            tb杯數5.Text = 杯數5.ToString();
        }
        private void tb杯數5_TextChanged(object sender, EventArgs e)
        {
            if (tb杯數5.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tb杯數5.Text, out 杯數5);

                if ((ifNum == true) && (杯數5 >= 0))
                {
                    //輸入正確
                    btn杯數5減.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                杯數5 = 0;
                tb杯數5.Text = "0";
            }
            計算總價();//呼叫計算總價
        }

        private void btn第二件六折_Click(object sender, EventArgs e)
        {
            if ((杯數1 > 2) || (杯數2 >2) || (杯數3 > 2) || (杯數4 > 2) || (杯數5 > 2))
            {
                第二件六折總價();
                
                DialogResult drResult;//表單在當做對話方塊使用時的結果
                drResult = MessageBox.Show("您確認送出訂購單?", "訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (drResult == DialogResult.No)
                {
                    //取消送出
                }
                else
                {
                    //確認訂單
                    string strOrder = "******iii冷飲店訂購單******\n";
                    strOrder += "----------------------------\n";//--號表排版
                    if (杯數1 > 0)
                    {
                        strOrder += lbl品名1.Text + ":" + lbl售價1.Text + "x" + tb杯數1.Text + "=" + 品項1總價.ToString() + "\n";
                    }

                    if (杯數2 > 0)
                    {
                        strOrder += lbl品名2.Text + ":" + lbl售價2.Text + "x" + tb杯數2.Text + "=" + 品項2總價.ToString() + "\n";
                    }

                    if (杯數3 > 0)
                    {
                        strOrder += lbl品名3.Text + ":" + lbl售價3.Text + "x" + tb杯數3.Text + "=" + 品項3總價.ToString() + "\n";
                    }

                    if (杯數4 > 0)
                    {
                        strOrder += lbl品名4.Text + ":" + lbl售價4.Text + "x" + tb杯數4.Text + "=" + 品項4總價.ToString() + "\n";
                    }

                    if (杯數5 > 0)
                    {
                        strOrder += lbl品名5.Text + ":" + lbl售價5.Text + "x" + tb杯數5.Text + "=" + 品項5總價.ToString() + "\n";
                    }
                    strOrder += "----------------------------\n";
                    if (折數 < 10.0)
                    {
                        strOrder += "第二件六折" + string.Format("{0:F2}", 六折後總價) + "\n";
                    }
                    strOrder += "訂單總價" + string.Format("{0:C}", 總價) + "\n";
                    strOrder += "折扣後總價" + string.Format("{0:C}", 六折後總價) + "\n";
                    strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                    strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                    MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);


                    strOrder += "----------------------------\n";

                }
            }
                
                
               
        }

        private void btn買三送一_Click(object sender, EventArgs e)
        {
            int[] array杯數;
            array杯數 = new int[5];
            array杯數[0] = 杯數1;
            array杯數[1] = 杯數2;
            array杯數[2] = 杯數3;
            array杯數[3] = 杯數4;
            array杯數[4] = 杯數5;

            double[] array售價;
            array售價 = new double[5];
            array售價[0] = 售價1;
            array售價[1] = 售價2;
            array售價[2] = 售價3;
            array售價[3] = 售價4;
            array售價[4] = 售價5;

            int 總杯數 = 杯數1+ 杯數2+ 杯數3+ 杯數4+ 杯數5;
            int x = 總杯數 / 4;//贈送杯數
            int 選擇1, 選擇2, 選擇3;//三種品項選擇
            for (選擇1 = 0; 選擇1 < 5; 選擇1++)
                for (選擇2 = 0; 選擇2 < 5; 選擇2++)
                    for (選擇3 = 0; 選擇3 < 5; 選擇3++)

                        if (((array杯數[選擇1] >= 1) && (array杯數[選擇2] >= 1) && (array杯數[選擇3] >= 1)) && ((選擇1 != 選擇2) && (選擇2 != 選擇3) && (選擇1 != 選擇3)))
                        {
                            if (x >= 1)
                            {
                                for (int i = 0; i < 5; i++)
                                {
                                    x = x - array杯數[i];
                                    if (x >= 0)
                                    {
                                        array杯數[i] = 0;
                                    }
                                    else
                                    {
                                        array杯數[i] = -x;
                                        break;
                                    }
                                }
                            }
                        }


            折扣後總價 = 0;
            for (int i = 0; i < 5; i++)
                折扣後總價 += array杯數[i] * array售價[i];
            lbl折扣後總價.Text = string.Format("{0:C}", 折扣後總價);
            if (總價 == 折扣後總價)
            {
                MessageBox.Show("不適用買三送一優惠");
            }

        }

        private void tb折數_TextChanged(object sender, EventArgs e)
        {
            if (tb折數.Text!="")
            {
                bool ifNum = System.Double.TryParse(tb折數.Text, out 折數);

                if(ifNum==true)
                {
                    if ((折數 >= 0.0) && (折數 <= 10.0))
                    {
                        //合理折數
                    }
                    else
                    {
                        MessageBox.Show("折數輸入錯誤(0.0-10.0");
                        tb折數.Text = "";
                        折數 = 10.0;//限制合理折數
                    }
                }
                else
                {
                    MessageBox.Show("折數輸入錯誤(0.0-10.0");
                    tb折數.Text = "";
                    折數 = 10.0;//限制合理折數
                }
            }
            else
            {
                折數 = 10.0;
            }
            計算總價();//呼叫計算總價
        }

        private void btn列印訂購單_Click(object sender, EventArgs e)
        {
            DialogResult drResult;//代表表單在當做對話方塊使用時的結果
            drResult = MessageBox.Show("您確認送出訂購單?", "訂單確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(drResult==DialogResult.No)
            {
                //取消送出
            }
            else
            {
                //確認訂單
                string strOrder = "******iii冷飲店訂購單******\n";
                strOrder += "----------------------------\n";//--號表排版
                if (杯數1 > 0)
                {
                    strOrder += lbl品名1.Text + ":" + lbl售價1.Text + "x" + tb杯數1.Text + "=" + 品項1總價.ToString() + "\n";
                }

                if (杯數2 > 0)
                {
                    strOrder += lbl品名2.Text + ":" + lbl售價2.Text + "x" + tb杯數2.Text + "=" + 品項2總價.ToString() + "\n";
                }

                if (杯數3 > 0)
                {
                    strOrder += lbl品名3.Text + ":" + lbl售價3.Text + "x" + tb杯數3.Text + "=" + 品項3總價.ToString() + "\n";
                }

                if (杯數4 > 0)
                {
                    strOrder += lbl品名4.Text + ":" + lbl售價4.Text + "x" + tb杯數4.Text + "=" + 品項4總價.ToString() + "\n";
                }

                if (杯數5 > 0)
                {
                    strOrder += lbl品名5.Text + ":" + lbl售價5.Text + "x" + tb杯數5.Text + "=" + 品項5總價.ToString() + "\n";
                }
                strOrder += "----------------------------\n";
                if (折數 < 10.0)
                {
                    strOrder += "折數" + string.Format("{0:F2}", 折數) + "\n";
                }
                strOrder += "訂單總價" + string.Format("{0:C}", 總價) + "\n";
                strOrder += "折扣後總價" + string.Format("{0:C}", 折扣後總價) + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);

                
                strOrder += "----------------------------\n";
                
            }
        }
        //計算總價方法
        void 計算總價()//類別變數沒有順序,是用事件驅動, void 表沒有回傳值,()表沒有傳入的參數
        {
            品項1總價 = 售價1 * 杯數1;
            品項2總價 = 售價2 * 杯數2;
            品項3總價 = 售價3 * 杯數3;
            品項4總價 = 售價4 * 杯數4;
            品項5總價 = 售價5 * 杯數5;

            總價 = 品項1總價 + 品項2總價 + 品項3總價 + 品項4總價 + 品項5總價;
            折扣後總價 = 總價 * 折數 / 10.0;

            lbl訂單總價.Text = string.Format("{0:C}", 總價);
            lbl折扣後總價.Text = string.Format("{0:C}", 折扣後總價);

        }
        void 第二件六折總價()
        {
            品項1總價 = (杯數1 - (杯數1 / 2))* 售價1 + (杯數1 / 2) * 0.6 * 售價1;
            品項2總價 = (杯數2 - (杯數2 / 2)) * 售價2 + (杯數2 / 2) * 0.6 * 售價2;
            品項3總價 = (杯數3 - (杯數3 / 2)) * 售價3 + (杯數3 / 2) * 0.6 * 售價3;
            品項4總價 = (杯數4 - (杯數4 / 2)) * 售價4 + (杯數4 / 2) * 0.6 * 售價4;
            品項5總價 = (杯數5 - (杯數5 / 2)) * 售價5 + (杯數5 / 2) * 0.6 * 售價5;

            
            六折後總價 = 品項1總價 + 品項2總價 + 品項3總價 + 品項4總價 + 品項5總價;

            lbl訂單總價.Text = string.Format("{0:C}",總價);
            lbl折扣後總價.Text = string.Format("{0:C}", 六折後總價);
            
        }
        
    }
}
