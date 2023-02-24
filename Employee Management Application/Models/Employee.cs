using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Employee_Mini_Proj.Models;

public partial class Employee
{
    [Display(Name = "Employee ID")]
    public int Empid { get; set; }

    [Required(ErrorMessage = "Please enter FirstName")]
    [Display(Name = "FirstName")]
    public string? Fname { get; set; }

    [Required(ErrorMessage = "Please enter LastName")]
    [Display(Name = "LastName")]
    public string? Lname { get; set; }

    [Required]
    [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
    public string? Email { get; set; }

    [Display(Name = "Gender")]
    [Required(ErrorMessage = "Please Select the gender")]
    public string? Gender { get; set; }

    [Required(ErrorMessage = "Please enter your position")]
    [Display(Name = "Position")]
    public string? Position { get; set; }

    [Required(ErrorMessage = "Please enter Salary")]
    [Display(Name = "Salary")]
    public int? Salary { get; set; }

    [Required(ErrorMessage = "Please enter Username")]
    [Display(Name = "Username")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Please enter password")]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
    [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase      Alphabet, 1 Number and 1 Special Character")]
    public string? Password { get; set; }
}
