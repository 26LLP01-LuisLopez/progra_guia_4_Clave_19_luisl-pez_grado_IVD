Algoritmo leccion_11_actividad_3_2
	Definir suma,contador,i,j Como Entero
	Definir Primo Como Logico
	suma<-0
	contadors<-0
	Para i<-300 Hasta 1 Con Paso -1
		Si i MOD 2=0 Entonces
			suma<-suma+i
		FinSi
		Primo<-Verdadero
		Si i<2 Entonces
			Primo<-Falso
		SiNo
			Para j<-2 Hasta i-1
				Si i MOD j=0 Entonces
					Primo<-Falso
				FinSi
			FinPara
		FinSi
		Si Primo Entonces
			
			contador<-contador+1
		FinSi
	FinPara
	Escribir contador,suma
FinAlgoritmo
