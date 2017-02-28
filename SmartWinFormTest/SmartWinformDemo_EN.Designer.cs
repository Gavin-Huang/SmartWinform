namespace SmartWinFormTest
{
    partial class SmartWinformDemo_EN : SmartWinForm.UI.SmartForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartWinformDemo_EN));
            this.ChangeForeColor = new System.Windows.Forms.Button();
            this.ChangeBackColor = new System.Windows.Forms.Button();
            this.LeftBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.TopFormBTN = new System.Windows.Forms.Button();
            this.BelowFormBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.indicatorLight1 = new SmartWinForm.UI.SmartControls.IndicatorLight();
            this.smartCheckBox1 = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.smartCheckBox2 = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.smartCheckBox3 = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.smartRadioButton4 = new SmartWinForm.UI.SmartControls.SmartRadioButton();
            this.smartRadioButton3 = new SmartWinForm.UI.SmartControls.SmartRadioButton();
            this.smartRadioButton2 = new SmartWinForm.UI.SmartControls.SmartRadioButton();
            this.smartRadioButton1 = new SmartWinForm.UI.SmartControls.SmartRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smartListBox1 = new SmartWinForm.UI.SmartControls.SmartListBox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.redBTN = new System.Windows.Forms.Button();
            this.greenBTN = new System.Windows.Forms.Button();
            this.yellowBTN = new System.Windows.Forms.Button();
            this.IsBlink = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.smartCheckBox4 = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IsCH = new SmartWinForm.UI.SmartControls.SmartCheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeForeColor
            // 
            this.ChangeForeColor.Location = new System.Drawing.Point(81, 61);
            this.ChangeForeColor.Name = "ChangeForeColor";
            this.ChangeForeColor.Size = new System.Drawing.Size(113, 23);
            this.ChangeForeColor.TabIndex = 0;
            this.ChangeForeColor.Text = "ChangeForeColor";
            this.ChangeForeColor.UseVisualStyleBackColor = true;
            this.ChangeForeColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeBackColor
            // 
            this.ChangeBackColor.Location = new System.Drawing.Point(200, 61);
            this.ChangeBackColor.Name = "ChangeBackColor";
            this.ChangeBackColor.Size = new System.Drawing.Size(111, 23);
            this.ChangeBackColor.TabIndex = 1;
            this.ChangeBackColor.Text = "ChangeBackColor";
            this.ChangeBackColor.UseVisualStyleBackColor = true;
            this.ChangeBackColor.Click += new System.EventHandler(this.ChangeBackColor_Click);
            // 
            // LeftBTN
            // 
            this.LeftBTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LeftBTN.Location = new System.Drawing.Point(12, 227);
            this.LeftBTN.Name = "LeftBTN";
            this.LeftBTN.Size = new System.Drawing.Size(24, 120);
            this.LeftBTN.TabIndex = 2;
            this.LeftBTN.Text = "left Form";
            this.LeftBTN.UseVisualStyleBackColor = true;
            this.LeftBTN.Click += new System.EventHandler(this.LeftBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightBTN.Location = new System.Drawing.Point(498, 227);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(24, 120);
            this.rightBTN.TabIndex = 3;
            this.rightBTN.Text = "Right Form";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // TopFormBTN
            // 
            this.TopFormBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopFormBTN.Location = new System.Drawing.Point(211, 12);
            this.TopFormBTN.Name = "TopFormBTN";
            this.TopFormBTN.Size = new System.Drawing.Size(96, 23);
            this.TopFormBTN.TabIndex = 4;
            this.TopFormBTN.Text = "Top Form";
            this.TopFormBTN.UseVisualStyleBackColor = true;
            this.TopFormBTN.Click += new System.EventHandler(this.TopFormBTN_Click);
            // 
            // BelowFormBTN
            // 
            this.BelowFormBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BelowFormBTN.Location = new System.Drawing.Point(232, 556);
            this.BelowFormBTN.Name = "BelowFormBTN";
            this.BelowFormBTN.Size = new System.Drawing.Size(96, 23);
            this.BelowFormBTN.TabIndex = 5;
            this.BelowFormBTN.Text = "BelowForm";
            this.BelowFormBTN.UseVisualStyleBackColor = true;
            this.BelowFormBTN.Click += new System.EventHandler(this.BelowFormBTN_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(447, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // indicatorLight1
            // 
            this.indicatorLight1.BlinkTime = 100;
            this.indicatorLight1.IsBlink = false;
            this.indicatorLight1.Location = new System.Drawing.Point(162, 107);
            this.indicatorLight1.Margin = new System.Windows.Forms.Padding(0);
            this.indicatorLight1.Name = "indicatorLight1";
            this.indicatorLight1.Size = new System.Drawing.Size(24, 24);
            this.indicatorLight1.TabIndex = 7;
            // 
            // smartCheckBox1
            // 
            this.smartCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartCheckBox1.BackgroundImage")));
            this.smartCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartCheckBox1.Checked = false;
            this.smartCheckBox1.Location = new System.Drawing.Point(59, 156);
            this.smartCheckBox1.Name = "smartCheckBox1";
            this.smartCheckBox1.Size = new System.Drawing.Size(32, 32);
            this.smartCheckBox1.TabIndex = 8;
            // 
            // smartCheckBox2
            // 
            this.smartCheckBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartCheckBox2.BackgroundImage")));
            this.smartCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartCheckBox2.Checked = false;
            this.smartCheckBox2.Location = new System.Drawing.Point(59, 194);
            this.smartCheckBox2.Name = "smartCheckBox2";
            this.smartCheckBox2.Size = new System.Drawing.Size(32, 32);
            this.smartCheckBox2.TabIndex = 9;
            // 
            // smartCheckBox3
            // 
            this.smartCheckBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartCheckBox3.BackgroundImage")));
            this.smartCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartCheckBox3.Checked = false;
            this.smartCheckBox3.Location = new System.Drawing.Point(59, 232);
            this.smartCheckBox3.Name = "smartCheckBox3";
            this.smartCheckBox3.Size = new System.Drawing.Size(32, 32);
            this.smartCheckBox3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.smartRadioButton4);
            this.groupBox1.Controls.Add(this.smartRadioButton3);
            this.groupBox1.Controls.Add(this.smartRadioButton2);
            this.groupBox1.Controls.Add(this.smartRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(59, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SwitherTest";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "item2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Item3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "item1";
            // 
            // smartRadioButton4
            // 
            this.smartRadioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartRadioButton4.BackgroundImage")));
            this.smartRadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartRadioButton4.Checked = false;
            this.smartRadioButton4.Location = new System.Drawing.Point(109, 62);
            this.smartRadioButton4.Name = "smartRadioButton4";
            this.smartRadioButton4.Size = new System.Drawing.Size(32, 32);
            this.smartRadioButton4.TabIndex = 3;
            // 
            // smartRadioButton3
            // 
            this.smartRadioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartRadioButton3.BackgroundImage")));
            this.smartRadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartRadioButton3.Checked = false;
            this.smartRadioButton3.Location = new System.Drawing.Point(109, 20);
            this.smartRadioButton3.Name = "smartRadioButton3";
            this.smartRadioButton3.Size = new System.Drawing.Size(32, 32);
            this.smartRadioButton3.TabIndex = 2;
            // 
            // smartRadioButton2
            // 
            this.smartRadioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartRadioButton2.BackgroundImage")));
            this.smartRadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartRadioButton2.Checked = false;
            this.smartRadioButton2.Location = new System.Drawing.Point(6, 58);
            this.smartRadioButton2.Name = "smartRadioButton2";
            this.smartRadioButton2.Size = new System.Drawing.Size(32, 32);
            this.smartRadioButton2.TabIndex = 1;
            // 
            // smartRadioButton1
            // 
            this.smartRadioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartRadioButton1.BackgroundImage")));
            this.smartRadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartRadioButton1.Checked = false;
            this.smartRadioButton1.Location = new System.Drawing.Point(6, 20);
            this.smartRadioButton1.Name = "smartRadioButton1";
            this.smartRadioButton1.Size = new System.Drawing.Size(32, 32);
            this.smartRadioButton1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "smartWinform can provide touchable RadioButon and CheckerBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "And AutoScroll ListBos to Show long string name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "four direction Newform show up and state indicator";
            // 
            // smartListBox1
            // 
            this.smartListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.smartListBox1.FormattingEnabled = true;
            this.smartListBox1.IsAutoScrollColomn = false;
            this.smartListBox1.Location = new System.Drawing.Point(59, 432);
            this.smartListBox1.Name = "smartListBox1";
            this.smartListBox1.Size = new System.Drawing.Size(93, 69);
            this.smartListBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "SmartIndicator";
            // 
            // redBTN
            // 
            this.redBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.redBTN.Location = new System.Drawing.Point(211, 108);
            this.redBTN.Name = "redBTN";
            this.redBTN.Size = new System.Drawing.Size(57, 23);
            this.redBTN.TabIndex = 20;
            this.redBTN.Text = "red";
            this.redBTN.UseVisualStyleBackColor = true;
            this.redBTN.Click += new System.EventHandler(this.redBTN_Click);
            // 
            // greenBTN
            // 
            this.greenBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.greenBTN.Location = new System.Drawing.Point(277, 108);
            this.greenBTN.Name = "greenBTN";
            this.greenBTN.Size = new System.Drawing.Size(57, 23);
            this.greenBTN.TabIndex = 21;
            this.greenBTN.Text = "green ";
            this.greenBTN.UseVisualStyleBackColor = true;
            this.greenBTN.Click += new System.EventHandler(this.greenBTN_Click);
            // 
            // yellowBTN
            // 
            this.yellowBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yellowBTN.Location = new System.Drawing.Point(343, 108);
            this.yellowBTN.Name = "yellowBTN";
            this.yellowBTN.Size = new System.Drawing.Size(57, 23);
            this.yellowBTN.TabIndex = 22;
            this.yellowBTN.Text = "yellow";
            this.yellowBTN.UseVisualStyleBackColor = true;
            this.yellowBTN.Click += new System.EventHandler(this.yellowBTN_Click);
            // 
            // IsBlink
            // 
            this.IsBlink.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IsBlink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IsBlink.BackgroundImage")));
            this.IsBlink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IsBlink.Checked = false;
            this.IsBlink.Location = new System.Drawing.Point(418, 107);
            this.IsBlink.Name = "IsBlink";
            this.IsBlink.Size = new System.Drawing.Size(32, 32);
            this.IsBlink.TabIndex = 23;
            this.IsBlink.SwitcherChanged += new System.EventHandler<SmartWinForm.UI.SmartControls.SwitcherChanged>(this.IsBlink_SwitcherChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "isBlink";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "it can easily change all winform fore and back color";
            // 
            // smartCheckBox4
            // 
            this.smartCheckBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smartCheckBox4.BackgroundImage")));
            this.smartCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.smartCheckBox4.Checked = false;
            this.smartCheckBox4.Location = new System.Drawing.Point(59, 270);
            this.smartCheckBox4.Name = "smartCheckBox4";
            this.smartCheckBox4.Size = new System.Drawing.Size(32, 32);
            this.smartCheckBox4.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 507);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 26;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "SmartTextBox";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 56;
            this.label12.Text = "中文";
            // 
            // IsCH
            // 
            this.IsCH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IsCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IsCH.BackgroundImage")));
            this.IsCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IsCH.Checked = false;
            this.IsCH.Location = new System.Drawing.Point(418, 14);
            this.IsCH.Name = "IsCH";
            this.IsCH.Size = new System.Drawing.Size(32, 32);
            this.IsCH.TabIndex = 57;
            // 
            // SmartWinformDemo_EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.IsCH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.smartCheckBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IsBlink);
            this.Controls.Add(this.yellowBTN);
            this.Controls.Add(this.greenBTN);
            this.Controls.Add(this.redBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.smartListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.smartCheckBox3);
            this.Controls.Add(this.smartCheckBox2);
            this.Controls.Add(this.smartCheckBox1);
            this.Controls.Add(this.indicatorLight1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BelowFormBTN);
            this.Controls.Add(this.TopFormBTN);
            this.Controls.Add(this.rightBTN);
            this.Controls.Add(this.LeftBTN);
            this.Controls.Add(this.ChangeBackColor);
            this.Controls.Add(this.ChangeForeColor);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.Name = "SmartWinformDemo_EN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SmartWinformTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeForeColor;
        private System.Windows.Forms.Button ChangeBackColor;
        private System.Windows.Forms.Button LeftBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Button TopFormBTN;
        private System.Windows.Forms.Button BelowFormBTN;
        private System.Windows.Forms.Button button1;
        private SmartWinForm.UI.SmartControls.IndicatorLight indicatorLight1;
        private SmartWinForm.UI.SmartControls.SmartCheckBox smartCheckBox1;
        private SmartWinForm.UI.SmartControls.SmartCheckBox smartCheckBox2;
        private SmartWinForm.UI.SmartControls.SmartCheckBox smartCheckBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private SmartWinForm.UI.SmartControls.SmartRadioButton smartRadioButton4;
        private SmartWinForm.UI.SmartControls.SmartRadioButton smartRadioButton3;
        private SmartWinForm.UI.SmartControls.SmartRadioButton smartRadioButton2;
        private SmartWinForm.UI.SmartControls.SmartRadioButton smartRadioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SmartWinForm.UI.SmartControls.SmartListBox smartListBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button redBTN;
        private System.Windows.Forms.Button greenBTN;
        private System.Windows.Forms.Button yellowBTN;
        private SmartWinForm.UI.SmartControls.SmartCheckBox IsBlink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private SmartWinForm.UI.SmartControls.SmartCheckBox smartCheckBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private SmartWinForm.UI.SmartControls.SmartCheckBox IsCH;
    }
}

