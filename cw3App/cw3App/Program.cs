using System.ComponentModel;
using cw3App;

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
Console.WriteLine(containerL);

ContainerShip containerShip = new ContainerShip(maxSpeed: 100, maxWeight: 100, maxNumberOfContainers: 100);
containerShip.AddContainer(containerL);
containerShip.AddContainer(containerG);
Console.WriteLine(containerShip);
                                        