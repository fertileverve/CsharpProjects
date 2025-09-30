// ====================================================================
// While/Do Loop Challenge
// int heroHealth = 10;
// int monsterHealth = 10;
// Random random = new Random();

// while (heroHealth > 0 && monsterHealth > 0)
// {
//     int damage = random.Next(1, 11);
//     monsterHealth -= damage;
//     Console.WriteLine($"Monster was damaged and lost {damage} heath is now has {monsterHealth} health.");

//     if (monsterHealth <= 0)
//     {
//         Console.WriteLine("Hero wins!");
//         break;
//     }

//     damage = random.Next(1, 11);
//     heroHealth -= damage;
//     Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");

//     if (heroHealth <= 0)
//     {
//         Console.WriteLine("Monster wins!");
//         break;
//     }
// }

// Challenge 2
// string? readResult;
// bool validEntry = false;
// int numericValue = 0;

// Console.WriteLine("Enter a integer number between 5 and 10:");

// do
// {
//   readResult = Console.ReadLine();

//   if (readResult != null)
//   {
//     validEntry = int.TryParse(readResult, out numericValue);
//     if (validEntry)
//     {
//       if (numericValue >= 5 && numericValue <= 10)
//       {
//         validEntry = true;
//       }
//       else
//       {
//         validEntry = false;
//         Console.WriteLine("You did not enter a number between 5 and 10. Please try again:");
//       }
//     }
//     else
//     {
//       Console.WriteLine("You didn't even enter a number. Please try again:");
//     }
//   }
// } while (validEntry == false);

// Console.WriteLine($"You entered a valid number: {numericValue}");

// Challenge 3
// string? readResult;
// bool validEntry = false;
// string role = "Administrator|Manager|User";

// Console.WriteLine("Are you an Administrator, Manager, or User?");

// do
// {
//   readResult = Console.ReadLine();

//   if (readResult == null || readResult.Trim() == "")
//   {
//     Console.WriteLine("You did not enter a valid role. Please try again:");
//     continue;
//   }

//   if (role.Trim().ToLower().Contains(readResult.Trim().ToLower()))
//   {
//     validEntry = true;
//   }
//   else
//   {
//     Console.WriteLine("You did not enter a valid role. Please try again:");
//   }
// } while (validEntry == false);

// Console.WriteLine($"You entered a valid role: {readResult}");

// Challenge 4
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = 0;

// foreach(string myString in myStrings)
// {
//   periodLocation = myString.IndexOf(".");

//   if (periodLocation == -1)
//   {
//     Console.WriteLine(myString.Trim());
//     continue;
//   }

//   string workString = myString;

//   while (periodLocation != -1)
//   {
//     Console.WriteLine(workString.Substring(0, periodLocation).TrimStart());
//     workString = workString.Substring(periodLocation + 1);

//     periodLocation = workString.IndexOf('.');
    
//     if (periodLocation == -1)
//     {
//       Console.WriteLine(workString.TrimStart());
//     }
//   }
// }


// ====================================================================
// While/Do Loop Tutorial
//Random random = new Random();
//int current = 0;
//int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//   Console.WriteLine(current);
//   current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);


// ====================================================================
// For loop challenge
// for (int i = 1; i <= 100; i++) 
// {
//   if (i % 3 == 0 && i % 5 == 0)
//     Console.WriteLine($"{i} - FizzBuzz");
  
//   else if (i % 3 == 0)
//     Console.WriteLine($"{i} - Fizz");
  
//   else if (i % 5 == 0)
//     Console.WriteLine($"{i} - Buzz");
  
//   else
//     Console.WriteLine(i);
// }

// ====================================================================
// For loop tutorial
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//   Console.WriteLine(names[i]);
//   //if (i == 7) break;
// }


// ====================================================================
// Switch/case challenge
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");


// ====================================================================
// Switch/case tutorial
// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//   case 100:
//   case 200:
//     title = "Senior Associate";
//     break;
//   case 300:
//     title = "Manager";
//     break;
//   case 400:
//     title = "Senior Manager";
//     break;
//   default:
//     title = "Associate";
//     break;
// }

