using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    public enum Status
    {
        Ready,
        Unready,
        Cancle,
        Paid
    }
    class Order
    {
        private int id;
        private string name;
        private double totalPrice;
        private Status state;
        private int quantity;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status State
        {
            get { return state; }
            set { state = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity < -1)
                {
                    quantity = value;
                }
            }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set
            {
                if (totalPrice < -1)
                {
                    totalPrice = value;
                }
            }
        }
    }
}
