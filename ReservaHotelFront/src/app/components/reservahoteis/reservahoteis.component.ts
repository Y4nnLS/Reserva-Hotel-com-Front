import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ReservaHotel } from 'src/app/ReservaHotel'; // Certifique-se de importar a classe ReservaHotel correta
import { ReservaHoteisService } from 'src/app/reservahoteis.service'; // Certifique-se de importar o serviço de reserva de hotéis correto

@Component({
  selector: 'app-reservahotels',
  templateUrl: './reservahoteis.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./reservahoteis.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class ReservaHotelsComponent implements OnInit {
  formularioReserva: any;
  tituloFormulario: string = '';

  constructor(private reservaHotelService: ReservaHoteisService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Reserva de Hotel';
    this.formularioReserva = new FormGroup({
      NomeHospede: new FormControl(null)
      // Adicione outras propriedades conforme necessário
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const reservaHotel: ReservaHotel = this.formularioReserva.value;
    this.reservaHotelService.cadastrar(reservaHotel).subscribe(result => {
      alert('Reserva de hotel inserida com sucesso.');
    });
  }
}