// Console.WriteLine($"{employeeName}, {title}");


// ====================================================================
// Variable scopes and context challenge
// int total = 0;
// bool found = false;
// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//        found = true;
// }

// if (found) 
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");


// ====================================================================
// Variable scopes and context tutorial
// bool flag = true;
// int value = 0;

// if (flag)
// {
//     Console.WriteLine($"Inside the code block: {value}");
// }

// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// Code sample 1
// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// bool flag = true;
// if (flag) Console.WriteLine(flag);

// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");


// ====================================================================
// Expressions tutorial
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output

// Console.WriteLine(pangram.Contains("fox") == false);
// Console.WriteLine(!pangram.Contains("fox"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;

// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coinFlip = new Random();

// coinFlip.Next(2); // Generates a number between 0 and 1
// string headsTails = coinFlip.Next(2) == 0 ? "Heads" : "Tails";

// Console.WriteLine(headsTails);

// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin") && level > 55)
//     Console.WriteLine("Welcome, Super Admin User.");

// else if (permission.Contains("Admin") && level <= 55)
//     Console.WriteLine("Welcome, Admin User.");

// else if (permission.Contains("Manager") && level >= 20)
//     Console.WriteLine("Contact an Admin for access.");

// else
//     Console.WriteLine("You do not have sufficient privileges.");


// ====================================================================
// Naming, comments, and whitespace challenge
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";
// int letterCount = 0;

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);
// string newMessage = new String(message);

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// ====================================================================
// Naming, comments, and whitespace tutorial
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");
//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// Console
// .
// WriteLine
// (
// "Hello Example 1!"
// )
// ;

// string firstWord = "Hello";string lastWord = "Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// ====================================================================
// Arrays challenge
// string[] foid = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// foreach (string id in foid)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine(id);
//     }
// }

// ====================================================================
// Arrays tutorial
// // string[] fraudulentOrderIDs = new string[3];
// // fraudulentOrderIDs[0] = "A123";
// // fraudulentOrderIDs[1] = "B456";
// // fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";
// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


// ====================================================================
// if, then, else if challenge
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Tests
// //daysUntilExpiration = 0;
// //daysUntilExpiration = 1;
// //daysUntilExpiration = 3;
// //daysUntilExpiration = 7;
// //daysUntilExpiration = 11;

// // Your code goes here
// if (daysUntilExpiration == 0)
// {
//     //discountPercentage = 50;
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day. \nRenew Now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. \nRenew Now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// ====================================================================
// if, then, else if tutorial
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int bonus = 0;
// string message = "";

// // Tests
// // roll1 = 6;
// // roll2 = 6;
// // roll3 = 5;

// // roll1 = 6;
// // roll2 = 6;
// // roll3 = 6;

// int total = roll1 + roll2 + roll3;

// // Bonus block
// if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
// {
//     // Triples gets 6 more points
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         bonus = 6;
//         Console.WriteLine($"You rolled triples! +{bonus} bonus to total!");
//         total += bonus;
//     }
//     else // Doubles gets 2 more points
//     {
//         bonus = 2;
//         Console.WriteLine($"You rolled doubles, +{bonus} bonus to the total!");
//         total += bonus;
//     }
// }


// // Win or not?
// // if (total >= 15)
// // {
// //     Console.WriteLine("You win!");
// // }
// // else
// // {
// //     Console.WriteLine("Sorry, you lose.");
// // }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// message = $"You rolled {roll1}, {roll2}, and {roll3} totaling {total} points.";
// if (bonus > 0)
// {
//     message += $" (including {bonus} bonus points)";
// }

// Console.WriteLine(message);

// ====================================================================
// Match challenge, return the larger number by discovering the correct System.Math method
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// ====================================================================
//  Methods turorial
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

//dice.Next();


// ====================================================================
// Random number tutorial
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);