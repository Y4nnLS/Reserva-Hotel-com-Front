export class EstadiaHotel {
    IdEstadia: number = 0;
    QtdQuartos: number = 0;
    DataEntrada: Date = new Date();
    DataSaida: Date = new Date();

    constructor(qtdQuartos: number, dataEntrada: Date, dataSaida: Date) {
        this.QtdQuartos = qtdQuartos;
        this.DataEntrada = dataEntrada;
        this.DataSaida = dataSaida;
    }
}
