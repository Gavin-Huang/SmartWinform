using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWinFormTest
{
    public partial class SmartWinformDemo_CH : SmartWinForm.UI.SmartForm
    {
        public SmartWinformDemo_CH()
        {
            InitializeComponent();
            BindingList<Person> InloveForever = new BindingList<Person>(){
                new Person(){PersonName ="Gavin-Huang(最帅的男生)"},
                new Person(){PersonName="TheOne(最漂亮的女生)"}};
            smartListBox1.DataSource = InloveForever;
            smartListBox1.DisplayMember = "PersonName";
        }

        private void TopFormBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.top);
        }

        private void BelowFormBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.down);
        }
        private void rightBTN_Click(object sender, System.EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.right);
        }

        private void LeftBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.left);
        }
        SmartWinForm.UI.SmartForm GetForm()
        {
            return new SmartWinformDemo_CH();
        }

        private void ChangeForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog tem = new ColorDialog();
            if (tem.ShowDialog() == DialogResult.OK)
            {
                SmartWinForm.UI.SmartForm.PublicForeColor = tem.Color;
            }
        }

        private void ChangeBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog tem = new ColorDialog();
            if (tem.ShowDialog() == DialogResult.OK)
            {
                SmartWinForm.UI.SmartForm.PublicbackColor = tem.Color;
            }
        }

        private void redBTN_Click(object sender, EventArgs e)
        {
            indicatorLight1.State = SmartWinForm.UI.SmartControls.IndicatorState.Warning;
        }

        private void greenBTN_Click(object sender, EventArgs e)
        {
            indicatorLight1.State = SmartWinForm.UI.SmartControls.IndicatorState.Working;
        }

        private void yellowBTN_Click(object sender, EventArgs e)
        {
            indicatorLight1.State = SmartWinForm.UI.SmartControls.IndicatorState.Waiting;
        }

        private void IsBlink_SwitcherChanged(object sender, SmartWinForm.UI.SmartControls.SwitcherChanged e)
        {
            indicatorLight1.IsBlink = e.NewValue;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OpenInputLabTip();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
