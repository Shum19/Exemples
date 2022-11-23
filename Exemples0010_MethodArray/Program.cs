/*int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3; 
    return result; 
}*/
//                0  1  2 3  4  5 6  7 8
int [] digits = {12,26,34,4,81,16,7,81,9};
int n = digits.Length;
int find = 81;
int i = 0;
while (i < n)
{
    if (digits[i] == find)
    {
        Console.WriteLine($"Ваше число {i}");
        break;
    }
    i ++;
}
/*int max1 = Max(digits[0], digits[1], digits[2]),
    max2 = Max(digits[3], digits[4], digits[5]),
    max3 = Max(digits[6], digits[7], digits[8]),
    max = Max(max1, max2, max3);
*/

