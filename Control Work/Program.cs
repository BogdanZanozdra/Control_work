
string [] array = {"Hello", "Hi", "CSharp", "GB", "555"};
string [] resultArray = new string [array.Length];
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    resultArray[i] = array[i];

}
Console.Write($"[{String.Join(", ", array)}] -> [{String.Join(", ", resultArray)}]");