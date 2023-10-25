import { Hotel } from './Hotel';

export class Comodidade {
    IDComodidade: number = 0;
    NumeroDoQuarto: number = 0;
    TipoDeQuarto: string | null = null;
    PrecoPorNoite: number = 0;
    Descricao: string | null = null;
    Disponibilidade: boolean = false;
    IDHotel: number = 0;
    Hotel: Hotel | null = null;
}
