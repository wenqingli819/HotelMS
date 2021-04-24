import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerDetailComponent } from './customers/customer-detail/customer-detail.component';
import { CustomerListComponent } from './customers/customer-list/customer-list.component';
import { HomeComponent } from './home/home.component';


const routes: Routes =
  [
    { path: '', component: HomeComponent },
    { path: 'customers', component: CustomerListComponent },
    { path: 'customers/:id', component: CustomerDetailComponent }
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
