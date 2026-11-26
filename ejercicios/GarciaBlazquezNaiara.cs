//validador de DNI sin expresiones 
Console.WriteLine("Introduce tu DNI:");
string dni = Console.ReadLine();
if (validarDni(dni))
{
    if (calculoLetra(dni))
    {
        Console.WriteLine("Dni correcto");
    }
    else
    {
        Console.WriteLine("La letra del DNI es incorrecta");
    }
}
else
{
    Console.WriteLine("Valor incorrecto");
}
//metodos
bool  validarDni (string dni){
    int longitud = 9;
    bool longitudCorrecta=(dni?.Length == longitud);
    return longitudCorrecta;
}

bool calculoLetra(string dni)
{
    string parteNumerica = dni.Substring(0, 8);
    string letra = dni.Substring(8, 1);
    int.TryParse(parteNumerica, out int numero); 
    string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
    int operacion = numero % 23;
    char letraCorrecta = letras[operacion];
    char letraUsuario = char.ToUpper(dni[8]);
    if (letraUsuario==letraCorrecta )
    {
        return true;
    }

    return false;


}