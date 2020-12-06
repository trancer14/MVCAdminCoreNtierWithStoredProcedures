using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminMVCCore.Dal.Migrations
{
    public partial class spUpdateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"create procedure [dbo].[UpdateCustomers]
                    @CustomerId int,
                    @FirstName varchar(50),
                    @LAstName varchar(50),
                    @City varchar(50),
                    @TC bigint,
                    @Phone bigint
                AS
            update [ademdkaya].[Customers] set CustomerFirstName=@FirstName,CustomerLastName=@LastName,CustomerCity=@City,CustomerIdentityNumber=@TC,CustomerPhone=@Phone where @CustomerId=Id
        ";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
