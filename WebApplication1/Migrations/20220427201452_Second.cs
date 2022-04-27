using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MotoristasVeiculos_Motoristas_MotoristaId",
                table: "MotoristasVeiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_MotoristasVeiculos_Veiculos_VeiculoId",
                table: "MotoristasVeiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotoristasVeiculos",
                table: "MotoristasVeiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Motoristas",
                table: "Motoristas");

            migrationBuilder.RenameTable(
                name: "Veiculos",
                newName: "tbl_veiculo");

            migrationBuilder.RenameTable(
                name: "MotoristasVeiculos",
                newName: "tbl_m_v");

            migrationBuilder.RenameTable(
                name: "Motoristas",
                newName: "tbl_motor");

            migrationBuilder.RenameColumn(
                name: "Placa",
                table: "tbl_veiculo",
                newName: "placa");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "tbl_veiculo",
                newName: "ano");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "tbl_veiculo",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "tbl_veiculo",
                newName: "veiculo_id");

            migrationBuilder.RenameColumn(
                name: "MotoristaId",
                table: "tbl_m_v",
                newName: "motor_id");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "tbl_m_v",
                newName: "veiculo_id");

            migrationBuilder.RenameIndex(
                name: "IX_MotoristasVeiculos_MotoristaId",
                table: "tbl_m_v",
                newName: "IX_tbl_m_v_motor_id");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "tbl_motor",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "MotoristaId",
                table: "tbl_motor",
                newName: "motor_id");

            migrationBuilder.AlterColumn<string>(
                name: "placa",
                table: "tbl_veiculo",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "tbl_veiculo",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "veiculo_id",
                table: "tbl_veiculo",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "motor_id",
                table: "tbl_m_v",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "veiculo_id",
                table: "tbl_m_v",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "tbl_motor",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "motor_id",
                table: "tbl_motor",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_veiculo",
                table: "tbl_veiculo",
                column: "veiculo_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_m_v",
                table: "tbl_m_v",
                columns: new[] { "veiculo_id", "motor_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_motor",
                table: "tbl_motor",
                column: "motor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_v_tbl_motor_motor_id",
                table: "tbl_m_v",
                column: "motor_id",
                principalTable: "tbl_motor",
                principalColumn: "motor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_v_tbl_veiculo_veiculo_id",
                table: "tbl_m_v",
                column: "veiculo_id",
                principalTable: "tbl_veiculo",
                principalColumn: "veiculo_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_v_tbl_motor_motor_id",
                table: "tbl_m_v");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_v_tbl_veiculo_veiculo_id",
                table: "tbl_m_v");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_veiculo",
                table: "tbl_veiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_motor",
                table: "tbl_motor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_m_v",
                table: "tbl_m_v");

            migrationBuilder.RenameTable(
                name: "tbl_veiculo",
                newName: "Veiculos");

            migrationBuilder.RenameTable(
                name: "tbl_motor",
                newName: "Motoristas");

            migrationBuilder.RenameTable(
                name: "tbl_m_v",
                newName: "MotoristasVeiculos");

            migrationBuilder.RenameColumn(
                name: "placa",
                table: "Veiculos",
                newName: "Placa");

            migrationBuilder.RenameColumn(
                name: "ano",
                table: "Veiculos",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Veiculos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "veiculo_id",
                table: "Veiculos",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Motoristas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "motor_id",
                table: "Motoristas",
                newName: "MotoristaId");

            migrationBuilder.RenameColumn(
                name: "motor_id",
                table: "MotoristasVeiculos",
                newName: "MotoristaId");

            migrationBuilder.RenameColumn(
                name: "veiculo_id",
                table: "MotoristasVeiculos",
                newName: "VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_m_v_motor_id",
                table: "MotoristasVeiculos",
                newName: "IX_MotoristasVeiculos_MotoristaId");

            migrationBuilder.AlterColumn<string>(
                name: "Placa",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Veiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VeiculoId",
                table: "Veiculos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Motoristas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "MotoristaId",
                table: "Motoristas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "MotoristaId",
                table: "MotoristasVeiculos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "VeiculoId",
                table: "MotoristasVeiculos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos",
                column: "VeiculoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motoristas",
                table: "Motoristas",
                column: "MotoristaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotoristasVeiculos",
                table: "MotoristasVeiculos",
                columns: new[] { "VeiculoId", "MotoristaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MotoristasVeiculos_Motoristas_MotoristaId",
                table: "MotoristasVeiculos",
                column: "MotoristaId",
                principalTable: "Motoristas",
                principalColumn: "MotoristaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MotoristasVeiculos_Veiculos_VeiculoId",
                table: "MotoristasVeiculos",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "VeiculoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
