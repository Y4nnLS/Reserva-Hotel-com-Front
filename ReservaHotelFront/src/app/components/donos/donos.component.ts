import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Dono } from 'src/app/Dono'; // Certifique-se de importar a classe Dono correta
import { DonosService } from 'src/app/donos.service'; // Certifique-se de importar o serviço de donos correto
import { Hotel } from 'src/app/Hotel'; // Certifique-se de importar a classe Hotel correta
import { HoteisService } from 'src/app/hotel.service'; // Certifique-se de importar o serviço de hotéis correto
import { Observer } from 'rxjs';

@Component({
  selector: 'app-donos',
  templateUrl: './donos.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./donos.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class DonosComponent implements OnInit {
  formularioDonos: any;
  tituloFormulario: string = '';
  hoteis: Array<Hotel> | undefined;

  constructor(private donosService: DonosService, private hoteisService: HoteisService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Dono';
    this.hoteisService.listar().subscribe(hoteis => {
      this.hoteis = hoteis;
      if (this.hoteis && this.hoteis.length > 0){
        this.formularioDonos.get('hotelId')?.setValue(this.hoteis[0].idHotel);
      }
    });
    this.formularioDonos = new FormGroup({
      Nome: new FormControl(null),
      NumeroTelefone: new FormControl(null),
      Email: new FormControl(null),
      Login: new FormControl(null),
      Senha: new FormControl(null),
      hotelId: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const dono: Dono = this.formularioDonos.value;
    const observer: Observer<Hotel> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (dono.donoId && !isNaN(Number(dono.donoId))){
        this.donosService.atualizar(dono).subscribe(observer);
      } else{
        this.donosService.cadastrar(dono).subscribe(observer);
      }
    }
}

