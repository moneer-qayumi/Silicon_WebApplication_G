﻿using System.ComponentModel.DataAnnotations;
using WebApplication_G.Filters;

namespace WebApplication_G.ViewModels;

public class SignUpViewModel
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;


    [Required]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;


    [Required]
    [Display(Name = "Confirm password", Prompt = "Confirm your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password do not match")]
    public string ConfirmPassword { get; set; } = null!;

    [CheckboxRequired]
    [Display(Name = "I agree to the Terms & Conditions.", Prompt = "Terms and Conditions")]
    public bool TermsAndConditions { get; set; }
}
