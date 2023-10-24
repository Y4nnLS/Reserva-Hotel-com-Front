using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservaDeHotel.Models;
public class Hotel
{
    [Key]
    public int IDHotel { get; set; }
    public string? Nome { get; set; }
    public string? Endereco { get; set; }
    public List<Avaliacao>? ListaAvaliacoes { get; set;}
    public string? Descricao { get; set; }
    public string? ListaDeQuartos { get; set; }
    public double AvaliacaoMedia { get; set; }
    public int NumeroTotalDeQuartos { get; set; }
    public int NumeroDeQuartosDisponiveis { get; set; }

    [ForeignKey("Dono")]
    public int IdDono { get; set; } // aqui teria que usar uma ForeignKey
    public Dono Dono {get; set;}
}
