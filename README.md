# Largest Series Product

Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

**Ad esempio:**

- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

- Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

## Soluzione
Per risolvere l'esercitazione iniziamo ponendo dei controlli che ci permettano di eliminare i vari errori che le varie istruzioni potrebbero darci, come ad esempio:
```
if(span < 0 || span > digits.Count() || int.TryParse(digits, out s) == false){
        if(digits == "" && span == 0){
                return 1;
        }
        throw new ArgumentException();
}
```
Con questo blocco eliminiamo diversi problemi come ad esempio se il numero di numeri da moltiplicare sia negativo, se i numeri da moltiplicare siano maggiori dei numeri della stringa e se nella stringa non ci siano caratteri indesiderati, poniamo una condizione extra nel caso in cui la stringa sia vuota e il numero di numeri da moltiplicare sia 0 e ggiungiamo un controllo in modo che se il TryParse non riesce a convertire la stringa perchè troppo grande esso non finisca per Throware il risultato.

Dopo aver termito con i controlli, scriviamo il blocco di codice che ci permette la risoluzione dell'esercizio, esso è il seguente:
```
for(int i = 0; i <= digits.Count() - span; i++){
        for (int j = i; j < span + i; j++){
                int temp = 0;
                int.TryParse(digits[j].ToString(), out temp);
                prova = prova * temp;
        }
        if(prova > max){
                max = prova;
        }
        prova = 1;
}
return max;
```
In questo blocco di codice creiamo un ciclo che girerà un numero di volte pari al numero di caratteri della stringa meno il numero di valori da moltiplicare fra loro per trovare il maggiore, successivamente creeremo un variabile in cui salveremo il prodotto dei vari numeri, verificheremo poi se questa variabile è maggiore del massimo e in caso alla variabile max gli assegnamo il valore del prodotto e alla fine di ogni ciclo ripristineremo il valore della variabile. Finito tutto ritorneremo il valore massimo
