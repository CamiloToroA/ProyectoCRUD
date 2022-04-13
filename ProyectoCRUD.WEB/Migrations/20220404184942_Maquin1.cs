using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCRUD.WEB.Migrations
{
    public partial class Maquin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maquinas",
                columns: table => new
                {
                    IdMaquina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMaquina = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Componentes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(180)", nullable: true),
                    Voltaje = table.Column<string>(type: "nvarchar(180)", nullable: true),
                    Potencia = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Amperaje = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Velocidad = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProtectorTermico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CajaReductora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquinas", x => x.IdMaquina);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maquinas");
        }
    }
}
