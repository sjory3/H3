import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GeometryComponentComponent } from './geometry-component.component';

describe('GeometryComponentComponent', () => {
  let component: GeometryComponentComponent;
  let fixture: ComponentFixture<GeometryComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GeometryComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeometryComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
