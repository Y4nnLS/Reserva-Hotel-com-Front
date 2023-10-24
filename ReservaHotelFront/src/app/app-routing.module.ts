import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HoteisComponent } from './components/hotel/hotel.component';


const routes: Routes = [{
  path: 'hotel', component:HoteisComponent
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
