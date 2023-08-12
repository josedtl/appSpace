import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoElementoSaveComponent } from './tipo-elemento-save.component';

describe('TipoElementoSaveComponent', () => {
  let component: TipoElementoSaveComponent;
  let fixture: ComponentFixture<TipoElementoSaveComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TipoElementoSaveComponent]
    });
    fixture = TestBed.createComponent(TipoElementoSaveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
