using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTableAlteraçãoUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/2_no_internet.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/3_vader.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/4_storm_tropper.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/5_100_gamer.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/6_spacex.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/7_coffee.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/9_neil.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/10_milennium_falcon.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/11_mars.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/12_gnu_linux.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 15L,
                column: "image_url",
                value: "https://github.com/kauanmeira/microservices-dotnet6/blob/main/GeekShopping.Web/ShoppingImages/13_dragon_ball.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 14L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "id",
                keyValue: 15L,
                column: "image_url",
                value: "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg");
        }
    }
}
