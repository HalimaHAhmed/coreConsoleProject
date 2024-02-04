Console.WriteLine("hello halimah");// See https://aka.ms/new-console-template for more information
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

// float baseSalary = 5000;
// float hra = 0.30F;
// float netSalary = (baseSalary-(baseSalary*hra));
// Console.WriteLine("Base salary :" + baseSalary);
// Console.WriteLine("Net salary :" +netSalary);

// int temperature = 50;
// if (temperature < 20)
// {
//     Console.WriteLine("It's very cold outside");
// }
// else
// {
//     Console.WriteLine("It's moderate outside");
// }


// bool isLoggedln = true;
// bool isEmailVerified = true;
// bool cardInfo = true;

// if (isLoggedln && isEmailVerified && cardInfo)
// {
//     Console.WriteLine("Allowed to make purchase");
// }
// else
// {
//     Console.WriteLine("Stop purchase");
// }


// bool isAuthenticated = false;

// if (isAuthenticated)
// {
//     Console.WriteLine("You are logged in.");
// }

// string result = isAuthenticated ? "You are logged in." : "You are not logged in.";

// Console.WriteLine(result);


// int temperature = 50;

// if (temperature < 20)
// {
//     Console.WriteLine("It's very cold outside");
// }
// else if (temperature >= 20 && temperature <= 50)
// {
//     Console.WriteLine("It's moderate outside");
// }
// else
// {
//     Console.WriteLine("It's too hot outside");
// }

// switch case

// string userType = "admin";

// switch (userType)
// {
//     case "admin":
//         Console.WriteLine("You have full access");
//         break;

//     case "subadmin":
//         Console.WriteLine("You can delete or create courses");
//         break;

//     case "user":
//         Console.WriteLine("You can access the courses");
//         break;

//     default:
//         Console.WriteLine("Trial user");
//         break;
// }




// loops

// string[] names = new string[5] { "halimah", "hussein", "ahmed", "mohamed", "ali" };

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

// for (int i = 4; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// int j = 0;
// while (j < names.Length)
// {
//     Console.WriteLine(names[j]);
//     j++;
// }

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine("hello halimah" + i);
// }


// arrays
// single dimantional array
// int[] marks = new int[5];
// marks[0] = 89;
// marks[1] = 76;
// marks[2] = 93;
// marks[3] = 85;
// marks[4] = 91;

// foreach (int mark in marks)
// {
//     Console.WriteLine(mark);
// }

// // multidimantional array

// int[,] multiArray = new int[3, 4]
// {
//     {89, 76, 93, 85},
//     {91, 98, 74, 68},
//     {96, 87, 91, 78}
// };

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write(multiArray[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// int[] jaggedArray = new int[2][];
// jaggedArray[0] = new int[2];
// jaggedArray[1] = new int[3];

// string str1 = "Hello world";
// string str2 = "c# programming";
// Console.WriteLine(str1);
// Console.WriteLine(str2.Length);
// string str3 = string.Concat(str1, str2);
// Console.WriteLine(str3);
// Console.WriteLine(str1.Equals(str2));

// Immutable string
// string s1 = "c# programming";
// string s2 = "java programming";

// // Mutable string
// System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
// stringBuilder.Append("c# programming ");
// stringBuilder.Append("java programming");

// Console.WriteLine(stringBuilder.ToString());


// Declaring and initializing a jagged array
// int[][] jaggedArray = new int[3][];
// jaggedArray[0] = new int[] { 1, 2, 3 }; // First sub-array with 3 elements
// jaggedArray[1] = new int[] { 4, 5 };    // Second sub-array with 2 elements
// jaggedArray[2] = new int[] { 6, 7, 8, 9 };






