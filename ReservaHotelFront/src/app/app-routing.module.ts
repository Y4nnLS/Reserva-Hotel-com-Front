import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HoteisComponent } from './components/hotel/hotel.component';
import { ClientesComponent } from './components/clientes/clientes.component';


const routes: Routes = [
  { path: 'hotel', component: HoteisComponent },
  { path: 'cliente', component: ClientesComponent }
];



@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
