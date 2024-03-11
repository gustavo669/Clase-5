class Program1
{
    static void Main(string[] args)
    {
        int numero;
        int mayor = int.MinValue;
        int menor = int.MaxValue;

        Console.WriteLine("Ingrese valores positivos (ingrese 0 para finalizar):");

        do
        {
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                if (numero > mayor)
                    mayor = numero;

                if (numero < menor)
                    menor = numero;
            }
            else if (numero < 0)
            {
                Console.WriteLine("Por favor, ingrese solo valores positivos.");
            }
        } while (numero != 0);

        if (mayor != int.MinValue && menor != int.MaxValue)
        {
            Console.WriteLine("El número mayor ingresado es: " + mayor);
            Console.WriteLine("El número menor ingresado es: " + menor);
        }
        else
        {
            Console.WriteLine("No se ingresaron números positivos.");
        }
    }
}
class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Piensa en un número y sigue las instrucciones:");

        Console.Write("1- Anota un número cualquiera: ");
        int numero = Convert.ToInt32(Console.ReadLine());
    
        int paso2 = numero * 2;
        Console.WriteLine($"2- Multiplica el número por 2: {numero} x 2 = {paso2}");

        int paso3 = paso2 + 8;
        Console.WriteLine($"3- Suma 8 al resultado: {paso2} + 8 = {paso3}");

        int paso4 = paso3 * 5;
        Console.WriteLine($"4- Multiplica el resultado por 5: {paso3} x 5 = {paso4}");

        Console.WriteLine("Entonces, ¿cuál es el resultado final?");
        int resultadoFinal = Convert.ToInt32(Console.ReadLine());

        int paso6 = resultadoFinal / 10;
        Console.WriteLine($"6- Anula la última cifra: {resultadoFinal} -> {paso6}");

        int paso7 = paso6 - 4;
        Console.WriteLine($"7- Resta 4 al resultado: {paso6} - 4 = {paso7}");

        Console.WriteLine($"El número que pensaste es: {paso7}");
    }
}
class Program3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();

        int contadorPalabras = 0;
        int contadorVocales = 0;
        int i = 0;

        while (i < frase.Length)
        {

            while (i < frase.Length && frase[i] == ' ')
            {
                i++;
            }

            while (i < frase.Length && frase[i] != ' ')
            {
                contadorPalabras++;

                i++;
            }
        }

        foreach (char caracter in frase.ToLower())
        {
            if ("aeiou".Contains(caracter))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine("Número de palabras en la frase: " + contadorPalabras);
        Console.WriteLine("Número de vocales en la frase: " + contadorVocales);
    }
}
class Program4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        bool esPalindromo = true;

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - 1 - i])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La palabra '" + palabra + "' es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra '" + palabra + "' no es un palíndromo.");
        }
    }
}