using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace BuffetAssistant.Classes
{
    //Order States
    public enum Status
    {
        Ready,
        Unready,
        Cancle,
        Paid
    }
    class Order
    {
        //fields
        private int id;
        private string name;
        private double totalPrice;
        private Status state;
        private int quantity;

        //properties
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
                quantity = value;
            }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        //constructors
        public Order(int id, string name, double totalPrice, Status state, int quantity)
        {
            this.id = id;
            this.name = name;
            this.totalPrice = totalPrice;
            this.state = state;
            this.quantity = quantity;
        }
        public Order()
        {
            this.id = 0;
            this.name = "No Name";
            this.totalPrice = 0;
            this.state = Status.Unready;
            this.quantity = 1;
        }
    }
}
