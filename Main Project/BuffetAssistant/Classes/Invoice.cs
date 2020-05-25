﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetAssistant.Classes
{
    class Invoice
    {
        private int id;
        private int turnNumber;
        private double totalPrice;
        private DateTime date;
        private Image icon;
        private string thank;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int TurnNumber
        {
            get { return turnNumber; }
            set { turnNumber = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set
            {
                if (totalPrice > 0)
                    totalPrice = value;
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Image Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public string Thank
        {
            get { return thank; }
            set { thank = value; }
        }

        
    }
}
