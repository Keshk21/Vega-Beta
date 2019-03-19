import { Injectable } from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map';
import { HttpModule } from '@angular/http';


@Injectable()
export class ModelService {

  constructor(private http :Http) {

   }
   getmodels(){
    return this.http.get("/Api/Models").map(res=> res.json());
}

}
