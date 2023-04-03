import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { GeneralService } from 'src/app/services/general.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  user?: User | null;
  showDetails: boolean = true;
  showProjects: boolean = false;

  constructor(private generalService: GeneralService) {
      this.generalService.user.subscribe(x => this.user = x);
  }
  ngOnInit() {
  }

}
