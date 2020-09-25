import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { MvProduct } from './product';
import { ProductFormComponent } from './product-form/product-form.component';
import { ProductService } from './product.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  errorMessage: string = null;
  displayedColumns: string[];
  dataSource: MvProduct[] = [];
  constructor(  private router: ActivatedRoute,
                private productService: ProductService,
                private dialog: MatDialog,
                private snacbar: MatSnackBar) { 
  }

  ngOnInit() {
    this.displayedColumns = ['ProductId', 'ProductName','ProductCategory','Stock'];
    this.getAllProducts();
  }

  getAllProducts(){
    this.productService.getProduct().subscribe((response: any) =>{
      if(response && response.data){
        this.dataSource = response.data;
        console.log("hello");
        console.log(this.dataSource, "data");
        
      }else{
        this.errorMessage = "No Data Available"
      }
    })
  }

  productAdd(){
    this.openDialog();
  }
  //creating dialog box for add and edit
  openDialog(){
    let dialogRef = this.dialog.open(ProductFormComponent, {data : {name: 'botman'}});
    dialogRef.afterClosed().subscribe(result =>{
      this.openSnackBar(result, "");
    })
  }

  openSnackBar(message,action){
    this.snacbar.open(message, action,{
      duration:3000,
      panelClass: ['login-snackbar'],
      verticalPosition: 'top',
      horizontalPosition: 'right',
    })
  }

}
