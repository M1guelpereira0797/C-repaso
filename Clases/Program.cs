public class Persona
{
    // Propiedades privadas con get y set
    private string Nombres { get; set; }
    private int Edad { get; set; }
    private string Direccion { get; set; }
    private string Apellidos { get; set; }

    // Constructor que obliga a inicializar todos los campos
    public Persona(string nombres, int edad, string direccion, string apellidos)
    {
        this.Nombres = nombres;
        this.Edad = edad;
        this.Direccion = direccion;
        this.Apellidos = apellidos;
    }
}