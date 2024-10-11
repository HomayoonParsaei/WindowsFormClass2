﻿
using Session02.Enum;
using System.Collections.Generic;
using System.ComponentModel;

namespace Session02.Models
{
    public class Student : User
    {
        //  Name(or shortcut)                           Description                           Valid locations to insert snippet
        //        ctor                 Creates a constructor for the containing class.                 Inside a class.

        public Student()
        {
            
        }
        public Student(string firstName, string lastName, DateOnly dateOfBirth, string nationalCode, string phoneNumber, short gender) : base()
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Gender = gender;
            
        }
        public int Id { get; set; }  
  


        public void ChangeFirstName (string firstName) => FirstName = firstName;
    }
}