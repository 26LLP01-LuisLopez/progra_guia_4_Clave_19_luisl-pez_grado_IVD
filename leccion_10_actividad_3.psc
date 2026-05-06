Algoritmo leccion_10_actividad_3
	Definir i, x Como Entero
	Definir primo Como Logico
	suma = 0
	Para i<-1 Hasta 22 Hacer
		primo = Verdadero
		Si 1 <= 1 Entonces
			primo = falso 
			Para x<-2 Hasta i -1   Hacer
				Si i MOD x = 0 Entonces
					primo = Falso
				Fin Si
			FinPara
		Fin Si
		Si primo Entonces
			suma = suma + 1
		Fin Si
	Fin Para
	Escribir " La suma de primos es de:",suma
FinAlgoritmo
