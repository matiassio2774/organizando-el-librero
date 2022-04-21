# organizando-el-librero

----Detalles de implementación-----
Debes implementar la función librero (bases, libros), que dados los arreglos deenteros bases y libros (ambos de tamaño N), retorne la altura final resultante.
En el caso de que no sea posible cumplir con el requisito solicitado de que todos los libros queden a una misma altura total en el librero, la función deberá retornar -1.

--Evaluador local--
El evaluador local lee de la entrada
estándar:
Una primera línea con la cantidad de
libros N
Una segunda línea con N enteros,
que representan las alturas de las
distintas bases, en orden.
Una tercera línea con N enteros,
que representan las alturas de los
distintos libros.

Devuelve por la salida estándar el resul-
tado de llamar a la función librero.

Cotas
*1 ≤ N ≤ 1000
*Todas las alturas son enteros entre 1 y 1000 inclusive.

-----Ejemplo-----
Si el evaluador local recibe la siguiente entrada:

8
3 2 6 2 4 2 1 6
6 8 4 8 7 9 8 4

Una implementación correcta deberá devolver:

10

Si en cambio recibe:

4
1 1 1 21
4 4 4 4 

Para una implementación correcta devolverá:

-1
