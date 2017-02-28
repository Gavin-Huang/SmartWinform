////
////
////

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
    public partial class SmartWinformDemo_EN : SmartWinForm.UI.SmartForm
    {
        public SmartWinformDemo_EN()
        {
            InitializeComponent();
            BindingList<Person> InloveForever = new BindingList<Person>(){
                new Person(){PersonName ="Gavin-Huang(most_handsome_boy)"},
                new Person(){PersonName="Pei-Xiaoya(lovelyest_girl)"}};
            smartListBox1.DataSource = InloveForever;
            smartListBox1.DisplayMember = "PersonName";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.right);
        }

        private void LeftBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.left);
        }
        SmartWinForm.UI.SmartForm GetForm()
        {
            if(IsCH.Checked)
                return  new SmartWinformDemo_CH();
            return new SmartWinformDemo_EN();
        }
        private void TopFormBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.top);
        }

        private void BelowFormBTN_Click(object sender, EventArgs e)
        {
            OpenNewForm(GetForm(), SmartWinForm.UI.Direction.down);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OpenInputLabTip();
        }
    }


    public class Person:INotifyPropertyChanged
    {
        private string Personname = "";
        public string PersonName
        {
            set {
                Personname = value;
                NotifyPropertyChanged("PersonName");
            }
            get { return Personname; }
        }
        public Person()
        {
 
        }
        public override string ToString()
        {
            return Personname;
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
