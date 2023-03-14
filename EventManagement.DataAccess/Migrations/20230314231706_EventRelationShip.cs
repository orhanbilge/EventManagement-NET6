using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.DataAccess.Migrations
{
    public partial class EventRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LessonId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClassRoomId",
                table: "Events",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_LessonId",
                table: "Events",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TeacherId",
                table: "Events",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_ClassRooms_ClassRoomId",
                table: "Events",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Lessons_LessonId",
                table: "Events",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_ClassRooms_ClassRoomId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Lessons_LessonId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Teachers_TeacherId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ClassRoomId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_LessonId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_TeacherId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "LessonId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Events");
        }
    }
}
