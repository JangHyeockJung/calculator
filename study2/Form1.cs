﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2
{
    public partial class Form1 : Form
    {
        string s = "0";       // 텍스트 박스 문자열
        char c = '+'; // 부호 표시
        float temp = 0; //계산 전 임시 저장 
        float result = 0; // 계산 결과
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = s; // 입력 영역 0 표시
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") // 입력 영역 0인 경우 1 입력 시 
            {
                s = "1";
            }
            else 
            {
                s = s + "1";
            }
            textBox1.Text = s; // 입력 영역 0이 아닌 경우 1 입력 시
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "2";
            }
            else
            {
                s = s + "2";
            }
            textBox1.Text = s;
            return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "3";
            }
            else
            {
                s = s + "3";
            }
            textBox1.Text = s;
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "4";
            }
            else
            {
                s = s + "4";
            }
            textBox1.Text = s;
            return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "5";
            }
            else
            {
                s = s + "5";
            }
            textBox1.Text = s;
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "6";
            }
            else
            {
                s = s + "6";
            }
            textBox1.Text = s;
            return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "7";
            }
            else
            {
                s = s + "7";
            }
            textBox1.Text = s;
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "8";
            }
            else
            {
                s = s + "8";
            }
            textBox1.Text = s;
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "9";
            }
            else
            {
                s = s + "9";
            }
            textBox1.Text = s;
            return;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                s = "0";
            }
            else
            {
                s = s + "0";
            }
            textBox1.Text = s;
            return;
        }

        private void button3_Click(object sender, EventArgs e) // 'C' 버튼 클릭 시 초기화
        {
            s = "0";
            textBox1.Text = s;
            temp = 0;
            result = 0;
            label1.Text = "0";
            return;
        }

        private void button13_Click(object sender, EventArgs e) // 백스페이스, 마지막 입력 지우기
        {
            if (s.Length > 1)
            {
                s = s.Remove(s.Length - 1);
                
            }
            else
            {
                s = "0";
            }
            textBox1.Text = s;
            return;
        }

        private void button14_Click(object sender, EventArgs e) // +
        {
            if (temp == 0)
            {
                temp = float.Parse(textBox1.Text);
                s = "0";
                textBox1.Text = s;
                c = '+';
                label1.Text = temp.ToString() + "+";
            }
            else 
            {
                s = "0";
                textBox1.Text = s;
                c = '+';
                label1.Text = temp.ToString() + "+";
            }
            
        }

        private void button18_Click(object sender, EventArgs e) // =
        {
            if (c == '+')
            {
                result = temp + float.Parse(textBox1.Text);
                textBox1.Text = result.ToString();
                temp = result;
                c = ' ';
                label1.Text = temp.ToString() + " ";
                return;
            }
            else if (c == '-')
            {
                result = temp - float.Parse(textBox1.Text);
                textBox1.Text = result.ToString();
                temp = result;
                c = ' ';
                label1.Text = temp.ToString() + " ";
                return;
            }
            else if (c == '*')
            {
                result = temp * float.Parse(textBox1.Text);
                textBox1.Text = result.ToString();
                temp = result;
                c = ' ';
                label1.Text = temp.ToString() + " ";
                return;
            }
            else if (c == '/')
            {
                result = temp / float.Parse(textBox1.Text);
                textBox1.Text = result.ToString();
                temp = result;
                c = ' ';
                label1.Text = temp.ToString() + " ";
                return;
            }
        }

        private void button15_Click(object sender, EventArgs e) // -
        {
            if (temp == 0)
            {
                temp = float.Parse(textBox1.Text);
                s = "0";
                textBox1.Text = s;
                c = '-';
                label1.Text = temp.ToString() + "-";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '-';
                label1.Text = temp.ToString() + "-";
            }
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            if (temp == 0)
            {
                temp = float.Parse(textBox1.Text);
                s = "0";
                textBox1.Text = s;
                c = '*';
                label1.Text = temp.ToString() + "*";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '*';
                label1.Text = temp.ToString() + "*";
            }
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            if (temp == 0)
            {
                temp = float.Parse(textBox1.Text);
                s = "0";
                textBox1.Text = s;
                c = '/';
                label1.Text = temp.ToString() + "/";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '/';
                label1.Text = temp.ToString() + "/";
            }
        }

        private void button1_Click(object sender, EventArgs e) // 음수 양수 전환
        {
            temp = float.Parse(textBox1.Text);
            
            if (temp == 0)
            {
                return;
            }
            else if (temp < 0)
            {
                s = "0";
                textBox1.Text = s;
                temp = -temp;
                label1.Text = temp.ToString();
            }
            else if (temp > 0) 
            {
                s = "0";
                textBox1.Text = s;
                temp = -temp;
                label1.Text = temp.ToString();
            }
        }
    }
}
