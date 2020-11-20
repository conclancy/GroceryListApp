using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryClasses
{
    public class User
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public IDictionary<Item, int> groceryList { get; set; }

        public User(string username, string firstName, string lastName, string email, string phoneNumber, Dictionary<Item, int> groceryList)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.groceryList = groceryList;
        }
    }

    
}
