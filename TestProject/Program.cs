// ====================================================================
// Guided Project: Plan Petting Zoo Trips
// using System;
// using System.Text.RegularExpressions;

// string[] pettingZoo =
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };

// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);

// void PlanSchoolVisit(string schoolName, int groups = 6)
// {
//   RandomizeAnimals();
//   string[,] group = AssignGroup(groups);
//   Console.WriteLine(schoolName);
//   PrintGroup(group);
// }

//   void RandomizeAnimals()
// {
//   Random random = new Random();

//   for (int i = 0; i < pettingZoo.Length; i++)
//   {
//     int r = random.Next(i, pettingZoo.Length);

//     string temp = pettingZoo[i];
//     pettingZoo[i] = pettingZoo[r];
//     pettingZoo[r] = temp;
//   }
// }

// string[,] AssignGroup(int groups = 6)
// {
//   string[,] result = new string[groups, pettingZoo.Length/groups];
//   int start = 0;

//   for (int i = 0; i < groups; i++)
//   {
//     for (int j = 0; j < result.GetLength(1); j++)
//     {
//       result[i, j] = pettingZoo[start++];
//     }
//   }

//   return result;
// }

// void PrintGroup(string[,] group)
// {
//   for (int i = 0; i < group.GetLength(0); i++)
//   {
//     Console.Write($"Group {i + 1}: ");
//     for (int j = 0; j < group.GetLength(1); j++)
//     {
//       Console.Write($"{group[i, j]}  ");
//     }
//     Console.WriteLine();
//   }
// }

// void PrintAnimals()
// {
//   foreach (string animal in pettingZoo)
//     Console.WriteLine(animal);

//   Console.WriteLine();
// }


// ====================================================================
// Methods that Return Values Challenge
// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// void PlayGame()
// {
//   var play = true;

//   while (play)
//   {
//     var target = RollDie(5);
//     var roll = RollDie(6);

//     Console.WriteLine($"Roll a number greater than {target} to win!");
//     Console.WriteLine($"You rolled a {roll}");
//     Console.WriteLine(WinOrLose(target, roll));
//     Console.WriteLine("\nPlay again? (Y/N)");

//     play = ShouldPlay();
//   }
// }

// bool ShouldPlay()
// {
//   bool validEntry = false;
//   bool result = false;
//   string expectedEntry = "y|n";
//   string? readResult;

//   do
//   {
//     readResult = Console.ReadLine();

//     if (readResult != null && readResult != "")
//     {
//       validEntry = expectedEntry.Contains(readResult.ToLower());

//       if (!validEntry)
//       {
//         Console.WriteLine("You did not enter either a \"Y\" or an \"N\", please try again.");
//       }

//       if (readResult.ToLower() == "y")
//         result = true;

//     }
//     else
//     {
//       Console.WriteLine("You entered nothing, please try again. (Y/N)");
//     }
//   } while (validEntry == false);

//   return result;
// }

// string WinOrLose(int target, int roll)
// {
//   string result = "You lose!";

//   if (roll > target)
//     result = "You win!";

//   return result;
// }

// int RollDie(int max)
// {
//   int result = random.Next(1, max + 1);

//   return result;
// }


// ====================================================================
// Methods that Return Values Tutorial
// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//   total += GetDiscountedPrice(i);
// }

// // if (TotalMeetsMinimum())
// // {
// //   total -= 5.00;
// // }
// total -= TotalMeetsMinimum() ? 5.00 : 0.00;

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//   // Calculate the discounted price of the item
//   return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//   // Check if the total meets the minimum
//   return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//   // Format the double so only 2 decimal places are displayed
//   return input.ToString().Substring(0, 5);
// }

// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// int UsdToVnd(double usd)
// {
//   int rate = 23500;
//   return (int)(rate * usd);
// }

// double VndToUsd(int vnd)
// {
//   double rate = 23500;
//   return vnd / rate;
// }

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseWord(string word)
// {
//   string result = "";
//   for (int i = word.Length - 1; i >= 0; i--)
//   {
//     result += word[i];
//   }
//   return result;
// }

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words) 
//     {
//         result += ReverseWord(word) + " ";
//     }

//     return result.Trim();
// }

// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

// Console.WriteLine("Is it a palindrome?");

// foreach (string word in words)
// {
//   Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//   int start = 0;
//   int end = word.Length - 1;

