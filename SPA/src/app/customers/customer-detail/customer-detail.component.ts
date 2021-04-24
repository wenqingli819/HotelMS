import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CustomerService } from 'src/app/core/services/customer.service';
import { Customer } from 'src/app/shared/models/customer';

@Component({
  selector: 'app-customer-detail',
  templateUrl: './customer-detail.component.html',
  styleUrls: ['./customer-detail.component.css']
})
export class CustomerDetailComponent implements OnInit {

  customer:Customer | undefined;
  id: number =-1;



  constructor(private customerService : CustomerService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(
      params => {
        this.id = Number(params?.get('id'));
        this.getCustomerDetail();
      }
    );
  }
  private getCustomerDetail() {
    this.customerService.getCustomerById(this.id)
      .subscribe(c => {
        this.customer = c;
      });

    }
}
