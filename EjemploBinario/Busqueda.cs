public class BuscadorBinario
{
    public int BusquedaBinaria(int[] arr, int x)
    {
        int bajo = 0; 
        int alto = arr.Length - 1; 

        while (bajo <= alto)
        {
  
            int medio = bajo + (alto - bajo) / 2;

            
            if (arr[medio] == x)
                return medio;
         
            if (arr[medio] < x)
                bajo = medio + 1;

            else
                alto = medio - 1;
        }

        return -1;
    }
}
