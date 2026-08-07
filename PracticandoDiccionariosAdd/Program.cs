public abstract class ProductoBase
{
    public string nombre_Producto { get; set; }
    public int Precio_Producto { get; set; }
}
 public class Bebida: ProductoBase
{
    public int litros {  get; set; }
}
public class Abarrotes : ProductoBase
{
    public int Kilos { get; set; }
}
public class Dulces : ProductoBase
{
}
class program {
    static void Main() {
Dictionary<string, List<ProductoBase>> Producto = new Dictionary<string, List<ProductoBase>>();

Console.WriteLine("Bienvenido");
Console.WriteLine("Desea continuar:  Si/No ");
string continuar = Console.ReadLine();
string miniscula = continuar.ToLower();
while (miniscula == "Si") {
    
    Console.WriteLine("Ingrese la categoria del producto que vende: ");
    string Categoria = Console.ReadLine();
    switch (Categoria.ToLower())
    {
        case "bebida":
                    var bebida = Bebidas(); // método devuelve un objeto Bebida
                    if (!Producto.ContainsKey("Bebidas"))
                        Producto["Bebidas"] = new List<ProductoBase>();
                    Producto["Bebidas"].Add(bebida);
                    break;
        case "Abarrotes":
            Abarrotes();
            break;
        case "Dulces":
            Dulces();
            break;

    }
            


}
}
static  Bebida Bebidas(){
    Console.WriteLine("Ingrese el nombre del producto que vende: ");
    string nombre_Producto = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto que vende: ");
    int Precio_Producto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los litros o ml del producto que vende: ");
    int Litros = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Se guardó la bebida: {nombre_Producto}, Precio: {Precio_Producto}, Litros: {Litros}");

        return new Bebida
        {
            nombre_Producto = nombre_Producto,
            Precio_Producto = Precio_Producto,
            litros = Litros
        };


    }

static  Abarrotes Abarrotes()
{
    Console.WriteLine("Ingrese el nombre del producto que vende: ");
    string nombre_Producto = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto que vende: ");
    int Precio_Producto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los kilos o gramos del producto que vende: ");
    int Kilos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Se guardó la bebida: {nombre_Producto}, Precio: {Precio_Producto}, Kilos/gramos: {Kilos}");

        return new Abarrotes
        {
            nombre_Producto = nombre_Producto,
            Precio_Producto = Precio_Producto,
            Kilos = Kilos
        };

    }

static Dulces Dulces()
{
    Console.WriteLine("Ingrese el nombre del producto que vende: ");
    string nombre_Producto = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del producto que vende: ");
    int Precio_Producto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Se guardó la bebida: {nombre_Producto}, Precio: {Precio_Producto}");

        return new Dulces
        {
            nombre_Producto = nombre_Producto,
            Precio_Producto = Precio_Producto
        };

    }
}