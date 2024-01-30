// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// variables and data types
// string name = "halimah";
// int age = 21;
// float discount = 1000.50F;
// double contactNumber = 1234324213;
// char gender = 'F';
// bool isValid = true;

// Console.WriteLine("Name: " + name);
// Console.WriteLine("Age: " + age);
// Console.WriteLine("Discount: " + discount);
// Console.WriteLine("Contact Number: " + contactNumber);
// Console.WriteLine("Gender: " + gender);
// Console.WriteLine("IsValid: " + isValid);

// LOgical  OPerators

float baseSalary = 5000;
float hra = 0.30F;
float netSalary = (baseSalary-(baseSalary*hra));
Console.WriteLine("Base salary :" + baseSalary);
Console.WriteLine("Net salary :" +netSalary);

// int temperature = 50;
// if (temperature < 20)
// {
//     Console.WriteLine("It's very cold outside");
// }
// else
// {
//     Console.WriteLine("It's moderate outside");
// }


bool isLoggedln = true;
bool isEmailVerified = true;
bool cardInfo = true;

if (isLoggedln && isEmailVerified && cardInfo)
{
    Console.WriteLine("Allowed to make purchase");
}
else
{
    Console.WriteLine("Stop purchase");
}


bool isAuthenticated = false;

if (isAuthenticated)
{
    Console.WriteLine("You are logged in.");
}

string result = isAuthenticated ? "You are logged in." : "You are not logged in.";

Console.WriteLine(result);


int temperature = 50;

if (temperature < 20)
{
    Console.WriteLine("It's very cold outside");
}
else if (temperature >= 20 && temperature <= 50)
{
    Console.WriteLine("It's moderate outside");
}
else
{
    Console.WriteLine("It's too hot outside");
}

// switch case

string userType = "admin";

switch (userType)
{
    case "admin":
        Console.WriteLine("You have full access");
        break;

    case "subadmin":
        Console.WriteLine("You can delete or create courses");
        break;

    case "user":
        Console.WriteLine("You can access the courses");
        break;

    default:
        Console.WriteLine("Trial user");
        break;
}





