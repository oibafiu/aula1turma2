using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImoveisApi.Models
{
    public class CustomValidator : ValidationAttribute
    {
        UsuarioContext db = new UsuarioContext();
        private string Field { get; set; }
        public CustomValidator(string FieldName)
        {
            Field = FieldName;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Field == "Nome")
            {
                if (db.Usuarios.FirstOrDefault(i => i.Nome == value.ToString()) != null) 
                    return ValidationResult.Success;
            } 
            
            if (Field == "DataNascimento")
            {
                DateTime valueConvertido = Convert.ToDateTime(value);
                DateTime DataMinima = DateTime.Now.AddYears(-18);
                DateTime DataMaxima = DateTime.Now.AddYears(-150);

                if (valueConvertido.Year > DataMinima.Year || valueConvertido.Year < DataMaxima.Year)
                {
                    return new ValidationResult("Sua idade é zuada pra krl");
                }


                return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }

    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        DateTime bday = DateTime.Parse(value.ToString());
    //        DateTime today = DateTime.Today;
    //        int age = today.Year - bday.Year;
    //        if (bday > today.AddYears(-age))
    //        {
    //            age--;
    //        }
    //        if (age < _Limit)
    //        {
    //            var result = new ValidationResult("Sorry you are not old enough");
    //            return result;
    //        }


    //        return null;

    //    }
    //}
}
}