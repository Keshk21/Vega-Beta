import { Component, OnInit, NgModule } from '@angular/core';
import { MakeService } from './../Services/make.service';
import { Console } from '@angular/core/src/console';
import { FeatureService } from './../Services/feature.service';
import { ModelService } from './../Services/model.service';
import { VehicleService } from './../Services/vehicle.service';


@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models:any[];
  Vehicle: any= {
    features:[]
  } ;
  features:any[];
  Modelf:any[];
  msg:string;
  IsRegistered: any[];
  




  constructor(private makeservice: MakeService,
     private featureService:FeatureService, private modelservice: ModelService, 
     private vehicleService : VehicleService) { }
  ngOnInit() {
  // this.makes= this.makeservice.getMakes().subscribe(makes=> this.makes=makes);

  this.makeservice.getMakes().subscribe(makes =>{this.makes=makes
    console.log("MAKes",this.makes); 
  })

 this.modelservice.getmodels().subscribe(Models=>{this.Modelf=Models
console.log("ModlelF",this.Modelf)});

  //this.featureService.getFeatures().subscribe(features => this.features=features);
  }
  onMakeChange()
  {
    var SelectedMake =this.makes.find(m=> m.makeId == this.Vehicle.makeId);
      this.models = SelectedMake ? SelectedMake.models:[];
      delete this.Vehicle.modelId;   
      this.Vehicle.features=[];
   



     //this.onfeaturechange();

    console.log("vehicle", this.Vehicle);   
    console.log("Models", this.models); 

   
  }  
  onModelChange()
  {
    var SelectModel = this.Modelf.find(m => m.modelId == this.Vehicle.modelId);
      this.features = SelectModel.features;
      //this.features = Selectfeature ? Selectfeature.features:[];

      this.Vehicle.features=[];

  console.log("Feature", this.features); 

   
  }  
  onFeatureToggle(featureId, $event){
    if($event.target.checked)
    this.Vehicle.features.push(featureId);
    else{
      var index =this.Vehicle.features.indexOf(featureId);
      this.Vehicle.features.splice(index,1);
    }

  }

clickEvent()
{
this.vehicleService.AddVehicle(this.Vehicle);
  this.msg='Button is Clicked';
 return this.msg;
}
}
