import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListgameconsoleComponent } from './listgameconsole.component';

describe('ListgameconsoleComponent', () => {
  let component: ListgameconsoleComponent;
  let fixture: ComponentFixture<ListgameconsoleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListgameconsoleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListgameconsoleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
