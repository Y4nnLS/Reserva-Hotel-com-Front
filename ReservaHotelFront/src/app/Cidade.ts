import { Hotel } from './Hotel';

export class Cidade {
    IdCidade: number = 0;
    Nome: string | null = null;
    Estado: string | null = null;
    Pais: string | null = null;
    Descricao: string | null = null;
    ListaHoteis: Hotel[] | null = null;
    // You can add more properties as needed
}
