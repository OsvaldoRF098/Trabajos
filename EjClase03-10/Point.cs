public struct Point
{
    public short X { get; set; }
    public short Y { get; set; }
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public void D()
    {
        Console.WriteLine($"Cordenadas: ({X}, {Y})");
        Console.WriteLine($"Color: RGB({R}, {G}, {B})");
    }
}
