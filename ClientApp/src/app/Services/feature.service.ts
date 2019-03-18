import { Injectable } from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map';
import { HttpModule } from '@angular/http';

@Injectable()
export class FeatureService {

  constructor(private http:Http) { 
    
  }
  getFeatures(){
    return this.http.get("/Api/Features").map(res=> res.json());
}
}
