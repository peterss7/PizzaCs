using PizzaCs.Infrastructure.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCs.Core.Models.Dtos.Users;

public class UserDto
{

    public int? UserId { get; set; }
    public string? UserName { get; set; }
    public string? UserEmail { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AccountNumber { get; set; }
    public UserDto() { }
    public UserDto(int? userId, string? userName, string? userEmail, string? firstName, string? lastName, string? accountNumber)
    {
        UserId = userId;
        UserName = userName;
        UserEmail = userEmail;
        FirstName = firstName;
        LastName = lastName;
        AccountNumber = accountNumber;
    }
}
