using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    class NormalOrder:Order
    {
        //fileds
        private int id;
        private string name;
        private double totalPrice;
        private Status state;
        private int quantity;
        public NormalOrder(int id, string name, double totalPrice, Status state, int quantity)
        {
            this.id = id;
            this.name = name;
            this.totalPrice = totalPrice;
            this.state = state;
            this.quantity = quantity;
        }
        public NormalOrder()
        {
            this.id = 0;
            this.name = "No Name";
            this.totalPrice = 0;
            this.state = Status.Unready;
            this.quantity = 1;
        }
    }
}
