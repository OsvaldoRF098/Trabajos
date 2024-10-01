/*Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
//Example: 
//First Pass: 
//( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1. 
( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4 
( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2 
( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them.*/

 int[] arreglos = new int[5];

 arreglos[0]=5;
 arreglos[1]=1;
 arreglos[2]=4;
 arreglos[3]=2;
 arreglos[4]=8;

 Console.WriteLine("Arreglos declarados");

for(var y=0; y<4; y++)
{
     for(var x=0; x<4; x++)
    {
        if(arreglos[x]>arreglos[x+1])
        {
            int temporal = arreglos[x];
            arreglos[x]=arreglos[x+1];
            arreglos[x+1]=temporal;

        }
     }
}


 for(var x=0; x<5; x++)
 {
    Console.WriteLine(arreglos[x]);
 }