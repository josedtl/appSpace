import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoInfraestructuraMainComponent } from './tipo-infraestructura-main.component';

describe('TipoInfraestructuraMainComponent', () => {
  let component: TipoInfraestructuraMainComponent;
  let fixture: ComponentFixture<TipoInfraestructuraMainComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TipoInfraestructuraMainComponent]
    });
    fixture = TestBed.createComponent(TipoInfraestructuraMainComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
