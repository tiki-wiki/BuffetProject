﻿using System;
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
        Cancle
    }
    class Order
    {
        private int id;
        private string name;
        private double totalPricel;
        public int ID
        {
            get { return id;}
            set { id = value; }
        }
        //Hello
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
