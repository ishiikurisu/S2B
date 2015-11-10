using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operator
    {
        public string Text { get; set; }
        private string NullString { get; } = "0";

        public Operator ()
        {
            Text = this.NullString;
        }

        public void Push(string value)
        {
            if ((value.Equals(this.NullString) && this.Text.Equals(this.NullString)) ||
                (value.Equals(".") && this.Text.Contains(".")))
                return;
            if (this.Text.Equals(NullString))
                this.Text = "";
            this.Text += value;
            
        }

        public string Flush()
        {
            string outlet = this.Text;
            this.Text = this.NullString;
            return outlet;
        }
    }
}
