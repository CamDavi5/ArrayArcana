
MajorArcana[] ArcanaArray = new MajorArcana[22];
int x  = 0;

MajorArcana Fool = new MajorArcana(x, "The Fool", "a beggar or vagabond");
ArcanaArray[x] = Fool;
x++;

MajorArcana Magician = new MajorArcana(x, "The Magician", "a sleight of hand artist");
ArcanaArray[x] = Magician;
x++;

MajorArcana HighPriestess = new MajorArcana(x, "The High Priestess", "a priestess with a crown");
ArcanaArray[x] = HighPriestess;
x++;

MajorArcana Empress = new MajorArcana(x, "The Empress", "a woman with a crown and scepter");
ArcanaArray[x] = Empress;
x++;

MajorArcana Emperor = new MajorArcana(x, "The Emperor", "a man with a crown, scepter, and globe");
ArcanaArray[x] = Emperor;
x++;

MajorArcana Hierophant = new MajorArcana(x, "The Hierophant", "a man with his hand raised and staff");
ArcanaArray[x] = Hierophant;
x++;

MajorArcana Lovers = new MajorArcana(x, "The Lovers", "a nude man and woman");
ArcanaArray[x] = Lovers;
x++;

MajorArcana Chariot = new MajorArcana(x, "The Chariot", "a man in a chariot, pulled by sphinx");
ArcanaArray[x] = Chariot;
x++;

MajorArcana Justice = new MajorArcana(x, "Justice", "a person with a sword and weighing scale");
ArcanaArray[x] = Justice;
x++;

MajorArcana Hermit = new MajorArcana(x, "The Hermit", "an old man with a staff and lantern");
ArcanaArray[x] = Hermit;
x++;

MajorArcana WheelOfFortune = new MajorArcana(x, "Wheel of Fortune", "the wheel of the goddess Fortuna");
ArcanaArray[x] = WheelOfFortune;
x++;

MajorArcana Strength = new MajorArcana(x, "Strength", "a woman and a lion");
ArcanaArray[x] = Strength;
x++;

MajorArcana HangedMan = new MajorArcana(x, "The Hanged Man", "a man hanging upside down on one foot");
ArcanaArray[x] = HangedMan;
x++;

MajorArcana Death = new MajorArcana(x, "Death", "an armored skeleton on a horse");
ArcanaArray[x] = Death;
x++;

MajorArcana Temperance = new MajorArcana(x, "Temperance", "an angel pouring liquid between chalices");
ArcanaArray[x] = Temperance;
x++;

MajorArcana Devil = new MajorArcana(x, "The Devil", "an animalistic devil with a pentagram");
ArcanaArray[x] = Devil;
x++;

MajorArcana Tower = new MajorArcana(x, "The Tower", "a burning tower");
ArcanaArray[x] = Tower;
x++;

MajorArcana Star = new MajorArcana(x, "The Star", "a nude woman pouring liquid onto water and land");
ArcanaArray[x] = Star;
x++;

MajorArcana Moon = new MajorArcana(x, "The Moon", "two wolves howling at the moon");
ArcanaArray[x] = Moon;
x++;

MajorArcana Sun = new MajorArcana(x, "The Sun", "an infant riding a horse beneath the sun");
ArcanaArray[x] = Sun;
x++;

MajorArcana Judgement = new MajorArcana(x, "Judgement", "an angel blowing on a trumpet");
ArcanaArray[x] = Judgement;
x++;

MajorArcana World = new MajorArcana(x, "The World", "a nude woman holding two staves");
ArcanaArray[x] = World;

void StartHere()
{
    Console.WriteLine("Welcome to the Major Arcana list, type a number 0-21 to select an Arcana: ");
    int input = Convert.ToInt32(Console.ReadLine());
    MajorArcana obj = ArcanaArray[input];
    Console.WriteLine("You selected {0}, {1} - depicted by {2}.", obj.Number, obj.Name, obj.Description);
}

StartHere();

public class MajorArcana
{
    public int Number { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public MajorArcana(int number, string name, string description)
    {
        Number = number;
        Name = name;
        Description = description;
    }
}

