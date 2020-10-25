public class Teacher : Person, ITalkable 
{
    private int age { get; set; }

    public Teacher(int age, string name) : base(name) => this.age = age;

    public string Talk() => "Don't forget to do the assigned reading!";
}