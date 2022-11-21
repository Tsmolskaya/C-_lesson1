//Вид 1 Ничего не принимают, ничего не возвращают.
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

//Вид 2 Ничего не возвращают, но принимают аргументы.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст");

//Вид 3 Что-то возвращают, но ничего не принимают.
int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 3 Что-то принимают, что-то возвращают.
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Z");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = i * j");
    }
    Console.WriteLine();
}

//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбнись, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replacestr(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replacestr(text, '', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);

// Алгоритм сортировки методом выбора (Алгоритм сортировки методом min max)

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Пишем метод который будет упорядочивать наш массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < arrayLenght -1 ; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)              //Ищем
        {
            if(array[j] < array[minPosition]) minPosition = j;  //максимальный
        }                                                       //элемент

        int temporary = array[i];
        array[i] = array[minPosition]; //Обмен 2х переменных местами
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);