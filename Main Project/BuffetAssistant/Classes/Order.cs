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
        private int Quantity;
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
        public Order()
        {

        }
        public Order(int id,string name,double totalPrice,Status state,int quantity)
        {
            this.id = id;
            this.name = name;
            this.totalPrice = totalPrice;
            this.state = state;
        }
    }
}
