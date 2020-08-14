export class Element {
    name:string;
    symbol:string;
    atomic_mass:number;
    number:number;
    phase:string;

    constructor(name:string, symbol:string, atomic_mass:number,number:number,phase:string){
        this.name=name;
        this.symbol=symbol;
        this.atomic_mass=atomic_mass;
        this.number=number;
        this.phase=phase;

    }
}
