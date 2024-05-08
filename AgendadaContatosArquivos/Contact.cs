using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AgendadaContatosArquivos
{
    internal class Contact
    {
        string name;
        string email;
        Address address;
        List<string> phonesList;

        public Contact(string name, string email, Address address, List<string> phonesList)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.phonesList = phonesList;
        }

        public string getName()
        {
            return name;
        }
     
        public string getEmail()
        {
            return email;
        }
        public Address getAddress()
        {
            return address;
        }
        public List<string> getPhonesList()
        {
            return phonesList;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }

        public void setPhonesList(List<string> phonesList)
        {
            this.phonesList = phonesList;
        }


        public override string ToString()
        {
            string contactInfo =   name + ";" + email + ";"
                +  address.ToString() + ";";
                
                foreach (string phone in phonesList)
                {
                contactInfo += phone + ";" ;
                }
            return contactInfo;
        }
    }
}

