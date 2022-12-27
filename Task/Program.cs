// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. Прии решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.


string [] inArray = {"rhkgh", "fox", "cow1", "chicken", "horse", "me", "la"};
string [] resultArray = ArrayOfLessThree(inArray);


Console.Write("[");
Console.Write($"{String.Join(", ", resultArray)}");
Console.Write("]");


//========================Метод формирования массива из строк длиной <= 3 символа

string [] ArrayOfLessThree(string [] inArray)
{
    string [] tempArray = new string [inArray.Length];

    int number = 0;
    for(int i=0; i<inArray.Length; i++)
    {
            if(inArray[i].Length<=3)
        {
            tempArray[number] = inArray[i];
            number++;
        } 
    }

    string [] resultArray = new string [number];

    for(int i =0; i<number; i++)
    {
    resultArray[i] = tempArray[i];
    }
    return resultArray;
}

