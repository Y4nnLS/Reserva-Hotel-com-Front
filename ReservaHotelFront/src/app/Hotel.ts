import { Avaliacao } from './Avaliacao';
import { Dono } from './Dono';

export class Hotel {
    idHotel: number = 0;
    nome: string = '';
    endereco: string = '';
    avaliacoes: Avaliacao | undefined;
    descricao: string = '';
    listaDeQuartos: string = '';
    avaliacaoMedia: number = 0;
    donoId: number = 0;
    dono: Dono | undefined;
    numeroTotalDeQuartos: number = 0;
    numeroDeQuartosDisponiveis: number = 0;
}
