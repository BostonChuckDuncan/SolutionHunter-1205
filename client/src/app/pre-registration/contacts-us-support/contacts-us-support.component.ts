import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-contacts-us-support',
  templateUrl: './contacts-us-support.component.html',
  styleUrls: ['./contacts-us-support.component.css']
})
export class ContactsUsSupportComponent implements OnInit {
  support;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.support = this.fb.group({
      login: ['', [Validators.minLength(8), Validators.required]],
      email: ['', [Validators.required,
        Validators.pattern('^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$')]],
      phone: ['', Validators.pattern('^([1-9]{1}-)?[0-9]{3}-[0-9]{3}-[0-9]{4}$')],
      message: ['', [Validators.required, Validators.minLength(10)]]
    });
  }

  get f() { return this.support.controls; }

  submitSupport() {
    const i = 0;
  }
}
