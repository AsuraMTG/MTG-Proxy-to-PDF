# MTG Proxy to PDF

**MTG Proxy to PDF** egy C# Windows Forms alkalmazás, amely lehetővé teszi Magic: The Gathering (MTG) képek PDF fájlba történő elhelyezését. A program 3x3-as elrendezésben rendezi el a képeket, és létrehozza belőlük a PDF fájlt.

## Funkciók

- **Felhasználói név megadása a PDF fájlhoz**: Az alkalmazás indításakor lehetőséged van megadni a létrehozandó PDF fájl nevét.
- **Forrásmappa kiválasztása**: Kiválaszthatsz egy mappát, amely a Magic: The Gathering képeket (PNG formátumban) tartalmazza, és a program ezeket fogja felhasználni a PDF generálásához.
- **Automatikus képrendezés**: A program automatikusan 3x3-as elrendezésben elhelyezi a képeket a PDF fájlban. Ha több mint 9 kép található, új oldalt indít a program a további képek számára.
- **Hibakezelés**: Ha egy kép nem felel meg (pl. nem PNG formátumú), akkor az nem kerül bele a PDF-be, és nem lesz a `Done` mappában sem.
- **Csak PNG formátum**: A program kizárólag PNG formátumú képekkel működik.

## Hogyan működik

1. **Alkalmazás indítása**: Az alkalmazás indításakor meg kell adnod a PDF fájl nevét, amelyet létre szeretnél hozni.
2. **Kép mappa kiválasztása**: Majd kattints a gombra, hogy kiválaszd azt a mappát, amely a Magic: The Gathering PNG képeket tartalmazza.
3. **PDF generálása**: A program automatikusan 3x3-as elrendezésben elhelyezi a képeket a PDF fájlban.
4. **Felhasznált Képek**: A felhasznált képek egy `Done` nevű mappába kerülnek.
5. **Nem megfelelő képek**: Ha egy kép nem felel meg a követelményeknek (például nem PNG formátumú), akkor az nem kerül bele a PDF-be, és nem lesz elhelyezve a `Done` mappában.

## Telepítés

1. Hamarosan elérhető lesz egy telepítő file
