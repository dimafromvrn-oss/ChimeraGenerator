using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    id_action = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.id_action);
                });

            migrationBuilder.CreateTable(
                name: "Creature_types",
                columns: table => new
                {
                    id_type = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creature_types", x => x.id_type);
                });

            migrationBuilder.CreateTable(
                name: "Damage_types",
                columns: table => new
                {
                    id_damage = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damage_types", x => x.id_damage);
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    id_feat = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.id_feat);
                });

            migrationBuilder.CreateTable(
                name: "Generation_tables",
                columns: table => new
                {
                    id_table = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generation_tables", x => x.id_table);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    id_language = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.id_language);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    id_role = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.id_role);
                });

            migrationBuilder.CreateTable(
                name: "Saving_throws",
                columns: table => new
                {
                    id_save = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saving_throws", x => x.id_save);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    id_skill = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Related_characteristic = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.id_skill);
                });

            migrationBuilder.CreateTable(
                name: "Speed",
                columns: table => new
                {
                    id_speed = table.Column<Guid>(type: "uuid", nullable: false),
                    Type_speed = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speed", x => x.id_speed);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id_user = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Password_hash = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    id_role = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id_user);
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Size = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    AC = table.Column<int>(type: "integer", nullable: false),
                    HP = table.Column<int>(type: "integer", nullable: false),
                    HP_formula = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    CR = table.Column<float>(type: "real", nullable: false),
                    Strength = table.Column<short>(type: "SMALLINT", nullable: false),
                    Dexterity = table.Column<short>(type: "SMALLINT", nullable: false),
                    Constitution = table.Column<short>(type: "SMALLINT", nullable: false),
                    Intelligence = table.Column<short>(type: "SMALLINT", nullable: false),
                    Wisdom = table.Column<short>(type: "SMALLINT", nullable: false),
                    Charisma = table.Column<short>(type: "SMALLINT", nullable: false),
                    ProficiencyBonus = table.Column<short>(type: "SMALLINT", nullable: false),
                    id_type = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.id_creature);
                    table.ForeignKey(
                        name: "FK_Creatures_Creature_types_id_type",
                        column: x => x.id_type,
                        principalTable: "Creature_types",
                        principalColumn: "id_type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actions_Creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_action = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions_Creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Actions_Creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    id_attack = table.Column<Guid>(type: "uuid", nullable: false),
                    Attack_bonus = table.Column<int>(type: "integer", nullable: false),
                    Damage = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Characteristic = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    id_damage = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.id_attack);
                    table.ForeignKey(
                        name: "FK_Attacks_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Creatures_Feats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    id_feat = table.Column<Guid>(type: "uuid", nullable: false),
                    Feat_type = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures_Feats", x => x.id);
                    table.ForeignKey(
                        name: "FK_Creatures_Feats_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Generation_tables_Creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_table = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    Range_min = table.Column<int>(type: "integer", nullable: false),
                    Range_max = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generation_tables_Creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Generation_tables_Creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Generation_tables_Creatures_Generation_tables_id_table",
                        column: x => x.id_table,
                        principalTable: "Generation_tables",
                        principalColumn: "id_table",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages_Creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_language = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    Can_speak = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages_Creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Languages_Creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saved",
                columns: table => new
                {
                    id_saved = table.Column<Guid>(type: "uuid", nullable: false),
                    id_user = table.Column<Guid>(type: "uuid", nullable: false),
                    id_hybrid = table.Column<Guid>(type: "uuid", nullable: true),
                    id_base = table.Column<Guid>(type: "uuid", nullable: true),
                    id_donor = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saved", x => x.id_saved);
                    table.ForeignKey(
                        name: "FK_Saved_Creatures_id_base",
                        column: x => x.id_base,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saved_Creatures_id_donor",
                        column: x => x.id_donor,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saved_Creatures_id_hybrid",
                        column: x => x.id_hybrid,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Saved_Users_id_user",
                        column: x => x.id_user,
                        principalTable: "Users",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saving_throws_creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_save = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saving_throws_creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Saving_throws_creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills_Creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_skill = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    Double_proficiency = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills_Creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Skills_Creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speed_Creatures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    id_speed = table.Column<Guid>(type: "uuid", nullable: false),
                    id_creature = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speed_Creatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Speed_Creatures_Creatures_id_creature",
                        column: x => x.id_creature,
                        principalTable: "Creatures",
                        principalColumn: "id_creature",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "id_role", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "user" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_Creatures_id_creature_id_action",
                table: "Actions_Creatures",
                columns: new[] { "id_creature", "id_action" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_id_creature",
                table: "Attacks",
                column: "id_creature");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_id_type",
                table: "Creatures",
                column: "id_type");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_Feats_id_creature_id_feat",
                table: "Creatures_Feats",
                columns: new[] { "id_creature", "id_feat" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Generation_tables_Creatures_id_creature",
                table: "Generation_tables_Creatures",
                column: "id_creature");

            migrationBuilder.CreateIndex(
                name: "IX_Generation_tables_Creatures_id_table_id_creature",
                table: "Generation_tables_Creatures",
                columns: new[] { "id_table", "id_creature" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Creatures_id_creature_id_language",
                table: "Languages_Creatures",
                columns: new[] { "id_creature", "id_language" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Saved_id_base",
                table: "Saved",
                column: "id_base");

            migrationBuilder.CreateIndex(
                name: "IX_Saved_id_donor",
                table: "Saved",
                column: "id_donor");

            migrationBuilder.CreateIndex(
                name: "IX_Saved_id_hybrid",
                table: "Saved",
                column: "id_hybrid");

            migrationBuilder.CreateIndex(
                name: "IX_Saved_id_user",
                table: "Saved",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_Saving_throws_creatures_id_creature_id_save",
                table: "Saving_throws_creatures",
                columns: new[] { "id_creature", "id_save" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_Creatures_id_creature_id_skill",
                table: "Skills_Creatures",
                columns: new[] { "id_creature", "id_skill" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Speed_Creatures_id_creature_id_speed",
                table: "Speed_Creatures",
                columns: new[] { "id_creature", "id_speed" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Actions_Creatures");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Creatures_Feats");

            migrationBuilder.DropTable(
                name: "Damage_types");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "Generation_tables_Creatures");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Languages_Creatures");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Saved");

            migrationBuilder.DropTable(
                name: "Saving_throws");

            migrationBuilder.DropTable(
                name: "Saving_throws_creatures");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Skills_Creatures");

            migrationBuilder.DropTable(
                name: "Speed");

            migrationBuilder.DropTable(
                name: "Speed_Creatures");

            migrationBuilder.DropTable(
                name: "Generation_tables");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Creature_types");
        }
    }
}
