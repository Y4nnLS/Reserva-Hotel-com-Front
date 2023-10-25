import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Dono } from 'src/app/Dono'; // Certifique-se de importar a classe Dono correta
import { DonosService } from 'src/app/donos.service'; // Certifique-se de importar o serviço de donos correto

@Component({
  selector: 'app-donos',
  templateUrl: './donos.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./donos.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class DonosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private donosService: DonosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Dono';
    this.formulario = new FormGroup({
      DonoId: new FormControl(null),
      Nome: new FormControl(null),
      NumeroTelefone: new FormControl(null),
      Email: new FormControl(null),
      Login: new FormControl(null),
      Senha: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const dono: Dono = this.formulario.value;
    this.donosService.cadastrar(dono).subscribe(result => {
      alert('Dono inserido com sucesso.');
    });
  }
}
