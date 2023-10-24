export class Hotel {
    IDHotel: number = 0;
    Nome: string | null = null;
    Endereco: string | null = null;
    ListaAvaliacoes: Avaliacao[] | null = null;
    Descricao: string | null = null;
    ListaDeQuartos: string | null = null;
    AvaliacaoMedia: number = 0;
    IdDoDono: number = 0;
    NumeroTotalDeQuartos: number = 0;
    NumeroDeQuartosDisponiveis: number = 0;
}

export class Avaliacao {
    // Defina os campos da avaliação aqui, se necessário
}
