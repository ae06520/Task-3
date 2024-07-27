
using System.Security.Cryptography;

class Person
{
   protected string id;
   protected string name;
   public Person()
    {
        id = "";
        name = "";
    }
    public Person(string name,string id)
    {
        this.name = name;
        this.id = id;
    }
     

}
class Empolyee:Person
{
    protected float salary;
    public Empolyee():base()
    {
        salary = 0f;
    }
    public Empolyee(string name,string id,float salary):base(name,id)
    {
        this.salary = salary;
    }

}
class Manger:Empolyee
{
    private float bouns;
    public Manger():base()
    {
        bouns = 0f;
    }
    public Manger(string name,string id,float salary,float bouns):base(name, id, salary)
    {
        this.bouns = bouns;
    }
}

class Test
{
    public static void Main(string[]arg)
    {
        Person p1=new Person("ahmed","1");
        Person p2=new Person("Mohmmad","2");
        Person p3=new Person("abdo","3");
        Empolyee E1 = new Empolyee();
        Manger M1 = new Manger();


    }
}