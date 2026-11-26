using System.Text;

const int MaximoCarton = 6;

var numerosGanadores = GenerarCartonLoteria();
Console.WriteLine("Numeros ganadores de la gran loteria 2026:");
Console.WriteLine(string.Join(", ", numerosGanadores));

Console.WriteLine("Presione una tecla para salir");
Console.ReadKey();
return;

int[] GenerarCartonLoteria() {
    var rand = new Random();
    var cartonLoteria = new int[MaximoCarton];

    for (var i = 0; i < cartonLoteria.Length; i++) {
        int numero;
        do {
            numero = rand.Next(1, 50);
        } while (cartonLoteria.Contains(numero));

        cartonLoteria[i] = numero;
    }

    return cartonLoteria;
}

//Ejercicio generador de la loteria
//Elegi el ejercicio mas corto que tenia para evitar lios
