string[] ConvertArray(string[] startArray)
{
    string str = string.Empty;
    int maxLengthString = 3;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= maxLengthString)
        {
            str += startArray[i] + " ";
        }
    }
    string[] convertArray = str.Trim().Split(" ");
    return convertArray;
}

string[] startArray = {"Hello", "2", "world", ":-)", "Лям"};
string[] convertedArray = ConvertArray(startArray);
Console.Write($"[{string.Join(", ", convertedArray)}]");
