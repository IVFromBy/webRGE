using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webRGE.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EGR01",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NKNOTREG = table.Column<int>(type: "int", nullable: true),
                    NKSCRT = table.Column<int>(type: "int", nullable: true),
                    NKSLKV = table.Column<int>(type: "int", nullable: true),
                    NKSOST = table.Column<int>(type: "int", nullable: true),
                    NKUZ = table.Column<int>(type: "int", nullable: true),
                    NKUZCRT = table.Column<int>(type: "int", nullable: true),
                    NKUZLKV = table.Column<int>(type: "int", nullable: true),
                    NKVOB = table.Column<int>(type: "int", nullable: true),
                    NSI00208 = table.Column<int>(type: "int", nullable: true),
                    NSI00211 = table.Column<int>(type: "int", nullable: true),
                    NSI00212 = table.Column<int>(type: "int", nullable: true),
                    NSI00212CRT = table.Column<int>(type: "int", nullable: true),
                    NSI00212LKV = table.Column<int>(type: "int", nullable: true),
                    NSI00219 = table.Column<int>(type: "int", nullable: true),
                    NSI00228 = table.Column<int>(type: "int", nullable: true),
                    NSI00243 = table.Column<int>(type: "int", nullable: true),
                    VNRCRT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNRLKV = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR01", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR01NAME",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGRN = table.Column<int>(type: "int", nullable: true),
                    NKSOST = table.Column<int>(type: "int", nullable: true),
                    NSI00219 = table.Column<int>(type: "int", nullable: true),
                    VFIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR01NAME", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0301",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOCEND = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NGRNS = table.Column<long>(type: "bigint", nullable: true),
                    NGRNTEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINDEX = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKSTRANI = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NKVALUT = table.Column<int>(type: "int", nullable: true),
                    NKVDOK = table.Column<int>(type: "int", nullable: true),
                    NKVOBS = table.Column<int>(type: "int", nullable: true),
                    NPOL = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00201I = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00204 = table.Column<int>(type: "int", nullable: true),
                    NSI00206 = table.Column<int>(type: "int", nullable: true),
                    NSI00211S = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NUF = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFA = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFI = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFM = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFP = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUNN = table.Column<int>(type: "int", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCORG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCSER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VMR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0301", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0302",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOCA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOCAEND = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOCEND = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NGRNS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NGRNTEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINDEX = table.Column<int>(type: "int", nullable: true),
                    NKDOLGN = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NKVDOK = table.Column<int>(type: "int", nullable: true),
                    NKVDOKA = table.Column<int>(type: "int", nullable: true),
                    NPOL = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00206 = table.Column<int>(type: "int", nullable: true),
                    NSI00206A = table.Column<int>(type: "int", nullable: true),
                    NSI00207 = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NUNN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCANUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCORG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCSER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VMR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELHOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELSOT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELWORK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0302", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0303",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NGRNTEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINDEX = table.Column<long>(type: "bigint", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NUNN = table.Column<int>(type: "int", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0303", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0305",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NSI00114 = table.Column<int>(type: "int", nullable: true),
                    VKVDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0305", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0313",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NGRNTEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINDEX = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NUNN = table.Column<int>(type: "int", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFNB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0313", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0315",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NSI00114 = table.Column<int>(type: "int", nullable: true),
                    VKVDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0315", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0316",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NSI00114 = table.Column<int>(type: "int", nullable: true),
                    VKVDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0316", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0318",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<int>(type: "int", nullable: true),
                    NKLVD = table.Column<long>(type: "bigint", nullable: true),
                    NSI00230 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0318", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0321",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NINDEX = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NKVPOM = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00234 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFAX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VSITE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0321", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0331",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NGRNTEMP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NINDEX = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NSI00201 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00226 = table.Column<int>(type: "int", nullable: true),
                    NSI00227 = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NUNN = table.Column<long>(type: "bigint", nullable: true),
                    VADRPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDISTRICT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VEMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFNB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKORP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPOM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTELS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VULITSA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0331", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0332",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<int>(type: "int", nullable: true),
                    VFN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFNB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNAIMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNB = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0332", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0355",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    VCPD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VCPDDOP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0355", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0356",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NSI00114 = table.Column<int>(type: "int", nullable: true),
                    VKVDN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0356", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0357",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NKFFS = table.Column<int>(type: "int", nullable: true),
                    NKFOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKFOPF = table.Column<int>(type: "int", nullable: true),
                    NKOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKOPF = table.Column<int>(type: "int", nullable: true),
                    NKVFS = table.Column<int>(type: "int", nullable: true),
                    NSI00012 = table.Column<int>(type: "int", nullable: true),
                    NSI00113 = table.Column<int>(type: "int", nullable: true),
                    NSI00203 = table.Column<int>(type: "int", nullable: true),
                    NSI00221 = table.Column<int>(type: "int", nullable: true),
                    NSI00222 = table.Column<int>(type: "int", nullable: true),
                    NSI00246 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0357", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0358",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NDG = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NDGI = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NDGM = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NKTUF = table.Column<int>(type: "int", nullable: true),
                    NKVALUT = table.Column<int>(type: "int", nullable: true),
                    NKVSUF = table.Column<int>(type: "int", nullable: true),
                    NSDBI = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NSDII = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NSI00204 = table.Column<int>(type: "int", nullable: true),
                    NSI00217 = table.Column<int>(type: "int", nullable: true),
                    NSI00218 = table.Column<int>(type: "int", nullable: true),
                    NSPBI = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NSPII = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUF = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFAM = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFAQ = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFI = table.Column<decimal>(type: "decimal(23,6)", nullable: true),
                    NUFM = table.Column<decimal>(type: "decimal(23,6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0358", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0359",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOPINFO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    VSOC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0359", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR0360",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CINCL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DCRTA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DDOCEND = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLVDA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04003 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NKVDOK = table.Column<int>(type: "int", nullable: true),
                    NPOL = table.Column<int>(type: "int", nullable: true),
                    NSI00206 = table.Column<int>(type: "int", nullable: true),
                    VDOCNUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCORG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VDOCSER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VFIOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VMR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VPRIM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR0360", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR04D",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04004 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04004A = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<long>(type: "bigint", nullable: true),
                    NKOP = table.Column<int>(type: "int", nullable: true),
                    NSI00223 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR04D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGR04G",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DDOC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DSROK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NGR04001 = table.Column<long>(type: "bigint", nullable: true),
                    NGR04004 = table.Column<long>(type: "bigint", nullable: true),
                    NGRN = table.Column<int>(type: "int", nullable: true),
                    NKOP = table.Column<int>(type: "int", nullable: true),
                    NKOSN = table.Column<int>(type: "int", nullable: true),
                    NKUZ = table.Column<int>(type: "int", nullable: true),
                    NKUZD = table.Column<int>(type: "int", nullable: true),
                    NKUZR = table.Column<int>(type: "int", nullable: true),
                    NSI00212 = table.Column<int>(type: "int", nullable: true),
                    NSI00212D = table.Column<int>(type: "int", nullable: true),
                    NSI00212R = table.Column<int>(type: "int", nullable: true),
                    NSI00213 = table.Column<int>(type: "int", nullable: true),
                    NSI00223 = table.Column<int>(type: "int", nullable: true),
                    VDOCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNRESH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGR04G", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TSI00012",
                columns: table => new
                {
                    NSI00012 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVFS = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNVFSK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVFSP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00012", x => x.NSI00012);
                });

            migrationBuilder.CreateTable(
                name: "TSI00113",
                columns: table => new
                {
                    NSI00113 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKSOOU = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSI00113S = table.Column<long>(type: "bigint", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VKOKOGUK2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKOKOGUK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKOKOGUP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00113", x => x.NSI00113);
                });

            migrationBuilder.CreateTable(
                name: "TSI00114",
                columns: table => new
                {
                    NSI00114 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOLD = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VKVDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVDNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVDNP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00114", x => x.NSI00114);
                });

            migrationBuilder.CreateTable(
                name: "TSI00201",
                columns: table => new
                {
                    NSI00201 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKSTRAN = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VALFA2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALFA3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSTRANK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSTRANP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00201", x => x.NSI00201);
                });

            migrationBuilder.CreateTable(
                name: "TSI00202",
                columns: table => new
                {
                    NSI00202 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CATNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CATNAMECONV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CATSHORTNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COMMENTARY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CTAE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NAMEDISTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAMEREGION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKCATEGORY = table.Column<int>(type: "int", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSI00239 = table.Column<int>(type: "int", nullable: true),
                    NSI00245 = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    OBJECTNUMBER = table.Column<int>(type: "int", nullable: true),
                    SOATODEPEND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UIDOPERIN = table.Column<int>(type: "int", nullable: true),
                    UIDOPEROUT = table.Column<int>(type: "int", nullable: true),
                    VAL_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VKSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNCENTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSFULL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSOATO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSSHORT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VSELSOVET = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00202", x => x.NSI00202);
                });

            migrationBuilder.CreateTable(
                name: "TSI00203",
                columns: table => new
                {
                    NSI00203 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKOPF = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NMUF = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VCONTAINEDWORDS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFBP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFEBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFEBP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFEK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPFP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00203", x => x.NSI00203);
                });

            migrationBuilder.CreateTable(
                name: "TSI00204",
                columns: table => new
                {
                    NSI00204 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVALUT = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VCOUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVALUTK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVALUTP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00204", x => x.NSI00204);
                });

            migrationBuilder.CreateTable(
                name: "TSI00206",
                columns: table => new
                {
                    NSI00206 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVDOK = table.Column<int>(type: "int", nullable: true),
                    NKVOB = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSI00211 = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VANSWER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VCLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVDOK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVDOKK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVDOKRP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00206", x => x.NSI00206);
                });

            migrationBuilder.CreateTable(
                name: "TSI00207",
                columns: table => new
                {
                    NSI00207 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKDOLGN = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNDOLGNK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNDOLGNP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00207", x => x.NSI00207);
                });

            migrationBuilder.CreateTable(
                name: "TSI00208",
                columns: table => new
                {
                    NSI00208 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKSCRT = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNSCRTK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSCRTP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00208", x => x.NSI00208);
                });

            migrationBuilder.CreateTable(
                name: "TSI00211",
                columns: table => new
                {
                    NSI00211 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVOB = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNVOBK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVOBP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00211", x => x.NSI00211);
                });

            migrationBuilder.CreateTable(
                name: "TSI00212",
                columns: table => new
                {
                    NSI00212 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NKFOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKIND = table.Column<int>(type: "int", nullable: true),
                    NKLOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKOKPO = table.Column<int>(type: "int", nullable: true),
                    NKSOATO = table.Column<long>(type: "bigint", nullable: true),
                    NKUZ = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKUZS = table.Column<int>(type: "int", nullable: true),
                    NKUZTO = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSI00113 = table.Column<int>(type: "int", nullable: true),
                    NSI00202 = table.Column<int>(type: "int", nullable: true),
                    NSI00212S = table.Column<int>(type: "int", nullable: true),
                    NSI00221 = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    NUNN = table.Column<long>(type: "bigint", nullable: true),
                    VDBLINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPKPP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPKPR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNUZK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNUZP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VUSRNAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00212", x => x.NSI00212);
                });

            migrationBuilder.CreateTable(
                name: "TSI00213",
                columns: table => new
                {
                    NSI00213 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKOSN = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNOSN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00213", x => x.NSI00213);
                });

            migrationBuilder.CreateTable(
                name: "TSI00217",
                columns: table => new
                {
                    NSI00217 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKTUF = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNTUFK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNTUFP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00217", x => x.NSI00217);
                });

            migrationBuilder.CreateTable(
                name: "TSI00218",
                columns: table => new
                {
                    NSI00218 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVSUF = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNVSUFK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNVSUFP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00218", x => x.NSI00218);
                });

            migrationBuilder.CreateTable(
                name: "TSI00219",
                columns: table => new
                {
                    NSI00219 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKSOST = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNSOSTK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSOSTP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00219", x => x.NSI00219);
                });

            migrationBuilder.CreateTable(
                name: "TSI00221",
                columns: table => new
                {
                    NSI00221 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKFOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNFOKOGU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00221", x => x.NSI00221);
                });

            migrationBuilder.CreateTable(
                name: "TSI00222",
                columns: table => new
                {
                    NSI00222 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKFOPF = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNFOPF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00222", x => x.NSI00222);
                });

            migrationBuilder.CreateTable(
                name: "TSI00223",
                columns: table => new
                {
                    NSI00223 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NFIX = table.Column<int>(type: "int", nullable: true),
                    NKOP = table.Column<int>(type: "int", nullable: true),
                    NKOPA = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NMAIN = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NREAL = table.Column<int>(type: "int", nullable: true),
                    NSI00223A = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNOP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPKORR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNOPREP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00223", x => x.NSI00223);
                });

            migrationBuilder.CreateTable(
                name: "TSI00226",
                columns: table => new
                {
                    NSI00226 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKTUL = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNTULK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNTULP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00226", x => x.NSI00226);
                });

            migrationBuilder.CreateTable(
                name: "TSI00227",
                columns: table => new
                {
                    NSI00227 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKTPOM = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNTPOMK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNTPOMP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00227", x => x.NSI00227);
                });

            migrationBuilder.CreateTable(
                name: "TSI00228",
                columns: table => new
                {
                    NSI00228 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKSLKV = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNSLKVK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNSLKVP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00228", x => x.NSI00228);
                });

            migrationBuilder.CreateTable(
                name: "TSI00230",
                columns: table => new
                {
                    NSI00230 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKLOKOGU = table.Column<int>(type: "int", nullable: true),
                    NKLVD = table.Column<long>(type: "bigint", nullable: true),
                    NKLVDP = table.Column<int>(type: "int", nullable: true),
                    NKUZ = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSI00113 = table.Column<int>(type: "int", nullable: true),
                    NSI00212 = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNLVD = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00230", x => x.NSI00230);
                });

            migrationBuilder.CreateTable(
                name: "TSI00234",
                columns: table => new
                {
                    NSI00234 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NKVPOM = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNVPOM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00234", x => x.NSI00234);
                });

            migrationBuilder.CreateTable(
                name: "TSI00239",
                columns: table => new
                {
                    NSI00239 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKTNP = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNTNPK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNTNPP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00239", x => x.NSI00239);
                });

            migrationBuilder.CreateTable(
                name: "TSI00243",
                columns: table => new
                {
                    NSI00243 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKEYS = table.Column<int>(type: "int", nullable: true),
                    NKNOTREG = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNNOTREGK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNNOTREGP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00243", x => x.NSI00243);
                });

            migrationBuilder.CreateTable(
                name: "TSI00246",
                columns: table => new
                {
                    NSI00246 = table.Column<int>(type: "int", nullable: false),
                    CACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CSTATUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DFROM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DOP = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NKFFS = table.Column<int>(type: "int", nullable: true),
                    NKUZA = table.Column<int>(type: "int", nullable: true),
                    NOP = table.Column<int>(type: "int", nullable: true),
                    NSTDOK = table.Column<int>(type: "int", nullable: true),
                    NSTOBM = table.Column<int>(type: "int", nullable: true),
                    VNFFSK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VNFFSP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSI00246", x => x.NSI00246);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EGR01_NGRN",
                table: "EGR01",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR01NAME_NGRN",
                table: "EGR01NAME",
                column: "NGRN");


        migrationBuilder.CreateIndex(
                name: "IX_EGR0301_NGRN",
                table: "EGR0301",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0302_NGRN",
                table: "EGR0302",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0303_NGRN",
                table: "EGR0303",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0305_NSI00114",
                table: "EGR0305",
                column: "NSI00114");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0313_NGRN",
                table: "EGR0313",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0315_NGRN",
                table: "EGR0315",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0316_NGRN",
                table: "EGR0316",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0318_NGRN",
                table: "EGR0318",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0321_NGRN",
                table: "EGR0321",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0331_NGRN",
                table: "EGR0331",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0332_NGRN",
                table: "EGR0332",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0355_NGRN",
                table: "EGR0355",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0356_NGRN",
                table: "EGR0356",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0357_NGRN",
                table: "EGR0357",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0358_NGRN",
                table: "EGR0358",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0359_NGRN",
                table: "EGR0359",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR0360_NGRN",
                table: "EGR0360",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR04D_NGRN",
                table: "EGR04D",
                column: "NGRN");

            migrationBuilder.CreateIndex(
                name: "IX_EGR04G_NGRN",
                table: "EGR04G",
                column: "NGRN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EGR01");

            migrationBuilder.DropTable(
                name: "EGR01NAME");

            migrationBuilder.DropTable(
                name: "EGR0301");

            migrationBuilder.DropTable(
                name: "EGR0302");

            migrationBuilder.DropTable(
                name: "EGR0303");

            migrationBuilder.DropTable(
                name: "EGR0305");

            migrationBuilder.DropTable(
                name: "EGR0313");

            migrationBuilder.DropTable(
                name: "EGR0315");

            migrationBuilder.DropTable(
                name: "EGR0316");

            migrationBuilder.DropTable(
                name: "EGR0318");

            migrationBuilder.DropTable(
                name: "EGR0321");

            migrationBuilder.DropTable(
                name: "EGR0331");

            migrationBuilder.DropTable(
                name: "EGR0332");

            migrationBuilder.DropTable(
                name: "EGR0355");

            migrationBuilder.DropTable(
                name: "EGR0356");

            migrationBuilder.DropTable(
                name: "EGR0357");

            migrationBuilder.DropTable(
                name: "EGR0358");

            migrationBuilder.DropTable(
                name: "EGR0359");

            migrationBuilder.DropTable(
                name: "EGR0360");

            migrationBuilder.DropTable(
                name: "EGR04D");

            migrationBuilder.DropTable(
                name: "EGR04G");

            migrationBuilder.DropTable(
                name: "TSI00012");

            migrationBuilder.DropTable(
                name: "TSI00113");

            migrationBuilder.DropTable(
                name: "TSI00114");

            migrationBuilder.DropTable(
                name: "TSI00201");

            migrationBuilder.DropTable(
                name: "TSI00202");

            migrationBuilder.DropTable(
                name: "TSI00203");

            migrationBuilder.DropTable(
                name: "TSI00204");

            migrationBuilder.DropTable(
                name: "TSI00206");

            migrationBuilder.DropTable(
                name: "TSI00207");

            migrationBuilder.DropTable(
                name: "TSI00208");

            migrationBuilder.DropTable(
                name: "TSI00211");

            migrationBuilder.DropTable(
                name: "TSI00212");

            migrationBuilder.DropTable(
                name: "TSI00213");

            migrationBuilder.DropTable(
                name: "TSI00217");

            migrationBuilder.DropTable(
                name: "TSI00218");

            migrationBuilder.DropTable(
                name: "TSI00219");

            migrationBuilder.DropTable(
                name: "TSI00221");

            migrationBuilder.DropTable(
                name: "TSI00222");

            migrationBuilder.DropTable(
                name: "TSI00223");

            migrationBuilder.DropTable(
                name: "TSI00226");

            migrationBuilder.DropTable(
                name: "TSI00227");

            migrationBuilder.DropTable(
                name: "TSI00228");

            migrationBuilder.DropTable(
                name: "TSI00230");

            migrationBuilder.DropTable(
                name: "TSI00234");

            migrationBuilder.DropTable(
                name: "TSI00239");

            migrationBuilder.DropTable(
                name: "TSI00243");

            migrationBuilder.DropTable(
                name: "TSI00246");
        }
    }
}
