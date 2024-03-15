
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;

internal class Program
{
    private static void Main(string[] args)
    {
        Role role = new Role()
        {
            Name = "Admin"
        };
        Role role1 = new Role()
        {
            Name = "Accounter"
        };
        Role role2 = new Role()
        {
            Name = "Teacher"

        };
        Role role3 = new Role()
        {
            Name = "Student"
        };
        
        RoleManager roleManager = new RoleManager(new EfRoleDal());
        roleManager.Add(role);
        roleManager.Add(role1);
        roleManager.Add(role2);
        roleManager.Add(role3);

    }

}