/* clases y objejtos 

var sale = new Sale(15);
var message = sale.GetInfo();

Console.WriteLine(message);


class Sale
{
    public decimal Total { get; set; }


    public Sale(decimal total)
    {
        Total = total;
    }

    public string GetInfo()
    {
        return "El total es " + Total;
    }

}

*/

/*herencia


var sale = new SaleWithTax(15);
var message = sale.GetInfo();

Console.WriteLine(message);

//hijo (salewithtax)

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWithTax(decimal total) : base(total)
    {
        
    }

    public string GetInfoWithTax()
    {
        return "El total es " + Total + " impuesto es: " + Tax;
    }
}

//padre (sale)

class Sale
{
    public decimal Total { get; set; }


    public Sale(decimal total)
    {
        Total = total;
    }

    public string GetInfo()
    {
        return "El total es " + Total;
    }

}

*/




/*sobreescritura*/



var sale = new SaleWithTax(15, 2.6m); // Asumiendo un impuesto de 2.6m(m es po decimal), ajusta según sea necesario
var message = sale.GetInfo();


Console.WriteLine(message);

class SaleWithTax : Sale
{
    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo()
    {
        return "El total es " + Total + " impuesto es: " + Tax;
    }
}

class Sale
{
    public decimal Total { get; set; }


    public Sale(decimal total)
    {
        Total = total;
    }

    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }

}

