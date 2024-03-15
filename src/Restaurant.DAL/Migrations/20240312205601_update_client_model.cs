using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.DAL.Migrations
{
    /// <inheritdoc />
    public partial class update_client_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Clients",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 9, Apt. 40", null, "Yelena", null, "+375334308346", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 10, Apt. 18", null, "Yaroslav", null, "+375444159332", 23 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Street, 8, Apt. 22", null, "Maria", null, "+375250323740", 46 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 14, Apt. 64", null, "Boris", null, "+375298436710", 39 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Kirova Avenue, 8, Apt. 10", null, "Yulia", null, "+375449039393", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gagarina Square, 12, Apt. 43", null, "Yulia", null, "+375292352363", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Mira Avenue, 6, Apt. 59", null, "Boris", null, "+375444608934", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 17, Apt. 62", null, "Vladimir", null, "+375334159681", 21 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 24, Apt. 89", null, "Viktor", null, "+375330099087", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 14, Apt. 23", null, "Vladimir", null, "+375256943260", 40 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 5, Apt. 16", null, "Anna", null, "+375251401250", 40 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 17, Apt. 94", null, "Ekaterina", null, "+375297578671", 33 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Kosmonavtov Street, 18, Apt. 46", null, "Andrei", null, "+375252979646", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Street, 9, Apt. 76", null, "Oleg", null, "+375253635595", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 4, Apt. 65", null, "Alexei", null, "+375442097974", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 11, Apt. 13", null, "Anna", null, "+375444375560", 5 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Stalina Avenue, 8, Apt. 65", null, "Svetlana", null, "+375335674406", 10 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 7, Apt. 79", null, "Valentina", null, "+375290167716", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Kirova Avenue, 14, Apt. 84", null, "Sergei", null, "+375445398289", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 22, Apt. 77", null, "Ekaterina", null, "+375338080444", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Square, 2, Apt. 6", null, "Sergey", null, "+375290336268", 6 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 20, Apt. 11", null, "Valentina", null, "+375252588342", 10 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 8, Apt. 82", null, "Ekaterina", null, "+375296466023", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Karl Marx Street, 10, Apt. 35", null, "Natalya", null, "+375299978792", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 13, Apt. 36", null, "Elena", null, "+375256885912", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Komsomolskaya Street, 7, Apt. 16", null, "Nikolai", null, "+375336373350", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 15, Apt. 46", null, "Tatiana", null, "+375254564679", 45 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Pushkina Square, 11, Apt. 88", null, "Sergey", null, "+375290064889", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 15, Apt. 83", null, "Dmitry", null, "+375447480992", 10 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 20, Apt. 65", null, "Pavel", null, "+375250095531", 27 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 19, Apt. 32", null, "Marina", null, "+375257221273", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone" },
                values: new object[] { "Lenina Square, 13, Apt. 79", null, "Tatyana", null, "+375339246213" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 11, Apt. 40", null, "Konstantin", null, "+375441466522", 40 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 8, Apt. 58", null, "Vadim", null, "+375447535018", 14 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 12, Apt. 96", null, "Natalya", null, "+375442617083", 12 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 13, Apt. 16", null, "Yulia", null, "+375293103312", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Pushkina Street, 6, Apt. 89", null, "Yuri", null, "+375448718104", 14 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 19, Apt. 36", null, "Olga", null, "+375259898320", 6 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Square, 2, Apt. 75", null, "Igor", null, "+375335941293", 49 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Kirova Street, 21, Apt. 96", null, "Ekaterina", null, "+375258759090", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Mira Street, 8, Apt. 50", null, "Katya", null, "+375441372520", 37 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Stalina Avenue, 5, Apt. 7", null, "Yaroslav", null, "+375445151581", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 12, Apt. 98", null, "Andrei", null, "+375334567033", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 12, Apt. 77", null, "Igor", null, "+375252017630", 46 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 21, Apt. 61", null, "Daria", null, "+375445992375", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 2, Apt. 73", null, "Ivan", null, "+375441687155", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 9, Apt. 10", null, "Daria", null, "+375291684676", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Karl Marx Street, 16, Apt. 46", null, "Konstantin", null, "+375290908235", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 20, Apt. 80", null, "Anna", null, "+375448207424", 43 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50,
                columns: new[] { "Address", "Email", "Name", "Password", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Street, 24, Apt. 1", null, "Anna", null, "+375445768320", 21 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 17.77, 107.246 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Tuna Salad", 14.619999999999999, 428.05799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Parmesan", 14.73, 207.215 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lobster Bisque", 20.07, 255.93799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Caesar Salad", 17.93, 357.24200000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "French Onion Soup", 6.5499999999999998, 124.13200000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Wellington", 5.3899999999999997, 323.745 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pad Thai", 8.8100000000000005, 396.20299999999997 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Vegetable Stir-Fry", 15.039999999999999, 418.255 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 4.0800000000000001, 456.66300000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 6.1299999999999999, 294.95600000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Tacos", 5.5800000000000001, 258.12900000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fried Chicken", 5.4000000000000004, 178.99299999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Alfredo", 8.0800000000000001, 391.55700000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Greek Salad", 24.039999999999999, 420.24799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Greek Salad", 8.8699999999999992, 180.67699999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Spaghetti Carbonara", 10.390000000000001, 456.76499999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pulled Pork Sandwich", 23.91, 230.535 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 7.5599999999999996, 195.69399999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Sushi", 15.74, 426.166 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Sushi", 6.96, 268.70800000000003 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Clam Chowder", 10.51, 318.49099999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lobster Bisque", 20.809999999999999, 170.39099999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Caesar Salad", 10.390000000000001, 146.65000000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Tuna Salad", 3.0099999999999998, 419.33100000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Scampi", 21.75, 426.89600000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Mushroom Risotto", 9.0500000000000007, 266.286 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fish and Chips", 11.17, 114.93300000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Crispy Duck", 5.46, 112.339 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Stroganoff", 24.84, 498.62599999999998 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 6, 10, new DateTime(2024, 3, 5, 13, 9, 58, 851, DateTimeKind.Unspecified).AddTicks(1691), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 41, 4, new DateTime(2024, 3, 11, 21, 40, 1, 517, DateTimeKind.Unspecified).AddTicks(4688), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 46, 18, new DateTime(2024, 2, 15, 17, 27, 28, 339, DateTimeKind.Unspecified).AddTicks(8063), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 42, 15, new DateTime(2024, 3, 1, 14, 37, 5, 322, DateTimeKind.Unspecified).AddTicks(3115), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 10, 14, new DateTime(2024, 3, 2, 14, 53, 42, 84, DateTimeKind.Unspecified).AddTicks(7263), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 1, 7, new DateTime(2024, 2, 26, 2, 7, 17, 575, DateTimeKind.Unspecified).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 19, 9, new DateTime(2024, 2, 21, 5, 11, 59, 27, DateTimeKind.Unspecified).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 48, 11, new DateTime(2024, 3, 5, 5, 2, 35, 423, DateTimeKind.Unspecified).AddTicks(384), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 28, 6, new DateTime(2024, 2, 22, 16, 34, 56, 278, DateTimeKind.Unspecified).AddTicks(3488), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 33, 6, new DateTime(2024, 3, 3, 1, 15, 48, 26, DateTimeKind.Unspecified).AddTicks(7096), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 25, new DateTime(2024, 3, 7, 9, 57, 5, 348, DateTimeKind.Unspecified).AddTicks(9223), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 23, 9, new DateTime(2024, 2, 17, 22, 57, 17, 648, DateTimeKind.Unspecified).AddTicks(7508), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 46, 18, new DateTime(2024, 3, 8, 1, 36, 58, 343, DateTimeKind.Unspecified).AddTicks(5620), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 15, 12, new DateTime(2024, 3, 2, 19, 0, 13, 891, DateTimeKind.Unspecified).AddTicks(1363), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                columns: new[] { "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 3, 7, 18, 10, 1, 753, DateTimeKind.Unspecified).AddTicks(1759), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 1, 13, new DateTime(2024, 3, 12, 21, 41, 0, 984, DateTimeKind.Unspecified).AddTicks(4468), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 46, 5, new DateTime(2024, 2, 25, 2, 58, 37, 197, DateTimeKind.Unspecified).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 20, 18, new DateTime(2024, 3, 9, 12, 4, 8, 861, DateTimeKind.Unspecified).AddTicks(5307), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 19, 1, new DateTime(2024, 3, 8, 20, 19, 55, 356, DateTimeKind.Unspecified).AddTicks(4469), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 4, 8, new DateTime(2024, 3, 6, 17, 4, 58, 318, DateTimeKind.Unspecified).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 28, new DateTime(2024, 3, 11, 1, 40, 49, 982, DateTimeKind.Unspecified).AddTicks(7999), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 2, 2, new DateTime(2024, 3, 3, 7, 13, 44, 134, DateTimeKind.Unspecified).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 16, 7, new DateTime(2024, 2, 25, 16, 11, 56, 646, DateTimeKind.Unspecified).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 29, 1, new DateTime(2024, 2, 26, 22, 45, 12, 836, DateTimeKind.Unspecified).AddTicks(5000), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 27, 14, new DateTime(2024, 2, 16, 21, 29, 55, 123, DateTimeKind.Unspecified).AddTicks(801), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 1, new DateTime(2024, 2, 29, 2, 48, 31, 954, DateTimeKind.Unspecified).AddTicks(4428), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 36, 13, new DateTime(2024, 2, 24, 18, 50, 45, 787, DateTimeKind.Unspecified).AddTicks(4448), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 10, 1, new DateTime(2024, 3, 5, 22, 7, 32, 452, DateTimeKind.Unspecified).AddTicks(343), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 7, 7, new DateTime(2024, 2, 29, 3, 13, 8, 839, DateTimeKind.Unspecified).AddTicks(4878), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 21, 14, new DateTime(2024, 2, 24, 1, 35, 33, 443, DateTimeKind.Unspecified).AddTicks(7782), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 11, new DateTime(2024, 2, 20, 17, 38, 54, 349, DateTimeKind.Unspecified).AddTicks(6961), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 26, 7, new DateTime(2024, 2, 28, 3, 30, 24, 819, DateTimeKind.Unspecified).AddTicks(7593), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 5, new DateTime(2024, 2, 26, 11, 20, 0, 446, DateTimeKind.Unspecified).AddTicks(4066), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                columns: new[] { "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 3, new DateTime(2024, 2, 21, 10, 49, 53, 862, DateTimeKind.Unspecified).AddTicks(7589), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 3, 14, new DateTime(2024, 2, 20, 8, 44, 7, 164, DateTimeKind.Unspecified).AddTicks(9113), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 17, 3, new DateTime(2024, 2, 29, 3, 57, 48, 71, DateTimeKind.Unspecified).AddTicks(5648), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 25, 2, new DateTime(2024, 3, 4, 0, 35, 20, 823, DateTimeKind.Unspecified).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 45, 5, new DateTime(2024, 3, 1, 15, 33, 40, 120, DateTimeKind.Unspecified).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 29, 4, new DateTime(2024, 2, 28, 20, 59, 4, 739, DateTimeKind.Unspecified).AddTicks(3495), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 29, 14, new DateTime(2024, 2, 22, 22, 22, 59, 121, DateTimeKind.Unspecified).AddTicks(3972), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 17, 8, new DateTime(2024, 2, 29, 18, 33, 20, 759, DateTimeKind.Unspecified).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 29, 8, new DateTime(2024, 2, 18, 1, 42, 20, 479, DateTimeKind.Unspecified).AddTicks(9655), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 15, 2, new DateTime(2024, 2, 20, 3, 35, 43, 136, DateTimeKind.Unspecified).AddTicks(2957), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 43, 8, new DateTime(2024, 3, 12, 23, 16, 29, 888, DateTimeKind.Unspecified).AddTicks(3652), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 30, 13, new DateTime(2024, 2, 22, 16, 39, 15, 959, DateTimeKind.Unspecified).AddTicks(9113), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 46, 3, new DateTime(2024, 2, 22, 5, 31, 51, 637, DateTimeKind.Unspecified).AddTicks(720), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 18, 6, new DateTime(2024, 3, 8, 23, 22, 10, 175, DateTimeKind.Unspecified).AddTicks(5646), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 30, 16, new DateTime(2024, 2, 17, 0, 13, 59, 794, DateTimeKind.Unspecified).AddTicks(2320), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 1, 2, new DateTime(2024, 3, 11, 12, 24, 38, 774, DateTimeKind.Unspecified).AddTicks(8230), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 33, 17, new DateTime(2024, 2, 22, 10, 34, 11, 115, DateTimeKind.Unspecified).AddTicks(9740), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 24, 18, new DateTime(2024, 2, 15, 22, 43, 44, 667, DateTimeKind.Unspecified).AddTicks(7463), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 5, new DateTime(2024, 2, 26, 23, 40, 31, 724, DateTimeKind.Unspecified).AddTicks(8658), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 25, 12, new DateTime(2024, 2, 26, 23, 16, 20, 812, DateTimeKind.Unspecified).AddTicks(5276), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 4, new DateTime(2024, 2, 25, 16, 41, 8, 258, DateTimeKind.Unspecified).AddTicks(3116), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55,
                columns: new[] { "ClientId", "OrderDate", "Quantity" },
                values: new object[] { 21, new DateTime(2024, 2, 15, 23, 1, 18, 547, DateTimeKind.Unspecified).AddTicks(827), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56,
                columns: new[] { "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { new DateTime(2024, 2, 28, 14, 2, 17, 685, DateTimeKind.Unspecified).AddTicks(9089), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 44, 18, new DateTime(2024, 3, 1, 20, 50, 45, 429, DateTimeKind.Unspecified).AddTicks(940), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 34, 17, new DateTime(2024, 3, 3, 10, 17, 30, 307, DateTimeKind.Unspecified).AddTicks(8736), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 17, 11, new DateTime(2024, 3, 5, 13, 32, 8, 859, DateTimeKind.Unspecified).AddTicks(3265), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 31, 3, new DateTime(2024, 3, 1, 7, 40, 59, 882, DateTimeKind.Unspecified).AddTicks(2842), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 46, 14, new DateTime(2024, 3, 9, 17, 36, 38, 320, DateTimeKind.Unspecified).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 15, 7, new DateTime(2024, 3, 2, 23, 12, 21, 772, DateTimeKind.Unspecified).AddTicks(1875), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 33, 10, new DateTime(2024, 3, 5, 5, 5, 40, 981, DateTimeKind.Unspecified).AddTicks(41), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 9, new DateTime(2024, 3, 7, 0, 4, 39, 910, DateTimeKind.Unspecified).AddTicks(6458), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 17, 10, new DateTime(2024, 2, 21, 5, 22, 50, 407, DateTimeKind.Unspecified).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 8, 12, new DateTime(2024, 3, 2, 13, 37, 0, 959, DateTimeKind.Unspecified).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 22, 8, new DateTime(2024, 2, 16, 5, 59, 48, 796, DateTimeKind.Unspecified).AddTicks(9960), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 14, 14, new DateTime(2024, 2, 21, 19, 47, 17, 534, DateTimeKind.Unspecified).AddTicks(926), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 1, 5, new DateTime(2024, 3, 1, 2, 25, 9, 5, DateTimeKind.Unspecified).AddTicks(2076), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 23, 17, new DateTime(2024, 2, 17, 7, 26, 50, 928, DateTimeKind.Unspecified).AddTicks(2583), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 31, 2, new DateTime(2024, 3, 7, 2, 19, 26, 88, DateTimeKind.Unspecified).AddTicks(9470), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 13, 17, new DateTime(2024, 3, 9, 1, 1, 16, 797, DateTimeKind.Unspecified).AddTicks(4921), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 48, 19, new DateTime(2024, 3, 4, 19, 3, 10, 279, DateTimeKind.Unspecified).AddTicks(9839), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 2, 11, new DateTime(2024, 3, 1, 6, 30, 26, 334, DateTimeKind.Unspecified).AddTicks(9582), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 6, 10, new DateTime(2024, 2, 16, 8, 41, 44, 848, DateTimeKind.Unspecified).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 30, 18, new DateTime(2024, 3, 5, 1, 8, 35, 200, DateTimeKind.Unspecified).AddTicks(9810), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 26, 8, new DateTime(2024, 2, 17, 18, 20, 51, 142, DateTimeKind.Unspecified).AddTicks(257), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 37, 10, new DateTime(2024, 2, 20, 13, 44, 24, 576, DateTimeKind.Unspecified).AddTicks(107), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 11, 9, new DateTime(2024, 3, 3, 11, 15, 51, 712, DateTimeKind.Unspecified).AddTicks(2607), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 34, 9, new DateTime(2024, 2, 28, 11, 2, 33, 90, DateTimeKind.Unspecified).AddTicks(6413), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 8, 11, new DateTime(2024, 2, 28, 17, 15, 21, 702, DateTimeKind.Unspecified).AddTicks(4004), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 22, 13, new DateTime(2024, 2, 18, 22, 39, 12, 419, DateTimeKind.Unspecified).AddTicks(9591), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 38, 8, new DateTime(2024, 3, 3, 18, 38, 17, 805, DateTimeKind.Unspecified).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 39, 10, new DateTime(2024, 3, 1, 15, 56, 31, 232, DateTimeKind.Unspecified).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 2, new DateTime(2024, 3, 10, 20, 34, 1, 492, DateTimeKind.Unspecified).AddTicks(4766), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 28, 16, new DateTime(2024, 2, 19, 8, 7, 13, 115, DateTimeKind.Unspecified).AddTicks(5668), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 15, new DateTime(2024, 3, 1, 3, 29, 41, 900, DateTimeKind.Unspecified).AddTicks(9755), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 30, 4, new DateTime(2024, 2, 27, 19, 8, 25, 2, DateTimeKind.Unspecified).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 37, 10, new DateTime(2024, 3, 1, 15, 1, 9, 764, DateTimeKind.Unspecified).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 1, 9, new DateTime(2024, 2, 28, 6, 16, 25, 873, DateTimeKind.Unspecified).AddTicks(746), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 28, 18, new DateTime(2024, 3, 7, 4, 18, 16, 98, DateTimeKind.Unspecified).AddTicks(747), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 12, 12, new DateTime(2024, 3, 6, 18, 46, 8, 173, DateTimeKind.Unspecified).AddTicks(4108), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 3, 12, 8, 22, 15, 215, DateTimeKind.Unspecified).AddTicks(5636), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 18, 9, new DateTime(2024, 3, 5, 6, 38, 34, 480, DateTimeKind.Unspecified).AddTicks(5065), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, 10, new DateTime(2024, 2, 28, 16, 39, 0, 775, DateTimeKind.Unspecified).AddTicks(9422), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 10, 10, new DateTime(2024, 2, 25, 19, 52, 11, 781, DateTimeKind.Unspecified).AddTicks(9294), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 43, new DateTime(2024, 3, 10, 17, 50, 1, 575, DateTimeKind.Unspecified).AddTicks(4357), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 19, 16, new DateTime(2024, 2, 29, 11, 56, 47, 384, DateTimeKind.Unspecified).AddTicks(2410), "Cash", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 42, 8, new DateTime(2024, 2, 28, 2, 21, 43, 879, DateTimeKind.Unspecified).AddTicks(4865), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 34, 10, new DateTime(2024, 2, 19, 9, 19, 24, 933, DateTimeKind.Unspecified).AddTicks(3277), "Card" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zhukova Avenue, 15, Apt. 55", "Ekaterina", "+375257641785", 22 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 7, Apt. 36", "Sergey", "+375256728233", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gorkogo Avenue, 17, Apt. 41", "Mikhail", "+375440341142", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 4, Apt. 63", "Ekaterina", "+375447689298", 36 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Street, 8, Apt. 14", "Svetlana", "+375339733508", 42 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 4, Apt. 70", "Dmitry", "+375334749781", 27 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Avenue, 16, Apt. 91", "Daria", "+375254796248", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 12, Apt. 71", "Katya", "+375447177446", 28 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Square, 19, Apt. 21", "Yulia", "+375290000317", 6 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Avenue, 23, Apt. 22", "Olga", "+375254212707", 21 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 11, Apt. 73", "Sergei", "+375290211607", 32 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Avenue, 9, Apt. 33", "Pavel", "+375251427680", 16 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Avenue, 3, Apt. 68", "Yelena", "+375331700693", 38 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Square, 5, Apt. 35", "Viktor", "+375337455040", 36 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 11, Apt. 28", "Maria", "+375445587223", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 1, Apt. 97", "Irina", "+375258623012", 15 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Square, 11, Apt. 76", "Anna", "+375256593741", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 23, Apt. 26", "Tatyana", "+375259834928", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 12, Apt. 25", "Oleg", "+375252507553", 12 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 19, Apt. 32", "Daria", "+375253823125", 46 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Kirova Street, 8, Apt. 14", "Viktor", "+375298192682", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 17, Apt. 38", "Sergey", "+375334133859", 15 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 23, Apt. 91", "Roman", "+375446920515", 25 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 14, Apt. 63", "Mikhail", "+375445053816", 31 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 15, Apt. 41", "Yulia", "+375298980602", 13 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Karl Marx Avenue, 21, Apt. 77", "Ekaterina", "+375292582889", 26 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Street, 23, Apt. 62", "Tatyana", "+375293983392", 18 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 10, Apt. 36", "Natalya", "+375251434513", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Revolyutsii Street, 19, Apt. 93", "Ivan", "+375258097874", 7 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Street, 8, Apt. 24", "Nikolai", "+375339993288", 29 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Masherova Avenue, 23, Apt. 81", "Tatyana", "+375258382532", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32,
                columns: new[] { "Address", "Name", "Phone" },
                values: new object[] { "Independence Avenue, 11, Apt. 19", "Igor", "+375443705244" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Avenue, 21, Apt. 25", "Katya", "+375331818742", 35 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 10, Apt. 33", "Igor", "+375298334484", 39 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pervomayskaya Square, 5, Apt. 73", "Valentina", "+375442322278", 47 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Street, 14, Apt. 58", "Anna", "+375446502737", 39 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Suvorova Street, 17, Apt. 83", "Mikhail", "+375254894034", 36 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Victory Avenue, 4, Apt. 46", "Ivan", "+375292647045", 11 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 17, Apt. 20", "Andrei", "+375256504079", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Pushkina Avenue, 2, Apt. 31", "Dmitry", "+375334007817", 8 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Square, 2, Apt. 8", "Viktor", "+375449240044", 19 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Independence Avenue, 2, Apt. 67", "Tatiana", "+375449531067", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Street, 5, Apt. 11", "Elena", "+375255915253", 36 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Lenina Square, 6, Apt. 51", "Marina", "+375256128383", 45 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Mira Street, 9, Apt. 19", "Andrei", "+375252368097", 34 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Sovetskaya Square, 15, Apt. 9", "Dmitry", "+375290110016", 44 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Zheleznodorozhnaya Street, 24, Apt. 30", "Viktor", "+375442132573", 17 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Gagarina Square, 13, Apt. 90", "Mikhail", "+375297704526", 30 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Frunze Avenue, 13, Apt. 66", "Valentina", "+375440388153", 20 });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50,
                columns: new[] { "Address", "Name", "Phone", "Sale" },
                values: new object[] { "Oktyabrskaya Avenue, 15, Apt. 23", "Sergey", "+375294848921", 16 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 13.630000000000001, 215.19999999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Eggplant Parmesan", 7.4100000000000001, 124.23999999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 6.8300000000000001, 315.99200000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 6.4100000000000001, 278.54899999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Sushi", 14.0, 440.23399999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Scampi", 15.890000000000001, 384.91899999999998 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lemon Chicken", 12.16, 463.75400000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pesto Pasta", 3.0600000000000001, 176.511 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pad Thai", 15.119999999999999, 110.97 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Margherita Pizza", 13.789999999999999, 292.73500000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Sushi", 11.16, 196.036 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Cocktail", 6.3300000000000001, 276.37299999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Pad Thai", 6.54, 288.17099999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "French Onion Soup", 10.529999999999999, 280.15800000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Tomato Soup", 3.96, 100.264 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Tikka Masala", 19.66, 285.762 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Ratatouille", 4.9299999999999997, 227.29400000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Roast Beef", 18.170000000000002, 160.214 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Fish and Chips", 3.8999999999999999, 293.42700000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Hamburger", 23.329999999999998, 494.48000000000002 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lobster Bisque", 11.130000000000001, 101.56699999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Lobster Bisque", 5.6699999999999999, 328.19099999999997 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Vegetable Stir-Fry", 9.4100000000000001, 475.18799999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Margherita Pizza", 6.2599999999999998, 199.214 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Grilled Salmon", 23.309999999999999, 480.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Tikka Masala", 14.18, 235.24700000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Beef Stroganoff", 9.5999999999999996, 394.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Shrimp Cocktail", 14.609999999999999, 138.464 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Caesar Salad", 19.82, 290.238 });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30,
                columns: new[] { "Name", "Price", "Weight" },
                values: new object[] { "Chicken Tikka Masala", 15.890000000000001, 362.238 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 13, 9, new DateTime(2024, 2, 22, 19, 15, 45, 564, DateTimeKind.Unspecified).AddTicks(2219), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 6, 9, new DateTime(2024, 2, 18, 8, 24, 17, 270, DateTimeKind.Unspecified).AddTicks(3960), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 14, 7, new DateTime(2024, 2, 27, 5, 13, 42, 19, DateTimeKind.Unspecified).AddTicks(3308), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 9, 17, new DateTime(2024, 2, 27, 1, 42, 31, 300, DateTimeKind.Unspecified).AddTicks(5273), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 34, 6, new DateTime(2024, 3, 10, 13, 16, 39, 581, DateTimeKind.Unspecified).AddTicks(2285), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 40, 18, new DateTime(2024, 2, 27, 20, 28, 37, 329, DateTimeKind.Unspecified).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 32, 14, new DateTime(2024, 3, 12, 19, 34, 11, 591, DateTimeKind.Unspecified).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 31, 17, new DateTime(2024, 3, 9, 21, 50, 22, 394, DateTimeKind.Unspecified).AddTicks(3626), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 16, 4, new DateTime(2024, 2, 18, 4, 40, 47, 168, DateTimeKind.Unspecified).AddTicks(4670), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 10, 2, new DateTime(2024, 3, 11, 13, 37, 1, 453, DateTimeKind.Unspecified).AddTicks(8232), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 38, new DateTime(2024, 2, 29, 16, 5, 48, 490, DateTimeKind.Unspecified).AddTicks(7525), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 14, 15, new DateTime(2024, 3, 2, 5, 51, 26, 600, DateTimeKind.Unspecified).AddTicks(6612), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 38, 15, new DateTime(2024, 3, 3, 11, 27, 27, 914, DateTimeKind.Unspecified).AddTicks(904), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 22, 5, new DateTime(2024, 3, 3, 12, 41, 4, 343, DateTimeKind.Unspecified).AddTicks(1846), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15,
                columns: new[] { "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 2, 22, 9, 16, 5, 612, DateTimeKind.Unspecified).AddTicks(7182), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 19, 15, new DateTime(2024, 2, 22, 23, 55, 30, 74, DateTimeKind.Unspecified).AddTicks(4744), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 17, 10, new DateTime(2024, 3, 4, 9, 54, 4, 366, DateTimeKind.Unspecified).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 3, 6, new DateTime(2024, 3, 8, 0, 43, 16, 548, DateTimeKind.Unspecified).AddTicks(2290), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 29, 12, new DateTime(2024, 3, 7, 18, 5, 19, 661, DateTimeKind.Unspecified).AddTicks(2622), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 45, 15, new DateTime(2024, 2, 18, 2, 49, 54, 456, DateTimeKind.Unspecified).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 3, 4, 4, 22, 19, 111, DateTimeKind.Unspecified).AddTicks(3113), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 46, 3, new DateTime(2024, 3, 4, 9, 59, 57, 855, DateTimeKind.Unspecified).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 6, 8, new DateTime(2024, 2, 23, 19, 42, 55, 931, DateTimeKind.Unspecified).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 40, 16, new DateTime(2024, 3, 9, 11, 41, 48, 686, DateTimeKind.Unspecified).AddTicks(2001), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 44, 2, new DateTime(2024, 3, 8, 23, 22, 14, 470, DateTimeKind.Unspecified).AddTicks(5378), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 4, 14, new DateTime(2024, 2, 26, 6, 41, 42, 947, DateTimeKind.Unspecified).AddTicks(67), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 27, 19, new DateTime(2024, 2, 26, 0, 5, 11, 716, DateTimeKind.Unspecified).AddTicks(9976), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 16, new DateTime(2024, 2, 20, 10, 50, 54, 320, DateTimeKind.Unspecified).AddTicks(4432), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 23, 2, new DateTime(2024, 2, 19, 11, 54, 2, 709, DateTimeKind.Unspecified).AddTicks(4150), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 30, 19, new DateTime(2024, 2, 17, 14, 23, 24, 816, DateTimeKind.Unspecified).AddTicks(4175), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 18, 17, new DateTime(2024, 2, 23, 14, 1, 44, 390, DateTimeKind.Unspecified).AddTicks(7731), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 3, 2, new DateTime(2024, 3, 12, 4, 30, 43, 695, DateTimeKind.Unspecified).AddTicks(7899), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 3, 13, new DateTime(2024, 2, 20, 13, 7, 1, 646, DateTimeKind.Unspecified).AddTicks(8742), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34,
                columns: new[] { "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 2, new DateTime(2024, 2, 16, 20, 26, 56, 961, DateTimeKind.Unspecified).AddTicks(8268), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 6, new DateTime(2024, 2, 20, 12, 3, 5, 377, DateTimeKind.Unspecified).AddTicks(1077), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 27, 6, new DateTime(2024, 3, 2, 11, 16, 7, 976, DateTimeKind.Unspecified).AddTicks(2688), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 38, 18, new DateTime(2024, 3, 6, 9, 45, 56, 579, DateTimeKind.Unspecified).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 33, 12, new DateTime(2024, 2, 17, 5, 8, 55, 306, DateTimeKind.Unspecified).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 7, new DateTime(2024, 3, 10, 10, 34, 43, 393, DateTimeKind.Unspecified).AddTicks(4453), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 12, 11, new DateTime(2024, 3, 3, 20, 49, 24, 647, DateTimeKind.Unspecified).AddTicks(5317), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 15, 10, new DateTime(2024, 3, 8, 19, 47, 48, 534, DateTimeKind.Unspecified).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 37, 5, new DateTime(2024, 3, 12, 10, 22, 19, 821, DateTimeKind.Unspecified).AddTicks(8566), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 13, new DateTime(2024, 3, 7, 3, 18, 30, 461, DateTimeKind.Unspecified).AddTicks(577), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 44, 3, new DateTime(2024, 3, 9, 5, 24, 26, 598, DateTimeKind.Unspecified).AddTicks(8331), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 42, 17, new DateTime(2024, 3, 2, 5, 31, 3, 427, DateTimeKind.Unspecified).AddTicks(6404), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 10, new DateTime(2024, 3, 11, 22, 29, 28, 426, DateTimeKind.Unspecified).AddTicks(9301), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 16, 13, new DateTime(2024, 2, 28, 3, 14, 25, 804, DateTimeKind.Unspecified).AddTicks(8069), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 41, 18, new DateTime(2024, 3, 7, 18, 8, 46, 605, DateTimeKind.Unspecified).AddTicks(6401), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 40, 3, new DateTime(2024, 2, 23, 17, 22, 7, 61, DateTimeKind.Unspecified).AddTicks(6658), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 14, new DateTime(2024, 3, 10, 0, 22, 38, 452, DateTimeKind.Unspecified).AddTicks(2877), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 45, 11, new DateTime(2024, 2, 24, 21, 28, 8, 802, DateTimeKind.Unspecified).AddTicks(6518), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 20, 9, new DateTime(2024, 3, 2, 4, 58, 51, 155, DateTimeKind.Unspecified).AddTicks(8773), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 19, 5, new DateTime(2024, 2, 23, 23, 49, 3, 730, DateTimeKind.Unspecified).AddTicks(5190), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 11, 14, new DateTime(2024, 3, 8, 11, 44, 24, 530, DateTimeKind.Unspecified).AddTicks(3609), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55,
                columns: new[] { "ClientId", "OrderDate", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 2, 28, 9, 19, 39, 143, DateTimeKind.Unspecified).AddTicks(8851), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56,
                columns: new[] { "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { new DateTime(2024, 3, 11, 6, 51, 46, 877, DateTimeKind.Unspecified).AddTicks(1575), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 36, 19, new DateTime(2024, 2, 27, 23, 45, 49, 18, DateTimeKind.Unspecified).AddTicks(1234), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, 2, new DateTime(2024, 2, 18, 3, 11, 16, 486, DateTimeKind.Unspecified).AddTicks(7114), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 4, 18, new DateTime(2024, 2, 16, 23, 27, 26, 559, DateTimeKind.Unspecified).AddTicks(7214), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 34, 12, new DateTime(2024, 3, 9, 17, 4, 6, 953, DateTimeKind.Unspecified).AddTicks(415), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 40, 19, new DateTime(2024, 2, 20, 19, 2, 29, 827, DateTimeKind.Unspecified).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 16, 12, new DateTime(2024, 2, 20, 15, 41, 2, 198, DateTimeKind.Unspecified).AddTicks(1561), "Card", 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 6, 16, new DateTime(2024, 2, 16, 11, 5, 8, 828, DateTimeKind.Unspecified).AddTicks(7027), "Cash" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 3, 18, new DateTime(2024, 2, 23, 13, 21, 4, 659, DateTimeKind.Unspecified).AddTicks(2053), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 29, 3, new DateTime(2024, 2, 21, 20, 8, 29, 41, DateTimeKind.Unspecified).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 15, 19, new DateTime(2024, 3, 10, 8, 33, 3, 426, DateTimeKind.Unspecified).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 40, 2, new DateTime(2024, 2, 28, 0, 13, 43, 857, DateTimeKind.Unspecified).AddTicks(1099), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 12, 10, new DateTime(2024, 3, 8, 4, 48, 48, 924, DateTimeKind.Unspecified).AddTicks(1556), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, 6, new DateTime(2024, 3, 10, 2, 14, 19, 424, DateTimeKind.Unspecified).AddTicks(8460), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 22, 12, new DateTime(2024, 3, 9, 8, 23, 10, 307, DateTimeKind.Unspecified).AddTicks(5182), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 2, 17, new DateTime(2024, 2, 21, 11, 54, 35, 681, DateTimeKind.Unspecified).AddTicks(5384), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 47, 1, new DateTime(2024, 3, 8, 12, 21, 47, 472, DateTimeKind.Unspecified).AddTicks(6495), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 31, 18, new DateTime(2024, 2, 21, 2, 31, 22, 835, DateTimeKind.Unspecified).AddTicks(8142), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 20, 7, new DateTime(2024, 2, 20, 14, 41, 47, 82, DateTimeKind.Unspecified).AddTicks(3028), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 13, 6, new DateTime(2024, 2, 20, 12, 18, 28, 703, DateTimeKind.Unspecified).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 6, 19, new DateTime(2024, 3, 7, 0, 41, 35, 397, DateTimeKind.Unspecified).AddTicks(1536), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 36, 9, new DateTime(2024, 3, 3, 13, 54, 38, 691, DateTimeKind.Unspecified).AddTicks(8639), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 16, 8, new DateTime(2024, 3, 7, 23, 9, 45, 224, DateTimeKind.Unspecified).AddTicks(7847), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 44, 4, new DateTime(2024, 3, 2, 22, 55, 48, 628, DateTimeKind.Unspecified).AddTicks(1002), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 26, 14, new DateTime(2024, 2, 16, 8, 5, 6, 71, DateTimeKind.Unspecified).AddTicks(957), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 19, 17, new DateTime(2024, 2, 23, 10, 11, 10, 510, DateTimeKind.Unspecified).AddTicks(6672), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 14, 17, new DateTime(2024, 2, 24, 21, 48, 27, 817, DateTimeKind.Unspecified).AddTicks(7424), "Card" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 24, 12, new DateTime(2024, 2, 20, 2, 27, 46, 850, DateTimeKind.Unspecified).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 42, 4, new DateTime(2024, 2, 23, 7, 35, 7, 711, DateTimeKind.Unspecified).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 5, 7, new DateTime(2024, 2, 21, 18, 20, 13, 975, DateTimeKind.Unspecified).AddTicks(5350), 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 38, 3, new DateTime(2024, 2, 24, 13, 14, 2, 19, DateTimeKind.Unspecified).AddTicks(3658), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 21, 19, new DateTime(2024, 2, 26, 6, 18, 28, 822, DateTimeKind.Unspecified).AddTicks(9475), 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 23, 9, new DateTime(2024, 2, 19, 3, 19, 4, 876, DateTimeKind.Unspecified).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89,
                columns: new[] { "ClientId", "DishId", "OrderDate" },
                values: new object[] { 32, 5, new DateTime(2024, 3, 10, 14, 41, 6, 569, DateTimeKind.Unspecified).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 16, 10, new DateTime(2024, 3, 4, 10, 16, 52, 585, DateTimeKind.Unspecified).AddTicks(2405), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 23, 11, new DateTime(2024, 3, 4, 0, 19, 35, 824, DateTimeKind.Unspecified).AddTicks(4757), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 29, 4, new DateTime(2024, 2, 16, 13, 46, 23, 239, DateTimeKind.Unspecified).AddTicks(3402), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 10, new DateTime(2024, 2, 18, 0, 15, 9, 628, DateTimeKind.Unspecified).AddTicks(8794), "Cash", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 48, 18, new DateTime(2024, 3, 6, 23, 19, 11, 368, DateTimeKind.Unspecified).AddTicks(43), "Card", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 11, 9, new DateTime(2024, 2, 29, 14, 0, 24, 511, DateTimeKind.Unspecified).AddTicks(7654), "Cash", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96,
                columns: new[] { "ClientId", "DishId", "OrderDate", "Quantity" },
                values: new object[] { 2, 13, new DateTime(2024, 3, 12, 17, 5, 40, 976, DateTimeKind.Unspecified).AddTicks(9617), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97,
                columns: new[] { "ClientId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 46, new DateTime(2024, 2, 27, 13, 38, 7, 855, DateTimeKind.Unspecified).AddTicks(8362), "Cash", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 4, 11, new DateTime(2024, 2, 16, 8, 57, 10, 597, DateTimeKind.Unspecified).AddTicks(9058), "Card", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType", "Quantity" },
                values: new object[] { 15, 17, new DateTime(2024, 3, 2, 7, 20, 44, 478, DateTimeKind.Unspecified).AddTicks(4888), "Card", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100,
                columns: new[] { "ClientId", "DishId", "OrderDate", "PaymentType" },
                values: new object[] { 11, 19, new DateTime(2024, 3, 4, 5, 46, 54, 171, DateTimeKind.Unspecified).AddTicks(5154), "Cash" });
        }
    }
}
