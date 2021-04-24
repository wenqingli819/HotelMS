import { CustomerService } from './../../core/services/customer.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Customer } from 'src/app/shared/models/customer';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  customers:Customer[]=[];
  customerId: number = -1;

  constructor(private customerService:CustomerService,
    private route:ActivatedRoute) { }

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.customerService.getAllCustomers()
        .subscribe(c => {
          this.customers = c;
        });
    }
  );
  }

}
