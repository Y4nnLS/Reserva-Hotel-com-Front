import { Pagamento } from './Pagamento';
import { EstadiaHotel } from './EstadiaHotel';

export class ReservaHotel {
    IdReserva: number = 0;
    NomeHospede: string | null = null;
    Pagamento: Pagamento[] | null = null;
    Estadia: EstadiaHotel | null = null;
}
