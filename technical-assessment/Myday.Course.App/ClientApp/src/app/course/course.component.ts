import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html'
})
export class CourseComponent {
  public courses: Course[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Course[]>(baseUrl + 'api/v1/Course').subscribe(result => {
      this.courses = result;
    }, error => console.error(error));
  }
}

interface Course {
  name: string;
}
