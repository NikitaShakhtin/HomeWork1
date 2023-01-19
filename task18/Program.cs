// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
switch (i)
{
case 1:
{
WriteLine("x>0 y>0");
break;
}
case 2:
{
WriteLine("x<0 y>0");
break;
}
case 3:
{
WriteLine("x<0 y<0");
break;
}
case 4:
{
WriteLine("x>0 y<0");
break;
}
default:
{
WriteLine("Ошибка");
break;
}
}


Write("Введите номер четверти:");
bool isParse=int.TryParse(ReadLine(),out int i);
if(!isParse)
{
WriteLine("Введено не число");
return;
}