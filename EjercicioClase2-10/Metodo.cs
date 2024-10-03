public class Metodo
{

    public static int Potencia(int numeroBase, int exponente)
    {
        int resultado = 1; 

       
        for (int i = 0; i < exponente; i++)
        {
            resultado *= numeroBase;
        }

        return resultado;
    }
}
