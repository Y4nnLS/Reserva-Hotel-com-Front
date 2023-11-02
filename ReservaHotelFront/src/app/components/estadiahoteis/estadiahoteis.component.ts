import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { EstadiaHotel } from 'src/app/EstadiaHotel'; // Certifique-se de importar a classe EstadiaHotel correta
import { EstadiaHoteisService } from 'src/app/estadiahoteis.service'; // Certifique-se de importar o serviço de estadia em hotéis correto

@Component({
  selector: 'app-estadiahotel',
  templateUrl: './estadiahoteis.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./estadiahoteis.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class EstadiaHotelComponent implements OnInit {
  formularioEstadia: any;
  tituloFormulario: string = '';

  constructor(private estadiaHotelService: EstadiaHoteisService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Estadia em Hotel';
    this.formularioEstadia = new FormGroup({
      QtdQuartos: new FormControl(null),
      DataEntrada: new FormControl(null),
      DataSaida: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const estadiaHotel: EstadiaHotel = this.formularioEstadia.value;
    this.estadiaHotelService.cadastrar(estadiaHotel).subscribe(result => {
      alert('Estadia em hotel inserida com sucesso.');
    });
  }
}
