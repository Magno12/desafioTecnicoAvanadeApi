using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafioTecnicoAvanadeApi.infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class createInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaClientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaProdutos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientePedidoId = table.Column<int>(type: "int", nullable: false),
                    PedidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaPedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabelaPedidos_TabelaClientes_ClientePedidoId",
                        column: x => x.ClientePedidoId,
                        principalTable: "TabelaClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabelaPedidos_TabelaPedidos_PedidosId",
                        column: x => x.PedidosId,
                        principalTable: "TabelaPedidos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TabelaPedidos_ClientePedidoId",
                table: "TabelaPedidos",
                column: "ClientePedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelaPedidos_PedidosId",
                table: "TabelaPedidos",
                column: "PedidosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaPedidos");

            migrationBuilder.DropTable(
                name: "TabelaProdutos");

            migrationBuilder.DropTable(
                name: "TabelaClientes");
        }
    }
}
