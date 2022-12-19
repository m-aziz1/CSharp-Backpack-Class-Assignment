Backpack blueBag = new Backpack("blue", "small"); 
Backpack redBag = new Backpack("red", "medium"); 
Backpack greenBag = new Backpack("green", "large"); 

blueBag.openBag();
blueBag.putIn("lunch");
blueBag.putIn("jacket");
blueBag.closeBag();
blueBag.putIn("testing");

public class Backpack
{
    public string Color;
    public string Size;
    public List<string> Items = new List<string>();
    public bool Open = false;

    public Backpack(string color, string size)
    {
        this.Color = color;
        this.Size = size;
    }

    public void openBag()
    {
        if (!this.Open)
        {
            this.Open = true;
            Console.WriteLine("Backpack has been opened");
        }
        else
        {
            Console.WriteLine("Backpack is already open");
        }
    }

    public void closeBag()
    {
        if (this.Open)
        {
            this.Open = false;
            Console.WriteLine("Backpack has been closed");
        }
        else
        {
            Console.WriteLine("Backpack is already closed");
        }
    }

    public void putIn(string item)
    {
        if (this.Open)
        {
            this.Items.Add(item);
            Console.WriteLine($"{item} has been added to the backpack");
        }
        else
        {
            Console.WriteLine("The backpack must be opened first to add items");
        }
    }

    public void takeOut(string item)
    {
        if (this.Open)
        {
            this.Items.Remove(item);
            Console.WriteLine($"{item} has been removed from the backpack");
        }
        else
        {
            Console.WriteLine("The backpack must be opened first to remove items");
        }
    }
}
