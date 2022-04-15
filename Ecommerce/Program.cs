
using Ecommerce.Models;
using Ecommerce.Services;

ProductServices services = new();
back:
Console.WriteLine("1. Ana Sehife");
Console.WriteLine("2. Mehsullar");
Console.WriteLine("3. Mehsul elave et");
Console.WriteLine("4. Mehsulu sil");
Console.WriteLine("5. Mehsulu yenile");

var menu = Console.ReadLine();
int menuInt = Convert.ToInt32(menu);

switch (menuInt)
{
    case 1:
        Console.Clear();
        foreach (var product in services.GetAll())
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine(
                "Id: " + product.Id +
                "\n" + "Name: " + product.Name +
                "\n" + "Price: " + product.Price + " AZN" +
                "\n" + "Area: " + product.Area + " m²" +
                "\n" + "RoomNumber: " + product.RoomNumber +
                "\n" + "Kupca: " + product.Kupca +
                "\n" + "Description: " + product.Description +
                "\n" + "Hit: " + product.Hit +
                "\n" + "Category" + product.Category +
                "\n" + "PublishDate: " + product.PublishDate +
                "\n" + "UptadeDate: " + product.UpdatedDate);
            Console.WriteLine("_________________________________________");
        }
        Console.WriteLine("Id daxil edin:");
        var touch = Console.ReadLine();
        var service = services.GetById(Convert.ToInt32(touch));

        Console.WriteLine(
                "Id: " + service.Id +
                "\n" + "Name: " + service.Name +
                "\n" + "Price: " + service.Price + " AZN" +
                "\n" + "Area: " + service.Area + " m²" +
                "\n" + "RoomNumber: " + service.RoomNumber +
                "\n" + "Kupca: " + service.Kupca +
                "\n" + "Description: " + service.Description +
                "\n" + "Hit: " + service.Hit +
                "\n" + "Category" + service.Category +
                "\n" + "PublishDate: " + service.PublishDate +
                "\n" + "UptadeDate: " + service.UpdatedDate);
        Console.WriteLine("------------------------------");
        goto back;

        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Qiymet daxil edin:");
        var filter = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filter))
        {
            filter = "0";
        }
        int filterInt = Convert.ToInt32(filter);
        foreach (var product in services.GetFilter(filterInt))
        {
            Console.WriteLine(
               "Id: " + product.Id +
               "\n" + "Name: " + product.Name +
               "\n" + "Price: " + product.Price + " AZN" +
               "\n" + "Area: " + product.Area + " m²" +
               "\n" + "RoomNumber: " + product.RoomNumber +
               "\n" + "Kupca: " + product.Kupca +
               "\n" + "Description: " + product.Description +
               "\n" + "Hit: " + product.Hit +
               "\n" + "Category" + product.Category +
               "\n" + "PublishDate: " + product.PublishDate +
               "\n" + "UptadeDate: " + product.UpdatedDate);
            Console.WriteLine("------------------------------");
        }
        goto back;
        break;
    case 3:

        Console.WriteLine("Id: ");
        var id = Console.ReadLine();
        int idInt = Convert.ToInt32(id);
        Console.WriteLine("Product name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Room Number: ");
        var roomNum = Console.ReadLine();
        int roomNumInt = Convert.ToInt32(roomNum);
        Console.WriteLine("Price: ");
        var price = Console.ReadLine();
        decimal priceDec = Convert.ToDecimal(price);
        Console.WriteLine("Area: ");
        var area = Console.ReadLine();
        decimal areaDec = Convert.ToDecimal(area); 
        Console.WriteLine("Description: ");
        var desc = Console.ReadLine();

        Product newProduct = new()
        {
            Id = idInt,
            Name = name,
            Price = priceDec,   
            Area = areaDec,
            Hit = 0,
            PublishDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            Description = desc,
            Kupca = false,
            RoomNumber = roomNumInt,
            Category = "Villa"

        };
        services.AddProduct(newProduct);
        goto back;
        break;
    case 4:
        Console.WriteLine("Id: ");
        var productId= Console.ReadLine();
        int productIdInt = Convert.ToInt32(productId);
        services.RemoveProduct( productIdInt);
        Console.WriteLine("Mehsul silindi");
        goto back;
        break;
    case 5:
        Console.WriteLine("Id: ");
        var updateID = Console.ReadLine();
        int updateIDInt = Convert.ToInt32(updateID);
        Console.WriteLine("Descriptionu daxil edin: ");
        var description = Console.ReadLine();  
        services.UpdatedProduct(updateIDInt , description );
        goto back;
        break;
}