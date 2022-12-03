void FillArray (int[] collection){
    int length = collection.Length;
    int i = 0;
    
    while(i < length)
    {
        collection [i] = new Random().Next(1, 10);
        i ++;
    }
}
 
void PrintArray (int [] col){
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write ($"{col[position]},");
        position ++;
    }
} 

int IndexOf (int[] collection, int find){
    int count = collection.Length;
    int i = 0;
    int remeber = -1;// -1 для того чтобы видеть что такого чисда нет в массиве для поиска его индекса в массиве

    while( i < count)
    {
         if ( collection[i] == find)
         {
            remeber = i;
            break;
        }
        i++;
    }
    return remeber;
}

int [] array = new int [10];
FillArray(array);

PrintArray(array);
int find2 = IndexOf(array, 5);
Console.WriteLine();
Console.WriteLine(find2);
