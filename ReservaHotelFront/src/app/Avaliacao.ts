import { Hotel } from './Hotel';

export class Avaliacao {
    IdAvaliacao: number = 0;
    AvaliacaoEstrelas: number = 0;
    Comentario: string | null = null;
    DataAvaliacao: Date = new Date();
    IdHotel: number = 0;
    Hotel: Hotel | null = null;
}
