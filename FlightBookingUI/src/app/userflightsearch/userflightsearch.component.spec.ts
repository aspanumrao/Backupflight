import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserflightsearchComponent } from './userflightsearch.component';

describe('UserflightsearchComponent', () => {
  let component: UserflightsearchComponent;
  let fixture: ComponentFixture<UserflightsearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserflightsearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserflightsearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
