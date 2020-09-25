import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductComponent } from './product.component';
import { RouterModule, Routes } from '@angular/router';
import { ProductService } from './product.service';

const routes: Routes = [
  {
    path:'',
    component: ProductComponent
  }
]

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
  ],
  declarations: [ProductComponent],
  providers: [ProductService],
  exports : [
    ProductComponent
  ]
})
export class ProductModule { }
