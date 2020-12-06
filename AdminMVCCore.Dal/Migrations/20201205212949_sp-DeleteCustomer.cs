using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminMVCCore.Dal.Migrations
{
    public partial class spDeleteCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"create procedure [dbo].[DeleteCustomer]
                       @id int
                        as
                       delete from [ademdkaya].[Customers] where @id=Id
                       ";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
