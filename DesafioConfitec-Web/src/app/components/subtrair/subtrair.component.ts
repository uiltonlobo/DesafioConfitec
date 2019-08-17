import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { OperacoesService } from 'src/app/operacoes.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-subtrair',
  templateUrl: './subtrair.component.html',
  styleUrls: ['./subtrair.component.css']
})
export class SubtrairComponent implements OnInit {

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

  subtrair(valor1, valor2) {
    this.service
      .subtrair(valor1, valor2)
      .subscribe((data: number) => {
        this.resultado = data;
      });
  }

  ngOnInit() {
  }

}
