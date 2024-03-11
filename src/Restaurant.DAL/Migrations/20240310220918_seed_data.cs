using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zhukova Avenue, 16, Apt. 28", "Ekaterina", "+375250530304", 47 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Street, 8, Apt. 17", "Viktor", "+375448597049", 29 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kosmonavtov Street, 13, Apt. 17", "Andrei", "+375297413659", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 9, Apt. 64", "+375333425766", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 6, Apt. 86", "Yulia", "+375442307016", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 1, Apt. 96", "Sergey", "+375292998997", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 24, Apt. 49", "Tatyana", "+375296922323", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 10, Apt. 17", "Alexei", "+375256671239", 27 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Avenue, 8, Apt. 74", "Vladimir", "+375445450977", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 8, Apt. 24", "Natalia", "+375253435476", 49 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Mira Avenue, 7, Apt. 85", "+375442845346", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Karl Marx Street, 4, Apt. 54", "+375449758627", 9 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 12, Apt. 60", "Maria", "+375251742994", 13 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Avenue, 17, Apt. 78", "Ekaterina", "+375339380645", 41 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 13, Apt. 32", "Daria", "+375338543446", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Street, 19, Apt. 28", "Anastasia", "+375293693433", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 3, Apt. 87", "Elena", "+375298357477", 43 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 16, Apt. 40", "Konstantin", "+375332655981", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 3, Apt. 64", "Nikolai", "+375253400378", 47 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kosmonavtov Street, 10, Apt. 72", "Yaroslav", "+375299758503", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Square, 20, Apt. 94", "Roman", "+375333430283", 10 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 3, Apt. 91", "Yaroslav", "+375252347071", 13 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Avenue, 9, Apt. 67", "Elena", "+375336724277", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 13, Apt. 52", "Valentina", "+375255283745", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 20, Apt. 39", "Vadim", "+375297202816", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Street, 12, Apt. 38", "Oleg", "+375334095182", 16 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 21, Apt. 32", "Viktor", "+375336283208", 33 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 2, Apt. 78", "Anna", "+375440603441", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 23, Apt. 57", "Sergei", "+375290423285", 14 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Square, 10, Apt. 4", "Yaroslav", "+375256378933", 21 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Avenue, 14, Apt. 55", "Marina", "+375253342839", 41 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 16, Apt. 67", "Dmitry", "+375442600689", 10 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 3, Apt. 44", "Elena", "+375444184344", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Avenue, 9, Apt. 93", "Marina", "+375443899292", 5 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 7, Apt. 97", "Tatyana", "+375296599100", 13 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 23, Apt. 62", "Marina", "+375294790369", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Square, 3, Apt. 75", "Daria", "+375333577859", 14 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 22, Apt. 60", "Oleg", "+375337548958", 6 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Zhukova Avenue, 2, Apt. 47", "+375291626636", 13 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Avenue, 19, Apt. 86", "Olga", "+375297604246", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 9, Apt. 30", "Tatyana", "+375446371119", 40 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 10, Apt. 25", "Natalia", "+375294746616", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Street, 10, Apt. 61", "Sergei", "+375292086672", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 2, Apt. 97", "Marina", "+375448554288", 17 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Street, 23, Apt. 43", "Ekaterina", "+375293953180", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 3, Apt. 42", "Natalya", "+375336020575", 33 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Street, 3, Apt. 44", "Anna", "+375447003770", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Street, 13, Apt. 7", "Maria", "+375290586642", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Suvorova Street, 24, Apt. 75", "Elena", "+375442398072", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 10, Apt. 2", "Daria", "+375330431089", 41 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Curry", 15.98, 325.46699999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Curry", 20.300000000000001, 477.19299999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Cocktail", 14.68, 455.64600000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lobster Bisque", 16.210000000000001, 260.45600000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "BBQ Ribs", 24.260000000000002, 459.15699999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pho", 20.890000000000001, 224.006 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "French Onion Soup", 21.800000000000001, 305.166 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "BBQ Ribs", 19.359999999999999, 137.69 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Grilled Salmon", 22.969999999999999, 252.22 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Curry", 18.93, 164.20599999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fish and Chips", 22.530000000000001, 157.56700000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pulled Pork Sandwich", 22.699999999999999, 118.486 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Tacos", 17.449999999999999, 182.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Spaghetti Carbonara", 7.2599999999999998, 441.81200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Stroganoff", 24.02, 317.74200000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Tacos", 14.279999999999999, 498.56 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Spaghetti Carbonara", 5.2699999999999996, 328.86900000000003 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 21.41, 498.721 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Spaghetti Carbonara", 14.26, 286.88299999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Caprese Salad", 19.309999999999999, 247.35599999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Eggplant Parmesan", 14.43, 457.34800000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Grilled Salmon", 17.510000000000002, 332.89400000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 6.25, 294.11599999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Steak Frites", 13.67, 139.25399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fried Chicken", 8.1899999999999995, 414.53699999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Scampi", 9.5299999999999994, 303.94200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 22.59, 454.09500000000003 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Sushi", 12.33, 236.41300000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shepherd's Pie", 14.699999999999999, 492.16399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pulled Pork Sandwich", 15.77, 294.27199999999999 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 6, new DateTime(2024, 2, 29, 2, 25, 36, 698, DateTimeKind.Unspecified).AddTicks(7453), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 40, 16, new DateTime(2024, 3, 2, 19, 51, 9, 134, DateTimeKind.Unspecified).AddTicks(2178), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 7, 11, new DateTime(2024, 2, 22, 21, 11, 22, 844, DateTimeKind.Unspecified).AddTicks(2616), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 18, new DateTime(2024, 2, 21, 2, 53, 13, 9, DateTimeKind.Unspecified).AddTicks(185), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "ClientId", "OrderDate", "PaymentType" },
                values: new object[] { 9, new DateTime(2024, 2, 15, 20, 7, 38, 652, DateTimeKind.Unspecified).AddTicks(6777), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 35, 10, new DateTime(2024, 2, 15, 8, 36, 28, 733, DateTimeKind.Unspecified).AddTicks(8582), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 48, 5, new DateTime(2024, 3, 9, 10, 20, 45, 641, DateTimeKind.Unspecified).AddTicks(2602), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 39, 16, new DateTime(2024, 2, 15, 10, 18, 10, 984, DateTimeKind.Unspecified).AddTicks(3123), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 32, 16, new DateTime(2024, 2, 15, 16, 36, 24, 829, DateTimeKind.Unspecified).AddTicks(1359), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 47, 10, new DateTime(2024, 3, 4, 20, 20, 10, 775, DateTimeKind.Unspecified).AddTicks(9548), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 35, 17, new DateTime(2024, 2, 18, 17, 54, 48, 963, DateTimeKind.Unspecified).AddTicks(4993), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 34, 18, new DateTime(2024, 3, 7, 0, 57, 50, 214, DateTimeKind.Unspecified).AddTicks(9688), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 25, 9, new DateTime(2024, 3, 6, 20, 49, 37, 824, DateTimeKind.Unspecified).AddTicks(7626), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 5, 5, new DateTime(2024, 3, 10, 22, 52, 29, 859, DateTimeKind.Unspecified).AddTicks(9151), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 45, 3, new DateTime(2024, 3, 1, 14, 30, 58, 403, DateTimeKind.Unspecified).AddTicks(4081), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 45, 12, new DateTime(2024, 2, 26, 7, 56, 42, 313, DateTimeKind.Unspecified).AddTicks(960), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 17, 5, new DateTime(2024, 2, 29, 10, 16, 30, 347, DateTimeKind.Unspecified).AddTicks(6151), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 24, 10, new DateTime(2024, 2, 21, 4, 43, 37, 209, DateTimeKind.Unspecified).AddTicks(1176), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, 3, new DateTime(2024, 2, 15, 18, 2, 23, 131, DateTimeKind.Unspecified).AddTicks(476), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 32, 3, new DateTime(2024, 3, 9, 20, 33, 1, 211, DateTimeKind.Unspecified).AddTicks(5814), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 3, 17, new DateTime(2024, 2, 27, 14, 38, 44, 764, DateTimeKind.Unspecified).AddTicks(5518), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 6, 9, new DateTime(2024, 2, 23, 23, 47, 54, 934, DateTimeKind.Unspecified).AddTicks(2564), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 19, new DateTime(2024, 3, 4, 19, 43, 47, 380, DateTimeKind.Unspecified).AddTicks(2159), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 45, 7, new DateTime(2024, 2, 21, 0, 43, 28, 919, DateTimeKind.Unspecified).AddTicks(5720), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 16, 15, new DateTime(2024, 2, 20, 21, 52, 8, 365, DateTimeKind.Unspecified).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 18, 3, new DateTime(2024, 2, 26, 0, 39, 3, 431, DateTimeKind.Unspecified).AddTicks(8185), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 22, 1, new DateTime(2024, 3, 9, 12, 41, 13, 124, DateTimeKind.Unspecified).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 28, 6, new DateTime(2024, 3, 10, 15, 26, 39, 894, DateTimeKind.Unspecified).AddTicks(8346), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 45, 17, new DateTime(2024, 3, 10, 13, 39, 23, 139, DateTimeKind.Unspecified).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 42, 13, new DateTime(2024, 3, 2, 3, 40, 51, 346, DateTimeKind.Unspecified).AddTicks(5292), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 22, 9, new DateTime(2024, 2, 24, 12, 15, 13, 578, DateTimeKind.Unspecified).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 39, 4, new DateTime(2024, 2, 20, 15, 46, 58, 676, DateTimeKind.Unspecified).AddTicks(6749), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 15, 1, new DateTime(2024, 2, 24, 7, 2, 10, 42, DateTimeKind.Unspecified).AddTicks(9), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 3, 16, new DateTime(2024, 2, 22, 3, 30, 22, 254, DateTimeKind.Unspecified).AddTicks(7095), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 44, 14, new DateTime(2024, 3, 1, 17, 46, 33, 335, DateTimeKind.Unspecified).AddTicks(4342), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 8, 17, new DateTime(2024, 3, 2, 1, 9, 53, 23, DateTimeKind.Unspecified).AddTicks(3638), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 7, 13, new DateTime(2024, 3, 5, 21, 32, 22, 230, DateTimeKind.Unspecified).AddTicks(628), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 29, 12, new DateTime(2024, 3, 9, 15, 53, 49, 145, DateTimeKind.Unspecified).AddTicks(8671), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 6, 4, new DateTime(2024, 2, 26, 7, 25, 16, 308, DateTimeKind.Unspecified).AddTicks(31), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 9, 18, new DateTime(2024, 2, 17, 23, 25, 28, 367, DateTimeKind.Unspecified).AddTicks(2362), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 36, 13, new DateTime(2024, 3, 9, 6, 9, 54, 761, DateTimeKind.Unspecified).AddTicks(9381), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, 8, new DateTime(2024, 3, 1, 15, 18, 8, 783, DateTimeKind.Unspecified).AddTicks(9514), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 13, 3, new DateTime(2024, 2, 28, 19, 12, 55, 476, DateTimeKind.Unspecified).AddTicks(9984), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 1, new DateTime(2024, 2, 26, 2, 1, 54, 788, DateTimeKind.Unspecified).AddTicks(8988), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, 11, new DateTime(2024, 2, 19, 3, 50, 15, 189, DateTimeKind.Unspecified).AddTicks(9353), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 12, 14, new DateTime(2024, 2, 17, 0, 14, 30, 582, DateTimeKind.Unspecified).AddTicks(1054), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, 6, new DateTime(2024, 2, 29, 11, 0, 18, 126, DateTimeKind.Unspecified).AddTicks(4885), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48,
                columns: new[] { "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 3, 10, 20, 45, 14, 615, DateTimeKind.Unspecified).AddTicks(2195), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 6, 17, new DateTime(2024, 2, 16, 9, 50, 17, 8, DateTimeKind.Unspecified).AddTicks(4717), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 48, 4, new DateTime(2024, 3, 7, 14, 42, 3, 481, DateTimeKind.Unspecified).AddTicks(5265), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 2, 8, new DateTime(2024, 2, 26, 5, 0, 3, 139, DateTimeKind.Unspecified).AddTicks(4580), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 24, 4, new DateTime(2024, 2, 24, 18, 18, 2, 720, DateTimeKind.Unspecified).AddTicks(5627), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 29, 15, new DateTime(2024, 3, 6, 7, 36, 31, 281, DateTimeKind.Unspecified).AddTicks(5287), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 11, 19, new DateTime(2024, 2, 23, 8, 11, 22, 213, DateTimeKind.Unspecified).AddTicks(1592), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, 19, new DateTime(2024, 3, 10, 9, 40, 12, 852, DateTimeKind.Unspecified).AddTicks(5765), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 16, new DateTime(2024, 3, 9, 5, 26, 55, 593, DateTimeKind.Unspecified).AddTicks(3702), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, new DateTime(2024, 3, 2, 15, 54, 41, 341, DateTimeKind.Unspecified).AddTicks(9537), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 45, 7, new DateTime(2024, 3, 1, 16, 36, 27, 874, DateTimeKind.Unspecified).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 13, new DateTime(2024, 2, 21, 17, 38, 21, 466, DateTimeKind.Unspecified).AddTicks(3264), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 32, 1, new DateTime(2024, 2, 16, 7, 27, 1, 604, DateTimeKind.Unspecified).AddTicks(6161), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 13, new DateTime(2024, 3, 10, 19, 45, 24, 4, DateTimeKind.Unspecified).AddTicks(2261), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 41, 14, new DateTime(2024, 3, 2, 1, 27, 10, 60, DateTimeKind.Unspecified).AddTicks(4191), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 7, new DateTime(2024, 3, 3, 13, 49, 22, 334, DateTimeKind.Unspecified).AddTicks(2691), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 44, 4, new DateTime(2024, 3, 7, 2, 45, 48, 951, DateTimeKind.Unspecified).AddTicks(5279), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 22, 19, new DateTime(2024, 2, 20, 1, 42, 17, 387, DateTimeKind.Unspecified).AddTicks(3843), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 19, new DateTime(2024, 3, 7, 23, 58, 2, 252, DateTimeKind.Unspecified).AddTicks(5246), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 7, 14, new DateTime(2024, 2, 16, 9, 57, 47, 966, DateTimeKind.Unspecified).AddTicks(6419), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 30, 4, new DateTime(2024, 2, 15, 19, 50, 34, 993, DateTimeKind.Unspecified).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 8, 13, new DateTime(2024, 3, 3, 8, 34, 19, 709, DateTimeKind.Unspecified).AddTicks(9154), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 3, new DateTime(2024, 2, 17, 6, 42, 54, 568, DateTimeKind.Unspecified).AddTicks(4358), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 48, 1, new DateTime(2024, 2, 15, 19, 18, 53, 521, DateTimeKind.Unspecified).AddTicks(6378), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 3, 4, 8, 8, 40, 184, DateTimeKind.Unspecified).AddTicks(8439), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73,
                columns: new[] { "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 3, 3, 10, 37, 35, 501, DateTimeKind.Unspecified).AddTicks(4215), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 39, 3, new DateTime(2024, 3, 3, 18, 25, 15, 738, DateTimeKind.Unspecified).AddTicks(6408), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 2, 18, new DateTime(2024, 2, 16, 9, 10, 59, 243, DateTimeKind.Unspecified).AddTicks(1511), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 8, 4, new DateTime(2024, 2, 22, 2, 49, 28, 990, DateTimeKind.Unspecified).AddTicks(1590), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 21, 18, new DateTime(2024, 2, 25, 9, 59, 16, 148, DateTimeKind.Unspecified).AddTicks(9283), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 37, 2, new DateTime(2024, 2, 27, 15, 35, 7, 133, DateTimeKind.Unspecified).AddTicks(5078), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 35, 12, new DateTime(2024, 2, 16, 15, 1, 57, 233, DateTimeKind.Unspecified).AddTicks(9795), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 28, new DateTime(2024, 3, 6, 12, 26, 21, 697, DateTimeKind.Unspecified).AddTicks(6418), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 22, 15, new DateTime(2024, 3, 7, 14, 23, 8, 436, DateTimeKind.Unspecified).AddTicks(3250), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 23, 12, new DateTime(2024, 2, 15, 3, 16, 49, 304, DateTimeKind.Unspecified).AddTicks(5947), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 49, 2, new DateTime(2024, 2, 16, 9, 10, 19, 546, DateTimeKind.Unspecified).AddTicks(3884), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 17, 12, new DateTime(2024, 2, 28, 19, 51, 24, 978, DateTimeKind.Unspecified).AddTicks(3362), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 33, 18, new DateTime(2024, 2, 21, 1, 5, 14, 600, DateTimeKind.Unspecified).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 12, 7, new DateTime(2024, 2, 23, 10, 0, 28, 642, DateTimeKind.Unspecified).AddTicks(1898), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 30, 19, new DateTime(2024, 2, 17, 23, 20, 35, 212, DateTimeKind.Unspecified).AddTicks(6679), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 49, 1, new DateTime(2024, 2, 20, 13, 45, 44, 227, DateTimeKind.Unspecified).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 47, 17, new DateTime(2024, 3, 2, 14, 52, 40, 120, DateTimeKind.Unspecified).AddTicks(3694), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 33, 1, new DateTime(2024, 2, 28, 16, 58, 6, 126, DateTimeKind.Unspecified).AddTicks(491), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 26, 7, new DateTime(2024, 2, 16, 23, 54, 52, 958, DateTimeKind.Unspecified).AddTicks(1727), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 25, 18, new DateTime(2024, 3, 10, 9, 20, 15, 910, DateTimeKind.Unspecified).AddTicks(9109), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 16, 16, new DateTime(2024, 3, 6, 12, 33, 29, 699, DateTimeKind.Unspecified).AddTicks(7568), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 30, 9, new DateTime(2024, 2, 20, 4, 57, 18, 640, DateTimeKind.Unspecified).AddTicks(4326), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 2, new DateTime(2024, 2, 28, 2, 4, 29, 300, DateTimeKind.Unspecified).AddTicks(531), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 13, 12, new DateTime(2024, 2, 28, 7, 11, 12, 887, DateTimeKind.Unspecified).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 13, 17, new DateTime(2024, 2, 29, 13, 7, 46, 195, DateTimeKind.Unspecified).AddTicks(8688), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 35, 3, new DateTime(2024, 3, 5, 2, 14, 34, 199, DateTimeKind.Unspecified).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 37, 3, new DateTime(2024, 3, 6, 4, 0, 25, 470, DateTimeKind.Unspecified).AddTicks(7112), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 18, new DateTime(2024, 2, 28, 9, 26, 6, 700, DateTimeKind.Unspecified).AddTicks(4748), 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Avenue, 1, Apt. 83", "Daria", "+375444453963", 4 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Square, 1, Apt. 62", "Sergei", "+375446263821", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Avenue, 24, Apt. 8", "Yaroslav", "+375292834617", 24 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 11, Apt. 83", "+375252548677", 27 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 1, Apt. 77", "Konstantin", "+375256858003", 38 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 20, Apt. 36", "Anna", "+375295634545", 24 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 16, Apt. 68", "Igor", "+375447277846", 20 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Avenue, 19, Apt. 54", "Natalya", "+375338338175", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Stalina Avenue, 23, Apt. 58", "Ivan", "+375334476024", 9 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 3, Apt. 13", "Sergey", "+375330179205", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 3, Apt. 75", "+375251335924", 18 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 14, Apt. 78", "+375297222970", 0 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 2, Apt. 23", "Marina", "+375339613864", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Avenue, 12, Apt. 20", "Elena", "+375299124721", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 14, Apt. 23", "Marina", "+375445867470", 25 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 20, Apt. 4", "Natalia", "+375292919247", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 13, Apt. 12", "Natalya", "+375254024563", 23 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 11, Apt. 89", "Daria", "+375294232075", 49 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Street, 16, Apt. 53", "Valentina", "+375441144737", 24 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 10, Apt. 53", "Yelena", "+375334932736", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kosmonavtov Street, 1, Apt. 21", "Andrei", "+375338528045", 29 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 2, Apt. 31", "Yulia", "+375254205965", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 5, Apt. 76", "Yulia", "+375443091190", 33 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Avenue, 15, Apt. 6", "Daria", "+375443440964", 4 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 23, Apt. 38", "Ivan", "+375448046280", 3 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 3, Apt. 87", "Tatiana", "+375295409178", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 24, Apt. 35", "Roman", "+375251266823", 29 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 17, Apt. 45", "Marina", "+375331667808", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 13, Apt. 34", "Roman", "+375292401697", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 9, Apt. 30", "Yuri", "+375290208113", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 11, Apt. 25", "Sergei", "+375259641550", 6 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Square, 14, Apt. 83", "Anastasia", "+375448021848", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 9, Apt. 45", "Katya", "+375258045171", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 17, Apt. 87", "Anna", "+375330409767", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 19, Apt. 34", "Marina", "+375298419014", 43 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 9, Apt. 3", "Elizaveta", "+375445537663", 4 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Square, 1, Apt. 79", "Nikolai", "+375295184946", 31 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 19, Apt. 37", "Anastasia", "+375299479539", 15 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39,
                columns: new[] { "Address", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 6, Apt. 71", "+375445711809", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zhukova Avenue, 2, Apt. 75", "Katya", "+375444857995", 39 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Square, 11, Apt. 21", "Nikolai", "+375258452695", 0 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 3, Apt. 60", "Konstantin", "+375445725719", 48 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 21, Apt. 89", "Pavel", "+375337763011", 20 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Street, 17, Apt. 68", "Irina", "+375440306634", 29 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 7, Apt. 22", "Igor", "+375443381797", 41 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 13, Apt. 39", "Marina", "+375251698255", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 13, Apt. 18", "Mikhail", "+375335652071", 36 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 7, Apt. 8", "Pavel", "+375337470688", 20 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 5, Apt. 48", "Boris", "+375442814271", 46 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 2, Apt. 75", "Igor", "+375441671027", 6 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Cocktail", 6.5599999999999996, 433.17000000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Parmesan", 5.0800000000000001, 145.11199999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 19.27, 197.41399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "French Onion Soup", 17.170000000000002, 237.715 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Ratatouille", 21.850000000000001, 174.12100000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Clam Chowder", 16.079999999999998, 296.49599999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fish and Chips", 16.649999999999999, 471.48599999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Ratatouille", 22.420000000000002, 482.17599999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pho", 19.359999999999999, 477.863 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 23.91, 367.47800000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Scampi", 12.59, 464.68400000000003 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Tikka Masala", 10.93, 121.52200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 21.530000000000001, 333.774 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Ratatouille", 11.369999999999999, 479.17399999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 6.5800000000000001, 218.726 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 15.69, 337.55900000000003 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Cocktail", 23.850000000000001, 459.31200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Wellington", 24.48, 439.94299999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "French Onion Soup", 14.470000000000001, 429.91399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Crispy Duck", 5.3099999999999996, 279.76999999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Margherita Pizza", 11.529999999999999, 421.82499999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Margherita Pizza", 10.130000000000001, 408.62799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pulled Pork Sandwich", 18.309999999999999, 189.79300000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Curry", 5.1299999999999999, 425.75700000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Clam Chowder", 11.26, 336.99799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Greek Salad", 4.3899999999999997, 198.304 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Spaghetti Carbonara", 18.5, 193.06200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Tikka Masala", 13.029999999999999, 427.62799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Roast Beef", 20.100000000000001, 343.59399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Caprese Salad", 17.149999999999999, 366.78899999999999 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 7, 5, new DateTime(2024, 3, 9, 11, 5, 8, 806, DateTimeKind.Unspecified).AddTicks(7741), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 17, new DateTime(2024, 3, 5, 6, 54, 2, 411, DateTimeKind.Unspecified).AddTicks(3952), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 48, 9, new DateTime(2024, 2, 29, 1, 0, 11, 323, DateTimeKind.Unspecified).AddTicks(1499), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 3, new DateTime(2024, 3, 5, 11, 39, 36, 823, DateTimeKind.Unspecified).AddTicks(8521), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "ClientId", "OrderDate", "PaymentType" },
                values: new object[] { 30, new DateTime(2024, 3, 10, 12, 28, 3, 679, DateTimeKind.Unspecified).AddTicks(2035), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 31, 14, new DateTime(2024, 3, 10, 10, 54, 45, 483, DateTimeKind.Unspecified).AddTicks(8095), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 37, 9, new DateTime(2024, 3, 5, 5, 6, 50, 900, DateTimeKind.Unspecified).AddTicks(7868), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 32, 18, new DateTime(2024, 3, 10, 4, 10, 53, 503, DateTimeKind.Unspecified).AddTicks(3244), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 21, 4, new DateTime(2024, 2, 17, 8, 48, 55, 875, DateTimeKind.Unspecified).AddTicks(4766), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 28, 19, new DateTime(2024, 2, 22, 10, 20, 50, 826, DateTimeKind.Unspecified).AddTicks(4389), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 47, 2, new DateTime(2024, 2, 21, 23, 31, 9, 824, DateTimeKind.Unspecified).AddTicks(1674), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 23, 9, new DateTime(2024, 2, 23, 7, 35, 53, 89, DateTimeKind.Unspecified).AddTicks(6560), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 24, 19, new DateTime(2024, 2, 22, 18, 20, 46, 62, DateTimeKind.Unspecified).AddTicks(3923), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 32, 14, new DateTime(2024, 2, 25, 21, 37, 53, 680, DateTimeKind.Unspecified).AddTicks(501), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 35, 16, new DateTime(2024, 2, 18, 18, 18, 45, 680, DateTimeKind.Unspecified).AddTicks(1188), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 47, 2, new DateTime(2024, 2, 20, 6, 23, 51, 437, DateTimeKind.Unspecified).AddTicks(2678), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 42, 1, new DateTime(2024, 2, 19, 10, 7, 7, 217, DateTimeKind.Unspecified).AddTicks(9378), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 35, 4, new DateTime(2024, 2, 20, 14, 7, 41, 667, DateTimeKind.Unspecified).AddTicks(1860), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 27, 9, new DateTime(2024, 2, 23, 13, 57, 23, 600, DateTimeKind.Unspecified).AddTicks(5283), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 34, 11, new DateTime(2024, 2, 24, 12, 34, 59, 127, DateTimeKind.Unspecified).AddTicks(6140), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 3, new DateTime(2024, 2, 29, 4, 13, 41, 499, DateTimeKind.Unspecified).AddTicks(7427), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 43, 1, new DateTime(2024, 2, 21, 0, 56, 49, 102, DateTimeKind.Unspecified).AddTicks(8813), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 37, 11, new DateTime(2024, 2, 15, 1, 53, 28, 714, DateTimeKind.Unspecified).AddTicks(1734), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 48, 12, new DateTime(2024, 2, 15, 3, 12, 47, 612, DateTimeKind.Unspecified).AddTicks(2999), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 38, 3, new DateTime(2024, 3, 5, 1, 38, 15, 270, DateTimeKind.Unspecified).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 15, new DateTime(2024, 3, 8, 13, 2, 34, 636, DateTimeKind.Unspecified).AddTicks(8262), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 6, 4, new DateTime(2024, 2, 24, 17, 16, 6, 1, DateTimeKind.Unspecified).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 14, 3, new DateTime(2024, 2, 23, 13, 20, 34, 899, DateTimeKind.Unspecified).AddTicks(5133), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 43, 18, new DateTime(2024, 2, 17, 12, 30, 39, 832, DateTimeKind.Unspecified).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 1, 19, new DateTime(2024, 2, 15, 5, 21, 19, 93, DateTimeKind.Unspecified).AddTicks(4194), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 38, 1, new DateTime(2024, 2, 19, 4, 5, 17, 678, DateTimeKind.Unspecified).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 28, 11, new DateTime(2024, 2, 15, 11, 17, 12, 966, DateTimeKind.Unspecified).AddTicks(8862), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 15, new DateTime(2024, 3, 9, 13, 8, 43, 479, DateTimeKind.Unspecified).AddTicks(5070), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 45, 12, new DateTime(2024, 2, 20, 7, 40, 35, 69, DateTimeKind.Unspecified).AddTicks(9547), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 22, 15, new DateTime(2024, 2, 28, 22, 32, 20, 608, DateTimeKind.Unspecified).AddTicks(1106), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 39, 7, new DateTime(2024, 3, 2, 18, 40, 44, 918, DateTimeKind.Unspecified).AddTicks(2804), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 1, 19, new DateTime(2024, 2, 23, 2, 33, 36, 559, DateTimeKind.Unspecified).AddTicks(4891), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 18, 13, new DateTime(2024, 2, 25, 1, 17, 56, 577, DateTimeKind.Unspecified).AddTicks(2177), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 22, 12, new DateTime(2024, 2, 16, 1, 46, 35, 515, DateTimeKind.Unspecified).AddTicks(26), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, 14, new DateTime(2024, 2, 28, 20, 9, 48, 118, DateTimeKind.Unspecified).AddTicks(7708), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 49, 1, new DateTime(2024, 2, 16, 11, 14, 7, 330, DateTimeKind.Unspecified).AddTicks(2794), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 39, 6, new DateTime(2024, 3, 3, 13, 3, 44, 978, DateTimeKind.Unspecified).AddTicks(4237), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 22, 10, new DateTime(2024, 2, 25, 23, 35, 22, 254, DateTimeKind.Unspecified).AddTicks(7600), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 26, 17, new DateTime(2024, 2, 16, 0, 17, 17, 760, DateTimeKind.Unspecified).AddTicks(4771), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 26, 4, new DateTime(2024, 3, 5, 15, 54, 47, 190, DateTimeKind.Unspecified).AddTicks(2553), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 1, 13, new DateTime(2024, 3, 8, 17, 24, 47, 554, DateTimeKind.Unspecified).AddTicks(4640), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 18, 3, new DateTime(2024, 2, 25, 8, 48, 59, 722, DateTimeKind.Unspecified).AddTicks(75), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48,
                columns: new[] { "DishId", "OrderDate", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 2, 25, 22, 10, 6, 510, DateTimeKind.Unspecified).AddTicks(8560), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 35, 18, new DateTime(2024, 2, 20, 2, 21, 38, 226, DateTimeKind.Unspecified).AddTicks(917), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 31, 19, new DateTime(2024, 3, 10, 5, 6, 27, 799, DateTimeKind.Unspecified).AddTicks(6821), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 21, 6, new DateTime(2024, 2, 16, 5, 52, 4, 263, DateTimeKind.Unspecified).AddTicks(9427), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 27, 10, new DateTime(2024, 2, 28, 8, 27, 3, 323, DateTimeKind.Unspecified).AddTicks(2465), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 42, 13, new DateTime(2024, 3, 9, 22, 2, 2, 32, DateTimeKind.Unspecified).AddTicks(9836), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 31, 18, new DateTime(2024, 3, 5, 21, 28, 20, 932, DateTimeKind.Unspecified).AddTicks(3406), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 35, 9, new DateTime(2024, 3, 10, 11, 26, 33, 808, DateTimeKind.Unspecified).AddTicks(428), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 27, 12, new DateTime(2024, 3, 10, 0, 51, 48, 522, DateTimeKind.Unspecified).AddTicks(3188), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 37, new DateTime(2024, 2, 15, 20, 27, 9, 818, DateTimeKind.Unspecified).AddTicks(8260), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 47, 11, new DateTime(2024, 3, 6, 22, 54, 23, 630, DateTimeKind.Unspecified).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 1, 6, new DateTime(2024, 2, 29, 19, 40, 19, 434, DateTimeKind.Unspecified).AddTicks(1478), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 5, 11, new DateTime(2024, 2, 28, 1, 25, 6, 988, DateTimeKind.Unspecified).AddTicks(7729), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 25, 5, new DateTime(2024, 2, 16, 6, 12, 44, 931, DateTimeKind.Unspecified).AddTicks(2307), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 7, 8, new DateTime(2024, 2, 23, 14, 12, 46, 670, DateTimeKind.Unspecified).AddTicks(4206), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 49, 9, new DateTime(2024, 2, 16, 14, 26, 5, 405, DateTimeKind.Unspecified).AddTicks(7691), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 21, 10, new DateTime(2024, 3, 10, 17, 27, 15, 452, DateTimeKind.Unspecified).AddTicks(4801), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 6, 9, new DateTime(2024, 2, 15, 21, 27, 1, 649, DateTimeKind.Unspecified).AddTicks(7027), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 40, 17, new DateTime(2024, 2, 17, 8, 52, 40, 838, DateTimeKind.Unspecified).AddTicks(9428), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 26, 17, new DateTime(2024, 2, 22, 21, 25, 13, 860, DateTimeKind.Unspecified).AddTicks(5260), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 42, 14, new DateTime(2024, 2, 21, 5, 14, 22, 196, DateTimeKind.Unspecified).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 38, 6, new DateTime(2024, 2, 20, 18, 41, 9, 876, DateTimeKind.Unspecified).AddTicks(398), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 8, 19, new DateTime(2024, 2, 21, 3, 40, 28, 955, DateTimeKind.Unspecified).AddTicks(392), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 28, 18, new DateTime(2024, 3, 9, 7, 38, 51, 971, DateTimeKind.Unspecified).AddTicks(8185), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 2, 26, 13, 26, 14, 436, DateTimeKind.Unspecified).AddTicks(9529), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73,
                columns: new[] { "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 9, new DateTime(2024, 2, 29, 7, 40, 5, 286, DateTimeKind.Unspecified).AddTicks(7858), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 27, 4, new DateTime(2024, 2, 24, 11, 48, 35, 920, DateTimeKind.Unspecified).AddTicks(7007), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 23, 1, new DateTime(2024, 2, 16, 15, 38, 17, 750, DateTimeKind.Unspecified).AddTicks(5026), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 12, 11, new DateTime(2024, 3, 9, 14, 5, 24, 477, DateTimeKind.Unspecified).AddTicks(2576), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 19, 19, new DateTime(2024, 3, 7, 23, 25, 55, 623, DateTimeKind.Unspecified).AddTicks(9896), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 7, 19, new DateTime(2024, 2, 17, 17, 37, 40, 985, DateTimeKind.Unspecified).AddTicks(4665), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 30, 1, new DateTime(2024, 2, 17, 15, 57, 58, 53, DateTimeKind.Unspecified).AddTicks(2368), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 27, new DateTime(2024, 3, 10, 6, 4, 54, 900, DateTimeKind.Unspecified).AddTicks(4164), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 4, 10, new DateTime(2024, 3, 9, 2, 52, 44, 151, DateTimeKind.Unspecified).AddTicks(4775), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 33, 3, new DateTime(2024, 3, 3, 0, 37, 57, 528, DateTimeKind.Unspecified).AddTicks(9846), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 15, 12, new DateTime(2024, 3, 2, 12, 57, 16, 84, DateTimeKind.Unspecified).AddTicks(9372), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 33, 2, new DateTime(2024, 3, 9, 13, 39, 8, 526, DateTimeKind.Unspecified).AddTicks(5784), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 45, 3, new DateTime(2024, 3, 7, 15, 29, 12, 134, DateTimeKind.Unspecified).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 41, 19, new DateTime(2024, 2, 21, 5, 38, 4, 860, DateTimeKind.Unspecified).AddTicks(5200), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 22, 9, new DateTime(2024, 2, 16, 22, 26, 5, 241, DateTimeKind.Unspecified).AddTicks(1496), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 15, 4, new DateTime(2024, 2, 29, 8, 55, 3, 742, DateTimeKind.Unspecified).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 40, 11, new DateTime(2024, 2, 26, 2, 25, 25, 838, DateTimeKind.Unspecified).AddTicks(8506), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 10, 9, new DateTime(2024, 3, 4, 19, 1, 22, 248, DateTimeKind.Unspecified).AddTicks(2805), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 24, 12, new DateTime(2024, 3, 10, 23, 14, 1, 720, DateTimeKind.Unspecified).AddTicks(1721), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 4, 8, new DateTime(2024, 3, 2, 22, 1, 11, 633, DateTimeKind.Unspecified).AddTicks(7481), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 40, 7, new DateTime(2024, 2, 20, 20, 38, 47, 895, DateTimeKind.Unspecified).AddTicks(9639), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 41, 5, new DateTime(2024, 2, 27, 0, 41, 46, 186, DateTimeKind.Unspecified).AddTicks(7260), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 47, 11, new DateTime(2024, 3, 1, 15, 28, 19, 455, DateTimeKind.Unspecified).AddTicks(3689), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 18, 4, new DateTime(2024, 2, 29, 4, 1, 14, 978, DateTimeKind.Unspecified).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 29, 14, new DateTime(2024, 3, 6, 6, 35, 28, 282, DateTimeKind.Unspecified).AddTicks(5085), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 21, 1, new DateTime(2024, 3, 10, 14, 40, 19, 265, DateTimeKind.Unspecified).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 21, 7, new DateTime(2024, 2, 24, 21, 13, 14, 244, DateTimeKind.Unspecified).AddTicks(114), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 36, 9, new DateTime(2024, 3, 9, 5, 0, 31, 614, DateTimeKind.Unspecified).AddTicks(3009), 1 });
        }
    }
}
