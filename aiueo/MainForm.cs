using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aiueo
{
    public partial class MainForm : Form
    {
        public List<symble> symbleList = new List<symble>();
        public List<symble> SubsymbleList;
        public Setting SettingForm = new Setting();
        bool buttonflag = false;
        int rand;

        public MainForm()
        {
            SettingForm.Owner = this;

            InitializeSymble();
            InitializeComponent();
        }

        public void InitializeSymble()
        {
            //あ
            symbleList.Add(new symble { hiragana = "あ", katakana = "ア", pronunciation = "a" });
            symbleList.Add(new symble { hiragana = "い", katakana = "イ", pronunciation = "i" });
            symbleList.Add(new symble { hiragana = "う", katakana = "ウ", pronunciation = "u" });
            symbleList.Add(new symble { hiragana = "え", katakana = "エ", pronunciation = "e" });
            symbleList.Add(new symble { hiragana = "お", katakana = "オ", pronunciation = "o" });
            //か
            symbleList.Add(new symble { hiragana = "か", katakana = "カ", pronunciation = "ka" });
            symbleList.Add(new symble { hiragana = "き", katakana = "キ", pronunciation = "ki" });
            symbleList.Add(new symble { hiragana = "く", katakana = "ク", pronunciation = "ku" });
            symbleList.Add(new symble { hiragana = "け", katakana = "ケ", pronunciation = "ke" });
            symbleList.Add(new symble { hiragana = "こ", katakana = "コ", pronunciation = "ko" });
            //さ
            symbleList.Add(new symble { hiragana = "さ", katakana = "サ", pronunciation = "sa" });
            symbleList.Add(new symble { hiragana = "し", katakana = "シ", pronunciation = "si" });
            symbleList.Add(new symble { hiragana = "す", katakana = "ス", pronunciation = "su" });
            symbleList.Add(new symble { hiragana = "せ", katakana = "セ", pronunciation = "se" });
            symbleList.Add(new symble { hiragana = "そ", katakana = "ソ", pronunciation = "so" });
            //た
            symbleList.Add(new symble { hiragana = "た", katakana = "タ", pronunciation = "ta" });
            symbleList.Add(new symble { hiragana = "ち", katakana = "チ", pronunciation = "chi" });
            symbleList.Add(new symble { hiragana = "つ", katakana = "ツ", pronunciation = "tsu" });
            symbleList.Add(new symble { hiragana = "て", katakana = "テ", pronunciation = "te" });
            symbleList.Add(new symble { hiragana = "と", katakana = "ト", pronunciation = "to" });
            //な
            symbleList.Add(new symble { hiragana = "な", katakana = "ナ", pronunciation = "na" });
            symbleList.Add(new symble { hiragana = "に", katakana = "ニ", pronunciation = "ni" });
            symbleList.Add(new symble { hiragana = "ぬ", katakana = "ヌ", pronunciation = "nu" });
            symbleList.Add(new symble { hiragana = "ね", katakana = "ネ", pronunciation = "ne" });
            symbleList.Add(new symble { hiragana = "の", katakana = "ノ", pronunciation = "no" });
            //は
            symbleList.Add(new symble { hiragana = "は", katakana = "ハ", pronunciation = "ha" });
            symbleList.Add(new symble { hiragana = "ひ", katakana = "ヒ", pronunciation = "hi" });
            symbleList.Add(new symble { hiragana = "ふ", katakana = "フ", pronunciation = "fu" });
            symbleList.Add(new symble { hiragana = "へ", katakana = "ヘ", pronunciation = "he" });
            symbleList.Add(new symble { hiragana = "ほ", katakana = "ホ", pronunciation = "ho" });
            //ま
            symbleList.Add(new symble { hiragana = "ま", katakana = "マ", pronunciation = "ma" });
            symbleList.Add(new symble { hiragana = "み", katakana = "ミ", pronunciation = "mi" });
            symbleList.Add(new symble { hiragana = "む", katakana = "ム", pronunciation = "mu" });
            symbleList.Add(new symble { hiragana = "め", katakana = "メ", pronunciation = "me" });
            symbleList.Add(new symble { hiragana = "も", katakana = "モ", pronunciation = "mo" });
            //や
            symbleList.Add(new symble { hiragana = "や", katakana = "ヤ", pronunciation = "ya" });
            symbleList.Add(new symble { hiragana = "ゆ", katakana = "ユ", pronunciation = "yu" });
            symbleList.Add(new symble { hiragana = "よ", katakana = "ヨ", pronunciation = "yo" });
            //ら
            symbleList.Add(new symble { hiragana = "ら", katakana = "ラ", pronunciation = "ra" });
            symbleList.Add(new symble { hiragana = "り", katakana = "リ", pronunciation = "ri" });
            symbleList.Add(new symble { hiragana = "る", katakana = "ル", pronunciation = "ru" });
            symbleList.Add(new symble { hiragana = "れ", katakana = "レ", pronunciation = "re" });
            symbleList.Add(new symble { hiragana = "ろ", katakana = "ロ", pronunciation = "ro" });
            //わ
            symbleList.Add(new symble { hiragana = "わ", katakana = "ワ", pronunciation = "wa" });
            symbleList.Add(new symble { hiragana = "を", katakana = "ヲ", pronunciation = "wo" });
            //ん
            symbleList.Add(new symble { hiragana = "ん", katakana = "ン", pronunciation = "n" });

            SubsymbleList = symbleList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!buttonflag)
                {
                    rand = new Random().Next(0, SubsymbleList.Count);
                    if (CB_Hiragana.Checked)
                        LB_Hiragana.Text = SubsymbleList[rand].hiragana;
                    else
                        LB_Hiragana.Text = "";

                    if (CB_Katakana.Checked)
                        LB_Katakana.Text = SubsymbleList[rand].katakana;
                    else
                        LB_Katakana.Text = "";

                    LB_Sound.Text = "";
                    buttonflag = true;
                }
                else
                {
                    LB_Sound.Text = SubsymbleList[rand].pronunciation;
                    buttonflag = false;
                }
            }
            else if (radioButton2.Checked)
            {
                if (!buttonflag)
                {
                    rand = new Random().Next(0, SubsymbleList.Count);
                    LB_Hiragana.Text = "";
                    LB_Katakana.Text = "";
                    LB_Sound.Text = SubsymbleList[rand].pronunciation;
                    buttonflag = true;
                }
                else
                {
                    if (CB_Hiragana.Checked)
                        LB_Hiragana.Text = SubsymbleList[rand].hiragana;
                    else
                        LB_Hiragana.Text = "";

                    if (CB_Katakana.Checked)
                        LB_Katakana.Text = SubsymbleList[rand].katakana;
                    else
                        LB_Katakana.Text = "";
                    buttonflag = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LB_Hiragana.Text = "";
            LB_Katakana.Text = "";
            LB_Sound.Text = "";
            buttonflag = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LB_Hiragana.Text = "";
            LB_Katakana.Text = "";
            LB_Sound.Text = "";
            buttonflag = false;
        }

        private void LL_Setting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LB_Hiragana.Text = "";
            LB_Katakana.Text = "";
            LB_Sound.Text = "";
            buttonflag = false;
            SettingForm.Show(this);
        }
    }

    public class symble
    {
        public string hiragana { get; set; }
        public string katakana { get; set; }
        public string pronunciation { get; set; }
    }
}
