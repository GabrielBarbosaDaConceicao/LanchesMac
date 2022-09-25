using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS(CATEGORIANOME, DESCRICAO)" +
                "VALUES('Normal', 'Lanche feito com ingredientes normais.')");

            migrationBuilder.Sql("INSERT INTO CATEGORIAS(CATEGORIANOME, DESCRICAO) " +
                "VALUES('Natural', 'Lanche feito com ingredientes integrais e naturais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS");
        }
    }
}
