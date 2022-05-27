import { Component, OnInit } from '@angular/core';
import { MSService } from '../services/m-s.service';

@Component({
  selector: 'lib-m-s',
  template: ` <p>m-s works!</p> `,
  styles: [],
})
export class MSComponent implements OnInit {
  constructor(private service: MSService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
