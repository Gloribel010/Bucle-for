// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int dato1, dato2;
Console.WriteLine("Escriba el primer nummero");
dato1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba el segundo numero");
dato2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"LOS NUMEROS PARES ENTRE LOS DATOS INGRESADOS {dato1} y {dato2} son:");
for (int i = dato1; i<= dato2; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
