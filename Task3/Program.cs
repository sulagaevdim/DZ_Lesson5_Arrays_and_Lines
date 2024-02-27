// Задайте произвольную строку. Выясните, является ли она палиндромом.

string str = "шаввашшовваш";
bool result = false;
for (int i = 0; i < (str.Length / 2); i++)
{
    if (str[i] == str[str.Length - 1 - i])
    {
        result = true;
    }
    else {
        result = false;
        break;
    }
}
if (result) {System.Console.WriteLine("Да");}
else {System.Console.WriteLine("Нет");}