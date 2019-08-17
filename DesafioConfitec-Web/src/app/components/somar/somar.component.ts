import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { OperacoesService } from 'src/app/operacoes.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-somar',
  templateUrl: './somar.component.html',
  styleUrls: ['./somar.component.css']
})
export class SomarComponent implements OnInit {

  formOperacao: FormGroup;
  resultado: any;

  constructor(private service: OperacoesService, private fb: FormBuilder) {
    this.createForm();
  }

  createForm() {
    this.formOperacao = this.fb.group({
      valor1: ['', Validators.required ],
      valor2: ['', Validators.required ]
   });
  }

  somar(valor1, valor2) {
    this.service
      .somar(valor1, valor2)
      .subscribe((data: number) => {
        this.resultado = data;
      });
  }

  ngOnInit() {
  }

}
