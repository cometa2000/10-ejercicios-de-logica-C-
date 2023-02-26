class Logica
{
    public void ejercicio1()
    {
        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola "+nombre);
        Console.ReadKey();
    }
    public void ejercicio2()
    {
        Console.WriteLine("Escribe la base");
        double baseR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la altura");
        double altura = Convert.ToInt32(Console.ReadLine());
        double perimetro = 2 * (baseR + altura);
        double area = baseR * altura;
        Console.WriteLine("El perimetro es "+perimetro+"El area es "+area);
        Console.ReadKey();
    }
    public void ejercicio3()
    {
        double cateto1 = 10;
        double cateto2 = 4;
        cateto1 = Math.Pow(cateto1, 2);
        cateto2 = Math.Pow(cateto2, 2);
        double hipotenusa = Math.Sqrt(cateto1 + cateto2);
        Console.WriteLine("La hipotenusa es " + hipotenusa);
        Console.ReadKey();
    }
    public void ejercicio4()
    {
        double valor1 = 10;
        double valor2 = 5;
        Console.WriteLine("La suma es " + (valor1 + valor2));
        Console.WriteLine("La resta es " + (valor1 - valor2));
        Console.WriteLine("La multiplicacion es " + (valor1 * valor2));
        Console.WriteLine("La divicion es " + (valor1 / valor2));
        Console.ReadKey();
    }
    public void ejercicio5()
    {
        double fahrenheit = 68;
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Los frados °C son " + celsius);
        Console.ReadKey();
    }
    public void ejercicio6()
    {
        Console.WriteLine("Escribe el numero 1");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el numero 2");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el numero 3");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        int media = (numero1 + numero2 + numero3) / 3;
        Console.WriteLine("La media o premedio es " + media);
        Console.ReadKey();
    }
    public void ejercicio7()
    {
        int minutos = 1000;
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;
        Console.WriteLine("Las horas son " + horas + " Los minutos " + minutosRestantes);
        Console.ReadKey();
    }
    public void ejercicio8()
    {
        double sueldoBase = 10000;
        double totañTresVentas = 5000;
        double comisino = totañTresVentas * .1;
        Console.WriteLine("El sueldo es " + sueldoBase);
        Console.WriteLine("Total de las ventas es  " + totañTresVentas+);
        Console.WriteLine("Sueldo total es " + (comisino + sueldoBase));
        Console.ReadKey();
    }
    public void ejercicio9()
    {
        double totalCompra = 3000;
        double compraDescuento = totalCompra * .15;
        double totalCompraDescuento = totalCompra - compraDescuento;
        Console.WriteLine("El total de la compra es $" + totalCompra);
        Console.WriteLine("Con descuento del 15% es $" + totalCompraDescuento);
        Console.ReadKey();
    }
    public void ejercicio10()
    {
        double calificacion1 = 10;
        double calificacion2 = 8;
        double calificacion3 = 9;
        double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
        double parcial = promedio * .55;
        double examenFinal = 10 * .3;
        double trabajoFinal = 8 * .15;
        double calificacionFinal = examenFinal + trabajoFinal+parcial;
        Console.WriteLine("Tu califiacion es " + calificacionFinal);
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Logica obj = new Logica();
        obj.ejercicio2();
    }
}