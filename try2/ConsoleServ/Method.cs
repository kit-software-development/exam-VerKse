using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Library;
using static Library.Class1;

namespace ConsoleServ
{
    public class Method
    {
        public class Contact
        {
            public int contactId { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string phone1 { get; set; }
            public string phone2 { get; set; }
            public string info { get; set; }
            public int groupId { get; set; }
        }

        public class Group
        {
            public int groupId { get; set; }
            public int key { get; set; }
        }

        public class User
        {
            public int userId { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public int groupId { get; set; }

        }
        public class MainDbContext : DbContext
        {
           

            public static DbSet<Contact> Contacts { get; set; }
            public static DbSet<Group> Groups { get; set; }
            public static DbSet<User> Users { get; set; }

            public bool AddNewContact(Contact c)
            {
                try
                {
                    Contacts.Add(c);
                    SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
            public bool UpdateContact(Contact oldC, Contact newC)
            {
                try
                {
                    Contacts.Remove(oldC);
                    Contacts.Add(newC);
                    return true;
                }
                catch (Exception) { return false; }
            }
            public bool DeleteContact(Contact c)
            {
                try
                {
                    Contacts.Remove(c);
                    SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }

            }

            public bool CheckPassword(User u)
            {
                if (Users.Find(u) == null)
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}
