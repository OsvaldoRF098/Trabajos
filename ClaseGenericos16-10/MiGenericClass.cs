public class MiGenericClass<T>
{
    private T genericMemberVariable;

    public MiGenericClass(T value)
    {
        this.genericMemberVariable = value;
    }

    public T GenercMethod (T genericParameter)
    {
        Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(),genericParameter);
        
        Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(),genericMemberVariable);
        return genericMemberVariable;
    }
    public T GenericProperty {get;set;}
}