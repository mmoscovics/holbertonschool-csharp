using System;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public Dog(string name_pass, float age_pass, string owner_pass, Rating rating_pass)
    {
        name = name_pass;
        age = age_pass;
        owner = owner_pass;
        rating = rating_pass;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public override string ToString()
    {
        return $"Dog Name: {this.name}\nAge: {this.age}\nOwner: {this.owner}\nRating: {this.rating}";
    } 
}