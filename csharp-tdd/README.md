# 0x07. C# - Test Driven Development
## Tasks
### 0. Add integers
Write a method that adds 2 numbers

-   Namespace:  `MyMath`
-   Class:  `Operations`
-   Prototype:  `public static int Add(int a, int b)`
-   Returns: sum of  `a`  and  `b`
-   Test Library Namespace:  `MyMath.Tests`
-   It is not necessary to account for integer overflow in this task

-   Directory:  [`0-add/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/0-add)
-   File:  [`MyMath.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/0-add/MyMath/MyMath.cs), [`MyMath.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/0-add/MyMath.Tests)

### 1. Divide a matrix

Write a method that divides all elements of a matrix.

-   Namespace:  `MyMath`
-   Class:  `Matrix`
-   Prototype:  `public static int[,] Divide(int[,] matrix, int num)`
-   Returns: a new matrix containing divided elements
-   If  `num`  is  `0`, print  `Num cannot be 0`  and return  `null`. (Hint: use  `try`  /  `catch`)
-   If  `matrix`  is  `null`, return  `null`

-   Directory:  [`1-divide/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/1-divide)
-   File:  [`MyMath.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/1-divide/MyMath/MyMath.cs), [`MyMath.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/1-divide/MyMath.Tests)

### 2. Max integer

Write a method that returns the max integer in a list of integers.

-   Namespace:  `MyMath`
-   Class:  `Operations`
-   Prototype:  `public static int Max(List<int> nums)`
-   Returns: max integer in list
-   If  `nums`  is empty, return  `0`

-   Directory:  [`2-max_int/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/2-max_int)
-   File:  [`MyMath.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/2-max_int/MyMath/MyMath.cs), [`MyMath.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/2-max_int/MyMath.Tests)

### 3. Desserts, I stressed!

Write a method that returns  `True`  if a string is a palindrome or  `False`  if it’s not.

-   Namespace:  `Text`
-   Class:  `Str`
-   Prototype:  `public static bool IsPalindrome(string s)`
-   Returns:  `True`  if string is a palindrome,  `False`  if it’s not
    
-   In this task, palindromes are  **not**  case sensitive
    
    -   `Racecar`  = True
    -   `level`  = True
-   Spaces and punctuation should be ignored
    
    -   `A man, a plan, a canal: Panama.`  = True
-   An empty string is considered a palindrome

-   Directory:  [`3-palindrome/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/3-palindrome)
-   File:  [`Text.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/3-palindrome/Text/Text.cs), [`Text.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/3-palindrome/Text.Tests)

### 4. Unique character

Write a method that returns the index of the first non-repeating character of a string.

-   Namespace:  `Text`
-   Class:  `Str`
-   Prototype:  `public static int UniqueChar(string s)`
-   Returns: index of first non-repeating character or  `-1`  if there is no non-repeating character
-   You can assume the string contains only lowercase letters, no spaces or special characters

-   Directory:  [`4-unique/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/4-unique)
-   File:  [`Text.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/4-unique/Text/Text.cs), [`Text.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/4-unique/Text.Tests)

### 5. camelCase

Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.

-   Namespace:  `Text`
-   Class:  `Str`
-   Prototype:  `public static int CamelCase(string s)`
-   Returns: number of words in  `s`

-   Directory:  [`5-camelcase/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/5-camelcase)
-   File:  [`Text.cs`](https://github.com/Titania792/holbertonschool-csharp/blob/main/0x07-csharp-tdd/5-camelcase/Text/Text.cs), [`Text.Tests/`](https://github.com/Titania792/holbertonschool-csharp/tree/main/0x07-csharp-tdd/5-camelcase/Text.Tests)