//Тема 24. Рекурсия. Домашнее задание.
//Console.Write("Введите слово: ");
//string word = Console.ReadLine();
//if (IsPalindrome(word))
//{
//    Console.WriteLine("Is a palindrom");
//}
//else
//{
//    Console.WriteLine("Not a palindrom");
//}
//bool IsPalindrome(string word)
//{
//    if (word.Length <= 1)
//        return true;

//    // Сравниваем первый и последний символы
//    if (word[0] == word[word.Length - 1])
//    {
//        // Рекурсивный вызов для оставшейся части строки
//        return IsPalindrome(word.Substring(1, word.Length - 2));
//    }
//    else
//    {
//        return false;
//    }
//}
//Тема 24. Рекурсия. Домашнее задание.
//Урок 2/2
//Console.Write("Введите любое положительное число:");
//int n=int.Parse(Console.ReadLine()!);
//PrintOddNumbers(n);
//void PrintOddNumbers(int n)
//{
//        if (n <= 0) return;
//    PrintOddNumbers(n - 1);
//    if (n % 2 != 0)
//    {
//        Console.WriteLine(n);
//    }
//}