using AkvelonWeek1LukaRaicevic;

static void ispisiNiz(Vozilo[] niz, int n)
{
    Console.WriteLine("Podaci o vozilima: \n");
    foreach (Vozilo v in niz)
        Console.WriteLine(v);
}//Deklarisanje novih vozila
Vozilo v1 = new Avion(15000,5000, "Zlatna", 800, 1200);
Vozilo v2 = new Auto("BMW",4,"Zuta",100,260);
Vozilo v3 = new Avion(12000, 5000, "Roze", 600, 900);
Vozilo v4 = new Auto("Ferrari", 2, "Plava", 40, 360);

//Ispisivanje podataka o jednom vozilu
Console.WriteLine("Ispis podataka o jednom vozilu\n");Console.WriteLine(v1);//Kreiranje niza vozilaVozilo[] niz = new Vozilo[4];Console.WriteLine("NIZ VOZILA\n");niz[0] = v1;
niz[1] = v2;
niz[2] = v3;
niz[3] = v4;ispisiNiz(niz, 4);

//Testiranje ubrzanja vozila i usporenja
Console.WriteLine("Testiranje promena brzine: \n");
v1.ubrzaj();
Console.WriteLine("Vozilo posle ubrzanja ");
Console.WriteLine(v1);
v1.uspori();
Console.WriteLine("Vozilo posle usporenja ");
Console.WriteLine(v1);
v2.ubrzaj();
Console.WriteLine("Vozilo posle ubrzanja ");
Console.WriteLine(v2);
v2.uspori();
Console.WriteLine("Vozilo posle usporenja ");
Console.WriteLine(v2);
v3.ubrzaj();
Console.WriteLine("Vozilo posle ubrzanja ");
Console.WriteLine(v3);
v3.uspori();
Console.WriteLine("Vozilo posle usporenja ");
Console.WriteLine(v3);
v4.ubrzaj();
Console.WriteLine("Vozilo posle ubrzanja ");
Console.WriteLine(v4);
v4.uspori();
Console.WriteLine("Vozilo posle usporenja ");
Console.WriteLine(v4);







