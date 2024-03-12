using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Address", "Name", "Phone", "Sale" },
                values: new object[,]
                {
                    { 1, "Zhukova Avenue, 15, Apt. 55", "Ekaterina", "+375257641785", 22 },
                    { 2, "Masherova Avenue, 7, Apt. 36", "Sergey", "+375256728233", 44 },
                    { 3, "Gorkogo Avenue, 17, Apt. 41", "Mikhail", "+375440341142", 42 },
                    { 4, "Frunze Avenue, 4, Apt. 63", "Ekaterina", "+375447689298", 36 },
                    { 5, "Sovetskaya Street, 8, Apt. 14", "Svetlana", "+375339733508", 42 },
                    { 6, "Victory Avenue, 4, Apt. 70", "Dmitry", "+375334749781", 27 },
                    { 7, "Mira Avenue, 16, Apt. 91", "Daria", "+375254796248", 28 },
                    { 8, "Revolyutsii Street, 12, Apt. 71", "Katya", "+375447177446", 28 },
                    { 9, "Gagarina Square, 19, Apt. 21", "Yulia", "+375290000317", 6 },
                    { 10, "Gagarina Avenue, 23, Apt. 22", "Olga", "+375254212707", 21 },
                    { 11, "Gagarina Street, 11, Apt. 73", "Sergei", "+375290211607", 32 },
                    { 12, "Oktyabrskaya Avenue, 9, Apt. 33", "Pavel", "+375251427680", 16 },
                    { 13, "Karl Marx Avenue, 3, Apt. 68", "Yelena", "+375331700693", 38 },
                    { 14, "Pervomayskaya Square, 5, Apt. 35", "Viktor", "+375337455040", 36 },
                    { 15, "Revolyutsii Street, 11, Apt. 28", "Maria", "+375445587223", 26 },
                    { 16, "Lenina Street, 1, Apt. 97", "Irina", "+375258623012", 15 },
                    { 17, "Oktyabrskaya Square, 11, Apt. 76", "Anna", "+375256593741", 30 },
                    { 18, "Revolyutsii Street, 23, Apt. 26", "Tatyana", "+375259834928", 7 },
                    { 19, "Lenina Square, 12, Apt. 25", "Oleg", "+375252507553", 12 },
                    { 20, "Pushkina Avenue, 19, Apt. 32", "Daria", "+375253823125", 46 },
                    { 21, "Kirova Street, 8, Apt. 14", "Viktor", "+375298192682", 8 },
                    { 22, "Frunze Avenue, 17, Apt. 38", "Sergey", "+375334133859", 15 },
                    { 23, "Lenina Street, 23, Apt. 91", "Roman", "+375446920515", 25 },
                    { 24, "Lenina Avenue, 14, Apt. 63", "Mikhail", "+375445053816", 31 },
                    { 25, "Gagarina Street, 15, Apt. 41", "Yulia", "+375298980602", 13 },
                    { 26, "Karl Marx Avenue, 21, Apt. 77", "Ekaterina", "+375292582889", 26 },
                    { 27, "Pervomayskaya Street, 23, Apt. 62", "Tatyana", "+375293983392", 18 },
                    { 28, "Lenina Street, 10, Apt. 36", "Natalya", "+375251434513", 19 },
                    { 29, "Revolyutsii Street, 19, Apt. 93", "Ivan", "+375258097874", 7 },
                    { 30, "Gagarina Street, 8, Apt. 24", "Nikolai", "+375339993288", 29 },
                    { 31, "Masherova Avenue, 23, Apt. 81", "Tatyana", "+375258382532", 8 },
                    { 32, "Independence Avenue, 11, Apt. 19", "Igor", "+375443705244", 11 },
                    { 33, "Lenina Avenue, 21, Apt. 25", "Katya", "+375331818742", 35 },
                    { 34, "Independence Avenue, 10, Apt. 33", "Igor", "+375298334484", 39 },
                    { 35, "Pervomayskaya Square, 5, Apt. 73", "Valentina", "+375442322278", 47 },
                    { 36, "Lenina Street, 14, Apt. 58", "Anna", "+375446502737", 39 },
                    { 37, "Suvorova Street, 17, Apt. 83", "Mikhail", "+375254894034", 36 },
                    { 38, "Victory Avenue, 4, Apt. 46", "Ivan", "+375292647045", 11 },
                    { 39, "Independence Avenue, 17, Apt. 20", "Andrei", "+375256504079", 34 },
                    { 40, "Pushkina Avenue, 2, Apt. 31", "Dmitry", "+375334007817", 8 },
                    { 41, "Gagarina Square, 2, Apt. 8", "Viktor", "+375449240044", 19 },
                    { 42, "Independence Avenue, 2, Apt. 67", "Tatiana", "+375449531067", 30 },
                    { 43, "Mira Street, 5, Apt. 11", "Elena", "+375255915253", 36 },
                    { 44, "Lenina Square, 6, Apt. 51", "Marina", "+375256128383", 45 },
                    { 45, "Mira Street, 9, Apt. 19", "Andrei", "+375252368097", 34 },
                    { 46, "Sovetskaya Square, 15, Apt. 9", "Dmitry", "+375290110016", 44 },
                    { 47, "Zheleznodorozhnaya Street, 24, Apt. 30", "Viktor", "+375442132573", 17 },
                    { 48, "Gagarina Square, 13, Apt. 90", "Mikhail", "+375297704526", 30 },
                    { 49, "Frunze Avenue, 13, Apt. 66", "Valentina", "+375440388153", 20 },
                    { 50, "Oktyabrskaya Avenue, 15, Apt. 23", "Sergey", "+375294848921", 16 }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, "Lemon Chicken", 13.630000000000001, 215.19999999999999 },
                    { 2, "Eggplant Parmesan", 7.4100000000000001, 124.23999999999999 },
                    { 3, "Lemon Chicken", 6.8300000000000001, 315.99200000000002 },
                    { 4, "Pesto Pasta", 6.4100000000000001, 278.54899999999998 },
                    { 5, "Sushi", 14.0, 440.23399999999998 },
                    { 6, "Shrimp Scampi", 15.890000000000001, 384.91899999999998 },
                    { 7, "Lemon Chicken", 12.16, 463.75400000000002 },
                    { 8, "Pesto Pasta", 3.0600000000000001, 176.511 },
                    { 9, "Pad Thai", 15.119999999999999, 110.97 },
                    { 10, "Margherita Pizza", 13.789999999999999, 292.73500000000001 },
                    { 11, "Sushi", 11.16, 196.036 },
                    { 12, "Shrimp Cocktail", 6.3300000000000001, 276.37299999999999 },
                    { 13, "Pad Thai", 6.54, 288.17099999999999 },
                    { 14, "French Onion Soup", 10.529999999999999, 280.15800000000002 },
                    { 15, "Tomato Soup", 3.96, 100.264 },
                    { 16, "Chicken Tikka Masala", 19.66, 285.762 },
                    { 17, "Ratatouille", 4.9299999999999997, 227.29400000000001 },
                    { 18, "Roast Beef", 18.170000000000002, 160.214 },
                    { 19, "Fish and Chips", 3.8999999999999999, 293.42700000000002 },
                    { 20, "Hamburger", 23.329999999999998, 494.48000000000002 },
                    { 21, "Lobster Bisque", 11.130000000000001, 101.56699999999999 },
                    { 22, "Lobster Bisque", 5.6699999999999999, 328.19099999999997 },
                    { 23, "Vegetable Stir-Fry", 9.4100000000000001, 475.18799999999999 },
                    { 24, "Margherita Pizza", 6.2599999999999998, 199.214 },
                    { 25, "Grilled Salmon", 23.309999999999999, 480.75999999999999 },
                    { 26, "Chicken Tikka Masala", 14.18, 235.24700000000001 },
                    { 27, "Beef Stroganoff", 9.5999999999999996, 394.49000000000001 },
                    { 28, "Shrimp Cocktail", 14.609999999999999, 138.464 },
                    { 29, "Caesar Salad", 19.82, 290.238 },
                    { 30, "Chicken Tikka Masala", 15.890000000000001, 362.238 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ClientId", "DishId", "OrderDate", "PaymentType", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 13, 9, new DateTime(2024, 2, 22, 19, 15, 45, 564, DateTimeKind.Unspecified).AddTicks(2219), "Cash", 0.0, 3 },
                    { 2, 6, 9, new DateTime(2024, 2, 18, 8, 24, 17, 270, DateTimeKind.Unspecified).AddTicks(3960), "Cash", 0.0, 3 },
                    { 3, 14, 7, new DateTime(2024, 2, 27, 5, 13, 42, 19, DateTimeKind.Unspecified).AddTicks(3308), "Card", 0.0, 1 },
                    { 4, 9, 17, new DateTime(2024, 2, 27, 1, 42, 31, 300, DateTimeKind.Unspecified).AddTicks(5273), "Cash", 0.0, 3 },
                    { 5, 34, 6, new DateTime(2024, 3, 10, 13, 16, 39, 581, DateTimeKind.Unspecified).AddTicks(2285), "Cash", 0.0, 4 },
                    { 6, 40, 18, new DateTime(2024, 2, 27, 20, 28, 37, 329, DateTimeKind.Unspecified).AddTicks(9621), "Card", 0.0, 3 },
                    { 7, 32, 14, new DateTime(2024, 3, 12, 19, 34, 11, 591, DateTimeKind.Unspecified).AddTicks(6526), "Cash", 0.0, 4 },
                    { 8, 31, 17, new DateTime(2024, 3, 9, 21, 50, 22, 394, DateTimeKind.Unspecified).AddTicks(3626), "Card", 0.0, 3 },
                    { 9, 16, 4, new DateTime(2024, 2, 18, 4, 40, 47, 168, DateTimeKind.Unspecified).AddTicks(4670), "Cash", 0.0, 4 },
                    { 10, 10, 2, new DateTime(2024, 3, 11, 13, 37, 1, 453, DateTimeKind.Unspecified).AddTicks(8232), "Cash", 0.0, 3 },
                    { 11, 38, 9, new DateTime(2024, 2, 29, 16, 5, 48, 490, DateTimeKind.Unspecified).AddTicks(7525), "Card", 0.0, 3 },
                    { 12, 14, 15, new DateTime(2024, 3, 2, 5, 51, 26, 600, DateTimeKind.Unspecified).AddTicks(6612), "Card", 0.0, 3 },
                    { 13, 38, 15, new DateTime(2024, 3, 3, 11, 27, 27, 914, DateTimeKind.Unspecified).AddTicks(904), "Cash", 0.0, 2 },
                    { 14, 22, 5, new DateTime(2024, 3, 3, 12, 41, 4, 343, DateTimeKind.Unspecified).AddTicks(1846), "Card", 0.0, 3 },
                    { 15, 34, 4, new DateTime(2024, 2, 22, 9, 16, 5, 612, DateTimeKind.Unspecified).AddTicks(7182), "Card", 0.0, 1 },
                    { 16, 19, 15, new DateTime(2024, 2, 22, 23, 55, 30, 74, DateTimeKind.Unspecified).AddTicks(4744), "Card", 0.0, 2 },
                    { 17, 17, 10, new DateTime(2024, 3, 4, 9, 54, 4, 366, DateTimeKind.Unspecified).AddTicks(9088), "Card", 0.0, 4 },
                    { 18, 3, 6, new DateTime(2024, 3, 8, 0, 43, 16, 548, DateTimeKind.Unspecified).AddTicks(2290), "Cash", 0.0, 1 },
                    { 19, 29, 12, new DateTime(2024, 3, 7, 18, 5, 19, 661, DateTimeKind.Unspecified).AddTicks(2622), "Card", 0.0, 4 },
                    { 20, 45, 15, new DateTime(2024, 2, 18, 2, 49, 54, 456, DateTimeKind.Unspecified).AddTicks(4745), "Card", 0.0, 1 },
                    { 21, 1, 19, new DateTime(2024, 3, 4, 4, 22, 19, 111, DateTimeKind.Unspecified).AddTicks(3113), "Cash", 0.0, 1 },
                    { 22, 46, 3, new DateTime(2024, 3, 4, 9, 59, 57, 855, DateTimeKind.Unspecified).AddTicks(6365), "Card", 0.0, 4 },
                    { 23, 6, 8, new DateTime(2024, 2, 23, 19, 42, 55, 931, DateTimeKind.Unspecified).AddTicks(2850), "Cash", 0.0, 4 },
                    { 24, 40, 16, new DateTime(2024, 3, 9, 11, 41, 48, 686, DateTimeKind.Unspecified).AddTicks(2001), "Card", 0.0, 3 },
                    { 25, 44, 2, new DateTime(2024, 3, 8, 23, 22, 14, 470, DateTimeKind.Unspecified).AddTicks(5378), "Card", 0.0, 1 },
                    { 26, 4, 14, new DateTime(2024, 2, 26, 6, 41, 42, 947, DateTimeKind.Unspecified).AddTicks(67), "Cash", 0.0, 1 },
                    { 27, 27, 19, new DateTime(2024, 2, 26, 0, 5, 11, 716, DateTimeKind.Unspecified).AddTicks(9976), "Card", 0.0, 2 },
                    { 28, 20, 16, new DateTime(2024, 2, 20, 10, 50, 54, 320, DateTimeKind.Unspecified).AddTicks(4432), "Card", 0.0, 2 },
                    { 29, 23, 2, new DateTime(2024, 2, 19, 11, 54, 2, 709, DateTimeKind.Unspecified).AddTicks(4150), "Cash", 0.0, 1 },
                    { 30, 30, 19, new DateTime(2024, 2, 17, 14, 23, 24, 816, DateTimeKind.Unspecified).AddTicks(4175), "Cash", 0.0, 2 },
                    { 31, 18, 17, new DateTime(2024, 2, 23, 14, 1, 44, 390, DateTimeKind.Unspecified).AddTicks(7731), "Cash", 0.0, 2 },
                    { 32, 3, 2, new DateTime(2024, 3, 12, 4, 30, 43, 695, DateTimeKind.Unspecified).AddTicks(7899), "Card", 0.0, 1 },
                    { 33, 3, 13, new DateTime(2024, 2, 20, 13, 7, 1, 646, DateTimeKind.Unspecified).AddTicks(8742), "Card", 0.0, 1 },
                    { 34, 34, 2, new DateTime(2024, 2, 16, 20, 26, 56, 961, DateTimeKind.Unspecified).AddTicks(8268), "Card", 0.0, 3 },
                    { 35, 16, 6, new DateTime(2024, 2, 20, 12, 3, 5, 377, DateTimeKind.Unspecified).AddTicks(1077), "Cash", 0.0, 1 },
                    { 36, 27, 6, new DateTime(2024, 3, 2, 11, 16, 7, 976, DateTimeKind.Unspecified).AddTicks(2688), "Card", 0.0, 3 },
                    { 37, 38, 18, new DateTime(2024, 3, 6, 9, 45, 56, 579, DateTimeKind.Unspecified).AddTicks(2945), "Cash", 0.0, 3 },
                    { 38, 33, 12, new DateTime(2024, 2, 17, 5, 8, 55, 306, DateTimeKind.Unspecified).AddTicks(3240), "Cash", 0.0, 4 },
                    { 39, 16, 7, new DateTime(2024, 3, 10, 10, 34, 43, 393, DateTimeKind.Unspecified).AddTicks(4453), "Card", 0.0, 1 },
                    { 40, 12, 11, new DateTime(2024, 3, 3, 20, 49, 24, 647, DateTimeKind.Unspecified).AddTicks(5317), "Cash", 0.0, 2 },
                    { 41, 15, 10, new DateTime(2024, 3, 8, 19, 47, 48, 534, DateTimeKind.Unspecified).AddTicks(8723), "Card", 0.0, 4 },
                    { 42, 37, 5, new DateTime(2024, 3, 12, 10, 22, 19, 821, DateTimeKind.Unspecified).AddTicks(8566), "Card", 0.0, 1 },
                    { 43, 5, 13, new DateTime(2024, 3, 7, 3, 18, 30, 461, DateTimeKind.Unspecified).AddTicks(577), "Cash", 0.0, 1 },
                    { 44, 44, 3, new DateTime(2024, 3, 9, 5, 24, 26, 598, DateTimeKind.Unspecified).AddTicks(8331), "Cash", 0.0, 3 },
                    { 45, 42, 17, new DateTime(2024, 3, 2, 5, 31, 3, 427, DateTimeKind.Unspecified).AddTicks(6404), "Card", 0.0, 3 },
                    { 46, 38, 10, new DateTime(2024, 3, 11, 22, 29, 28, 426, DateTimeKind.Unspecified).AddTicks(9301), "Card", 0.0, 2 },
                    { 47, 16, 13, new DateTime(2024, 2, 28, 3, 14, 25, 804, DateTimeKind.Unspecified).AddTicks(8069), "Cash", 0.0, 2 },
                    { 48, 41, 18, new DateTime(2024, 3, 7, 18, 8, 46, 605, DateTimeKind.Unspecified).AddTicks(6401), "Cash", 0.0, 3 },
                    { 49, 40, 3, new DateTime(2024, 2, 23, 17, 22, 7, 61, DateTimeKind.Unspecified).AddTicks(6658), "Cash", 0.0, 3 },
                    { 50, 44, 14, new DateTime(2024, 3, 10, 0, 22, 38, 452, DateTimeKind.Unspecified).AddTicks(2877), "Card", 0.0, 1 },
                    { 51, 45, 11, new DateTime(2024, 2, 24, 21, 28, 8, 802, DateTimeKind.Unspecified).AddTicks(6518), "Cash", 0.0, 2 },
                    { 52, 20, 9, new DateTime(2024, 3, 2, 4, 58, 51, 155, DateTimeKind.Unspecified).AddTicks(8773), "Cash", 0.0, 4 },
                    { 53, 19, 5, new DateTime(2024, 2, 23, 23, 49, 3, 730, DateTimeKind.Unspecified).AddTicks(5190), "Cash", 0.0, 3 },
                    { 54, 11, 14, new DateTime(2024, 3, 8, 11, 44, 24, 530, DateTimeKind.Unspecified).AddTicks(3609), "Card", 0.0, 3 },
                    { 55, 12, 17, new DateTime(2024, 2, 28, 9, 19, 39, 143, DateTimeKind.Unspecified).AddTicks(8851), "Cash", 0.0, 2 },
                    { 56, 42, 11, new DateTime(2024, 3, 11, 6, 51, 46, 877, DateTimeKind.Unspecified).AddTicks(1575), "Cash", 0.0, 1 },
                    { 57, 36, 19, new DateTime(2024, 2, 27, 23, 45, 49, 18, DateTimeKind.Unspecified).AddTicks(1234), "Cash", 0.0, 1 },
                    { 58, 46, 2, new DateTime(2024, 2, 18, 3, 11, 16, 486, DateTimeKind.Unspecified).AddTicks(7114), "Card", 0.0, 4 },
                    { 59, 4, 18, new DateTime(2024, 2, 16, 23, 27, 26, 559, DateTimeKind.Unspecified).AddTicks(7214), "Card", 0.0, 1 },
                    { 60, 34, 12, new DateTime(2024, 3, 9, 17, 4, 6, 953, DateTimeKind.Unspecified).AddTicks(415), "Cash", 0.0, 3 },
                    { 61, 40, 19, new DateTime(2024, 2, 20, 19, 2, 29, 827, DateTimeKind.Unspecified).AddTicks(9295), "Cash", 0.0, 4 },
                    { 62, 16, 12, new DateTime(2024, 2, 20, 15, 41, 2, 198, DateTimeKind.Unspecified).AddTicks(1561), "Card", 0.0, 4 },
                    { 63, 6, 16, new DateTime(2024, 2, 16, 11, 5, 8, 828, DateTimeKind.Unspecified).AddTicks(7027), "Cash", 0.0, 4 },
                    { 64, 3, 18, new DateTime(2024, 2, 23, 13, 21, 4, 659, DateTimeKind.Unspecified).AddTicks(2053), "Card", 0.0, 2 },
                    { 65, 29, 3, new DateTime(2024, 2, 21, 20, 8, 29, 41, DateTimeKind.Unspecified).AddTicks(9908), "Cash", 0.0, 4 },
                    { 66, 15, 19, new DateTime(2024, 3, 10, 8, 33, 3, 426, DateTimeKind.Unspecified).AddTicks(7025), "Card", 0.0, 1 },
                    { 67, 40, 2, new DateTime(2024, 2, 28, 0, 13, 43, 857, DateTimeKind.Unspecified).AddTicks(1099), "Card", 0.0, 2 },
                    { 68, 12, 10, new DateTime(2024, 3, 8, 4, 48, 48, 924, DateTimeKind.Unspecified).AddTicks(1556), "Card", 0.0, 3 },
                    { 69, 46, 6, new DateTime(2024, 3, 10, 2, 14, 19, 424, DateTimeKind.Unspecified).AddTicks(8460), "Card", 0.0, 3 },
                    { 70, 22, 12, new DateTime(2024, 3, 9, 8, 23, 10, 307, DateTimeKind.Unspecified).AddTicks(5182), "Card", 0.0, 1 },
                    { 71, 2, 17, new DateTime(2024, 2, 21, 11, 54, 35, 681, DateTimeKind.Unspecified).AddTicks(5384), "Cash", 0.0, 3 },
                    { 72, 47, 1, new DateTime(2024, 3, 8, 12, 21, 47, 472, DateTimeKind.Unspecified).AddTicks(6495), "Card", 0.0, 4 },
                    { 73, 31, 18, new DateTime(2024, 2, 21, 2, 31, 22, 835, DateTimeKind.Unspecified).AddTicks(8142), "Card", 0.0, 2 },
                    { 74, 20, 7, new DateTime(2024, 2, 20, 14, 41, 47, 82, DateTimeKind.Unspecified).AddTicks(3028), "Cash", 0.0, 1 },
                    { 75, 13, 6, new DateTime(2024, 2, 20, 12, 18, 28, 703, DateTimeKind.Unspecified).AddTicks(5165), "Cash", 0.0, 4 },
                    { 76, 6, 19, new DateTime(2024, 3, 7, 0, 41, 35, 397, DateTimeKind.Unspecified).AddTicks(1536), "Card", 0.0, 1 },
                    { 77, 36, 9, new DateTime(2024, 3, 3, 13, 54, 38, 691, DateTimeKind.Unspecified).AddTicks(8639), "Cash", 0.0, 1 },
                    { 78, 16, 8, new DateTime(2024, 3, 7, 23, 9, 45, 224, DateTimeKind.Unspecified).AddTicks(7847), "Cash", 0.0, 3 },
                    { 79, 44, 4, new DateTime(2024, 3, 2, 22, 55, 48, 628, DateTimeKind.Unspecified).AddTicks(1002), "Cash", 0.0, 1 },
                    { 80, 26, 14, new DateTime(2024, 2, 16, 8, 5, 6, 71, DateTimeKind.Unspecified).AddTicks(957), "Card", 0.0, 1 },
                    { 81, 19, 17, new DateTime(2024, 2, 23, 10, 11, 10, 510, DateTimeKind.Unspecified).AddTicks(6672), "Cash", 0.0, 2 },
                    { 82, 14, 17, new DateTime(2024, 2, 24, 21, 48, 27, 817, DateTimeKind.Unspecified).AddTicks(7424), "Card", 0.0, 4 },
                    { 83, 24, 12, new DateTime(2024, 2, 20, 2, 27, 46, 850, DateTimeKind.Unspecified).AddTicks(5166), "Cash", 0.0, 1 },
                    { 84, 42, 4, new DateTime(2024, 2, 23, 7, 35, 7, 711, DateTimeKind.Unspecified).AddTicks(5922), "Cash", 0.0, 4 },
                    { 85, 5, 7, new DateTime(2024, 2, 21, 18, 20, 13, 975, DateTimeKind.Unspecified).AddTicks(5350), "Card", 0.0, 3 },
                    { 86, 38, 3, new DateTime(2024, 2, 24, 13, 14, 2, 19, DateTimeKind.Unspecified).AddTicks(3658), "Cash", 0.0, 1 },
                    { 87, 21, 19, new DateTime(2024, 2, 26, 6, 18, 28, 822, DateTimeKind.Unspecified).AddTicks(9475), "Card", 0.0, 2 },
                    { 88, 23, 9, new DateTime(2024, 2, 19, 3, 19, 4, 876, DateTimeKind.Unspecified).AddTicks(8881), "Cash", 0.0, 3 },
                    { 89, 32, 5, new DateTime(2024, 3, 10, 14, 41, 6, 569, DateTimeKind.Unspecified).AddTicks(1739), "Card", 0.0, 1 },
                    { 90, 16, 10, new DateTime(2024, 3, 4, 10, 16, 52, 585, DateTimeKind.Unspecified).AddTicks(2405), "Card", 0.0, 3 },
                    { 91, 23, 11, new DateTime(2024, 3, 4, 0, 19, 35, 824, DateTimeKind.Unspecified).AddTicks(4757), "Cash", 0.0, 2 },
                    { 92, 29, 4, new DateTime(2024, 2, 16, 13, 46, 23, 239, DateTimeKind.Unspecified).AddTicks(3402), "Cash", 0.0, 1 },
                    { 93, 10, 9, new DateTime(2024, 2, 18, 0, 15, 9, 628, DateTimeKind.Unspecified).AddTicks(8794), "Cash", 0.0, 2 },
                    { 94, 48, 18, new DateTime(2024, 3, 6, 23, 19, 11, 368, DateTimeKind.Unspecified).AddTicks(43), "Card", 0.0, 2 },
                    { 95, 11, 9, new DateTime(2024, 2, 29, 14, 0, 24, 511, DateTimeKind.Unspecified).AddTicks(7654), "Cash", 0.0, 1 },
                    { 96, 2, 13, new DateTime(2024, 3, 12, 17, 5, 40, 976, DateTimeKind.Unspecified).AddTicks(9617), "Cash", 0.0, 1 },
                    { 97, 46, 15, new DateTime(2024, 2, 27, 13, 38, 7, 855, DateTimeKind.Unspecified).AddTicks(8362), "Cash", 0.0, 3 },
                    { 98, 4, 11, new DateTime(2024, 2, 16, 8, 57, 10, 597, DateTimeKind.Unspecified).AddTicks(9058), "Card", 0.0, 1 },
                    { 99, 15, 17, new DateTime(2024, 3, 2, 7, 20, 44, 478, DateTimeKind.Unspecified).AddTicks(4888), "Card", 0.0, 3 },
                    { 100, 11, 19, new DateTime(2024, 3, 4, 5, 46, 54, 171, DateTimeKind.Unspecified).AddTicks(5154), "Cash", 0.0, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ClientId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 19);
        }
    }
}
