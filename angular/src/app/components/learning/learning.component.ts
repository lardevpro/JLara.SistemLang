import { Component, OnInit } from '@angular/core';
import { SpeechRecognitionService } from '../../services/speech-recognition.service'; // Servicio de reconocimiento de voz
import { TextToSpeechService } from '../../services/text-to-speech.service'; // Servicio de síntesis de voz
import { SoundService } from '../../services/sound.service'; // Servicio para sonidos

@Component({
  selector: 'app-decorative-learning',
  templateUrl: './learning.component.html',
  styleUrls: ['./learning.component.scss'],
  standalone: true,
})
export class LearningComponent implements OnInit {
  // Información del usuario
  userName: string = 'John Doe';
  userPhoto: string = 'https://via.placeholder.com/100';
  
  // Progreso y nivel
  level: number = 1;
  progress: number = 0;
  maxProgress: number = 100;
  
  // Palabra a pronunciar y retroalimentación
  wordToPronounce: string = '';
  feedback: string = '';
  smiley: string = '😊';
  
  // Estado del reconocimiento
  userSpeech: string = '';
  
  // Configuración de niveles y palabras
  wordsByLevel: { [key: number]: string[] } = {
    1: ['cat', 'dog', 'fish'],
    2: ['apple', 'orange', 'banana'],
    3: ['elephant', 'umbrella', 'giraffe'],
    4: ['philosophy', 'architecture', 'consciousness'],
  };

  // Variables adicionales
  isListening: boolean = false; // Para controlar el estado del botón de hablar
  recognitionTimeout: any; // Para almacenar el temporizador de la cuenta atrás

  constructor(
    private recognitionService: SpeechRecognitionService, 
    private soundService: SoundService,
    private textToSpeechService: TextToSpeechService // Inyección del servicio TTS
  ) {}

  ngOnInit(): void {
    this.generateWord();
    this.startRecognition();
  }

  // Genera una palabra acorde al nivel
  generateWord(): void {
    const words = this.wordsByLevel[this.level] || [];
    this.wordToPronounce = words[Math.floor(Math.random() * words.length)];
  }

  // Configuración y gestión del reconocimiento de voz
  startRecognition(): void {
    this.recognitionService.getRecognizedText().subscribe(result => {
      this.userSpeech = result;
      this.checkPronunciation(this.userSpeech);
    }, error => {
      this.feedback = `Error: ${error.message}`;
    });
  }

  // Inicia la escucha
  startListening(): void {
    this.isListening = true;
    this.feedback = 'Escuchando...';
    this.userSpeech = ''; 
    this.recognitionService.startRecognition();
    
    // Si no se detecta voz en 5 segundos, se considera un error
    this.recognitionTimeout = setTimeout(() => {
      if (!this.userSpeech) {
        this.checkPronunciation('');
      }
    }, 5000);
  }

  // Detiene la escucha y la cuenta atrás
  stopListening(): void {
    clearTimeout(this.recognitionTimeout);
    this.isListening = false;
  }

  // Verifica la pronunciación
  checkPronunciation(userSpeech: string): void {
    this.stopListening(); // Detenemos la cuenta atrás y deshabilitamos el botón

    if (userSpeech === '') {
      this.feedback = 'No he escuchado lo que dijiste. Por favor, intenta nuevamente.';
      this.smiley = '😕';
      this.soundService.playErrorSound();
      this.textToSpeechService.speak('No he escuchado lo que dijiste. Por favor, intenta nuevamente.');
    } else if (userSpeech.toLowerCase() === this.wordToPronounce.toLowerCase()) {
      this.feedback = `¡Correcto! Pronunciaste "${this.wordToPronounce}" correctamente.`;
      this.smiley = '😄';
      this.updateProgress(true);
      this.soundService.playSuccessSound();
      this.textToSpeechService.speak(`¡Correcto! Pronunciaste "${this.wordToPronounce}" correctamente.`);
    } else {
      this.feedback = `Incorrecto. Dijiste "${userSpeech}", pero era "${this.wordToPronounce}".`;
      this.smiley = '😞';
      this.updateProgress(false);
      this.soundService.playErrorSound();
      this.textToSpeechService.speak(`Incorrecto. Dijiste "${userSpeech}", pero era "${this.wordToPronounce}".`);
    }

    this.generateWord();
  }

  // Actualiza el progreso y el nivel
  updateProgress(isCorrect: boolean): void {
    if (isCorrect) {
      this.progress += 20;
      if (this.progress >= this.maxProgress) {
        this.level += 1;
        this.progress = 0;
        this.feedback += ` ¡Subiste al nivel ${this.level}!`;
      }
    } else {
      this.progress -= 10;
      if (this.progress < 0) {
        this.level = Math.max(1, this.level - 1);
        this.progress = this.maxProgress - 10;
        this.feedback += ` Bajaste al nivel ${this.level}.`;
      }
    }
  }
}
