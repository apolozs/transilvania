import { Component, OnInit } from '@angular/core';
import { Quarto } from './models/Quarto';
import { QuartoService } from './services/quarto.service';

@Component({
  selector: 'app-root',
  templateUrl: "./app.component.html",
  styleUrls: []
})
export class AppComponent implements OnInit {
  listquartos : Quarto[] = [];
  constructor(private service: QuartoService){}
  ngOnInit(): void {
    this.service.list().subscribe(quartos =>{
        this.listquartos = quartos;
    });
  }
  
}
