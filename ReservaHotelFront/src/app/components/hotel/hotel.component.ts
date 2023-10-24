import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Hotel } from 'src/app/Hotel'; // Certifique-se de importar a classe Hotel correta
import { HoteisService } from 'src/app/hotel.service'; // Certifique-se de importar o serviço de hotéis correto

@Component({
  selector: 'app-hoteis',
  templateUrl: './hotel.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./hoteis.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class HoteisComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private hoteisService: HoteisService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Hotel';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      endereco: new FormControl(null),
      descricao: new FormControl(null),
      listaDeQuartos: new FormControl(null),
      avaliacaoMedia: new FormControl(0), // Valor padrão, pode ser ajustado conforme necessário
      idDoDono: new FormControl(0), // Valor padrão, pode ser ajustado conforme necessário
      numeroTotalDeQuartos: new FormControl(0), // Valor padrão, pode ser ajustado conforme necessário
      numeroDeQuartosDisponiveis: new FormControl(0) // Valor padrão, pode ser ajustado conforme necessário
    });
  }

  enviarFormulario(): void {
    const hotel: Hotel = this.formulario.value;
    this.hoteisService.cadastrar(hotel).subscribe(result => {
      alert('Hotel inserido com sucesso.');
    });
  }
}
