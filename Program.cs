Console.Clear();

int[] inventario = [200, 450, 700, 175, 250];

var sum = 0;
int numContenedores = 0;
foreach (var item in inventario)
{
    sum += item;
    numContenedores++;
    Console.WriteLine($"El contenedor {numContenedores} tiene {item} items. Habiendo un total de {sum} items en el inventario.");
}

Console.WriteLine($"Tengo {sum} items en el inventario, almacenados en {numContenedores} contenedores.");