// Definición de pines para el sensor
const int trigPin = 9;
const int echoPin = 10;

// Definición de pines para los LEDs (todos PWM en UNO: 3,5,6,11)
const int ledVerde = 11;
const int ledAmarillo = 3;
const int ledNaranja = 5;
const int ledRojo = 6;

// Definición de pin para el zumbador
const int buzzerPin = 8;

// Variables para la medición de distancia
long duracion;
int distanciaCm;

// Modo y estados
bool modoManual = false;
int intensidadPWM = 255;  // 0..255

// Estado (ON/OFF) para cada LED en modo manual
bool estadoVerde = false;
bool estadoAmarillo = false;
bool estadoNaranja = false;
bool estadoRojo = false;
  unsigned long ultimoPWM = 0;
const int intervaloPWM = 30; // ms
// Aplica la intensidad (analogWrite) a todos los LEDs que estén "ON" en modo manual
void aplicarPWM() {
  if (estadoVerde)  analogWrite(ledVerde, intensidadPWM); 
  else digitalWrite(ledVerde, LOW); // si no está marcado, lo mantengo en LOW en modo manual

  if (estadoAmarillo) analogWrite(ledAmarillo, intensidadPWM);
  else digitalWrite(ledAmarillo, LOW);

  if (estadoNaranja) analogWrite(ledNaranja, intensidadPWM);
  else digitalWrite(ledNaranja, LOW);

  if (estadoRojo) analogWrite(ledRojo, intensidadPWM);
  else digitalWrite(ledRojo, LOW);

}

void setup() {
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  pinMode(ledVerde, OUTPUT);
  pinMode(ledAmarillo, OUTPUT);
  pinMode(ledNaranja, OUTPUT);
  pinMode(ledRojo, OUTPUT);

  pinMode(buzzerPin, OUTPUT);

  Serial.begin(9600);
}

void loop() {

  // ---------------- SENSOR (solo si no estamos en modo manual) ----------------
  if (!modoManual) {
    // Trigger del sensor
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);

    duracion = pulseIn(echoPin, HIGH);
    distanciaCm = duracion * 0.0343 / 2;

    Serial.print("Distancia: ");
    Serial.print(distanciaCm);
    Serial.println(" cm");

    // Control automático de LEDs (digitalWrite)
    if (distanciaCm >= 40 || distanciaCm <= 0) {
      digitalWrite(ledVerde, LOW);
      digitalWrite(ledAmarillo, LOW);
      digitalWrite(ledNaranja, LOW);
      digitalWrite(ledRojo, LOW);
      noTone(buzzerPin);
    }
    else if (distanciaCm >= 30) {
      digitalWrite(ledVerde, HIGH);
      digitalWrite(ledAmarillo, LOW);
      digitalWrite(ledNaranja, LOW);
      digitalWrite(ledRojo, LOW);
      noTone(buzzerPin);
    }
    else if (distanciaCm >= 20) {
      digitalWrite(ledVerde, HIGH);
      digitalWrite(ledAmarillo, HIGH);
      digitalWrite(ledNaranja, LOW);
      digitalWrite(ledRojo, LOW);
      noTone(buzzerPin);
    }
    else if (distanciaCm >= 10) {
      digitalWrite(ledVerde, HIGH);
      digitalWrite(ledAmarillo, HIGH);
      digitalWrite(ledNaranja, HIGH);
      digitalWrite(ledRojo, LOW);
      tone(buzzerPin, 1000);
    }
    else {
      digitalWrite(ledVerde, HIGH);
      digitalWrite(ledAmarillo, HIGH);
      digitalWrite(ledNaranja, HIGH);
      digitalWrite(ledRojo, HIGH);
      tone(buzzerPin, 2000);
    }
  } // fin if(!modoManual)

  // ---------------- COMANDOS DESDE PC ----------------
  // Protocolo simple:
  // V -> encender Verde (modo manual)
  // A -> encender Amarillo
  // N -> encender Naranja
  // R -> encender Rojo
  // X -> apagar todos y volver a modo automático
  // P<valor> -> cambiar intensidad (0..255) y aplicarla a todos los LEDs ON
  // Ejemplo de P: "P180" o "P50" o "P255"

  if (Serial.available()) {
    char comando = Serial.read();

    if (comando == 'V') {
      modoManual = true;
      estadoVerde = true;
      aplicarPWM(); // aplica intensidad actual al LED marcado
    }
    else if (comando == 'A') {
      modoManual = true;
      estadoAmarillo = true;
      aplicarPWM();
    }
    else if (comando == 'N') {
      modoManual = true;
      estadoNaranja = true;
      aplicarPWM();
    }
    else if (comando == 'R') {
      modoManual = true;
      estadoRojo = true;
      aplicarPWM();
    }
    else if (comando == 'X') {
      // Apagar todo y volver a automático
      estadoVerde = estadoAmarillo = estadoNaranja = estadoRojo = false;
      modoManual = false;
      // Apago físicamente los leds
      digitalWrite(ledVerde, LOW);
      digitalWrite(ledAmarillo, LOW);
      digitalWrite(ledNaranja, LOW);
      digitalWrite(ledRojo, LOW);
    }
    else if (comando == 'P') {
      // Leer el número que viene después de P (parseInt lee hasta no dígito)
      int valor = Serial.parseInt(); // lee 0..999
      if (millis() - ultimoPWM > intervaloPWM) {
    intensidadPWM = constrain(Serial.parseInt(), 0, 255);
    ultimoPWM = millis();

    analogWrite(ledVerde, intensidadPWM);
    analogWrite(ledAmarillo, intensidadPWM);
    analogWrite(ledNaranja, intensidadPWM);
    analogWrite(ledRojo, intensidadPWM);
}
      // Aplicar a todos los encendidos
      if (modoManual) aplicarPWM();
    }
    // cualquier otro carácter se ignora
  }
 delay (35);
}