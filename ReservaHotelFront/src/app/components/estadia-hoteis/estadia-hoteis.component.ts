import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { EstadiaHotel } from 'src/app/EstadiaHotel'; // Certifique-se de importar a classe EstadiaHotel correta
import { EstadiaHoteisService } from 'src/app/estadia-hoteis.service'; // Certifique-se de importar o serviço de estadia em hotéis correto

@Component({
  selector: 'app-estadiahotel',
  templateUrl: './estadia-hoteis.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./estadia-hoteis.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class EstadiaHotelComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private estadiaHotelService: EstadiaHoteisService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Estadia em Hotel';
    this.formulario = new FormGroup({
      IdEstadia: new FormControl(null),
      QtdQuartos: new FormControl(null),
      DataEntrada: new FormControl(null),
      DataSaida: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const estadiaHotel: EstadiaHotel = this.formulario.value;
    this.estadiaHotelService.cadastrar(estadiaHotel).subscribe(result => {
      alert('Estadia em hotel inserida com sucesso.');
    });
  }
}
