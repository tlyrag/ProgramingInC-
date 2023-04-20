using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManateeDemo
{
    public partial class Form1 : Form
    {
        private List<Manatee> ManateeList = new List<Manatee>();
        private List<string> HeaderList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void readFile()
        {
            try
            {
                ManateeList.Clear();
                using (StreamReader reader = new StreamReader("ManateeSampleData.csv")) 
                { 
                    if(!reader.EndOfStream) { 
                        string[] header = reader.ReadLine().Split(',');
                        foreach(string line in header)
                        {
                            HeaderList.Add(line);
                        }
                    } 
                    while(!reader.EndOfStream)
                    {
                        string[] listItem = reader.ReadLine().Split(',') ;
                        string location = listItem[0];
                        string[] dates = { listItem[1], listItem[2], listItem[3], listItem[4] };
                        int[] sigthCount = { int.Parse(listItem[5]), int.Parse(listItem[6]), int.Parse(listItem[7]), int.Parse(listItem[8]) };
                        Manatee manatee = new Manatee(location,dates,sigthCount);
                        ManateeList.Add(manatee);
                    }
                }
            } catch(Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }
        private void loadListBox()
        {   
            manateeListBox.Items.Clear();
            string[] headerArrItems = { "Min Sight", "Max Sight", "Avg Sight" };
            foreach (string line in headerArrItems) { HeaderList.Add(line); }
            string listBoxHeader = $"{HeaderList[0],-12}{HeaderList[1],-12}{HeaderList[2],-12}{HeaderList[3],-12}{HeaderList[4],-12}{HeaderList[5],-8}{HeaderList[6],-8}{HeaderList[7],-8}{HeaderList[8],-8}";
            manateeListBox.Items.Add(listBoxHeader);
            foreach (Manatee manatee in ManateeList)
            {

                manateeListBox.Items.Add(manatee);
            }
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            readFile();
            loadListBox();
            StatusLabel.Text = $"{ManateeList.Count()} Were added to the list";
        }

        private void manateeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indx = manateeListBox.SelectedIndex -1;
            if (indx >0) {
                date1TextBox.Text = ManateeList[indx].Date[0];
                date2TextBox.Text = ManateeList[indx].Date[1];
                date3TextBox.Text = ManateeList[indx].Date[2];
                date4TextBox.Text = ManateeList[indx].Date[3];

                count1TextBox.Text = $"{ManateeList[indx].SightCount[0]}";
                count2TextBox.Text = $"{ManateeList[indx].SightCount[1]}";
                count3TextBox.Text = $"{ManateeList[indx].SightCount[2]}";
                count4TextBox.Text = $"{ManateeList[indx].SightCount[3]}";

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int indx = manateeListBox.SelectedIndex - 1;

            if (indx >0)
            {
                ManateeList[indx].Date[0]= date1TextBox.Text;
                ManateeList[indx].Date[1] = date2TextBox.Text;
                ManateeList[indx].Date[2] = date3TextBox.Text;
                ManateeList[indx].Date[3] = date4TextBox.Text;

                try
                {
                    ManateeList[indx].SightCount[0] = int.Parse(count1TextBox.Text);
                    ManateeList[indx].SightCount[1] = int.Parse(count2TextBox.Text);
                    ManateeList[indx].SightCount[2] = int.Parse(count3TextBox.Text);
                    ManateeList[indx].SightCount[3] = int.Parse(count4TextBox.Text);
                } catch(Exception err) {
                    MessageBox.Show($"Error: {err}");
                }

                loadListBox();
            }
        }
    }
}
