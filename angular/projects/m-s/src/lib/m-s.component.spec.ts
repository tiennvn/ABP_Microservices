import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MSComponent } from './m-s.component';

describe('MSComponent', () => {
  let component: MSComponent;
  let fixture: ComponentFixture<MSComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MSComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MSComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
