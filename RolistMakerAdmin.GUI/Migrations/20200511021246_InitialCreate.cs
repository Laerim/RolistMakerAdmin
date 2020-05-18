using Microsoft.EntityFrameworkCore.Migrations;

namespace RolistMakerAdmin.GUI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titre = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Race = table.Column<bool>(nullable: false),
                    Classe = table.Column<bool>(nullable: false),
                    Statistique = table.Column<bool>(nullable: false),
                    Competence = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClasseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClasseId);
                    table.ForeignKey(
                        name: "FK_Classes_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    CompetenceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.CompetenceId);
                    table.ForeignKey(
                        name: "FK_Competences_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Lien = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musiques",
                columns: table => new
                {
                    MusiqueId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Lien = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musiques", x => x.MusiqueId);
                    table.ForeignKey(
                        name: "FK_Musiques_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.PlaylistId);
                    table.ForeignKey(
                        name: "FK_Playlists_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexeId);
                    table.ForeignKey(
                        name: "FK_Sexes_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statistiques",
                columns: table => new
                {
                    StatistiqueId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistiques", x => x.StatistiqueId);
                    table.ForeignKey(
                        name: "FK_Statistiques_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClasseCompetences",
                columns: table => new
                {
                    ClasseId = table.Column<int>(nullable: false),
                    CompetenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasseCompetences", x => new { x.ClasseId, x.CompetenceId });
                    table.ForeignKey(
                        name: "FK_ClasseCompetences_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "ClasseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClasseCompetences_Competences_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competences",
                        principalColumn: "CompetenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lieus",
                columns: table => new
                {
                    LieuId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieus", x => x.LieuId);
                    table.ForeignKey(
                        name: "FK_Lieus_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lieus_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeObjets",
                columns: table => new
                {
                    TypeObjetId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeObjets", x => x.TypeObjetId);
                    table.ForeignKey(
                        name: "FK_TypeObjets_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypeObjets_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusiquePlaylists",
                columns: table => new
                {
                    MusiqueId = table.Column<int>(nullable: false),
                    PlaylistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusiquePlaylists", x => new { x.MusiqueId, x.PlaylistId });
                    table.ForeignKey(
                        name: "FK_MusiquePlaylists_Musiques_MusiqueId",
                        column: x => x.MusiqueId,
                        principalTable: "Musiques",
                        principalColumn: "MusiqueId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusiquePlaylists_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "PlaylistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnages",
                columns: table => new
                {
                    PersonnageId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SexeId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true),
                    RaceId = table.Column<int>(nullable: true),
                    ClasseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnages", x => x.PersonnageId);
                    table.ForeignKey(
                        name: "FK_Personnages_Classes_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classes",
                        principalColumn: "ClasseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnages_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnages_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnages_Sexes_SexeId",
                        column: x => x.SexeId,
                        principalTable: "Sexes",
                        principalColumn: "SexeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LieuMusiques",
                columns: table => new
                {
                    LieuId = table.Column<int>(nullable: false),
                    MusiqueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LieuMusiques", x => new { x.LieuId, x.MusiqueId });
                    table.ForeignKey(
                        name: "FK_LieuMusiques_Lieus_LieuId",
                        column: x => x.LieuId,
                        principalTable: "Lieus",
                        principalColumn: "LieuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LieuMusiques_Musiques_MusiqueId",
                        column: x => x.MusiqueId,
                        principalTable: "Musiques",
                        principalColumn: "MusiqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Objets",
                columns: table => new
                {
                    ObjetId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypeObjetId = table.Column<int>(nullable: true),
                    GameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objets", x => x.ObjetId);
                    table.ForeignKey(
                        name: "FK_Objets_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Objets_TypeObjets_TypeObjetId",
                        column: x => x.TypeObjetId,
                        principalTable: "TypeObjets",
                        principalColumn: "TypeObjetId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonnageCompetences",
                columns: table => new
                {
                    PersonnageId = table.Column<int>(nullable: false),
                    CompetenceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnageCompetences", x => new { x.PersonnageId, x.CompetenceId });
                    table.ForeignKey(
                        name: "FK_PersonnageCompetences_Competences_CompetenceId",
                        column: x => x.CompetenceId,
                        principalTable: "Competences",
                        principalColumn: "CompetenceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnageCompetences_Personnages_PersonnageId",
                        column: x => x.PersonnageId,
                        principalTable: "Personnages",
                        principalColumn: "PersonnageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnageStatistiques",
                columns: table => new
                {
                    PersonnageId = table.Column<int>(nullable: false),
                    StatistiqueId = table.Column<int>(nullable: false),
                    Max = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnageStatistiques", x => new { x.PersonnageId, x.StatistiqueId });
                    table.ForeignKey(
                        name: "FK_PersonnageStatistiques_Personnages_PersonnageId",
                        column: x => x.PersonnageId,
                        principalTable: "Personnages",
                        principalColumn: "PersonnageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnageStatistiques_Statistiques_StatistiqueId",
                        column: x => x.StatistiqueId,
                        principalTable: "Statistiques",
                        principalColumn: "StatistiqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnageObjets",
                columns: table => new
                {
                    PersonnageId = table.Column<int>(nullable: false),
                    ObjetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnageObjets", x => new { x.PersonnageId, x.ObjetId });
                    table.ForeignKey(
                        name: "FK_PersonnageObjets_Objets_ObjetId",
                        column: x => x.ObjetId,
                        principalTable: "Objets",
                        principalColumn: "ObjetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnageObjets_Personnages_PersonnageId",
                        column: x => x.PersonnageId,
                        principalTable: "Personnages",
                        principalColumn: "PersonnageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatistiqueObjets",
                columns: table => new
                {
                    StatistiqueId = table.Column<int>(nullable: false),
                    ObjetId = table.Column<int>(nullable: false),
                    Bonus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatistiqueObjets", x => new { x.StatistiqueId, x.ObjetId });
                    table.ForeignKey(
                        name: "FK_StatistiqueObjets_Objets_ObjetId",
                        column: x => x.ObjetId,
                        principalTable: "Objets",
                        principalColumn: "ObjetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatistiqueObjets_Statistiques_StatistiqueId",
                        column: x => x.StatistiqueId,
                        principalTable: "Statistiques",
                        principalColumn: "StatistiqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClasseCompetences_CompetenceId",
                table: "ClasseCompetences",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_GameId",
                table: "Classes",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Competences_GameId",
                table: "Competences",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_GameId",
                table: "Images",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_LieuMusiques_MusiqueId",
                table: "LieuMusiques",
                column: "MusiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Lieus_GameId",
                table: "Lieus",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Lieus_ImageId",
                table: "Lieus",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MusiquePlaylists_PlaylistId",
                table: "MusiquePlaylists",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_Musiques_GameId",
                table: "Musiques",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Objets_GameId",
                table: "Objets",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Objets_TypeObjetId",
                table: "Objets",
                column: "TypeObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnageCompetences_CompetenceId",
                table: "PersonnageCompetences",
                column: "CompetenceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnageObjets_ObjetId",
                table: "PersonnageObjets",
                column: "ObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_ClasseId",
                table: "Personnages",
                column: "ClasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_GameId",
                table: "Personnages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_RaceId",
                table: "Personnages",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnages_SexeId",
                table: "Personnages",
                column: "SexeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnageStatistiques_StatistiqueId",
                table: "PersonnageStatistiques",
                column: "StatistiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_GameId",
                table: "Playlists",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_GameId",
                table: "Races",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Sexes_GameId",
                table: "Sexes",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_StatistiqueObjets_ObjetId",
                table: "StatistiqueObjets",
                column: "ObjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistiques_GameId",
                table: "Statistiques",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeObjets_GameId",
                table: "TypeObjets",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeObjets_ImageId",
                table: "TypeObjets",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClasseCompetences");

            migrationBuilder.DropTable(
                name: "LieuMusiques");

            migrationBuilder.DropTable(
                name: "MusiquePlaylists");

            migrationBuilder.DropTable(
                name: "PersonnageCompetences");

            migrationBuilder.DropTable(
                name: "PersonnageObjets");

            migrationBuilder.DropTable(
                name: "PersonnageStatistiques");

            migrationBuilder.DropTable(
                name: "StatistiqueObjets");

            migrationBuilder.DropTable(
                name: "Lieus");

            migrationBuilder.DropTable(
                name: "Musiques");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "Personnages");

            migrationBuilder.DropTable(
                name: "Objets");

            migrationBuilder.DropTable(
                name: "Statistiques");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "TypeObjets");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
