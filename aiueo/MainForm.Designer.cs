namespace aiueo
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Hiragana = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.LB_Katakana = new System.Windows.Forms.Label();
            this.LB_Sound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Hiragana = new System.Windows.Forms.CheckBox();
            this.CB_Katakana = new System.Windows.Forms.CheckBox();
            this.LL_Setting = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LB_Hiragana
            // 
            this.LB_Hiragana.AutoSize = true;
            this.LB_Hiragana.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Hiragana.Location = new System.Drawing.Point(12, 32);
            this.LB_Hiragana.Name = "LB_Hiragana";
            this.LB_Hiragana.Size = new System.Drawing.Size(0, 50);
            this.LB_Hiragana.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "下一個";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(233, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "平假名/片假名";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(233, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "發音";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LB_Katakana
            // 
            this.LB_Katakana.AutoSize = true;
            this.LB_Katakana.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Katakana.Location = new System.Drawing.Point(68, 32);
            this.LB_Katakana.Name = "LB_Katakana";
            this.LB_Katakana.Size = new System.Drawing.Size(0, 50);
            this.LB_Katakana.TabIndex = 4;
            // 
            // LB_Sound
            // 
            this.LB_Sound.AutoSize = true;
            this.LB_Sound.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_Sound.Location = new System.Drawing.Point(124, 32);
            this.LB_Sound.Name = "LB_Sound";
            this.LB_Sound.Size = new System.Drawing.Size(0, 50);
            this.LB_Sound.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "發音";
            // 
            // CB_Hiragana
            // 
            this.CB_Hiragana.AutoSize = true;
            this.CB_Hiragana.Checked = true;
            this.CB_Hiragana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Hiragana.Location = new System.Drawing.Point(6, 8);
            this.CB_Hiragana.Name = "CB_Hiragana";
            this.CB_Hiragana.Size = new System.Drawing.Size(60, 16);
            this.CB_Hiragana.TabIndex = 9;
            this.CB_Hiragana.Text = "平假名";
            this.CB_Hiragana.UseVisualStyleBackColor = true;
            // 
            // CB_Katakana
            // 
            this.CB_Katakana.AutoSize = true;
            this.CB_Katakana.Checked = true;
            this.CB_Katakana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Katakana.Location = new System.Drawing.Point(67, 8);
            this.CB_Katakana.Name = "CB_Katakana";
            this.CB_Katakana.Size = new System.Drawing.Size(60, 16);
            this.CB_Katakana.TabIndex = 10;
            this.CB_Katakana.Text = "片假名";
            this.CB_Katakana.UseVisualStyleBackColor = true;
            // 
            // LL_Setting
            // 
            this.LL_Setting.AutoSize = true;
            this.LL_Setting.Location = new System.Drawing.Point(287, 35);
            this.LL_Setting.Name = "LL_Setting";
            this.LL_Setting.Size = new System.Drawing.Size(37, 12);
            this.LL_Setting.TabIndex = 11;
            this.LL_Setting.TabStop = true;
            this.LL_Setting.Text = "Setting";
            this.LL_Setting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Setting_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 86);
            this.Controls.Add(this.LL_Setting);
            this.Controls.Add(this.CB_Katakana);
            this.Controls.Add(this.CB_Hiragana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Sound);
            this.Controls.Add(this.LB_Katakana);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB_Hiragana);
            this.Name = "MainForm";
            this.Text = "aiueo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Hiragana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label LB_Katakana;
        private System.Windows.Forms.Label LB_Sound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CB_Hiragana;
        private System.Windows.Forms.CheckBox CB_Katakana;
        private System.Windows.Forms.LinkLabel LL_Setting;
    }
}

