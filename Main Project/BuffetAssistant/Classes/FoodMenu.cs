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
    class FoodMenu
    {
        private string title;
        private ObservableCollection<string> category;
        private string filter;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Filter
        {
            get { return filter; }
            set { filter = value; }
        }
      public ObservableCollection<string> Category
        {
            get { return category; }
            set { category = value; }
        }

        public void AddItem(MenuItem newItem)
        {
            throw new NotImplementedException();

        }
        public void RemoveItem(MenuItem item)
        {
            throw new NotImplementedException();

        }
        public void AddCategory(string categoryName)
        {
            category.Add(categoryName);
        }
        public MenuItem EditItem(MenuItem item)
        {
            throw new NotImplementedException();
        }
        public ObservableCollection<MenuItem>SearchItems(MenuItem item)
        {
            throw new NotImplementedException();
        }
    }
    class MenuItem
    {
        private string name;
        private string id;
        private ImageSource image;
        private int rank;
        private string ingredient;

        public MenuItem(string name,string id,ImageSource image,int rank,string ingredient)
        {
            this.name = name;
            this.id = id;
            this.image = image;
            this.rank = rank;
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
