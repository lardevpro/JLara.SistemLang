import { Component, Input } from '@angular/core';

@Component({
  standalone:true,
  selector: 'app-progress',
  templateUrl: './progress.component.html',
  styleUrls: ['./progress.component.scss'],
})
export class ProgressComponent {
  @Input() userName: string = 'Usuario';
  @Input() userPhoto: string = 'https://via.placeholder.com/70';
  @Input() level: number = 1;
  @Input() progress: number = 0; // Progress percentage (0-100)
  @Input() recommendation: string = 'Practica vocabulario nuevo todos los días.';
  @Input() inspirationalQuote: string = 'La práctica hace al maestro.';
}
