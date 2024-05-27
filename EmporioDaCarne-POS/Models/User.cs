using EmporioDaCarne_POS.Models.Enums;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmporioDaCarne_POS.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateBirth { get; set; }

        [Required]
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

        // PROBLEM: usar o [Required] esta causando problemas com registros com colunas nulas dentro do banco de dados
        // registros com valores nao nulos funcionam corretamente
        // Para resolver vamos depois mudar o esquema do banco de dados (retirando o nullable) e podemos utilizar o [Required] a vontade
    }
}
