import { Component } from '@angular/core';
import { User } from './models/user';
import { GeneralService } from './services/general.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  user?: User | null;

  constructor(private generalService: GeneralService) {
      this.generalService.user.subscribe(x => this.user = x);
  }

  logout() {
      this.generalService.logout();
  }
}
