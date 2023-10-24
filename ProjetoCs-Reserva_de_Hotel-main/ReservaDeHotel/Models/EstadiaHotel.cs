using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models
{
    public class EstadiaHotel
    {
        [Key]
        public int IdEstadia { get; set; }
        public int QtdQuartos { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public EstadiaHotel()
        {
        }

        public EstadiaHotel(int qtdQuartos, DateTime dataEntrada, DateTime dataSaida)
        {
            QtdQuartos = qtdQuartos;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }
    }
}
