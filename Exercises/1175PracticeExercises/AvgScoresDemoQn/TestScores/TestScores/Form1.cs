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
using System.Drawing.Text;

namespace TestScores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private List<double> scores = new List<double>();
        private List<double> approved = new List<double>();
        private List<double> failed = new List<double>();
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            readFile();
            loadListBox();

        }
        private void readFile()
        {
            try 
            {
                using (StreamReader reader = new StreamReader("TestScores.txt"))
                {
                    if(!reader.EndOfStream)
                    {
                        reader.ReadLine();
                    }
                    while (!reader.EndOfStream)
                    {
                        double.TryParse(reader.ReadLine(), out double score);
                        scores.Add(score) ;
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Error "+ ex.Message);
            }
        }
        private void loadListBox()
        {
            scoreListBox.Items.Clear();
            scoreListBox.Items.Add("Scores");
            foreach (double score in scores)
            {
                scoreListBox.Items.Add(score);
            }
        }
        private void calculateValues()
        {
            double scoreSum = 0;
            double minScore = scores[0];
            double maxScore = scores[1];
            
            foreach (double score in scores)
            {
                scoreSum += score;
                
                if(minScore > score) minScore = score; 
                if(maxScore < score) maxScore = score;

            }
            double avg = scoreSum / scores.Count;

            AvgScoreValue.Text = $"{avg:F2}";
            MinScoreValue.Text = minScore.ToString();   
            MaxScoreValue.Text = maxScore.ToString();   
        }

        private void PerformCompBtn_Click(object sender, EventArgs e)
        {
            calculateValues();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(AddTextBox.Text, out double score) || score <0)
            {
                MessageBox.Show($"{score} is not a valid Number");
            }
            else
            {
                scores.Add(score);
                loadListBox();
            }
            AddTextBox.Text = "";
            updateStatusLabel("Item Added");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(UpdateTextBox.Text, out double score) || score < 0 || score >100)
            {
                MessageBox.Show($"{score} is not a valid Number");
            }
            else
            {
                int indx = scoreListBox.SelectedIndex;

                if (indx <1 ) {
                    MessageBox.Show("Please select a valid field");
                } else
                {
                    scores[indx-1] = score;
                    scoreListBox.Items[indx] = score;
                }
            }
            UpdateTextBox.Text = "";
            updateStatusLabel("Item Updated");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int indx = scoreListBox.SelectedIndex;
            if (indx < 1)
            {
                MessageBox.Show("Please select a valid field");
            }
            else
            {
                scores.RemoveAt(indx - 1);
                scoreListBox.Items.RemoveAt(indx);
            }
            updateStatusLabel("Item Deleted");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter Write = new StreamWriter("NewScores.txt"))
            {
                Write.WriteLine("Scores");
                foreach (double score in scores) {
                    Write.WriteLine(score);
                }
            }
            updateStatusLabel("NewScores.txt File Saved");
        }
        private void updateStatusLabel(string Message) { StatusLabel.Text = Message; }

        private void CheckStatusBtn_Click(object sender, EventArgs e)
        {
            approved = (from score in scores orderby score where score >70 select score).ToList();
            failed = (from score in scores orderby score where score < 70 select score).ToList();

            Form2 form2 = new Form2();
            form2.ApprovedListBox.Items.Add("Scores");
            form2.FailedListBox.Items.Add("Scores");

            foreach (double score in approved)
            {
               form2.ApprovedListBox.Items.Add(score);
            }
            foreach (double score in failed)
            {
                form2.FailedListBox.Items.Add(score);
            }
            form2.ShowDialog();
        }
    }   
}
