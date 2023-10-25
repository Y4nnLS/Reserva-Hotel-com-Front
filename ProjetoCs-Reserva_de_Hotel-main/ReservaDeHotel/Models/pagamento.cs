using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Pagamento
{
    [Key]
    public int IdPagamento {get;set;}
    public int IdReservaEstadia { get; set;} // aqui teria que usar uma ForeignKey
    public string? MetodoPagamento { get; set;}
    public decimal Valor { get; set;} 
    public DateTime DataPagamento { get; set;}
}
