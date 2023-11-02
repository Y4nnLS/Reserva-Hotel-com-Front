import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Pagamento } from 'src/app/Pagamento'; // Certifique-se de importar a classe Pagamento correta
import { PagamentosService } from 'src/app/pagamentos.service'; // Certifique-se de importar o serviço de pagamentos correto

@Component({
  selector: 'app-pagamentos',
  templateUrl: './pagamentos.component.html', // Substitua pelo caminho real do seu template
  styleUrls: ['./pagamentos.component.css'] // Substitua pelo caminho real do seu arquivo CSS
})
export class PagamentosComponent implements OnInit {
  formularioPagamentos: any;
  tituloFormulario: string = '';

  constructor(private pagamentoService: PagamentosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Pagamento';
    this.formularioPagamentos = new FormGroup({
      MetodoPagamento: new FormControl(null),
      Valor: new FormControl(null),
      DataPagamento: new FormControl(null)
    });
  }

  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const pagamento: Pagamento = this.formularioPagamentos.value;
    this.pagamentoService.cadastrar(pagamento).subscribe(result => {
      alert('Pagamento inserido com sucesso.');
    });
  }
}
