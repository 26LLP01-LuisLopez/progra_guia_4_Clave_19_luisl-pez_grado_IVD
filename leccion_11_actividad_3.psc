Algoritmo leccion_11_actividad_3
	Definir suma,pares,num,i Como Entero
	suma<-0
	pares<-0
	Para i<-1 Hasta 20
		num<-i*7
		suma<-suma+num
		Si num MOD 2=0 Entonces
			pares<-pares+1
		FinSi
	FinPara
	Escribir suma,pares
FinAlgoritmo
