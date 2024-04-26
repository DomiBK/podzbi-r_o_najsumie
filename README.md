# podzbior_o_najsumie
Największą sumę możemy znaleźć przez obliczenie wszystkich sum częściowych i  wybranie spośród nich największej. Pierwszy algorytm będzie pracował wg tej właśnie zasady.

W algorytmie będziemy pamiętać:
Największą wartość sumy częściowej w zmiennej ms.
Bieżąco wyliczaną sumę częściową w zmiennej bs.
Indeksy startu i końca podciągu o bieżąco największej sumie w zmiennych ip oraz ik.

Zasada działania będzie następująca:
W algorytmie będą dwie pętle: pętla i będzie wybierała elementy startu podciągu, a wewnętrzna pętla j będzie wybierała kolejne elementy końca podciągu. W pętli wewnętrznej będzie obliczana suma bs kolejno elementów o indeksach od i do  j. Jeśli suma bs okaże się większa od sumy maksymalnej ms, to do ms wpiszemy sumę bs i jednocześnie zapamiętamy pozycję startu i końca tego podciągu w zmiennych ip oraz ik. Gdy zewnętrzna pętla i  zakończy działanie, w zmiennych ms, ip, ik znajdzie się wynik.

Algorytm znajdowania największej sumy podciągu
Wejście:
n : liczba elementów tablicy, n ∈ N.
T : tablica n-elementowa z ciągiem liczb, elementy są liczbami całkowitymi lub rzeczywistymi.

Wyjście:
ms : największa suma podciągu, typ taki sam jak typ elementów T.
ip : indeks pierwszego elementu podciągu, ip ∈ C.
ik : indeks ostatniego elementu podciągu, ik ∈ C.
Zmienne pomocnicze:
i, j : przebiegają przez kolejne indeksy elementów T. i, j ∈ C.

Lista kroków:
K01: ms ← najmniejsza liczba ; ta wartość zostanie uaktualniona 
K02: Dla i = 0,1,…,n-1:      ; i wyznacza pierwszy element podciągu      wykonuj kroki K03…K09 
K03:   bs  ← 0               ; zerujemy sumę bieżącą 
K04:   Dla j = i,i+1,…,n-1:  ; j wyznacza ostatni element podciągu        wykonuj kroki K05…K09 
K05:     bs  ← bs + T[j]     ; liczymy sumę częściową 
K06:     Jeśli bs ≤ ms,          to następny obieg K04 
K07:     ms  ← bs            ; uaktualniamy zmienne wynikowe 
K08:     ip  ← i             ; indeks początku podciągu 
K09:     ik  ← j             ; indeks końca podciągu 
K10: Zakończ

Utwórz program który tworzy tablicę 20 elementową i wypełnia ją całkowitymi liczbami pseudolosowymi od -99 do 99. Następnie znajduje największą sumę podciągu oraz pozycję tego podciągu w tablicy.

Na cel:
Utwórz program który tworzy macierz 20x20 i wypełnia ją całkowitymi liczbami pseudolosowymi od -99 do 99. Następnie znajduje największą sumę podciągu oraz pozycję tego podciągu w macierzy.
