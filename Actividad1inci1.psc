Algoritmo Actividad1inci1
	Definir not1, not2, not3, not4, not5, pro Como Real
	
    Escribir "Ingrese 5 calificaciones:"
    Leer not1, not2, not3, not4, not5
	
    pro = (not1 + not2 + not3 + not4 + not5) / 5
	
    Escribir "Tu promedio es: ", pro
	
    Si pro >= 70 Entonces
	Escribir "Aprobado"
    Sino
    Escribir "Reprobado"
    FinSi
FinAlgoritmo
