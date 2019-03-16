import { Component, OnInit } from '@angular/core';
import { MakeService } from './../Services/make.service';
import { Console } from '@angular/core/src/console';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models:any[];
  Vehicle: any= {} ;


  constructor(private makeservice: MakeService) { }
  ngOnInit() {
  // this.makes= this.makeservice.getMakes().subscribe(makes=> this.makes=makes);
  this.makeservice.getMakes().subscribe(makes =>{this.makes=makes
    console.log("MAKes",this.makes); 
  })

  }
  onMakeChange()
  {
    var SelectedMake =this.makes.find(m=> m.makeId == this.Vehicle.make);
      this.models=SelectedMake.models;

    console.log("vehicle", this.Vehicle); 
    console.log("Models", this.models); 

   
  }  
}
