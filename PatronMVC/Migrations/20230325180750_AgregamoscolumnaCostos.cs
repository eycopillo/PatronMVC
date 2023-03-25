using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatronMVC.Migrations
{
    /// <inheritdoc />
    public partial class AgregamoscolumnaCostos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "costo",
                table: "Departamentos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costo",
                table: "Departamentos");
        }
    }
}
