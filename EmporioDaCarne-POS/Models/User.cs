using EmporioDaCarne_POS.Models.Enums;
using System.Collections;
using System.Collections.Generic;

namespace EmporioDaCarne_POS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? DateBirth { get; set; }
        public Permission Permision { get; set; }
        //public ICollection Sales { get; set; }// = new List<SalesRecord>();

        public User()
        {
        }

        public User(int id, string name, string email, string password, DateTime dateBirth, Permission permission)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            DateBirth = dateBirth;
            Permision = permission;
        }

        /*public void AddSale(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSale(SalesRecord sr)
        {
            Sales.Remove(sr);
        }*/
    }
}