//   while (start < end)
//   {
//     if (word[start] != word[end])
//       return false;

//     start++;
//     end--;
//   }

//   return true;
// }

// int target = 80;
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0)
// {
//   Console.WriteLine("No two coins make change");
// }
// else
// {
//   Console.WriteLine($"Change found at positions:");
//   for (int i = 0; i < result.GetLength(0); i++)
//   {
//     if (result[i, 0] == -1)
//       break;

//     Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
//   }
// }

// int[,] TwoCoins(int[] coins, int target)
// {
//   int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//   int count = 0;

//   for (int curr = 0; curr < coins.Length; curr++)
//   {
//     for (int next = curr + 1; next < coins.Length; next++)
//     {
//       if (coins[curr] + coins[next] == target)
//       {
//         result[count, 0] = curr;
//         result[count, 1] = next;
//         count++;
//       }

//       // get outta here if we already have the max results
//       if (count == result.GetLength(0))
//         return result;
//     }
//   }

//   return (count == 0) ? new int[0,0] : result;
// }


// ====================================================================
// Methods with Parameters Challenge
// const string domain = "@contoso.com";
// const string externalDomain = "@hayworth.com";

// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//   createEmail(corporate[i, 0].ToLower(), corporate[i, 1].ToLower());
// }

// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     createEmail(external[i, 0].ToLower(), external[i, 1].ToLower(), externalDomain);
// }

// void createEmail(string firstName, string lastName, string domain = domain)
// {
//   string emailOutput = firstName.Substring(0, 2) + lastName + domain;

//   Console.WriteLine(emailOutput);
// }


// ====================================================================
// Methods with Parameters Tutorial
// CountTo(5);

// 	void CountTo(int max) 
// 	{
// 		for (int i = 0; i < max; i++)
// 		{
// 			Console.Write($"{i}, ");
// 		}
// 	}

// int[] schedule = [800, 1200, 1600, 2000];

// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//   int diff = 0;
//   if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//   {
//     CL("Invalid GMT");
//   }
//   else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//   {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//   }
//   else
//   {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//   }

//   for (int i = 0; i < times.Length; i++)
//   {
//     int newTime = ((times[i] + diff)) % 2400;
//     CL($"{times[i]} -> {newTime}");
//   }
// }

// void CL(string message)
// {
//   Console.WriteLine(message);
// }

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }

// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//   if (inviteOnly)
//   {
//     // search guestList before adding rsvp
//     bool found = false;
//     foreach (string guest in guestList)
//     {
//       if (guest.Equals(name))
//       {
//         found = true;
//         break;
//       }
//     }
//     if (!found)
//     {
//       Console.WriteLine($"Sorry, {name} is not on the guest list");
//       return;
//     }
//   }

//   rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//   count++;
// }

// void ShowRSVPs()
// {
//   Console.WriteLine("\nTotal RSVPs:");
//   for (int i = 0; i < count; i++)
//   {
//     Console.WriteLine(rsvps[i]);
//   }
// }


// ====================================================================
// Methods Challenge
// TellFortune();

// void TellFortune()
// {
//   Random random = new Random();
//   int luck = random.Next(100);

//   string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//   string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//   string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//   string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

//   Console.WriteLine("A fortune teller whispers the following words:");
//   string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//   for (int i = 0; i < 4; i++)
//   {
//     Console.Write($"{text[i]} {fortune[i]} ");
//   }
// }


// ====================================================================
// Methods Tutorial
// Console.WriteLine("Before calling a method");
// SayHello();
// Console.WriteLine("After calling a method");

// void SayHello() 
// {
//     Console.WriteLine("Hello World!");
// }

// int[] a = {1,2,3,4,5};

// Console.WriteLine("Contents of Array:");
// PrintArray();

// void PrintArray()
// {
//     foreach (int x in a)
//     {
//         Console.Write($"{x} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

// void DisplayRandomNumbers()
// {
//   Random random = new Random();

//   for (int i = 0; i < 5; i++)
//   {
//     Console.Write($"{random.Next(1, 100)} ");
//   }

//   Console.WriteLine();
// }

// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//   Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//   diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//   /* Adjust the times by adding the difference, keeping the value within 24 hours */
//   AdjustTimes();
// }
// else
// {
//   diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//   /* Adjust the times by adding the difference, keeping the value within 24 hours */
//   AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();
// void DisplayTimes()
// {
//   foreach (int val in times)
//   {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//       time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//       time = time.Insert(0, "0:");
//     }
//     else
//     {
//       time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
//   }

//   Console.WriteLine();
// }

// void AdjustTimes()
// {
//   for (int i = 0; i < times.Length; i++)
//   {
//     times[i] = ((times[i] + diff)) % 2400;
//   }
// }

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// foreach (string ip in ipv4Input) 
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }

// void ValidateLength()
// {
//   //string[] address = ipv4Input.Split(".");
//   validLength = address.Length == 4;
// }

// void ValidateZeroes()
// {
//   //string[] address = ipv4Input.Split(".");

//   foreach (string number in address)
//   {
//     if (number.Length > 1 && number.StartsWith("0"))
//     {
//       validZeroes = false;
//       return;
//     }
//   }

//   validZeroes = true;
// }

// void ValidateRange()
// {
//   //string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);

//   foreach (string number in address)
//   {
//     int value = int.Parse(number);
//     if (value < 0 || value > 255)
//     {
//       validRange = false;
//       return;
//     }
//   }
//   validRange = true;
// }


// ====================================================================
// String Methods Challenge
// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here
// int spanStart = input.IndexOf("<span>") + "<span>".Length;
// quantity = input.Substring(spanStart, input.IndexOf("</span>") - spanStart);
// output = input.Replace("<div>", "").Replace("</div>", "").Replace("trade", "reg");

// Console.WriteLine(quantity);
// Console.WriteLine(output);


// ====================================================================
// String Methods Tutorial
// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition++; // move to the first character inside the parentheses

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//   int openingPosition = message.IndexOf('(');
//   if (openingPosition == -1) break;

//   openingPosition += 1;
//   int closingPosition = message.IndexOf(')');
//   int length = closingPosition - openingPosition;
//   Console.WriteLine(message.Substring(openingPosition, length));

//   // Note the overload of the Substring to return only the remaining 
//   // unprocessed message:
//   message = message.Substring(closingPosition + 1);
//   Console.WriteLine($"Remaining message: '{message}'");
// }

// string message = "Hello, world!";
// char[] charsToFind = ['a', 'e', 'i'];

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);



// ====================================================================
// String Formating Basics Challenge
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine();
// Console.WriteLine($"Currently, you own {currentShares:N} that return {currentReturn:P2}.");
// Console.WriteLine();
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.");
// Console.WriteLine();
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);


// ====================================================================
// String Formating Basics Tutorial
// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string input = "Pad this";
// // Console.WriteLine(input.PadLeft(12));
// // Console.WriteLine(input.PadRight(12));
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);


// ====================================================================
// Array helpers challenge
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] result = pangram.Split(" ");
// string final = "";

// foreach (string word in result)
// {
//   char[] wordArray = word.ToCharArray();
//   Array.Reverse(wordArray);
//   final += new string(wordArray) + " ";
// }

// final = final.Trim();
// Console.WriteLine(final);

// Challenge 2
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// string[] orders = orderStream.Split(',');

// Array.Sort(orders);

// foreach (string order in orders)
// {
//   Console.Write(order);
//   if (order.Length != 4)
//     Console.WriteLine("\t- Error");
//   else
//     Console.WriteLine("");
// }


// ====================================================================
// Array helpers tutorial
// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2);
// // if (pallets[0] != null)
// //     Console.WriteLine($"After: {pallets[0].ToLower()}");

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// //string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


// ====================================================================
// Data Types Conversion Challenge
// string[] values = ["12.3", "45", "ABC", "11", "DEF"];
// decimal number = 0m;
// decimal total = 0;
// string message = "";

// foreach (string value in values)
// {
//   bool result = decimal.TryParse(value, out number);

//   if (result)
//     total += number;
//   else
//     message += value;
// }

// Console.WriteLine($"Message: {message}\nTotal: {total}");

// Challenge 2
// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// int result1 = Convert.ToInt32(value1 / value2);
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = Convert.ToDecimal(value2) / Convert.ToDecimal(value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// float result3 = value3 / (float)value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// ====================================================================
// Data Types Conversion Tutorial
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");


// ====================================================================
// Data Types Tutorial
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int[] data = new int[3];


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