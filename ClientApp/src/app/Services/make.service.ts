import { Injectable } from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map';
import { HttpModule } from '@angular/http';


@Injectable()
export class MakeService {

  constructor(private http:Http) { 
    
    }
    getMakes(){
      return this.http.get("/Api/Makes").map(res=> res.json());
  }

}
       