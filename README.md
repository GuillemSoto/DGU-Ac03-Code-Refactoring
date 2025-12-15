# 3. Jocs de prova

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
