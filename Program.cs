using System;
Console.Clear();

string permission = "Admin";
int level = 87;

var role = permission.Contains("Admin") ? "Admin" : permission.Contains("Manager") ? "Manager" : "None";

var mensaje = role switch
{
    "Admin" => level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.",
    "Manager" => level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.",
    _ => "You do not have sufficient privileges."
};

Console.WriteLine(mensaje);