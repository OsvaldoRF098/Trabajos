// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> milista =new List<int>();

List<string> listanombres = new List<string>();

MiGenericClass<string> miGenericClass = new MiGenericClass<string>("nombre");

miGenericClass.GenercMethod("otro string");

MiGenericClass<long> migenericlong = new MiGenericClass<long>(200);
migenericlong.GenercMethod(23000);




Repository<Product> repositoryProducts = new Repository<Product>();

Product product1 = new Product("pza","Clavo", "13221320", 200);
Product product2 = new Product("metros","Alambre recocido", "1321321", 900);


repositoryProducts.Save(product1);
repositoryProducts.Save(product2);

var lastProduct = repositoryProducts.GetItem();

Repository<Service> repositoryService = new Repository<Service>();

Service service1 = new Service(10, "Lavado de auto", 100);
Service service2 = new Service(2, "Hora de programacion", 500);

repositoryService.Save(service1);
repositoryService.Save(service2);


