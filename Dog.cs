public class Dog : Pet, ITalkable 
{
    private bool friendly;

    public Dog(bool friendly, string name) : base(name) => this.friendly = friendly;

    public bool IsFriendly() => friendly;

    public string Talk() => "Bark";

    public override string ToString() => $"Dog: name={name}, friendly={friendly}";
} 