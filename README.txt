LoversenySzimulator

Kezdő felület felépítése
 -> Új verseny gomb
 -> Verseny indítása gomb
 -> Fogadás típus választó
 -> Fogadó felület (változik a típus választás függvényében)
 -> Játékosok adatai panel
 -> Futópálya
 -> Eredmény kijelző tábla

Új verseny gomb megnyomás (buttonUjVerseny_Click)
 -> Eddig minden más felület disabled innentől lesz aktív (első verseny után ezzel lehet reset-elni a felületet)
 -> Versenyzők véletlenszerű kiválasztás ellenőrizve, hogy ne legyen azonos versenyző
 -> Adatok feltöltése a Versenyzok listába (class Versenyzo)
 	-> Lovak számának megnézése (LoDB)
	-> Zsokék számának megnézése (ZsokeDB)
	-> Lovak nevének kikeresése (LoNev)
	-> Zsokék nevének kikeresése (ZsokeNev)
	-> Lovak eredményeinek kiszámítása az eddigi verseny eredményekből (LoEredmény)
	-> Zsokék eredményeinek kiszámítása az eddigi verseny eredményekből (ZsokeEredmény)
 	-> Ebből az osztályon belül az összesítet Eredményt ami a versenyző szintje a property settere automatikusan számolja
 -> VersenyzoInterface lista feltöltése ezen fog megjelenni a képen az adatok (class Versenyzointerface : Label)
 -> VersenyzoInterfacek kirajzolása a felületre
 -> Versenyző Babuk feltöltéltese azonosítóval és a hozzá tartozó bábú képével (class Lovacska : Label)
 -> Fogadás típusok szerint feltölteni adattala fogadást (class Fogadas)

Fogadásitípus vállasztás
 -> A fogadás adatainak változását lerögzíten a fogadásban és a fogadásban szerepl versenyzők interface-ének kiemelése és ezek válzotásainak kezelése (combobox-ok SelectedIndexChange eseményei és a Fogadas class aktive property setter eseménye)

Verseny indítása
Verseny szimulálása
Verseny lezárása
Eredmeny kiírás csv-be és utána mentése az adatbázisba
Újversenynél a felület alaphelyzetbe állítása