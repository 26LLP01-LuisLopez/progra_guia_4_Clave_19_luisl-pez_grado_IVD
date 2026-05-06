Algoritmo leccion_11_actividad_2
	Definir i,j,contador,suma Como Entero
	Definir esPrimo Como Logico
	contador<-0
	suma<-0
	Para i<-2 Hasta 100
		esPrimo<-Verdadero
		Para j<-2 Hasta i-1
			Si i MOD j=0 Entonces
				esPrimo<-Falso
			FinSi
		FinPara
		Si esPrimo Entonces
			contador<-contador+1
			suma<-suma+i
		FinSi
	FinPara
	Escribir "Cantidad:",contador
	Escribir "suma",suma
FinAlgoritmo
