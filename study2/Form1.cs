using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//키보드 입력, 텍스트 박스 미사용 - 라벨 O
//점 2개 오류 - 팝업 O
//천 단위 구분자 - %3

namespace study2
{
    public partial class Form1 : Form
    {
        string s = "0";       // 텍스트 박스 문자열
        char c = '+'; // 부호 표시
        string temp = "0"; //계산 전 임시 저장 
        float result = 0; // 계산 결과
        float f = 0; //스트링 숫자 변환
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = s; // 입력 영역 0 표시
            this.ActiveControl = button18;
            
        }
        public void btn1() 
        {
            if (textBox1.Text == "0") // 입력 영역 0인 경우 1 입력 시 
            {
                s = "1";
                textBox1.Text = s;
            }
            else
            {   
                s += "1";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###"); // 입력 영역 0이 아닌 경우 1 입력 시
            }
            
            this.ActiveControl = button18;
        }
        public void btn2() //2
        {
            if (textBox1.Text == "0")
            {
                s = "2";
                textBox1.Text = s;
            }
            else
            {
                s = s + "2";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            this.ActiveControl = button18;
        }
        public void btn3() //3
        {
            if (textBox1.Text == "0")
            {
                s = "3";
                textBox1.Text = s;
            }
            else
            {
                s = s + "3";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn4() //4 
        {
            if (textBox1.Text == "0")
            {
                s = "4";
                textBox1.Text = s;
            }
            else
            {
                s = s + "4";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn5() //5
        {
            if (textBox1.Text == "0")
            {
                s = "5";
                textBox1.Text = s;
            }
            else
            {
                s = s + "5";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn6() //6
        {
            if (textBox1.Text == "0")
            {
                s = "6";
                textBox1.Text = s;
            }
            else
            {
                s = s + "6";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn7() //7
        {
            if (textBox1.Text == "0")
            {
                s = "7";
                textBox1.Text = s;
            }
            else
            {
                s = s + "7";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn8() //8
        {
            if (textBox1.Text == "0")
            {
                s = "8";
                textBox1.Text = s;
            }
            else
            {
                s = s + "8";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn9() //9
        {
            if (textBox1.Text == "0")
            {
                s = "9";
                textBox1.Text = s;
            }
            else
            {
                s = s + "9";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btn0() //0
        {
            if (textBox1.Text == "0")
            {
                s = "0";
                textBox1.Text = s;
            }
            else
            {
                s = s + "0";
                f = float.Parse(s);
                textBox1.Text = f.ToString("#,##0.###");
            }
            
            this.ActiveControl = button18;
        }
        public void btnESC() //C
        {
            s = "0";
            textBox1.Text = s;
            temp = "0";
            result = 0;
            label1.Text = "0";
            this.ActiveControl = button18;
        }
        public void btnBack() //<-
        {
            if (s.Length > 1)
            {
                s = s.Remove(s.Length - 1);

            }
            else
            {
                s = "0";
            }
            f = float.Parse(s);
            textBox1.Text = f.ToString("#,##0.###");
            this.ActiveControl = button18;
        }
        public void btnAdd() //+
        {
            if (temp == "0")
            {
                f = float.Parse(textBox1.Text);
                temp = f.ToString("#,##0.###");
                s = "0";
                textBox1.Text = s;
                c = '+';
                label1.Text = temp + "+";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '+';
                label1.Text = temp + "+";
            }
            this.ActiveControl = button18;
        }
        public void btnSubtract() //-
        {
            if (temp == "0")
            {
                f = float.Parse(textBox1.Text);
                temp = f.ToString("#,##0.###");
                s = "0";
                textBox1.Text = s;
                c = '-';
                label1.Text = temp + "-";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '-';
                label1.Text = temp + "-";
            }
            this.ActiveControl = button18;
        }
        public void btnMultiply() //*
        {
            if (temp == "0")
            {
                f = float.Parse(textBox1.Text);
                temp = f.ToString("#,##0.###");
                s = "0";
                textBox1.Text = s;
                c = '*';
                label1.Text = temp + "*";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '*';
                label1.Text = temp + "*";
            }
            this.ActiveControl = button18;
        }
        public void btnDivide() // /
        {
            if (temp == "0")
            {
                f = float.Parse(textBox1.Text);
                temp = f.ToString("#,##0.###");
                s = "0";
                textBox1.Text = s;
                c = '/';
                label1.Text = temp + "/";
            }
            else
            {
                s = "0";
                textBox1.Text = s;
                c = '/';
                label1.Text = temp + "/";
            }
            this.ActiveControl = button18;
        }
        public void btnEqual() //=
        {
            if (c == '+')
            {
                result = float.Parse(temp) + float.Parse(textBox1.Text);
                textBox1.Text = "0";
                temp = result.ToString("#,##0.###");
                c = ' ';
                label1.Text = temp;
            }
            else if (c == '-')
            {
                result = float.Parse(temp) - float.Parse(textBox1.Text);
                textBox1.Text = "0";
                temp = result.ToString("#,##0.###");
                c = ' ';
                label1.Text = temp;
            }
            else if (c == '*')
            {
                result = float.Parse(temp) * float.Parse(textBox1.Text);
                textBox1.Text = "0";
                temp = result.ToString("#,##0.###");
                c = ' ';
                label1.Text = temp;
            }
            else if (c == '/')
            {
                result = float.Parse(temp) / float.Parse(textBox1.Text);
                textBox1.Text = "0";
                temp = result.ToString("#,##0.###");
                c = ' ';
                label1.Text = temp;
            }
            s = "0";
            this.ActiveControl = button18;
        }
        public void btnChange() // +/-
        {
            f = float.Parse(temp);

            if (f == 0)
            {
                return;
            }
            else if (f < 0)
            {
                s = "0";
                textBox1.Text = s;
                f = -f;
                temp = f.ToString("#,##0.###");
                label1.Text = temp;
            }
            else if (f > 0)
            {
                s = "0";
                textBox1.Text = s;
                f = -f;
                temp = f.ToString("#,##0.###");
                label1.Text = temp;
            }
            this.ActiveControl = button18;
        }
        public void btnDemical() 
        {
            if (textBox1.Text.Any(c => c == '.'))
            {
                MessageBox.Show(". 두 번 오류");
            }
            else
            {
                s = s + ".";
                textBox1.Text = s;
            }
            this.ActiveControl = button18;
        }
        private void button4_Click(object sender, EventArgs e) //1
        {
            btn1();
        }

        private void button5_Click(object sender, EventArgs e)//2
        {
            btn2();
        }

        private void button6_Click(object sender, EventArgs e)//3
        {
            btn3();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn4();
        }//4

        private void button8_Click(object sender, EventArgs e)
        {
            btn5();
        }//5

        private void button9_Click(object sender, EventArgs e)
        {
            btn6();
        }//6

        private void button10_Click(object sender, EventArgs e)
        {
            btn7();
        }//7

        private void button11_Click(object sender, EventArgs e)
        {
            btn8();
        }//8

        private void button12_Click(object sender, EventArgs e)
        {
            btn9();
        }//9

        private void button19_Click(object sender, EventArgs e)
        {
            btn0();
        }//0

        private void button3_Click(object sender, EventArgs e) // 'C' 버튼 클릭 시 초기화
        {
            btnESC();
        }

        private void button13_Click(object sender, EventArgs e) // 백스페이스, 마지막 입력 지우기
        {
            btnBack();
        }

        private void button14_Click(object sender, EventArgs e) // +
        {
            btnAdd();
        }

        private void button18_Click(object sender, EventArgs e) // =
        {
            btnEqual();
        }

        private void button15_Click(object sender, EventArgs e) // -
        {
            btnSubtract();
        }

        private void button16_Click(object sender, EventArgs e) // *
        {
            btnMultiply();
        }

        private void button17_Click(object sender, EventArgs e) // /
        {
            btnDivide();   
        }

        private void button1_Click(object sender, EventArgs e) // 음수 양수 전환
        {
            btnChange();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn1();
                    break;
                case Keys.NumPad1:
                    btn1();
                    break;
                case Keys.D2:
                    btn2();
                    break;
                case Keys.NumPad2:
                    btn2();
                    break;
                case Keys.D3:
                    btn3();
                    break;
                case Keys.NumPad3:
                    btn3();
                    break;
                case Keys.D4:
                    btn4();
                    break;
                case Keys.NumPad4:
                    btn4();
                    break;
                case Keys.D5:
                    btn5();
                    break;
                case Keys.NumPad5:
                    btn5();
                    break;
                case Keys.D6:
                    btn6();
                    break;
                case Keys.NumPad6:
                    btn6();
                    break;
                case Keys.D7:
                    btn7();
                    break;
                case Keys.NumPad7:
                    btn7();
                    break;
                case Keys.D8:
                    btn8();
                    break;
                case Keys.NumPad8:
                    btn8();
                    break;
                case Keys.D9:
                    btn9();
                    break;
                case Keys.NumPad9:
                    btn9();
                    break;
                case Keys.D0:
                    btn0();
                    break;
                case Keys.NumPad0:
                    btn0();
                    break;
                case Keys.Add:
                    btnAdd();
                    break;
                case Keys.Subtract:
                    btnSubtract();
                    break;
                case Keys.Multiply:
                    btnMultiply();
                    break;
                case Keys.Divide:
                    btnDivide();
                    break;
                case Keys.OemPeriod:
                    btnDemical();
                    break;
                case Keys.Decimal:
                    btnDemical();
                    break;
                case Keys.Enter:
                    btnEqual();
                    break;
                }
        } // 키보드 입력
    }
}
