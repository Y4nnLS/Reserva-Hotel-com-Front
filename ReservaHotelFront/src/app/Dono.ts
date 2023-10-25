import { Hotel } from './Hotel';

export class Dono {
    DonoId: number = 0;
    Nome: string | null = null;
    NumeroTelefone: number = 0;
    Email: string | null = null;
    Login: string | null = null;
    Senha: string | null = null;
    ListaHoteis: Hotel[] = [];
    Hotel: Hotel | null = null;

    constructor() {
        this.ListaHoteis = [];
    }
}
