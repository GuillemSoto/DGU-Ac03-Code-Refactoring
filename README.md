# 1. SonarCloud

---

### Pregunta 1
**En aquest anàlisi inicial del programa, es mostren resultats en l’apartat de cobertura de codi (coverage)? Raoneu la vostra resposta, incloent una captura de la pantalla de resum de SonarCloud.**  

En aquest anàlisi incial encara no es mostren els resultats respecte a la cobertura de codi es a dir, el coverage. De moment el nostre projecte només conté el Program.cs amb el codi però sense cap test realitzat (xUnit o MSTest, per exemple), per tant, no podrem generar el coverage sense abans implementar tests al nostre projecte.

![SonarCube start coverage](Images/SonarCube_Coverage.png)

# 2. Refactoring del codi

---

### Pregunta 2
**Quines accions heu realitzat per reduir la complexitat ciclomàtica?  Raoneu la vostra resposta.**

Primer hem canviat l'accés de class Program & static void Main a public, ja que si no es fa no pots testejar el codi.
Després hem tret unusedVar i una part del codi cap al final ja que cap dels dos fragments estava fent res.
Console.WriteLine("Benvingut al programa de càlculs!") i Console.WriteLine("Finalitzant el programa...") estaven duplicats i a més tots els missatges estaven posats com a literals en comptes de com a constants, així que també ho hem canviat.
Després d'això hem posat a les variables a, b i c els noms firstNum, secondNum i thirdNum, ja que aquests són més descriptius.
Una vegada tot fet hem passat gran part del codi a una funció separada i arreglat una cadena d'ifs que no era agradable ni eficient i l'hem passat a una cadena d'else if i a un switch respectivament.
Per últim, hem separat la funció que calcula el resultat de la que el printa per tal de tenir un codi més modular

# 3. Jocs de prova

---

- Si a > 0, b > 0 i c > 0, el resultat és **a + b + c**.
- Si a > 0, b > 0 i c ≤ 0, el resultat és **a + b**.
- Si a > 0 i b ≤ 0, el resultat és **a**.
- Si a ≤ 0, el resultat és **0**.
- Si el resultat és **0**, mostra:  
  > "El resultat és zero."
- Si el resultat és **> 0**, mostra:  
  > "El resultat és positiu."
- Si el resultat és **< 0**, mostra:  
  > "El resultat és negatiu."

## Casos de prova

| Cas  | Descripció | Entrada | Accions | Resultat Esperat | Resultat obtingut |
|-----|------------|---------|---------|------------------|-------------------|
| CP01 | Comprovar que si tots els valors<br>són 0 el resultat sigui 0. | a=0;<br>b=0;<br>c=0; | Passar 0 a tots els valors d'entrada | "El resultat és zero.",<br>resultat=0 | |
| CP02 | Comprovar que si tots els valors<br>són majors a 0 el resultat sigui a+b+c. | a=3;<br>b=7;<br>c=9; | Passar 3, 7 i 9 respectivament als valors d'entrada | "El resultat és positiu.",<br>resultat=19 | |
| CP03 | Comprovar que si posem "a" com un<br>valor negatiu el resultat serà 0. | a=-4;<br>b=0;<br>c=9; | Passar -4, 0 i 9 respectivament als valors d'entrada | "El resultat és zero.",<br>resultat=0 | |
| CP04 | Comprovar que si a i b són positius i<br>c no, el resultat sigui a + b. | a=6;<br>b=2;<br>c=-8; | Passar 6, 2 i -8 respectivament als valors d'entrada | "El resultat és positiu.",<br>resultat=8 | |
| CP05 | Comprovar que si només a és positiu<br>el resultat sigui a. | a=5;<br>b=0;<br>c=-8; | Passar 5, 0 i -8 respectivament als valors d'entrada | "El resultat és positiu.",<br>resultat=5 | |

---

### Pregunta 3
**Com separaríeu la lògica de càlcul en mètodes independents? Raoneu la vostra resposta.**
Hauria d'haver un mètode que llegeixi cada número, un que comprovi quina condició es compleix (És a dir, que comprovi si a>0, b>0, etc) i un que retorni el valor de resultat per cada càlcul possible, per exemple un retornarà a+b+c (si tots son positius), un altre retornarà 0 (si a és negatiu) o un altre retornarà a.
Aquesta solució intenta modular el codi el màxim possible per tal que sigui escal·lable en el futur.

### Pregunta 4
**Es poden passar tots els tests correctament? Com es captura la sortida per consola? Raoneu la vostra resposta i poseu algun exemple on ho heu implementat.**
![testing image](Images/TestCode.png)
En l'image es testega el codi senes refactoritzar i el codi refactoritzat. Tots els tests s'han passat correctament.

Per capturar la sortida per consola hem utilitzat dos metodes diferents. 
- En el primer, en comptes de printar el missatge, s'ha emagatzemat aquest en una variable del tipus string i s'ha comprovat el resultat.
- En el segon, el metode si que printa el missatge, i en comptes d'utilitzar una variable en el test per emagatzemar el missatge i despres comprovar-lo s'ha fet el seguent: 
```
public void TC3_Test_AfterRefactor_With_ConsoleOutput(int firstNum, int secondNum, int thirdNum, int expectedResult, string msgExpected)
{
    //Arrange
    StringWriter msgResult = new StringWriter();
    Console.SetOut(msgResult);
    int result;

    //Act
    IssuesCode.CalculSumsRefactorWithConsoleOutput(firstNum, secondNum, thirdNum, out result);

    //Assert
    Assert.Equal(expectedResult, result);
    Assert.Equal(msgExpected, msgResult.ToString());
}
```
