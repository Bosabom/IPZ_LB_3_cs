using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using IPZ_Proj.Service;
using MySql.Data.MySqlClient;

namespace IPZ_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuctionCarService auctionCarService = new AuctionCarService();
            IAuctionLotService auctionLotService = new AuctionLotService();
            IAuctionPhotoService auctionPhotoService = new AuctionPhotoService();
            ICarService carService = new CarService();
            ICarOwnerService carOwnerService = new CarOwnerService();
            IPhotosService photosService = new PhotosService();
            IUsersCarService usersCarService = new UsersCarService();
            IUsersPhotosService usersPhotosService = new UsersPhotosService();

            IOrderService orderService = new OrderService();
            IUserService userService = new UserService();

            Console.WriteLine("==== Auction cars ====\n");

            foreach (var item in auctionCarService.GetCars())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Auction lots ====\n");

            foreach (var item in auctionLotService.GetLots())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Auction photos ====\n");

            foreach (var item in auctionPhotoService.GetPhotos())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Cars ====\n");

            foreach (var item in carService.GetCars())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Car owners ====\n");

            foreach (var item in carOwnerService.GetCarOwners())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Photos ====\n");

            foreach (var item in photosService.GetPhotos())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Users cars ====\n");

            foreach (var item in usersCarService.GetUsersCars())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Users photos ====\n");

            foreach (var item in usersPhotosService.GetUsersPhotos())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Orders ====\n");

            foreach (var item in orderService.GetOrders())
            {
                Console.WriteLine(item + "\n");
            }

            Console.WriteLine();

            Console.WriteLine("==== Users ====\n");

            foreach (var item in userService.GetUsers())
            {
                Console.WriteLine(item + "\n");
            }
        }
    }
}
