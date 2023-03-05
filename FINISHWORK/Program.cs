string[] myarray = {"Hello", "=)", "567", "formant", "8", "some"} ;
string[] newarray = new string[myarray.Length];

void CheckSymbols(string[] myarray)
{
    int count = 0;
    for(int i = 0; i < myarray.Length; i++)
    {
       if(myarray[i].Length <= 3)
       {
        newarray[count] = myarray[i];
        count++;
       }
    }
}
 void PrintArray(string[] array)
 {
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
 }
