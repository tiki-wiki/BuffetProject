using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    public enum PayOptions
    {
        Cash,
        Credit,
        Online
    }
    class Payment
    {
        private int id;
        private List<Order> orders;
        private string details;
        private double total;
        private DateTime date;
        private PayOptions paymentMethod;

        public int ID
        {
            get { return id; }
            set
            {
                if (id > 0)
                    id = value;
            }
        }
        public List<Order>Orders
        {
            get { return orders; }
            set
            {
                if (orders.Count > 0)
                    orders = value;
            }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        private double Total
        {
            get { return total; }
            set
            {
                if (total > 0)
                    total = value;
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public PayOptions PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public Payment(int id,List<Order> orders,string details,double total,
            DateTime date,PayOptions paymentMethod)
        {
            this.id = id;
            this.orders = orders;
            this.details = details;
            this.total = total;
            this.date = date;
            this.paymentMethod = paymentMethod;
        }
        public Payment()
        {
            this.id = 1;
            orders = null;
            this.details = "No Details";
            this.total = 0;
            this.date = DateTime.Now;
            this.paymentMethod = PayOptions.Cash;
        }
    }
}
