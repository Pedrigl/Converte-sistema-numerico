 static void main()
{
    Console.WriteLine("Por favor, digite o número que deseja converter no formato decimal.");
    converte(Console.ReadLine());
    Console.ReadLine();
    
}


static string converte(string numero)
{
    string str = "";
    int number;
    char primeiro = numero.First();
    
    int[] chars = new int[4];
    chars[0] = 2; chars[1] = 8; chars[2] = 10; chars[3] = 16;
    number = int.Parse(numero);
    string texto = "";
    for (int i = 0; i < chars.Length; i++)
    {
        switch (chars[i])
        {
            case 2:
                texto = "em binário é:";
               break;

            case 8:
                texto = "em octal é:";
                break;

            case 10:
            texto = "em decimal é:";
                break;

            case 16:
                texto = "em hexadecimal é:";
                break;

        }
        str = Convert.ToString(number, chars[i]);
        Console.WriteLine(texto + " "+ str);
    }
            
    return str;
}

main();
