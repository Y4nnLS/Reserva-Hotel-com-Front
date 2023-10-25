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
  formulario: any;
  tituloFormulario: string = '';

  constructor(private avaliacoesService: AvaliacoesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Avaliação';
    this.formulario = new FormGroup({
      IDAvaliacao: new FormControl(null),
      Comentario: new FormControl(null),
      Pontuacao: new FormControl(null),
      Data: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const avaliacao: Avaliacao = this.formulario.value;
    this.avaliacoesService.cadastrar(avaliacao).subscribe(result => {
      alert('Avaliação inserida com sucesso.');
    });
  }
}
