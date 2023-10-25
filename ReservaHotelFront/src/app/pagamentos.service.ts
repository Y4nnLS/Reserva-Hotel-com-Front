import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Pagamento } from './Pagamento'; // Certifique-se de importar a classe Pagamento correta

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class PagamentosService {
  apiUrl = 'http://localhost:5000/pagamento';

  constructor(private http: HttpClient) { }

  listar(): Observable<Pagamento[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Pagamento[]>(url);
  }

  buscar(id: number): Observable<Pagamento> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Pagamento>(url);
  }

  cadastrar(Pagamento: Pagamento): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Pagamento>(url, Pagamento, httpOptions);
  }

  atualizar(Pagamento: Pagamento): Observable<any> {
    const url = `${this.apiUrl}/atualizar`;
    return this.http.put<Pagamento>(url, Pagamento, httpOptions);
  }

  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/excluir/${id}`;
    return this.http.delete<string>(url, httpOptions);
  }
}
