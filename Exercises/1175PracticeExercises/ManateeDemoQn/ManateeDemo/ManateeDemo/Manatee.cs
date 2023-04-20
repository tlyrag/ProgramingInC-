using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManateeDemo
{
    internal class Manatee
    {
        public string Location { get; set; }
        public string[] Date { get; set; }
        public int[] SightCount { get; set; } 
        public int MinSightCount { 
            get {
                int minSight = SightCount[0];
                foreach (int count in SightCount) {
                    if(count < minSight) 
                    { 
                        minSight = count; 
                    }
                }
                return minSight;    
            } 
        }
        public int MaxSightCount
        {
            get
            {
                int maxSight = SightCount[0];
                foreach (int count in SightCount)
                {
                    if (count > maxSight)
                    {
                        maxSight = count;
                    }
                }
                return maxSight;
            }
        }
        public int AvgSightCount
        {
            get
            {
                int sumSight = 0;
                foreach (int count in SightCount)
                {
                    sumSight += count;
                }
                return sumSight;
            }
        }
        public Manatee(string location, string[] date, int[] sightCount)
        {
            this.Location = location;
            this.Date = date;
            this.SightCount = sightCount;
        }
        public override string ToString()
        {
            string dates = "";
            string sightCount = "";
            
            foreach (string date in this.Date)
            {
                dates += $" {date,-10} ";
            }
            
            foreach (int s in this.SightCount) { 
                sightCount += $" {s,-8} ";
            }
            
            string manatee = $"{this.Location,-10}{dates,-10}{sightCount,-10}{this.MinSightCount,-8}{this.MaxSightCount,-8}{this.AvgSightCount,-8}";
            return manatee;
        }
    }
}
