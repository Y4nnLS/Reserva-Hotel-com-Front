import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Avaliacao } from 'src/app/Avaliacao'; // Certifique-se de importar a classe Avaliacao correta
import { AvaliacoesService } from 'src/app/avaliacoes.service'; // Certifique-se de importar o serviço de avaliações correto

@Component({
  selector: 'app-avaliacoes',
  templateUrl: './avaliacoes.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./avaliacoes.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class AvaliacoesComponent implements OnInit {
  formularioAvaliacao: any;
  tituloFormulario: string = '';

  constructor(private avaliacoesService: AvaliacoesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Avaliação';
    this.formularioAvaliacao = new FormGroup({
      comentario: new FormControl(null),
      estrelas: new FormControl(null),
      dataAvaliacao: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const avaliacao: Avaliacao = this.formularioAvaliacao.value;
    this.avaliacoesService.cadastrar(avaliacao).subscribe(result => {
      alert('Avaliação inserida com sucesso.');
    });
  }
}
