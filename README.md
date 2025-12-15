# 3. Jocs de prova
Si a > 0, b > 0 i c > 0, el resultat és a + b + c.
Si a > 0, b > 0 i c ≤ 0, el resultat és a + b.
Si a > 0 i b ≤ 0, el resultat és a.
Si a ≤ 0, el resultat és 0.
Si el resultat és 0, mostra: "El resultat és zero."
Si el resultat és > 0, mostra: "El resultat és positiu."
Si el resultat és < 0, mostra: "El resultat és negatiu."

Cas         Descripció                               Entrada         Accions                                                 Resultat Esperat                          Resultat obtingut
CP01        Comprovar que si tots els valors 
            són 0 el resultat sigui 0.               a=0;b=0;c=0;    Passar 0 a tots els valors d'entrada                    "El resultat és zero.", resultat=0
CP02        Comprovar que si tots els valors 
            són majors a 0 el resultat sigui a+b+c.  a=3;b=7;c=9;    Passar 3, 7 i 9 respectivament als valors d'entrada     "El resultat és positiu.", resultat=19 
CP03        Comprovar que si posem "a" com un
            valor negatiu el resultat serà 0.        a=-4;b=0;c=9;   Passar -4, 0 i 9 respectivament als valors d'entrada    "El resultat és zero.", resultat=0
CP04        Comprovar que si a i b són positius i
            c no, el resultat sigui a + b.           a=6;b=2;c=-8;   Passar 6, 2 i -8 respectivament als valors d'entrada    "El resultat és positiu.", resultat=8
CP05        Comprovar que si només a és positiu 
            el resultat sigui a.                     a=5;b=0;c=-8;   Passar 5, 0 i -8 respectivament als valors d'entrada    "El resultat és positiu.", resultat=5

