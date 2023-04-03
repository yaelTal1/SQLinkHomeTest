import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { GeneralService } from 'src/app/services/general.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm!: FormGroup;
  loading = false;

  constructor(
      private formBuilder: FormBuilder,
      private route: ActivatedRoute,
      private router: Router,
      private generalService: GeneralService
  ) { }

  ngOnInit() {
      this.loginForm = this.formBuilder.group({
          username: new FormControl('', [
            Validators.required,
            Validators.pattern('^[a-zA-Z0-9 \-\'\@]+'), 
            Validators.email
          ]),
          password: new FormControl('', [
            Validators.required, 
            Validators.pattern('^[a-zA-Z0-9 \-\']+'), 
            Validators.minLength(8)
          ])
      });
  }

  get f() { return this.loginForm.controls; }

  onSubmit() {
      this.loading = true;
      this.generalService.login(this.f.username.value, this.f.password.value)
          .pipe(first())
          .subscribe({
              next: () => {
                  this.router.navigateByUrl("/homePage");
              },
              error: error => {
                  this.loading = false;
              }
          });
  }
}