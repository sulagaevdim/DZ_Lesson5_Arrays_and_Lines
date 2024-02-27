// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] chars_matrix = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'},
    {'h', 'j', 'k'}
};
foreach (char chars in chars_matrix)
{
    System.Console.Write(chars);    
}