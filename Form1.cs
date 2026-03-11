using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0225
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void caculate_Click(object sender, EventArgs e)
        {
            double height;
            double weight;
            bool IsheightValid = double.TryParse(txtHeight.Text, out height);
            bool IsweightValid = double.TryParse(txtWeight.Text, out weight);
            double bmi;

            if (IsheightValid && IsweightValid)
            {
                height /= 100;
                bmi = weight / (height * height);
                // outout_BMI.Text = $"{bmi:F2}"; //格式化字串  F 代表固定小數點格式（Fixed - point）。   2 表示顯示兩位小數。
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); //MessageBox.Show(“訊息”, “標題”, 按扭, 圖示);
                return;
            }
            string[] strResult = { "體重過輕", "健康體位", "體位過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList = { Color.Blue, Color.Green, Color.Orange, Color.DarkOrange, Color.Red, Color.Purple };
            string Text_Result = "";
            Color colorResult = Color.Black;
            int resultIndex = 0;
            if (bmi < 18.5)
            {
                resultIndex = 0;
            }
            else if (bmi < 24)
            {
                resultIndex = 1;
            }
            else if (bmi < 27)
            {
                resultIndex = 2;
            }
            else if (bmi < 30)
            {
                resultIndex = 3;
            }
            else if (bmi < 35)
            {
                resultIndex = 4;
            }
            else
            {
                resultIndex = 5;
            }

            Text_Result = strResult[resultIndex];
            colorResult = colorList[resultIndex];
            output_BMI.Text = $"{bmi:F2} ({Text_Result})";
            output_BMI.BackColor = colorResult;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBMI_Load(object sender, EventArgs e)
        {

        }
    }
}
