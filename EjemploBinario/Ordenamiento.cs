public class Orden
{
    public void OrdenarA(int[] arr)
    {
        for(var y=0; y<4; y++)
        {
            for(var x=0; x<4; x++)
            {
                if(arr[x]>arr[x+1])
                {
                    int temporal = arr[x];
                    arr[x]=arr[x+1];
                    arr[x+1]=temporal;

                }
            }
        }


        for(var x=0; x<5; x++)
        {
            Console.WriteLine(arr[x]);
        }
    }
}
