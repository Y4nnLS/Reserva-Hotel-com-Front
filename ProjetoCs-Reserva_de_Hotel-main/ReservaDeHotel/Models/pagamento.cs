using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservaDeHotel.Models;
public class Pagamento
{
    [Key]
    public int IdPagamento {get;set;}
    public string? MetodoPagamento { get; set;}
    public decimal Valor { get; set;} 
    public DateTime DataPagamento { get; set;}

    [ForeignKey("ReservaHotel")]
    public int IdReservaEstadia { get; set;} // aqui teria que usar uma ForeignKey
    public ReservaHotel ReservaHotel { get; set;}
}
