using cw3App;

// Stworzenie kontenera danego typu
ContainerL containerL = new ContainerL(weight: 1000,
                                        height: 10,
                                        cargoWeight: 0,
                                        depth: 5,
                                        maxCargoWeight: 5000,
                                        hazardousCargo:true);
ContainerG containerG = new ContainerG(weight: 1000,
                                        height: 10,
                                        cargoWeight: 0,
                                        depth: 5,
                                        maxCargoWeight: 5000,
                                        pressure:100);
ContainerC containerC = new ContainerC(weight: 1000,
                                        height: 10,
                                        cargoWeight: 0,
                                        depth: 5,
                                        maxCargoWeight: 5000,
                                        productType:ProductType.Banana,
                                        containerTemperature: 13);
// Załadowanie ładunku do danego kontenera
containerC.Fill(105);
try
{
    containerC.Fill(10000);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}

// Załadowanie kontenera na statek
ContainerShip containerShip = new ContainerShip(maxSpeed: 100, maxWeight: 100, maxNumberOfContainers: 5);
containerShip.AddContainer(containerC);

// Załadowanie listy kontenerów na statek
containerShip.AddContainers([containerG,containerL]);
Console.WriteLine(containerShip);

// Usunięcie kontenera ze statku
containerShip.Remove(containerG);
Console.WriteLine(containerShip);

// Rozładowanie kontenera
containerC.Empty();
Console.WriteLine(containerC);

// Zastąpienie kontenera na statku o danym numerze innymkontenerem
containerShip.Replace(index: 0,containerG);
Console.WriteLine(containerShip);

// Możliwość przeniesienie kontenera między dwoma statkami
ContainerShip containerShip2 = new ContainerShip(maxSpeed: 150, maxWeight: 10, maxNumberOfContainers: 3);
containerShip.TransportTo(containerShip: containerShip2,
                            container: containerShip.Containers[0]);
Console.WriteLine(containerShip);
Console.WriteLine(containerShip2);

// Wypisanie informacji o danym kontenerze
Console.WriteLine(containerC);

// Wypisanie informacji o danym statku i jego ładunku
Console.WriteLine(containerShip);