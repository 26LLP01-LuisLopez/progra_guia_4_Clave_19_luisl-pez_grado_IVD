Algoritmo leccion_9_actividad_3_2
	Definir num, i Como Entero
	Definir primo Como Logico
	Escribir "Digite un numero"
	leer num
	primo= Verdadero
	i=2
	Mientras i < num Hacer
		Si num MOD i = 0 Entonces
			primo = Falso
		Fin Si
		i = i +1
	Fin Mientras
	Si primo Entonces
		Escribir " Es primo"
	SiNo
		Escribir " No es primo"
	Fin Si
FinAlgoritmo
