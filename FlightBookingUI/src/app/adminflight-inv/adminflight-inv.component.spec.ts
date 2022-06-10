import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminflightInvComponent } from './adminflight-inv.component';

describe('AdminflightInvComponent', () => {
  let component: AdminflightInvComponent;
  let fixture: ComponentFixture<AdminflightInvComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminflightInvComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminflightInvComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
