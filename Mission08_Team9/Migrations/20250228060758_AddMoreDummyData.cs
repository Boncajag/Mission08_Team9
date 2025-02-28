using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission08_Team9.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 1, "2025-03-02", 1, "Call doctor for appointment" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 4,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, "2025-03-10", 1, "Submit tax documents" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CategoryId", "Completed", "DueDate", "Quadrant", "TaskName" },
                values: new object[,]
                {
                    { 5, 3, 0, "2025-03-10", 2, "Prepare for work presentation" },
                    { 6, 4, 0, "2025-03-15", 2, "Read book on leadership" },
                    { 7, 1, 0, "2025-03-12", 2, "Exercise for 30 mins" },
                    { 8, 1, 0, "2025-04-01", 2, "Plan summer vacation" },
                    { 9, 3, 0, "2025-03-06", 3, "Reply to random emails" },
                    { 10, 3, 0, "2025-03-07", 3, "Attend unnecessary meeting" },
                    { 11, 2, 0, "2025-03-08", 3, "Fix minor bug in personal project" },
                    { 12, 1, 0, "2025-03-09", 3, "Help friend move furniture" },
                    { 13, 1, 0, "2025-03-20", 4, "Watch Netflix series" },
                    { 14, 3, 0, "2025-03-21", 4, "Scroll through social media" },
                    { 15, 1, 0, "2025-03-22", 4, "Rearrange bookshelf" },
                    { 16, 1, 0, "2025-03-23", 4, "Play video games" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 3, "2025-03-10", 2, "Prepare for work presentation" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 4,
                columns: new[] { "CategoryId", "DueDate", "Quadrant", "TaskName" },
                values: new object[] { 4, "2025-03-15", 2, "Read book on leadership" });
        }
    }
}
