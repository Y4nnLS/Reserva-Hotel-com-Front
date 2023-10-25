import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Cidade } from 'src/app/Cidade'; // Certifique-se de importar a classe Cidade correta
import { CidadesService } from 'src/app/cidades.service'; // Certifique-se de importar o serviço de cidades correto

@Component({
  selector: 'app-cidades',
  templateUrl: './cidades.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./cidades.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class CidadesComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private cidadesService: CidadesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Cidade';
    this.formulario = new FormGroup({
      IdCidade: new FormControl(null),
      Nome: new FormControl(null),
      Estado: new FormControl(null),
      País: new FormControl(null),
      Descricao: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const cidade: Cidade = this.formulario.value;
    this.cidadesService.cadastrar(cidade).subscribe(result => {
      alert('Cidade inserida com sucesso.');
    });
  }
}
