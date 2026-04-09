using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                labelWarning.Text = "建議增加營養攝取，並諮詢醫師或營養師";
            }
            else if (bmi < 24)
            {
                resultIndex = 1;
                labelWarning.Text = "請持續保持良好飲食與運動習慣";
            }
            else if (bmi < 27)
            {
                resultIndex = 2;
                labelWarning.Text = "建議開始控制飲食並增加運動";
            }
            else if (bmi < 30)
            {
                resultIndex = 3;
                labelWarning.Text = "有慢性病風險，建議積極減重";
            }
            else if (bmi < 35)
            {
                resultIndex = 4;
                labelWarning.Text = "健康風險提高，建議尋求專業協助";
            }
            else
            {
                resultIndex = 5;
                labelWarning.Text = "高風險族群，建議醫療介入與長期管理";
            }

            Text_Result = strResult[resultIndex];
            colorResult = colorList[resultIndex];
            output_BMI.Text = $"{bmi:F2} ({Text_Result})";
            output_BMI.BackColor = colorResult;

        }

        private void frmBMI_Load(object sender, EventArgs e)
        {

        }
        private void frmBMI_MouseDown(object sender, MouseEventArgs e)
        {
            // 當點擊視窗空白處，強迫視窗取得焦點
            this.ActiveControl =null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_Entry(object sender, EventArgs e)
        {
            if (txtHeight.Text == "請輸入身高")
            {
                txtHeight.Text = "";
                txtHeight.ForeColor = Color.Black; // 恢復正常顏色
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            // 如果使用者沒輸入任何內容就離開，恢復導覽文字
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                txtHeight.Text = "請輸入身高";
                txtHeight.ForeColor = Color.Gray; // 讓導覽文字看起來淺一點
            }
        }

        private void txtWeight_Entry(object sender, EventArgs e)
        {
            if (txtWeight.Text == "請輸入體重")
            {
                txtWeight.Text = "";
                txtWeight.ForeColor = Color.Black; // 恢復正常顏色
            }
        }
        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                txtWeight.Text = "請輸入體重";
                txtWeight.ForeColor = Color.Gray; // 讓導覽文字看起來淺一點
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
