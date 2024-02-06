// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

PttManager pttManager = new PttManager(new PersonManager());

Person person = new Person
{
    DateOfBirthYear = 1996,
    LastName = "Doğukan",
    FirstName = "Test",
    NationalIdentity = 0000000
};

pttManager.GiveMask(person);

