using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Service.UserManagementAPI.Migrations
{
    public partial class loginusermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loginTbls",
                columns: table => new
                {
                    guid = table.Column<Guid>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginTbls", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "userRoleTbls",
                columns: table => new
                {
                    roleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rolename = table.Column<string>(nullable: true),
                    guid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoleTbls", x => x.roleid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loginTbls");

            migrationBuilder.DropTable(
                name: "userRoleTbls");
        }
    }
}
