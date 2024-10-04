struct Employee{
    public int EmpId;

    public string FirstName;

    public string LastName;

    public PositionType Position;

    public WonderOfTheAncientWorld WondersVisited;

    static Employee()
    {
        Console.Write("First object created");
    }

    public Employee(int empid, string fname, string lname )
    {
        EmpId=empid;
        FirstName=fname;
        LastName=lname;
    }
    public void Print() => Console.WriteLine($" {EmpId} {FirstName} {LastName}");
}