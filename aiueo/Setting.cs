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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).SubsymbleList = new List<symble>();
            if (CB_a.Checked)
            {
                for (int i = 0; i < 5; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ka.Checked)
            {
                for (int i = 5; i < 10; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_sa.Checked)
            {
                for (int i = 10; i < 15; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ta.Checked)
            {
                for (int i = 15; i < 20; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_na.Checked)
            {
                for (int i = 20; i < 25; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ha.Checked)
            {
                for (int i = 25; i < 30; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ma.Checked)
            {
                for (int i = 30; i < 35; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ya.Checked)
            {
                for (int i = 35; i < 38; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_ra.Checked)
            {
                for (int i = 38; i < 43; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_wa.Checked)
            {
                for (int i = 43; i < 45; i++)
                    ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[i]);
            }
            if (CB_n.Checked)
            {

                ((MainForm)this.Owner).SubsymbleList.Add(((MainForm)this.Owner).symbleList[45]);
            }


            this.Hide();
        }
    }
}
