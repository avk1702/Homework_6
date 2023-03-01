//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 double Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  double result = Convert.ToDouble(ReadInput);
  return result;
}
double X(double b1,double k1,double b2,double k2)
{
double x = (b2 - b1)/(k1 - k2);
return x;
}
double Y(double b1,double k1,double b2,double k2)
{
  double y = y = k1 * (b2 - b1)/(k1 - k2) + b1;
  return y;
}

double b1 = Prompt ("Введите число b1:  ");
double k1 = Prompt ("Введите число k1:  ");
double b2 = Prompt ("Введите число b2:  ");
double k2 = Prompt ("Введите число k2:  ");

Console.WriteLine($"Координаты точки пересечения двух прямых: x =  {X(b1,k1,b2,k2)}  y =  {Y(b1,k1,b2,k2)}");

//Console.WriteLine(Y(b1,k1,b2,k2));
