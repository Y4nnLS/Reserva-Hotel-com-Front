import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Cliente } from 'src/app/cliente'; // Certifique-se de importar a classe Cliente correta
import { ClientesService } from 'src/app/clientes.service'; // Certifique-se de importar o serviço de clientes correto

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./clientes.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class ClientesComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private clientesService: ClientesService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Cliente';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      numeroTelefone: new FormControl(null),
      email: new FormControl(null),
      login: new FormControl(null),
      senha: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    const cliente: Cliente = this.formulario.value;
    this.clientesService.cadastrar(cliente).subscribe(result => {
      alert('Cliente inserido com sucesso.');
    });
  }
}
