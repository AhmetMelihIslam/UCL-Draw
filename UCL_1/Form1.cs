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
        public Form1()
        {
            InitializeComponent();
        }
    
//*************************************************************

        // First group stage draw

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int teamNumber = list_1.Items.Count;
            for (int i = 1; i <= teamNumber; i++)
            {
                int randomTeam = rnd.Next(0, list_1.Items.Count);
            

                if(i < 2)
                {
                    listBox1.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }

                else if(i < 3)
                {
                    listBox5.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }

                
                else if(i < 4)
                {
                    listBox9.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }

                
                else if(i < 5)
                {
                    listBox13.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }

                
                else if(i < 6)
                {
                    listBox17.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }

                
                else if(i < 7)
                {
                    listBox21.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }
                
                
                else if(i < 8)
                {
                    listBox25.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }


                else if (i < 9)
                {
                    listBox29.Items.Add(list_1.Items[randomTeam]);
                    list_1.Items.RemoveAt(randomTeam);
                }



            }

        }
        
//*************************************************************

        // Second group stage draw

        private void Sec_group_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int teamNumber = list_2.Items.Count;
            for (int i = 1; i <= teamNumber; i++)
            {
                int randomTeam = rnd.Next(0, list_2.Items.Count);


                if (i < 2)
                {
                    listBox2.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }

                else if (i < 3)
                {
                    listBox6.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 4)
                {
                    listBox10.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 5)
                {
                    listBox14.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 6)
                {
                    listBox18.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 7)
                {
                    listBox22.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 8)
                {
                    listBox26.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }


                else if (i < 9)
                {
                    listBox30.Items.Add(list_2.Items[randomTeam]);
                    list_2.Items.RemoveAt(randomTeam);
                }



            }
        }

//*************************************************************

        // Third group stage draw

        private void Third_group_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int teamNumber = list_3.Items.Count;
            for (int i = 1; i <= teamNumber; i++)
            {
                int randomTeam = rnd.Next(0, list_3.Items.Count);


                if (i < 2)
                {
                    listBox3.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }

                else if (i < 3)
                {
                    listBox7.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 4)
                {
                    listBox11.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 5)
                {
                    listBox15.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 6)
                {
                    listBox19.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 7)
                {
                    listBox23.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 8)
                {
                    listBox27.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }


                else if (i < 9)
                {
                    listBox31.Items.Add(list_3.Items[randomTeam]);
                    list_3.Items.RemoveAt(randomTeam);
                }



            }
        }

//*************************************************************

        // Fourth group stage draw

        private void Fourth_group_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int teamNumber = list_4.Items.Count;
            for (int i = 1; i <= teamNumber; i++)
            {
                int randomTeam = rnd.Next(0, list_4.Items.Count);


                if (i < 2)
                {
                    listBox4.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }

                else if (i < 3)
                {
                    listBox8.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 4)
                {
                    listBox12.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 5)
                {
                    listBox16.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 6)
                {
                    listBox20.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 7)
                {
                    listBox24.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 8)
                {
                    listBox28.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }


                else if (i < 9)
                {
                    listBox32.Items.Add(list_4.Items[randomTeam]);
                    list_4.Items.RemoveAt(randomTeam);
                }



            }
        }

//*************************************************************

            // Clear All Group

        private void button1_Click_3(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox11.Items.Clear();
            listBox12.Items.Clear();
            listBox13.Items.Clear();
            listBox14.Items.Clear();
            listBox15.Items.Clear();
            listBox16.Items.Clear();
            listBox17.Items.Clear();
            listBox18.Items.Clear();
            listBox19.Items.Clear();
            listBox20.Items.Clear();
            listBox21.Items.Clear();
            listBox22.Items.Clear();
            listBox23.Items.Clear();
            listBox24.Items.Clear();
            listBox25.Items.Clear();
            listBox26.Items.Clear();
            listBox27.Items.Clear();
            listBox28.Items.Clear();
            listBox29.Items.Clear();
            listBox30.Items.Clear();
            listBox31.Items.Clear();
            listBox32.Items.Clear();


        }
//*************************************************************

    // Team add Button
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                list_1.Items.Add(textBox1.Text);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                list_2.Items.Add(textBox2.Text);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                list_3.Items.Add(textBox3.Text);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                list_4.Items.Add(textBox4.Text);
            }
        }

//*************************************************************


            // Team delete button

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = list_1.SelectedItems.Count - 1; i >= 0; i--)
            {
                list_1.Items.Remove(list_1.SelectedItems[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = list_2.SelectedItems.Count - 1; i >= 0; i--)
            {
                list_2.Items.Remove(list_2.SelectedItems[i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = list_3.SelectedItems.Count - 1; i >= 0; i--)
            {
                list_3.Items.Remove(list_3.SelectedItems[i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = list_4.SelectedItems.Count - 1; i >= 0; i--)
            {
                list_4.Items.Remove(list_4.SelectedItems[i]);
            }
        }

//*************************************************************


    }
}
