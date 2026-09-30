Revistas revistas = new Revistas(1,"casita",2024,"ezequiel");
Revistas revistas2 = new Revistas(2,"casita2",2025,"ezequiel2");
Libro libro = new Libro(1,"casita2",2025,"ezequiel2");

Biblioteca biblioteca = new Biblioteca();

biblioteca.IngresarMaterial(revistas);
biblioteca.IngresarMaterial(revistas2);
biblioteca.IngresarMaterial(libro);
Console.WriteLine(biblioteca.Material[1]);
Console.WriteLine(biblioteca.ConusltarMostrador(1));
Console.WriteLine(biblioteca.ConusltarMostrador(2));
Console.WriteLine(biblioteca.ConusltarMostrador(1));