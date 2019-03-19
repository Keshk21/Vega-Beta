import { Component, OnInit, NgModule } from '@angular/core';
import { MakeService } from './../Services/make.service';
import { Console } from '@angular/core/src/console';
import { FeatureService } from './../Services/feature.service';
import { ModelService } from './../Services/model.service';


@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes: any[];
  models:any[];
  Vehicle: any= {} ;
  features:any[];
  Modelf:any[];


  constructor(private makeservice: MakeService,
     private featureService:FeatureService, private modelservice: ModelService) { }
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
    var SelectedMake =this.makes.find(m=> m.makeId == this.Vehicle.make);
      this.models = SelectedMake ? SelectedMake.models:[];

     //this.onfeaturechange();

    console.log("vehicle", this.Vehicle);   
    console.log("Models", this.models); 

   
  }  
  onModelChange()
  {
    var SelectModel = this.Modelf.find(m => m.modelId == this.Vehicle.model);
      this.features = SelectModel.features;
      //this.features = Selectfeature ? Selectfeature.features:[];


  console.log("Feature", this.features); 


    
  }  
  
}
