using System;
using System.Collections.Generic;

namespace Employees
{

    public class Company
{
    public List<Employee> EmployeeList {get; set;}

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company(string name, DateTime dateOfCreation) {
        Name = name;
        DateOfCreation = dateOfCreation;
        EmployeeList = new List<Employee>();
    }

    public string Name {get;}
    public DateTime DateOfCreation {get;}

    public void employeeLoop(){
        foreach (Employee person in EmployeeList){
            Console.WriteLine($"{person.firstName} {person.lastName} works as the {person.title} and has been employed since {person.startDate}.");
        }
    }
}
    class Program
    {
           static void Main()
        {
            Company Netflix = new Company("Netflix", new DateTime (2001, 1, 1));

            Employee firstEmployee = new Employee();
            firstEmployee.firstName = "Jordan";
            firstEmployee.lastName = "Rosas";
            firstEmployee.title = "Head of IT";
            firstEmployee.startDate = new DateTime (2019, 3, 7);

            Employee secondEmployee = new Employee();
            secondEmployee.firstName = "Nick";
            secondEmployee.lastName = "Hansen";
            secondEmployee.title = "Janitor";
            secondEmployee.startDate = new DateTime (2019, 5, 17);

            Employee thirdEmployee = new Employee();
            thirdEmployee.firstName = "OJ";
            thirdEmployee.lastName = "Simpson";
            thirdEmployee.title = "Criminal";
            thirdEmployee.startDate = new DateTime (2011, 4, 12);

            Netflix.EmployeeList.Add(firstEmployee);
            Netflix.EmployeeList.Add(secondEmployee);
            Netflix.EmployeeList.Add(thirdEmployee);

            Netflix.employeeLoop();
        }
    }
}