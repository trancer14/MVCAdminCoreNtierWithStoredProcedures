using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminMVCCore.Dal.Migrations
{
    public partial class spCreateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[CreateCustomer]
                    @FirstName varchar(50),
                    @LAstName varchar(50),
                    @City varchar(50),
                    @TC bigint,
                    @Phone bigint
                AS
                insert into [ademdkaya].[Customers](CustomerFirstName,CustomerLastName,CustomerCity,CustomerIdentityNumber,CustomerPhone) values (@FirstName,@LastName,@City,@TC,@Phone)               
                  ";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
