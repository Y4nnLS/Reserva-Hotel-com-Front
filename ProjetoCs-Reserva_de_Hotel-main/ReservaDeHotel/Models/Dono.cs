using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Dono
{
    [Key]
    public int DonoId {get;set;}
    public string? Nome { get; set;}
    public int NumeroTelefone { get; set;}
    public string? Email { get; set;}
    public string? Login { get; set;}
    public string? Senha { get; set;}
    public List<Hotel>? ListaHoteis { get; set;}

    public Dono()
    {
        ListaHoteis = new List<Hotel>();
    }
}