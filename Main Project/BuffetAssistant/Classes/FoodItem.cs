using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;

namespace BuffetAssistant.Classes
{
    class FoodItem
    {
        private string name;
        private string id;
        private ImageSource image;
        private string ingredient;

        //seperate field
        private int rank;
        //

        public FoodItem(string name,string id,ImageSource image,string ingredient)
        {
            this.name = name;
            this.id = id;
            this.image = image;
            this.ingredient = ingredient;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public ImageSource Image
        {
            get { return image; }
            set { image = value; }
        }
        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string Ingredient
        {
            get { return ingredient; }
            set { ingredient = value; }
        }
    }
}
