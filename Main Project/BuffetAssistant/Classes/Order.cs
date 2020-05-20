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
        Cancle
    }
    class Order
    {
        private int id;
        private string name;
        private double totalPricel;
    }
}
