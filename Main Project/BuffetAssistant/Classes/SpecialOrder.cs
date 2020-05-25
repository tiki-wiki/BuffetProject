using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    class SpecialOrder:Order
    {
        //fields
        private int id;
        private string name;
        private double specialPrice;
        private Status state;
        private int quantity;

        public double SpecialPrice
        {
            get { return specialPrice; }
            set
            {
                if (specialPrice > 0)
                    specialPrice = value;
            }
        }
        public SpecialOrder(int id,string name,double specialPrice,Status state,int quantity)
        {
            this.id = id;
            this.name = name;
            this.specialPrice = specialPrice;
            this.state = state;
            this.quantity = quantity;
        }
        public SpecialOrder()
        {
            this.id = 1;
            this.name = "No Name";
            this.specialPrice = 0;
            this.state = Status.Unready;
            this.quantity = 1;
        }
    }
}
