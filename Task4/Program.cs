﻿// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string str = "My name is Dmitriy";
string[] array = str.Split();
for(int i = (array.Length - 1); i >= 0; i--)
{
    System.Console.Write(array[i] + " ");
}


