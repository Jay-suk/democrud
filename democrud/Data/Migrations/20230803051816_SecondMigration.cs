using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace democrud.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Posts",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Posts",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNo",
                table: "Posts",
                type: "TEXT",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 1, "Demo", "Name1", "1234567891" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 2, "Demo", "Name2", "1234567892" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 3, "Demo", "Name3", "1234567893" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 4, "Demo", "Name4", "1234567894" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 5, "Demo", "Name5", "1234567895" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "Age", "FirstName", "LastName", "MobileNo" },
                values: new object[] { 6, "Demo", "Name6", "1234567896" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Posts",
                type: "TEXT",
                maxLength: 100000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Posts",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 1 and it has some very interesting content. I have also liked the video and subscribed.", "Post 1" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 2 and it has some very interesting content. I have also liked the video and subscribed.", "Post 2" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 3 and it has some very interesting content. I have also liked the video and subscribed.", "Post 3" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 4 and it has some very interesting content. I have also liked the video and subscribed.", "Post 4" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 5 and it has some very interesting content. I have also liked the video and subscribed.", "Post 5" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "Content", "Title" },
                values: new object[] { "This is post 6 and it has some very interesting content. I have also liked the video and subscribed.", "Post 6" });
        }
    }
}
