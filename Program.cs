﻿Console.Title = "Classes";
/*
//Forest Forest = new Forest();
////using setters
//Forest.Name = "Amazon";
//Forest.age = 29;


//Forest.name = "using field";
//Forest.Name = "using property"; 


//Console.WriteLine($"{Forest.Name} & {Forest.age}");
//Forest.Name = "Test";
//Console.WriteLine(Forest.Name);

//Forest.Biome = "Tropical";
//Console.WriteLine(Forest.Biome);

//Console.WriteLine(Forest.Name);


//calling the constructor with arguments
Forest forest = new Forest("Kyle", "Tropical");
Console.WriteLine($"{forest.Name} {forest.Biome}");

class Forest
{
    //just a standard public name property in the Forest class
    public string name;
    //using getter and setters within the same property
    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}

    //this is the same as above, but shorthand
    public string Name 
    {
        get { return name; }
        set
        {
            if (value == "Test")
            {
                Console.WriteLine("This was a test");
            }
            name = value;
        }
    }


    public int age;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public int trees;
    public string biome;
    public string Biome
    {
        get { return biome; }
        set 
        {
            if (value == "Tropical" || value == "Temperate" || value == "Boreal")
            {
                biome = value;
            }
            else
            {
                Console.WriteLine("Unkwown");
            }
        
        }
    }
    public Forest(string name, string biome)
    {
        Name = name; Biome = biome;

    }
}
*/

Console.WriteLine("Dating App v 1");

Profile profile = new Profile("Kyle", 29, "k", "lk");

profile.Age = 28;
Console.WriteLine(profile.Age);
Console.WriteLine(profile.Pronouns);

profile.SetHobbies(new string[] {"test", "test2", "test3" });
profile.ViewProfile();

public class Profile
{
    //fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    //constructors
    public Profile()
    {

    }

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
        this.name = name;
        this.age = age;
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;

    }

    //properties
    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } set { age = value; } }
    public string City { get { return city; } set { city = value; } }
    public string Country { get { return country; } set { country = value; } }
    public string Pronouns { get { return pronouns; } set { pronouns = value; } }
    public string[] Hobbies { get { return hobbies;} set { hobbies = value; } }

    //methods
    public string ViewProfile()
    {
        string bio = $"{Name}, {Age}, {City}, {Country} ";
        Console.WriteLine(bio);
        foreach (string hobbie in hobbies)
        {
            Console.WriteLine(hobbie);
        }
        return bio;
    }

    public void SetHobbies(string[] hobbies)
    {
        this.Hobbies = hobbies;

    }
}