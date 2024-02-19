using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Model
{
    public class Tip
    {
        private double amount;
        private double percent;

        private double Amount 
        {
            get {  return amount; }
            set {  amount = value; } 
        }
        public double Percent
        {
            get { return percent; }
            set
            {
                if (value > 1)
                {
                    this.percent = value / 100.00;
                }
                else
                {
                    percent = value;
                }
            }
        }
        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }
        public Tip():this(0,0) { }

        public double CalculateTip()
        {
            return Amount * Percent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }

    }
}
