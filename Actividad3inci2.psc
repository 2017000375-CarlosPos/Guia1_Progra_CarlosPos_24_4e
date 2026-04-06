Algoritmo Actividad3inci2
	Definir a, b, c Como Entero
	
    Escribir "Ingrese los tres ángulos:"
    Leer a, b, c
	
    Si a + b + c = 180 Entonces
	Si a = 90 O b = 90 O c = 90 Entonces
	Escribir "Triángulo rectángulo"
	Sino
	Si a < 90 Y b < 90 Y c < 90 Entonces
	Escribir "Triángulo acutángulo"
	Sino
	Escribir "Triángulo obtusángulo"
	FinSi
	FinSi
    Sino
	Escribir "No es un triángulo válido"
    FinSi
FinAlgoritmo
