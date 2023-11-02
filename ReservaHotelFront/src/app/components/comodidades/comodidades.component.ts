import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Comodidade } from 'src/app/Comodidade'; // Certifique-se de importar a classe Comodidade correta
import { ComodidadesService } from 'src/app/comodidades.service'; // Certifique-se de importar o serviço de comodidades correto

@Component({
  selector: 'app-comodidades',
  templateUrl: './comodidades.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./comodidades.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class ComodidadesComponent implements OnInit {
  formularioComodidades: any;
  tituloFormulario: string = '';

  constructor(private comodidadesService: ComodidadesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Comodidade';
    this.formularioComodidades = new FormGroup({
      NumeroDoQuarto: new FormControl(null),
      TipoDeQuarto: new FormControl(null),
      PrecoPorNoite: new FormControl(null),
      Descricao: new FormControl(null),
      Disponibilidade: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const comodidade: Comodidade = this.formularioComodidades.value;
    this.comodidadesService.cadastrar(comodidade).subscribe(result => {
      alert('Comodidade inserida com sucesso.');
    });
  }
}
