Console.Clear();
/*устанавливает курсор в определеной строке; в данном случае на 4-ой строчке и на позиции 11 символа так отсчет идет с 0!
Console.SetCursorPosition(10, 4); 
Console.WriteLine("+");*/

// создаем три точки в консоле
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // просто выбрана любая точка
int i = 0; 

while (i < 10000){
    int what = new Random().Next(0, 3); //[0, 1, 2]
    if (what == 0){
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (what == 1){
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if (what == 2){
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    i++;
}



