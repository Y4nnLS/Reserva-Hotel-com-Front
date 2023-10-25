import { ReservaHotel } from './ReservaHotel';

export class Pagamento {
    IdPagamento: number = 0;
    MetodoPagamento: string | null = null;
    Valor: number = 0;
    DataPagamento: Date = new Date();
    IdReservaEstadia: number = 0;
    ReservaHotel: ReservaHotel | null = null;
}
