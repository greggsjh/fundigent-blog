using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fundigent.Blog.Data.Migrations
{
    public partial class FundigentDbSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("92e9bd4c-be55-4c85-9cf4-b3ade63b0562"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(3160), new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b7b33fe3-7981-4a16-9253-f927c4b901fa"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(4450), new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 6, 12, 10, 35, 21, DateTimeKind.Local).AddTicks(2640), new DateTime(2020, 5, 6, 12, 10, 35, 37, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogCategory", "CreatedDate", "ModifiedDate", "Text", "Title" },
                values: new object[] { new Guid("c2e1b06c-42c8-4a6e-ae9b-cd1e12769b09"), 3, new DateTime(2020, 5, 6, 12, 10, 35, 37, DateTimeKind.Local).AddTicks(9680), new DateTime(2020, 5, 6, 12, 10, 35, 37, DateTimeKind.Local).AddTicks(9700), @"What is a data structure?
                  <ul>
                    <li>Data structure – classes that are used to organize data and provide various operations on that data; organize and operate on data.</li>
                  </ul>
                  How is the efficiency of data structures analyzed?
                  <ul>
                   	<li>Asymptotic analysis (Big-Oh) – a method of analysis that measures how the efficiency of a data structure changes as the data structure’s size approaches infinity.</li>
                    <li>Asymptotic analysis steps</li>
                    <ol>
                      <li>Determine the steps that constitute the algorithm’s running time. Typically, one should concern him or herself with steps that involve the data structure itself, NOT simple atomic operations performed by the computer.</li>
                      <li>Find the lines of code that perform the steps of interest in counting and put a ‘1’ next to each of these lines.</li>
                      <li>For each line with a ‘1’ next to it, see if said line is in a loop. If so, change the ‘1’ to ‘1’ times the maximum number of repetitions the loop may perform. If there are 2 or more nested loops, continue the multiplication for each loop.</li>
                      <li>Find the largest single term written above; this is the running time.</li>
                    </ol>
                  </ul>
                  Why is the analysis of efficiency important?
                  <ul>
                    <li>The analysis of efficiency is important when choosing the data structure and algorithm to use when solving a problem in the real-world. It is not a definitive method of choosing an algorithm, but can be used as part of the process. One algorithm may outperform another when working on sufficiently sized data depending further upon the specific implementation.</li>
                  </ul>
                  Types of data structures:
                  <ul>
                    <li>Array – contains a homogeneous, contiguous collection of data items that can be accessed by an ordinal index; one of the most common data structures.</li>
                    <li>List – contains a homogeneous, contiguous collection of data items that can be accessed by an ordinal index; similar to an array with the exception that the size does not need to be constant as is required by an array.</li>
                    <li>Queue</li>
                    <li>Stack</li>
                    <li>Hashtable</li>
                    <li>Graph</li>
                    <li>Skip List</li>
                    <li>Sets</li>
                    <li>Disjoint sets</li>
                  </ul>
                  ", "Data Structures Overview" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83e657b6-a4c2-4dc0-bff1-0059bf96334e"),
                columns: new[] { "DisplayName", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { "BlueJay", "jay999@gmail.com", "Jay", "Gee", "jhg" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "ModifiedDate", "PostId", "Text", "UserId" },
                values: new object[] { new Guid("6d30db38-f440-476a-a99b-046837148788"), new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(4500), new DateTime(2020, 5, 6, 12, 10, 35, 38, DateTimeKind.Local).AddTicks(4500), new Guid("c2e1b06c-42c8-4a6e-ae9b-cd1e12769b09"), "Another Good One! Thanks for the overview.", new Guid("183fbe51-5258-49b4-9231-55829c18d8c9") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6d30db38-f440-476a-a99b-046837148788"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c2e1b06c-42c8-4a6e-ae9b-cd1e12769b09"));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("92e9bd4c-be55-4c85-9cf4-b3ade63b0562"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(1810), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b7b33fe3-7981-4a16-9253-f927c4b901fa"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2870), new DateTime(2020, 5, 5, 16, 59, 38, 897, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("16e9c70e-14bd-411c-ab9a-fba51f2f4610"),
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2020, 5, 5, 16, 59, 38, 879, DateTimeKind.Local).AddTicks(4850), new DateTime(2020, 5, 5, 16, 59, 38, 896, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83e657b6-a4c2-4dc0-bff1-0059bf96334e"),
                columns: new[] { "DisplayName", "Email", "FirstName", "LastName", "UserName" },
                values: new object[] { "JayGregg100", "jaygregg100@gmail.com", "Jamison", "Greggs", "greggsjh" });
        }
    }
}
