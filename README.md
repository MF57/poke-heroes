# poke-heroes


Gra zbudowana na bazie Hexagon Asset.

Instrukcja:

W pierwszej kolejności należy wybrać z menu w lewym górnym rogu, tryb jedno, czy dwuosobowy:
 - w przypadku trybu jednoosobowego gracz staje do walki z prostym AI
 - w przypadku trybu dwuosobowego - dwóch graczy staje na przeciwko siebie do walki.
 
 Po wybraniu trybu rozgrywki, automatycznie zaczyna się gra.
 
 Obaj zawodnicy otrzymują po 3 Pokemony rozstawione po bokach planszy (w przypadku trybu jednoosobowego pokemony gracza znajdują sie po prawej stronie).
 
 Gracz za pomocą strzałek może sterować kamerą.
 
 Rzogrywka jest turowa. Gracz, który jako pierwszy utraci wszystkie swoje pokemony przegrywa.
 
 W trakcie tury, gracz może poruszyć swoimi pokemonami, każdym maksymalnie raz na turę. Pokemony, którymi w tej turze można wykonać ruch, podświetlają się na zielono. 
 
 Aby poruszyć się pokemonem należy na niego kliknąć, a następnie kliknąć w pole, na które gracz chce, aby pokemon się przeniósł. Jeśli pole jest w zasięgu pokemona, to pojawi się ścieżka, z żółtych pól, po której pokemon przejdzie. Jeśli pole jest poza zasięgiem pokemona, to ruch w to miejsce jest niemożliwy. 
 
 Jeśli po wybraniu pokemona, gracz zdecyduje się jeszcze nim nie ruszać, należy w lewego górnego rogu wybrać opcję 'Cancel move'.
 
 Każdy pokemon po swoim ruchu ma możliwość ataku pokemona gracza przeciwnego. Atak jest możliwy tylko i wyłącznie jeśli przeciwny pokemon znajduje się na polu sąsiadującym do pola, na którym znajduje się pokemon gracza (pole z przeciwnikiem podświetli się na czerwono). Jeśli po ruchu gracz nie chce atakować, to powinien wybrać opcję Cancel Attack z lewego górnego rogu.
 
 Po wyczerpaniu wszystkich ruchów, tura się kończy i kolej na drugiego gracza. Jeśli gracz chce zakończyć swoją turę wcześniej, może to zrobić klikając 'End turn' w lewym górnym rogu.
 
 
 
 W grze została zaimplementowana logika z Pokemonów. Każdy pokemon posiada 6 statystyk: ATK, SP_ATK, DEF, SP_DEF, SPEED, 1 lub 2 typy oraz 4 ataki.
 
 Atak pokemona posiada swój typ (tak jak typ pokemona), rozdaj (psychical, spechial), basePower oraz celność.
 W momencie zaatakowania pokemona przeciwnego, losowany jest jeden z ataków pokemona (mozliwosc wyboru ataku z UI jako mozliwosc dalszego rozwoju), a następnie generowana jest losowo liczba, która sprawdza, czy atak trafił, czy nie.
 
 Następnie sprawdzane jest type effectiveness. Jeśli typ ataku jest super effective lub not very effective przeciwko typom pokemona-celu, ustawiane są odpowiednie mnożniki.
 
 Dodatkowo generowane są losowe dwie liczby, jedna, która ustawia mnożnik critical hit, a druga, która dorzuca czynnik losowości do zadawanych obrażeń.
 
 Jeśli atak jest rodzaju psychical, to uzywany jest wspolczynnik ATK pokemona atakującego oraz wspolczynnik DEF pokemona-celu.
 Jeśli atak jest rodzaju special, to uzywany jest wspolczynnik SP_ATK pokemona atakującego oraz wspolczynnik SP_DEF pokemona-celu.

SPEED jest wykorzystywany w wyznaczaniu zasięgu pokemona. 



Możliwości dalszego rozwoju:
- wybór pokemonów do walki z guia - dodawanie nowego pokemona do planszy jest bardzo latwe, gracz moglby to wyklikiwac z guia
- mozliwosc wyboru ataku - backend jest, guia nie ma
- ataki pasywne - np zmieniajace statystyki pokemonow
- różne plansze
- animacje
