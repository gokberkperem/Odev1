#region Homework1
//Console.Write("Please enter a positive number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("You need to enter {0} positive numbers.", n);

//int[] numberarray = new int[n];

//for (int i = 1; i < n + 1; i++)
//{

//    Console.Write("Number {0}: ", i);
//    numberarray[i - 1] = Convert.ToInt32(Console.ReadLine());
//}

//Console.Write("Even numbers you entered: ");
//foreach (var number in numberarray)
//{
//    if (number % 2 == 0)
//    {
//        Console.Write(" " + number + ",");
//    }
//}
#endregion

#region Homework2
//Console.WriteLine("Please enter 2 positive numbers");
//Console.Write("First number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Second number: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("You need to enter {0} positive numbers.", n);

//int[] numberarray = new int[n];

//for (int i = 0; i < numberarray.Length; i++)
//{

//    Console.Write((i + 1) + ". Number : ");
//    numberarray[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int j = 0; j < numberarray.Length; j++)
//{
//    if (m % numberarray[j] == 0)
//    {
//        Console.WriteLine(numberarray[j]);
//    }
//} 
#endregion

#region Homework3
//Console.Write("Please enter a positive number: ");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("You need to enter " + n + " words.");

//string[] wordarray = new string[n];

//for (int i = 0; i < wordarray.Length; i++)
//{
//    Console.Write((i + 1) + ". Word : ");
//    wordarray[i] = Console.ReadLine();
//}

//Array.Reverse(wordarray);

//foreach (var word in wordarray)
//{
//    Console.WriteLine(word);
//} 
#endregion

#region Homework4
//Console.Write("Please enter a sentence: ");
//string sentence = Console.ReadLine();
//sentence = sentence.ToLower();

//int numberofcharacters = sentence.Count();

//string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";

//int numberofletters = 0;
//for (int i = 0; i < numberofcharacters; i++)
//{
//    if (letters.Contains(sentence[i]))
//    {
//        numberofletters++;
//    }
//}

//Console.WriteLine("Number of letters the sentence you entered: " + numberofletters);


//string[] words = sentence.Split(' ');

//Console.WriteLine("Number of words the sentence you entered: " + words.Length); 
#endregion