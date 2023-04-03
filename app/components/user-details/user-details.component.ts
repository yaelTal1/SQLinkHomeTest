import { Component, Input, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { GeneralService } from 'src/app/services/general.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {
  @Input() user?: User | null;
  userDetails?: User | null;

  constructor(private generalService: GeneralService) {
  }
  ngOnInit() {
    this.userDetails = this.user;
    if (this.userDetails) {
      console.log(this.userDetails[0])
    }
  }

}
