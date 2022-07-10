string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
        words[i] = words[i].ToLower();
        Console.WriteLine();
    }
return words;
}

void ShowArray (string[] array)
{
    for (int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int CountEYU( string [] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i][0] == 'e' || array[i][0] == 'y' || array[i][0] == 'u' || array[i][0] == 'i' || array[i][0] == 'o' || array[i][0] == 'a')
        count++;

return count;
}

Console.WriteLine("Введите четное количество слов"); //Для второй задачи
Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());

string [] names = CreateStringArray(size);
ShowArray(names);

//Console.WriteLine(CountEYU(names));

string [] ArrayCombination (string [] array)
    {
        string [] newArray = new string [array.Length];
            for (int i = 0; i < array.Length-1; i = i+2)
                newArray[i] = array[i] + array[i+1];
    
    return newArray;
    }


string [] array = ArrayCombination (names);
ShowArray(array);