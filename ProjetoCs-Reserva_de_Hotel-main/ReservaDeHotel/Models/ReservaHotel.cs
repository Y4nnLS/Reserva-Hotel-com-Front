using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservaDeHotel.Models
{
    public class ReservaHotel
    {
        [Key]
        public int IdReserva { get; set; }
        public string? NomeHospede { get; set; }
        public List<Pagamento>? Pagamento { get; set; }
        // public string? MetodoPagamento { get; set; } // está model Pagamento
        // public decimal Valor { get; private set; } // ta dentro da model Pagamento
        // [ForeignKey("Estadia")]
        // public int IdEstadia { get; set; } // se ele recebe a Estadia, precisa mesmo ter o IdEstadia aqui?
        public EstadiaHotel? Estadia { get; set; }

        // public ReservaHotel()
        // {
        // }

        // public ReservaHotel(int idReserva, string nomeHospede, string metodoPagamento, EstadiaHotel estadia)
        // {
        //     IdReserva = idReserva;
        //     NomeHospede = nomeHospede;
        //     MetodoPagamento = metodoPagamento;

        //     Estadia = estadia;
        //     IdEstadia = estadia.IdEstadia;

        //     CalcularValorReserva();
        // }

        // private void CalcularValorReserva()
        // {
        //     TimeSpan periodoEstadia = Estadia.DataSaida - Estadia.DataEntrada;
        //     int diasEstadia = periodoEstadia.Days;

        //     Valor = diasEstadia * Estadia.QtdQuartos;
        // }
    }
}
