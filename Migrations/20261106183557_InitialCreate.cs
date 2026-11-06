using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HimeraLab.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreatureTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenerationTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RelatedCharacteristic = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeedTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TypeSpeed = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeedTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<string>(type: "text", nullable: false),
                    AC = table.Column<int>(type: "integer", nullable: false),
                    HP = table.Column<int>(type: "integer", nullable: false),
                    CR = table.Column<float>(type: "real", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Dexterity = table.Column<int>(type: "integer", nullable: false),
                    Constitution = table.Column<int>(type: "integer", nullable: false),
                    Intelligence = table.Column<int>(type: "integer", nullable: false),
                    Wisdom = table.Column<int>(type: "integer", nullable: false),
                    Charisma = table.Column<int>(type: "integer", nullable: false),
                    Profficiency_bonus = table.Column<int>(type: "integer", nullable: false),
                    IdType = table.Column<int>(type: "integer", nullable: false),
                    CreatureTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creatures_CreatureTypes_CreatureTypeId",
                        column: x => x.CreatureTypeId,
                        principalTable: "CreatureTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    IdRole = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActionCreatures",
                columns: table => new
                {
                    IdAction = table.Column<int>(type: "integer", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    ActionId = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionCreatures", x => new { x.IdCreature, x.IdAction });
                    table.ForeignKey(
                        name: "FK_ActionCreatures_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActionCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AttackBonus = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Characteristic = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    IdDamage = table.Column<int>(type: "integer", nullable: true),
                    DamageTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attacks_Creatures_IdCreature",
                        column: x => x.IdCreature,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attacks_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatureFeats",
                columns: table => new
                {
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    IdFeat = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    FeatId = table.Column<int>(type: "integer", nullable: false),
                    FeatType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureFeats", x => new { x.IdCreature, x.IdFeat });
                    table.ForeignKey(
                        name: "FK_CreatureFeats_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureFeats_Feats_FeatId",
                        column: x => x.FeatId,
                        principalTable: "Feats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenerationTableCreatures",
                columns: table => new
                {
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    IdTable = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    TableId = table.Column<int>(type: "integer", nullable: false),
                    RangeMin = table.Column<int>(type: "integer", nullable: false),
                    RangeMax = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenerationTableCreatures", x => new { x.IdTable, x.IdCreature });
                    table.ForeignKey(
                        name: "FK_GenerationTableCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenerationTableCreatures_GenerationTables_TableId",
                        column: x => x.TableId,
                        principalTable: "GenerationTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguageCreatures",
                columns: table => new
                {
                    IdLanguage = table.Column<int>(type: "integer", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    CanSpeak = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageCreatures", x => new { x.IdCreature, x.IdLanguage });
                    table.ForeignKey(
                        name: "FK_LanguageCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguageCreatures_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrowCreatures",
                columns: table => new
                {
                    IdSave = table.Column<int>(type: "integer", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    SavingThrowId = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrowCreatures", x => new { x.IdCreature, x.IdSave });
                    table.ForeignKey(
                        name: "FK_SavingThrowCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SavingThrowCreatures_SavingThrows_SavingThrowId",
                        column: x => x.SavingThrowId,
                        principalTable: "SavingThrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillCreatures",
                columns: table => new
                {
                    IdSkill = table.Column<int>(type: "integer", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    DoubleProficiency = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCreatures", x => new { x.IdCreature, x.IdSkill });
                    table.ForeignKey(
                        name: "FK_SkillCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillCreatures_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeedCreatures",
                columns: table => new
                {
                    IdSpeed = table.Column<int>(type: "integer", nullable: false),
                    IdCreature = table.Column<int>(type: "integer", nullable: false),
                    SpeedTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeedCreatures", x => new { x.IdCreature, x.IdSpeed });
                    table.ForeignKey(
                        name: "FK_SpeedCreatures_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeedCreatures_SpeedTypes_SpeedTypeId",
                        column: x => x.SpeedTypeId,
                        principalTable: "SpeedTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<int>(type: "integer", nullable: false),
                    IdHybrid = table.Column<int>(type: "integer", nullable: true),
                    IdBase = table.Column<int>(type: "integer", nullable: true),
                    IdDonor = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedItems_Creatures_IdBase",
                        column: x => x.IdBase,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedItems_Creatures_IdDonor",
                        column: x => x.IdDonor,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedItems_Creatures_IdHybrid",
                        column: x => x.IdHybrid,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SavedItems_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "user" },
                    { 2, "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionCreatures_ActionId",
                table: "ActionCreatures",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActionCreatures_CreatureId",
                table: "ActionCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_DamageTypeId",
                table: "Attacks",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_IdCreature",
                table: "Attacks",
                column: "IdCreature");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureFeats_CreatureId",
                table: "CreatureFeats",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureFeats_FeatId",
                table: "CreatureFeats",
                column: "FeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_CreatureTypeId",
                table: "Creatures",
                column: "CreatureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationTableCreatures_CreatureId",
                table: "GenerationTableCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_GenerationTableCreatures_IdTable_RangeMin",
                table: "GenerationTableCreatures",
                columns: new[] { "IdTable", "RangeMin" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenerationTableCreatures_TableId",
                table: "GenerationTableCreatures",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageCreatures_CreatureId",
                table: "LanguageCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageCreatures_LanguageId",
                table: "LanguageCreatures",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedItems_IdBase",
                table: "SavedItems",
                column: "IdBase");

            migrationBuilder.CreateIndex(
                name: "IX_SavedItems_IdDonor",
                table: "SavedItems",
                column: "IdDonor");

            migrationBuilder.CreateIndex(
                name: "IX_SavedItems_IdHybrid",
                table: "SavedItems",
                column: "IdHybrid");

            migrationBuilder.CreateIndex(
                name: "IX_SavedItems_IdUser",
                table: "SavedItems",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrowCreatures_CreatureId",
                table: "SavingThrowCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrowCreatures_SavingThrowId",
                table: "SavingThrowCreatures",
                column: "SavingThrowId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillCreatures_CreatureId",
                table: "SkillCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillCreatures_SkillId",
                table: "SkillCreatures",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedCreatures_CreatureId",
                table: "SpeedCreatures",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedCreatures_SpeedTypeId",
                table: "SpeedCreatures",
                column: "SpeedTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionCreatures");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "CreatureFeats");

            migrationBuilder.DropTable(
                name: "GenerationTableCreatures");

            migrationBuilder.DropTable(
                name: "LanguageCreatures");

            migrationBuilder.DropTable(
                name: "SavedItems");

            migrationBuilder.DropTable(
                name: "SavingThrowCreatures");

            migrationBuilder.DropTable(
                name: "SkillCreatures");

            migrationBuilder.DropTable(
                name: "SpeedCreatures");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "GenerationTables");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SavingThrows");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "SpeedTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "CreatureTypes");
        }
    }
}
