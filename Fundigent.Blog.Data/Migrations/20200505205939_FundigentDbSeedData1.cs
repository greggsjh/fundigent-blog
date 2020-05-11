using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fundigent.Blog.Data.Migrations
{
    public partial class FundigentDbSeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogRole",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Src",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Images",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogCategory", "CreatedDate", "ModifiedDate", "Text", "Title" },
                values: new object[] { new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"), 3, new DateTime(2020, 5, 5, 16, 59, 38, 879, DateTimeKind.Local).AddTicks(4850), new DateTime(2020, 5, 5, 16, 59, 38, 896, DateTimeKind.Local).AddTicks(7340), @"<p>Before we get into more specific details of what makes a web API RESTful, we should probably cover a
                      bit of history. Distributed computing is defined as the communication of one computing system with
                      another computing system where these systems are separated geographically and/or physically using
                      some network. Distributed computing has a long history, going back to the early days of computing and
                      networks. One of the most common ways that we utilize distributed systems today is with HTTP and the internet.</p>

                      <p>But what is REST? Well Representational State Transfer (REST) is an architectural principle or style that
                      says the transfer or modification of data or the state of data should represent the underlying resources
                      of the system providing that data. Additionally, the operations used to modify or transfer that data
                      should be pre-defined and stateless. So, for a web API, the resources that are represented are web
                      resources that map to contextual entities within our system. These contextual entities do not necessarily
                      map to the internal entities in our system, but can be any abstraction that can be named, addressed, or
                      otherwise identified. Also, because this is a Web API, we are using the HTTP protocol. Hyper-Text
                      Transfer Protocol (HTTP) is inherently stateless, so we have that covered and because HTTP also defines
                      a set of methods or verbs, we can use these to satisfy REST’s pre-defined operations requirement.</p>

                      <p>How is REST different from SOAP? Both REST and SOAP solve many of the same problems. It is deeper
                      than JSON vs XML (which can be supported using REST by the way). However, SOAP requires the use of
                      an arbitrary set of self-described operations. It can be argued, that REST provides a cleaner structure for
                      solving the same problems more easily.</p>

                      <p>In my next post, I will get into more of the details of how HTTP enables the creation of RESTful web APIs
                      and some considerations the proper design of your web API.</p> ", "Rest and Web APIs" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BlogRole", "DisplayName", "Email", "FirstName", "LastName", "MiddleName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("83e657b6-a4c2-4dc0-bff1-0059bf96334e"), 2, "JayGregg100", "jaygregg100@gmail.com", "Jamison", "Greggs", null, "P@ssword1", "greggsjh" },
                    { new Guid("35a1eba1-35dc-41e7-945b-8eca647f20ba"), 1, "Here's Johnny!", "johnnyt@test.com", "Johnny", "Test", null, "P@ssword1", "jtester" },
                    { new Guid("183fbe51-5258-49b4-9231-55829c18d8c9"), 1, "Jane", "jane.tester@test.com", "Jane", "Tester", null, "P@ssword1", "janetester" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "PostId", "Text", "UserId" },
                values: new object[] { new Guid("92e9bd4c-be55-4c85-9cf4-b3ade63b0562"), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(1810), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2310), new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"), "This is an awesome first article!", new Guid("35a1eba1-35dc-41e7-945b-8eca647f20ba") });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "PostId", "Text", "UserId" },
                values: new object[] { new Guid("b7b33fe3-7981-4a16-9253-f927c4b901fa"), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2870), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2890), new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"), "I agree with Johnny. This is great!", new Guid("183fbe51-5258-49b4-9231-55829c18d8c9") });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("92e9bd4c-be55-4c85-9cf4-b3ade63b0562"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b7b33fe3-7981-4a16-9253-f927c4b901fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83e657b6-a4c2-4dc0-bff1-0059bf96334e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("183fbe51-5258-49b4-9231-55829c18d8c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("35a1eba1-35dc-41e7-945b-8eca647f20ba"));

            migrationBuilder.DropColumn(
                name: "BlogRole",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Src",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 140);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Posts_PostId",
                table: "Images",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
