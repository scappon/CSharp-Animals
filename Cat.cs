public class Cat : Pet, ITalkable 
{
    private int mousesKilled { get; set; }

    public Cat(int mousesKilled, string name) : base(name) => this.mousesKilled = mousesKilled;

    public void AddMouse() => mousesKilled++;

    public string Talk() => "meow";

    public override string ToString() => $"Cat: name={name} mousesKilled={mousesKilled}";
}