import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { ReservaHotel } from 'src/app/ReservaHotel'; // Certifique-se de importar a classe ReservaHotel correta
import { ReservaHoteisService } from 'src/app/reservahoteis.service'; // Certifique-se de importar o serviço de reserva de hotéis correto
import { Observer } from 'rxjs';
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
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const reserva: ReservaHotel = this.formularioReserva.value;
    const observer: Observer<ReservaHotel> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (reserva.idReserva && !isNaN(Number(reserva.idReserva))){
        this.reservaHotelService.atualizar(reserva).subscribe(observer);
      } else{
        this.reservaHotelService.cadastrar(reserva).subscribe(observer);
      }
    }
  }
