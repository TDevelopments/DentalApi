using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DentalApi.Models
{
    public class Address 
    {
        public int Id { get; set;}    
        public string Population {get; set;}
        public string Province {get; set;}
        public int PostalCode {get; set;}
        public string Country {get; set;}
        
        
    }

}
