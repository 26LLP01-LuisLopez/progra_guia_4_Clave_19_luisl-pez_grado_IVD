Algoritmo leccion_11_actividad_2_2
	Definir total,cont,billete,i Como Entero
	total<-0
	cont<-0
	Para i<-1 Hasta 1000
		Leer billete
		total<-total+billete
		Si billete=100 Entonces
			cont<-cont+1
		FinSi
	FinPara
	Escribir cont,total
	
FinAlgoritmo
