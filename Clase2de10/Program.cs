using System.Net.Mail;

Console.WriteLine("Hola mundo");

Map map = new Map();
map.latitude = 100;
map.Long = 200;

long x = 40;
long y = 50;
MoveMap(map, x, y, out long oldlatitud );

MoveMapX(map, x);

Console.WriteLine(map.latitude);
Console.WriteLine(x);

Console.WriteLine(oldlatitud);

MoveMapFunc(map, x, y);


static void MoveMap(Map map, long x, long y, out long oldlatitud)
{
    oldlatitud = map.latitude;
    map.latitude += x;

    x = 10;
    y = 20;
}

static void MoveMapX(Map map, long x, long y=10)
{
    map.latitude += x;

    x = 10;
    y = 20;
}


static void swapValue(int oldvalue, int newvalue)
{
    int temp = oldvalue;
    oldvalue = newvalue;
    newvalue = temp;
}

//se crea un nuevo mapa para no perder modificaciones
static Map MoveMapFunc(Map map, long x, long y)
{
    Map newMap = map;
    newMap.latitude += x;
    newMap.Long += y;
    return newMap;
}