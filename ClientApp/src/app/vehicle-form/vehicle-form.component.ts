import { Component, OnInit } from '@angular/core';
import { MakeService } from './../Services/make.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  // this.makes= this.makeservice.getMakes().subscribe(makes=> this.makes=makes);
  }

}
