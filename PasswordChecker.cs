using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
    //Define Variables
    int minLength = 8;
    string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWZYZ";
    string lowercase = "abcdefghijklmnopqrstuvwxyz";
    string digits = "0123456789";
    string specialChars = "!@#$%^&*";
    //User Input
    Console.WriteLine("Please enter in a password you wish to use: ");

    //Save user Input To Variable
    string userPassword = Console.ReadLine();

    //Score User Password
    int score = 0;
    if (userPassword.Length >= minLength)
    {
      score++;
    }
    if (Tools.Contains(userPassword, uppercase))
    {
      score++;
    }
    if (Tools.Contains(userPassword, lowercase))
    {
      score++;
    }
    if (Tools.Contains(userPassword, digits))
    {
      score++;
    }
    if (Tools.Contains(userPassword, specialChars))
    {
      score++;
    }
    Console.WriteLine(score);
   
   //Update User Score
   switch (score)
   {
    case 4:
    case 5:
      Console.WriteLine("You password is very strong!");
      break;
    case 3:
      Console.WriteLine("Your password is strong!");
      break;
    case 2:
      Console.WriteLine("Your password is medium!");
      break;
    case 1:
      Console.WriteLine("Your password is weak!");
      break;
    default:
      Console.WriteLine("Your password does not meet any of the criteria!");
      break;
    
   }
   
    }
  }
}
