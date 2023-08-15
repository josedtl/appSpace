import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpresaMainComponent } from './empresa-main.component';

describe('EmpresaMainComponent', () => {
  let component: EmpresaMainComponent;
  let fixture: ComponentFixture<EmpresaMainComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EmpresaMainComponent]
    });
    fixture = TestBed.createComponent(EmpresaMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
