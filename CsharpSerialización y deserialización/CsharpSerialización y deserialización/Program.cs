using System.Text.Json;


var mauricio = new People()
{
    Name = "Mauricio",
    Age = 25,
};


string json = JsonSerializer.Serialize(mauricio);

Console.WriteLine(json);

string myjson = @"{
    ""Name"":""Juan"",
    ""Age"":25
}";

//el signo se utiliza para que sepa que el "juan" es un objeto(string myjson = @"") en memoria pero que no contiene nada(nul) 
People? juan = JsonSerializer.Deserialize<People>(myjson);
Console.WriteLine(juan?.Name);
Console.WriteLine(juan?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}
