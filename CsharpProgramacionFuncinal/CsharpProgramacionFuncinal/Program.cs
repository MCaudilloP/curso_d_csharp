/*Console.WriteLine(Sub(2, 1));


//la siguiente es una funcion pura
int Sub(int a, int b)
{
    return a - b;
}

*/

/*

//la siguiente no es una funcion pura, por que? Por que si la ejecutas hoy te regresa el valor de mañana, etc.. 
DateTime GetTomorrow()
{
    return DateTime.Now.AddDays(1);
}
*/

/*

//DateTime en Csharp no es un objeto es un struct
//un struct es un  elemento en Csharp que pasa por valor y no como referencia(como en los objetos)
//DateTime date = DateTime.Now;
DateTime date = new DateTime(2024, 02, 9);


Console.WriteLine(GetTomorrow(date));


//esto  se arregla de la siguiente manera
//de esta manera nosotros podemos otorgar el valor de manera externa
DateTime GetTomorrow(DateTime date)
{
    return date.AddDays(1);
}
*/


/*
// Crear una nueva instancia de Beer con el nombre "guinness"
var beer = new Beer()
{
    Name = "guinness"
};

// Definir una función que convierte el nombre de una cerveza a mayúsculas
Beer ToUpper(Beer beer)
{
    //de esta manera evitamos modificar el elemento externo
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper(),
    };
    // Convertir el nombre de la cerveza recibida a mayúsculas
    //beer.Name = beer.Name.ToUpper();
    // Devolver la cerveza modificada
    return beer2;
}

// Llamar a la función ToUpper con la cerveza "beer" y luego imprimir el nombre en mayúsculas
Console.WriteLine(ToUpper(beer).Name);

// Imprimir el nombre de la cerveza "beer" (que ha sido modificado por la función ToUpper)
Console.WriteLine(beer.Name);

// Definir la clase Beer con una propiedad Name
class Beer
{
    public string Name { get; set; }
}
*/

/*

var show = Show;

Some(show, "Hola como estas");

void Show(string message)
{
    Console.WriteLine(message);
}
//si tu funcion no regresa nada se puede usar el metodo action
void Some(Action<string> fn,string message)
{
    Console.WriteLine("Hace algo al inicio");
    fn(message);
    Console.WriteLine("Hace algo al final");
}

*/
//######

var show = Show;

Some(show, "Hola como estas");

string Show(string message)
{
    return message.ToUpper();
};

//si quieres que tu funcio regrese algo()o va a regresar algo) se usa el metodo Func
void Some(Func<string, string> fn, string message)
{
    Console.WriteLine("Hace algo al inicio");
    fn(message);
    Console.WriteLine("Hace algo al final");
}