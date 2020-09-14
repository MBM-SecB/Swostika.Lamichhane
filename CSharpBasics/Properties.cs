class Person
{
    private int age=23;
    internal string name="Swostika";

    public string  Name { get; set; }

    public string Address{get;}

    public int Age{
        get
        {
            return age;
        }
        set
        {
            if(value>20 && value<30)
             {
                 age=value;
             }
        }
     }

}