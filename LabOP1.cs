using System;


class Program 
{
public static float  x_starting=-1.5f;
public static float  x_ending=-2.5f;
public static float  step=-0.5f;
public static float  b=-1.5f;
public static float  y;

public static float current_x;

  
public static void Calculate_x(float x_to_calculate)
{
    y=x_to_calculate*x_to_calculate+MathF.Tan(x_to_calculate*5+b/x_to_calculate);
    Console.WriteLine("Для поточного x"+x_to_calculate.ToString()+"Результат:"+y.ToString());
    Console.WriteLine(""); //Робимо пустий ентер в консолі, щоб текст не зливався
}    
    
public static void Main() 
{
  
  Console.WriteLine("Введіть початкову межу");
  float.TryParse( Console.ReadLine(),out x_starting); //вводимо з клавіатури цифру
  
  Console.WriteLine("Введіть кінцеву межу");   
  float.TryParse( Console.ReadLine(),out x_ending); //вводимо з клавіатури цифру
  
  Console.WriteLine("Введіть крок функції");   
  float.TryParse( Console.ReadLine(), out step); //вводимо з клавіатури цифру
  //TryParse - переводимо текстовий тип данних в дробове число
  
  // Цей current_x в програмуванні називається "Ітератор"
   current_x = x_starting; // Ставимо x,який буде "крокувати" на початкову позицію 
   
  
  
  //до тих пір, поки поточний Х не вийшов за кінцеву межу (включно з кінцевою межою)
  while(current_x >= x_ending )
  {
    Calculate_x(current_x);// Обраховуэм y і виводимо його в консольку
    
    current_x = current_x+step; // Так як в нас крок відємний, мінус на плюс - мінус. 
    //Знач операція віднімання

    
  }
  
  
    
}



  
}