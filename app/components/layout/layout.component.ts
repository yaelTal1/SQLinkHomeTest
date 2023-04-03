import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GeneralService } from 'src/app/services/general.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {

  constructor(
    private router: Router,
    private generalService: GeneralService
) {
    // redirect to home if already logged in
    if (this.generalService.user) {
        this.router.navigate(['/homePage']);
    }
    else {
      this.router.navigate(['/login']);

    }
}

  ngOnInit() {
  }

}
