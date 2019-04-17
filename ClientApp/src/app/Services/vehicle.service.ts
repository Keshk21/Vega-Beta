import { Injectable } from '@angular/core';
import {Http} from '@angular/http';
import 'rxjs/add/operator/map';
import { HttpModule } from '@angular/http';


@Injectable()
export class VehicleService {

  constructor(private http:Http) { 
    
    }
    AddVehicle(Vehicle){
      return this.http.post("/Api/vehicle", Vehicle).map(res=> res.json());
    }
  }