# APBD-cw4
Aplikacje REST API, która pozwala zarządzać danymi zwierząt w
bazie danych schroniska dla kliniki weterynaryjnej.
Zwierze opisywane jest przez:
-id,
-imię,
-kategoria (np. pies, kod itp.)
-masa
-kolor sierści
Chcielibyśmy mieć możliwość:
-pobierania listy zwierząt
-pobierania konkretnego zwierzęcia po id
-dodawania zwierzęcia
-edycji zwierzęcia
-usuwania zwierzęcia

Ponadto chcielibyśmy zapisywać informacje na temat wizyt zwierzęcia:
Wizyta obejmuje następujące informacje:
1. chcielibyśmy mieć możliwość pobrania listy wizyt powiązanych z danym
zwierzęciem
2. chcielibyśmy mieć możliwość dodawania nowych wizyt
data wizyty
zwierzę
opis wizyty
cena wizyty
1. Przygotuj aplikację z REST API z odpowiednimi końcówkami HTTP -
GET, POST, PUT, DELETE.
2. Upewnij się, że struktura końcówek jest zgodna z zasadami
projektowania końcówek REST.
3. Jako bazą danych przygotuj statyczną kolekcję z obiektami.
4. Możesz wykorzystać zarówno podejście MinimalAPI lub skorzystać z
wersji API wykorzystującej klasy kontrolerów.
5. Przetestuj przygotowaną aplikację z pomocą Postman'a.