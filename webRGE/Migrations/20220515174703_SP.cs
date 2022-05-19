using Microsoft.EntityFrameworkCore.Migrations;

namespace webRGE.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "idx_EGR04D_f",
                table: "EGR04D",
                column: "NGR04001", "NGR04004A");

            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE [dbo].[mainSearch]
                                   @ngr int = NULL,
                                   @nm nvarchar(30) = NULL 
                                 AS
                                 BEGIN
                                 SET NOCOUNT ON;
                                 
                                 DECLARE @nmE nvarchar(30)= ""+@nm+"";
                                 
                                 
                                 SELECT TOP 100 e1.NGRN,
                                            e1.VNAIM,
                                            e1.VN,
                                            e1.VFN,
                                            e1.VFIO,
                                            e1.DFROM,
                                            e1.DTO,
                                            T219.VNSOSTK
                                 FROM egr01name e1
                                 LEFT JOIN TSI00219 T219 ON E1.NSI00219 = T219.NSI00219
                                 WHERE e1.NGRN = @ngr
                                 OR(
                                      CONTAINS(vfio, @nmE)
                                   OR CONTAINS(vnaim, @nmE)
                                   OR CONTAINS(vn, @nmE)
                                   )
                                    /* -- Если не установлен полнотекстовый поиск, то использовать вот это
                                      or  (vfio like '%'+@nm+'%'
                                          or vnaim like '%'+@nm+'%'
                                          or vn like '%'+@nm+'%')*/ ");

            migrationBuilder.Sql(@"create or alter procedure HistoryType(@ngr int)
                    as
                    begin
                    SET NOCOUNT ON;
                    
                    SELECT G4.NGR04004,
                           G4.DFROM,
                           G4.DTO,
                           G4.NKOP,
                           T223G.VNOP,
                           G4.DDOC,
                           G4.VDOCN,
                           G4.NKUZD,
                           T212D.VNUZK VNUZKD,
                           G4.NKUZR,
                           T212R.VNUZK VNUZKR,
                           G4.VNRESH,
                           G4.NKUZ,
                           T212.VNUZK VNUZK,
                           G4.NKOSN,
                           T213.VNOSN,
                           G4.DSROK,
                           D4.NKOP NKOPD,
                           T223D.VNOP VNOPD ,
                           g4.NGRN
                    FROM EGR04G g4
                      LEFT JOIN EGR04d d4 ON g4.ngr04004 = d4.ngr04004a AND g4.ngr04001 = d4.ngr04001
                      LEFT JOIN TSI00223 T223G ON T223G.NSI00223 = G4.NSI00223
                      LEFT JOIN TSI00212 T212R ON T212R.NSI00212 = G4.NSI00212R
                      LEFT JOIN TSI00212 T212D ON T212D.NSI00212 = G4.NSI00212D
                      LEFT JOIN TSI00212 T212 ON T212.NSI00212 = G4.NSI00212
                      LEFT JOIN TSI00213 T213 ON T213.NSI00213 = G4.NSI00213
                      LEFT JOIN TSI00223 T223D ON T223D.NSI00223 = D4.NSI00223
                    WHERE g4.NGRN=@ngr
                    ORDER BY DFROM ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure mainSearch");
        }
    }
}
