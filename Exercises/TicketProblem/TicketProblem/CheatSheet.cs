using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProblem
{
    internal class CheatSheet
    {
        // Auto Properties
        public int PropName { 
            get; 
            set; 
        } // must be public to import. 
        // Calling Computed Read-Write Properties -> public type propname {get {logic return something} set{logic}} Ex:
        public int PropNamePlus1 { 
            get { 
                return this.PropName + 1; }
            set { 
                this.PropName += 1; 
            } 
        } 
        // Method Assignment -> public type MethodName(type param) { logic return something}
        public string GetPropNameMethod(string a) { 
            string b = string.Format($"Hello {a}"); 
            return b;
        }

        // Constructor Creation -> ClassName(parameters) {this.prop = param} Ex:
        public CheatSheet(int propName) {
            this.PropName = propName;
        }
        // String Override -> public override string ToString() { string var = String.Format($"Text: {var}")} 
        public override string ToString() {
            string.Format("aa");
            return base.ToString();
        }
    }
}
