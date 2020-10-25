public abstract class Pet 
{
    protected string name { get; }

    public Pet(string name) => this.name = name;

    public string GetName() => name;
}