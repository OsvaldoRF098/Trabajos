 //imprementar busqueda binaria en arrays


int[] arr = { 3, 2, 4, 40, 10 };
int x = 10; 

Orden ordenar = new Orden();
ordenar.OrdenarA(arr);

BuscadorBinario buscador = new BuscadorBinario();

     
int resultado = buscador.BusquedaBinaria(arr, x);

     
if (resultado == -1)
    Console.WriteLine("Elemento no encontrado en el arreglo");
else
    Console.WriteLine("Elemento encontrado en el índice " + resultado);
