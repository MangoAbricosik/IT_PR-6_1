using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_PR_6_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
      Podgotovka();
        }
    public void Podgotovka()
    {
      int[] massiv = new int[15];
      Random rand = new Random();

      int i = 0;

      while (i < 15)
      {
        massiv[i] = rand.Next(-50, 100);
        textBox1.Text += Environment.NewLine + massiv[i];
        i++;
      }
      Start(massiv);
    }
    public void Start(int[] massim)
    {
      int n = 0;
      if (radioButton2.Checked) n = 2;
      if (radioButton3.Checked) n = 3;
      if (radioButton4.Checked) n = 4;
      if (radioButton5.Checked) n = 5;
      if (radioButton6.Checked) n = 6;

      int i = 0, sum = 0, cout = 0;

      switch (n)
      {
        case 2:
          while (i < 15)
          {
            if (massim[i] > 0)
            {
              sum += massim[i];
            }
            i++;
          }
          textBox2.Text = "Сумма элементов массива = " + sum.ToString();
          break;
        case 3:
          while (i < 15)
          {
            if (i % 2 == 0)
            {
              sum += massim[i];
            }
            i++;
          }
          textBox2.Text = "Сумма четных элементов массива = " + sum.ToString();
          break;
        case 4:
          while (i < 15)
          {
            if (massim[i] <= 0)
            {
              cout++;
            }
            i++;
          }
          textBox2.Text = "Кол-во нулевых или отрицательных элементов массива = " + cout.ToString();
          break;
        case 5:
          while (i < 15)
          {
            if (massim[i] % 6 == 0)
            {
              sum += massim[i];
            }
            i++;
          }
          textBox2.Text = "Сумма элементов которые деляться на 6 без остатка массива = " + sum.ToString();
          break;
        case 6:
          while (i < 15)
          {
            if (massim[i] < 0)
            {
              massim[i] = 0;
              textBox2.Text += "Mas[" + Convert.ToString(i) + "] = "
+ Convert.ToString(massim[i]) + Environment.NewLine;
            }
            i++;
          }
          break;
      }

    }
  }
}
