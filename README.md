# Piramide

Devi scrivere un programma che calcoli l'altezza massima di una piramide (in termini di piani) dato un certo numero di cubi di pietra.

La piramide che andrai a costruire avrà le seguenti caratteristiche:

- Ogni piano della piramide sarà composto da un quadrato di mattoni.
- La piramide sarà compatta, quindi non ci saranno cavità al suo interno.
- Ogni piano sarà quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- Il primo piano sarà composto da un singolo mattone.

Esempi:

- Il primo piano avrà un mattone, il secondo avrà 9 mattoni, il terzo 25, e così via.
- Con 1 solo mattone, la piramide avrà un'altezza di 1 piano.
- Con 84 mattoni, la piramide avrà un'altezza di 4 piani.

Il tuo compito è implementare:

- Il metodo `int Piani(int mattoni)` che restituisce il numero di piani della piramide data una quantità di mattoni.
- Il metodo `int Rimanenti(int mattoni)` che restituisce il numero di mattoni rimasti dopo la costruzione della piramide.

Se ti avanzano dei mattoni, considerali come "rimanenti", a patto che tu abbia costruito una piramide completa.

Ecco il codice parziale che puoi utilizzare per completare la soluzione:

```csharp
public static int Piani(int mattoni) {
    int floors = 0;
    while (mattoni >= (2 * floors + 1) * (2 * floors + 1)){
        floors++;
        mattoni -= (2 * floors - 1) * (2 * floors - 1);
    }
    return floors;
}

public static int Rimanenti(int mattoni) {
    int floors = Piani(mattoni);
    int mattoniUtilizzati = 0;
    for (int i = 1; i <= floors; i++){
        mattoniUtilizzati += (2 * i - 1) * (2 * i - 1);
    }
    return mattoni - mattoniUtilizzati;
}
```
