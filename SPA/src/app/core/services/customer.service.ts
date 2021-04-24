import { Injectable } from '@angular/core';
import { Customer } from 'src/app/shared/models/customer';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private apiService:ApiService) { }

  getCustomerById(id:number):Observable<Customer>{
    return this.apiService.getOne('customers',id);
  }

  getAllCustomers():Observable<Customer[]>{
    return this.apiService.getAll('customers');
  }

}
