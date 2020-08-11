export abstract class Geometry {
  sideA: number;
  sideB: number;

  constructor(sideA: number, sideB: number) {
    this.sideA = sideA;
    this.sideB = sideB
  }

  Area(): number {
    return this.sideA * this.sideB;
  }

  Perimeter(): number {
    return this.sideA * 2 + this.sideB * 2;
  }
}
