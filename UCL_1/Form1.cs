using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCL_1
{
    public partial class Form1 : Form
    {
        ListBox[] teamlist = null;
        Random rnd = null;
        int randomTeam;
        int teamNumber;

        public Form1()
        {            
            InitializeComponent();
            teamlist = new ListBox[32];
            teamlist[0] = listBox1;
            teamlist[1] = listBox2;
            teamlist[2] = listBox3;
            teamlist[3] = listBox4;
            teamlist[4] = listBox5;
            teamlist[5] = listBox6;
            teamlist[6] = listBox7;
            teamlist[7] = listBox8;
            teamlist[8] = listBox9;
            teamlist[9] = listBox10;
            teamlist[10] = listBox11;
            teamlist[11] = listBox12;
            teamlist[12] = listBox13;
            teamlist[13] = listBox14;
            teamlist[14] = listBox15;
            teamlist[15] = listBox16;
            teamlist[16] = listBox17;
            teamlist[17] = listBox18;
            teamlist[18] = listBox19;
            teamlist[19] = listBox20;
            teamlist[20] = listBox21;
            teamlist[21] = listBox22;
            teamlist[22] = listBox23;
            teamlist[23] = listBox24;
            teamlist[24] = listBox25;
            teamlist[25] = listBox26;
            teamlist[26] = listBox27;
            teamlist[27] = listBox28;
            teamlist[28] = listBox29;
            teamlist[29] = listBox30;
            teamlist[30] = listBox31;
            teamlist[31] = listBox32;
            rnd = new Random();
            randomTeam = 0;
            teamNumber = 0;
        }

        void stageGroupDraw(ListBox list, int firstteamno, int increment = 4)
        {
            teamNumber = list.Items.Count;
            int teamlistno = firstteamno;
            for (int i = 0; i < teamNumber; i++)
            {
                randomTeam = rnd.Next(0, list.Items.Count);

                teamlist[teamlistno].Items.Add(list.Items[randomTeam]);
                list.Items.RemoveAt(randomTeam);
                teamlistno += increment;
                
                if (teamlistno > teamlist.Length - 1) teamlistno = firstteamno;
            }

        }

        private void firstGroupStageDraw(object sender, EventArgs e)
        {
            // first: listBox1
            stageGroupDraw(list_1, 0);
        }
        
        private void secondGroupStageDraw(object sender, EventArgs e)
        {
            // first: listBox2
            stageGroupDraw(list_2, 1);
        }

        private void thirdGroupStageDraw(object sender, EventArgs e)
        {
            // first: listBox3
            stageGroupDraw(list_3, 2);
        }

        private void fourthGroupStageDraw(object sender, EventArgs e)
        {
            // first: listBox4
            stageGroupDraw(list_4, 3);
        }

        private void allTeamDelete(object sender, EventArgs e)
        {
            for(int i = 0; i < teamlist.Length; i++)
            {
                teamlist[i].Items.Clear();
            }
        }

        private void list1AddText(object sender, EventArgs e)
        {
            listAddText(list_1, textBox1);
        }

        private void list2AddText(object sender, EventArgs e)
        {
            listAddText(list_2, textBox2);
        }

        private void list3AddText(object sender, EventArgs e)
        {
            listAddText(list_3, textBox3);
        }

        private void list4AddText(object sender, EventArgs e)
        {
            listAddText(list_4, textBox4);
        }

        void listAddText(ListBox list, TextBox textBox)
        {
            if (textBox.Text != "")
            {
                list.Items.Add(textBox.Text);
            }
        }

        private void list1TeamDelete(object sender, EventArgs e)
        {
            teamDelete(list_1);
        }

        private void list2TeamDelete(object sender, EventArgs e)
        {
            teamDelete(list_2);
        }

        private void list3TeamDelete(object sender, EventArgs e)
        {
            teamDelete(list_3);
        }

        private void list4TeamDelete(object sender, EventArgs e)
        {
            teamDelete(list_4);
        }
        
        void teamDelete(ListBox list)
        {
            for (int i = list.SelectedItems.Count - 1; i >= 0; i--)
            {
                list.Items.Remove(list.SelectedItems[i]);
            }
        }

    }
}
