Algoritmo Actividad3inci1
	Definir dia, mes Como Entero
	
    Escribir "Pon el número del día:"
    Leer dia
    Escribir "Pon el número del mes:"
    Leer mes
	
    Si (mes = 12 Y dia >= 21) O (mes = 1) O (mes = 2) O (mes = 3 Y dia <= 20) Entonces
	Escribir "Verano"
    Sino
	Si (mes = 3 Y dia >= 21) O (mes = 4) O (mes = 5) O (mes = 6 Y dia <= 20) Entonces
	Escribir "Otoño"
	Sino
	Si (mes = 6 Y dia >= 21) O (mes = 7) O (mes = 8) O (mes = 9 Y dia <= 20) Entonces
	Escribir "Invierno"
	Sino
	Si (mes = 9 Y dia >= 21) O (mes = 10) O (mes = 11) O (mes = 12 Y dia <= 20) Entonces
	Escribir "Primavera"
    SiNo

	Escribir "Fecha equivocada"
	FinSi
	FinSi
	FinSi
    FinSi
FinAlgoritmo
