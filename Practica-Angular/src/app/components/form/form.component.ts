import { AfterContentChecked, AfterContentInit, AfterViewInit, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'my-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  form : FormGroup;
  @Input()
  buttonName : string;
  @Input()
  inputNameValue : string;
  @Input()
  inputPhoneValue : string;
  @Output()
  onSubmit : EventEmitter<any>;
  
  constructor(private router: Router, private readonly fb: FormBuilder) {
    this.onSubmit = new EventEmitter();
  }

  btnBack(): void {
    this.router.navigateByUrl('/home');
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      name: ["", [Validators.required, Validators.maxLength(40)]],
      phone: ["", [Validators.required, Validators.maxLength(24)]]
    });

  }

  onSubmitForm() : void {
    if (this.form.controls['name'].value == "") {
      this.form.patchValue({
        name: this.inputNameValue
      });

    }
    if (this.form.controls['phone'].value == "") {
      this.form.patchValue({
        phone: this.inputPhoneValue
      });
    }

    this.form.markAllAsTouched()
    if(this.form.valid){
      this.onSubmit.emit({
        name: this.form.controls['name'].value,
        phone: this.form.controls['phone'].value
    });
    }

    
  }
}
