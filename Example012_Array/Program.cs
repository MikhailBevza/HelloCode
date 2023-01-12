// Var 1
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
*/

// Var2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "Текст", count: 4);
*/


// Var3
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

// Var4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "q");
Console.WriteLine(res);
*/

// пример с циклом for
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "q");
Console.WriteLine(res);
*/


// Таблица умножения
/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Задача. Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" заменить
// маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаяСь, - что, "
            + "ежели бы вас поСлали вместо нашего милого Винценгероде, "
            + "вы бы взяли приСтупом Согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/
// string s = "qwerty"
//             012
// s[3] // r
/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += newValue;
        else result += text[i];
    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/


// Упорядочить массив. Алгоритм сортировки методом выбора.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int length = array.Length;

    for(int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);