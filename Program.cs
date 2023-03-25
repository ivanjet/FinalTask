string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "Rus",
"-2", "computer science", "Russia", "Denmark", "Kazan", "NO", "RUN", "geek", "dot" };
int count = ArrayCheck(array);
string[] resArray = FillResArray(array, count);
int ArrayCheck(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
string[] FillResArray(string[] array, int count)
{
    string[] res = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            res[res.Length - count] = array[i];
            count--;
        }
    }
    return res;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}
PrintArray(resArray);