using System.Runtime.CompilerServices;
byte edad;
Console.WriteLine("Cual es su edad");
edad = byte.Parse(Console.ReadLine());
Console.WriteLine("No aparentas " + edad);


byte f1, f2;
ushort resultado;
Console.WriteLine("Ingrese el primer numero");
f1 = byte.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero");
f2 = byte.Parse(Console.ReadLine());

resultado = (ushort)(f1 * f2);
Console.WriteLine("el resultado es: " + resultado);

long s1, s2, m1, m2, m3;
Console.WriteLine("Ingresar el primer numero");
s1 = long.Parse(Console.ReadLine());

Console.WriteLine("Ingresar el segundo numero");
s2 = long.Parse(Console.ReadLine());
m1 = s1 + s2;
m2 = s1 - s2;
m3 = s1 * s2;

Console.WriteLine("el resultado de la suma es:  " + m1);
Console.WriteLine("el resultado de la resta es : " + m2);
Console.WriteLine("el resultado de la multiplicacion es: " +m3);



