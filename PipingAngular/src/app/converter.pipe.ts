import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'converter'
})
export class ConverterPipe implements PipeTransform {

  transform(message: string): string {
    var value = message.toUpperCase();
    value = value.replace(/A/g, '· —');
    value = value.replace(/B/g, '— · · · ');
    value = value.replace(/C/g, '— · — ·');
    value = value.replace(/D/g, '— · ·');
    value = value.replace(/E/g, '·');
    value = value.replace(/F/g, '· · — ·');
    value = value.replace(/G/g, '— — ·');
    value = value.replace(/H/g, '· · · · ');
    value = value.replace(/I/g, '· ·');
    value = value.replace(/J/g, '· — — —');
    value = value.replace(/K/g, '— · —');
    value = value.replace(/L/g, '· — · ·');
    value = value.replace(/M/g, '— ·');
    value = value.replace(/N/g, '— —');
    value = value.replace(/O/g, '— — —');
    value = value.replace(/P/g, '· — — ·');
    value = value.replace(/Q/g, '— — · —');
    value = value.replace(/R/g, '· — ·');
    value = value.replace(/S/g, '· · · ');
    value = value.replace(/T/g, '—');
    value = value.replace(/U/g, '· · —');
    value = value.replace(/V/g, '· · · —');
    value = value.replace(/W/g, '· — —');
    value = value.replace(/X/g, '— · · —');
    value = value.replace(/Y/g, '— · — —');
    value = value.replace(/Z/g, '— — · ·');

    value = value.replace(/Æ/g, '· — · —');
    value = value.replace(/Ä/g, '· — · —');
    value = value.replace(/Ą/g, '· — · —');

    value = value.replace(/Ø/g, '— — — ·');
    value = value.replace(/Ó/g, '— — — ·');
    value = value.replace(/Ö/g, '— — — ·');
    
    value = value.replace(/Å/g, '· — — · —');
    value = value.replace(/À/g, '· — — · —');

    value = value.replace(/1/g, '· — — — —');
    value = value.replace(/2/g, '· · — — —');
    value = value.replace(/3/g, '· · · — —');
    value = value.replace(/4/g, '· · · · —');
    value = value.replace(/5/g, '· · · · ·');
    value = value.replace(/6/g, '— · · · ·');
    value = value.replace(/7/g, '— — · · ·');
    value = value.replace(/8/g, '— — — · ·');
    value = value.replace(/9/g, '— — — — · ');
    value = value.replace(/0/g, '— — — — — ');

    value = value.replace(/[.]/g, '· — · — · —');
    value = value.replace(/[,]/g, '— — · · — —');
    value = value.replace(/[:]/g, '— — — · · ·');
    value = value.replace(/[?]/g, '· · — — · ·');
    value = value.replace(/[']/g, '· — — — — ·');
    value = value.replace(/[-]/g, '— · · · · —');
    value = value.replace(/[/]/g, '— · · — ·');
    value = value.replace(/[(]/g, '— · — — ·');
    value = value.replace(/[)]/g, '— · — — · — ');
    value = value.replace(/["]/g, '· — · · — · ');
    value = value.replace(/[*]/g, '— · · — ');
    value = value.replace(/[@]/g, '· — — · — ·');
    return value;
  } 
}