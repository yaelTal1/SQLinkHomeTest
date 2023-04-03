import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';
import { Project } from 'src/app/models/project';
import { GeneralService } from 'src/app/services/general.service';

@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.css']
})
export class ProjectsComponent implements OnInit {
  term: string;
  deadlinePercent: string ='';
  scoresAverage: string ='';
  _listFilter = '';
  get listFilter(): string {
    return this._listFilter;
  }

  set listFilter(value: string) {
    this._listFilter = value;
    this.filtereProjects = this.listFilter ? this.doFilter(this.listFilter) : this.projects;
    this.calcDeadlinePercent();
    this.calcScoresAverage();;
  }

  filtereProjects?: Project[] = [];
  projects?: Project[] = [];

  constructor(private generalService: GeneralService) {
  }

  ngOnInit() {
    this.generalService.getAllProjects()
      .pipe(first())
      .subscribe({
        next: (projects) => {
          this.projects = projects;
          this.filtereProjects = this.projects;
          this.listFilter = '';
          this.calcDeadlinePercent();
          this.calcScoresAverage();;
        }
      });

  }

  doFilter(filterBy: string): Project[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.projects.filter((project: Project) =>
      project.name.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }

  sort(colName) {
    this.projects.sort((a, b) => a[colName] > b[colName] ? 1 : a[colName] < b[colName] ? -1 : 0);
  }

  calcDeadlinePercent() {
    this.deadlinePercent = (100 / this.filtereProjects.length * this.filtereProjects.filter(x => x.madeDadeline).length).toFixed(2);
  }

  calcScoresAverage() {
    let sum = 0;
    for (let i = 0; i < this.filtereProjects.length; ++i) {
      sum += this.filtereProjects[i].score;
    }
    this.scoresAverage = (sum / this.filtereProjects.length).toFixed(2);
  }
}
