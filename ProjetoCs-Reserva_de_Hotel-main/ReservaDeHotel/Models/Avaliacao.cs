using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservaDeHotel.Models;
public class Avaliacao
{
    [Key]
    public int IdAvaliacao {get;set;}
    public int AvaliacaoEstrelas { get; set;}
    public string? Comentario { get; set;}
    public DateTime DataAvaliacao { get; set;}
    
    [ForeignKey("Hotel")]
    public int IdHotel { get; set;} // aqui teria que usar uma ForeignKey
    public Hotel Hotel {get; set;}
}
