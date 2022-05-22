using Microsoft.EntityFrameworkCore.Migrations;

namespace webRGE.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE NONCLUSTERED INDEX [idx_EGR04D_f] ON [EGR04D] ( [NGR04001] ASC, [NGR04004A] ASC)");

            migrationBuilder.Sql(@"create or alter procedure mainSearch(@ngr int=null, @nm nvarchar(40) = null)
                    as
                    begin
                    SET NOCOUNT ON;DECLARE @nmE nvarchar(40)= '"" + @nm + ""' ;
                                    if (@nm is not null)
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
                                    OR(vfio like '%' + @nm + '%' or vnaim like '%' + @nm + '%' or vn like '%' + @nm + '%')
                                    --Если нужно ускорить поиск, то установить полнотекстовый и использовать условие ниже, вместо старого                             
                                    --OR(CONTAINS(vfio, @nmE) OR CONTAINS(vnaim, @nmE) OR CONTAINS(vn, @nmE))
                                    else
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
                                    WHERE e1.NGRN = @ngr end");

            migrationBuilder.Sql(@"create or alter procedure HistoryType(@ngr int)
                    as
                    begin
                    SET NOCOUNT ON;
                    
                    SELECT G4.NGR04004, G4.DFROM, G4.DTO, G4.NKOP, T223G.VNOP, G4.DDOC,
                           G4.VDOCN, G4.NKUZD, T212D.VNUZK VNUZKD, G4.NKUZR, T212R.VNUZK VNUZKR,
                           G4.VNRESH, G4.NKUZ, T212.VNUZK VNUZK, G4.NKOSN, T213.VNOSN,G4.DSROK,
                           D4.NKOP NKOPD, T223D.VNOP VNOPD ,g4.NGRN
                    FROM EGR04G g4
                      LEFT JOIN EGR04d d4 ON g4.ngr04004 = d4.ngr04004a AND g4.ngr04001 = d4.ngr04001
                      LEFT JOIN TSI00223 T223G ON T223G.NSI00223 = G4.NSI00223
                      LEFT JOIN TSI00212 T212R ON T212R.NSI00212 = G4.NSI00212R
                      LEFT JOIN TSI00212 T212D ON T212D.NSI00212 = G4.NSI00212D
                      LEFT JOIN TSI00212 T212 ON T212.NSI00212 = G4.NSI00212
                      LEFT JOIN TSI00213 T213 ON T213.NSI00213 = G4.NSI00213
                      LEFT JOIN TSI00223 T223D ON T223D.NSI00223 = D4.NSI00223
                    WHERE g4.NGRN=@ngr
                    ORDER BY DFROM 
             END");

            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE [HistoryManager]
                                      @ngr int
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                    SELECT  
                                        e1.DFROM, e1.DTO, e1.VNAIM, T207.VNDOLGNP, T206A.VNVDOK VNVDOCA, 
                                    	T201.VNSTRANP, e1.NINDEX, e1.NKSOATO, T202.VNSFULL, T239.VNTNPP,
                                    	e1.VNP, T226.VNTULP, e1.VULITSA, e1.VDOM, e1.VKORP, e1.VPOM,
                                    	T227.VNTPOMP, e1.VADRPRIM, e1.VEMAIL, e1.VTELWORK, e1.VTELHOME, 
                                    	e1.VTELSOT, T206.VNVDOK, e1.VDOCSER, e1.VDOCNUM, e1.DDOC, 
                                    	e1.DDOCEND, e1.VDOCORG, e1.CLN, e1.DR, e1.VMR
                                            FROM egr0302 e1
                                                LEFT JOIN TSI00207 T207 ON E1.NSI00207 = T207.NSI00207
                                                LEFT JOIN TSI00206 T206A ON E1.NSI00206A = T206A.NSI00206
                                                LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                                LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                                LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                                LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                                LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                                LEFT JOIN TSI00206 T206 ON E1.NSI00206 = T206.NSI00206
                                            WHERE e1.ngrn = @ngr
                                    ORDER BY DFROM
                                    END");

            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE ActivityType(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                            SELECT  
                                                e1.NGRN,
                                                e1.DFROM,
                                                e1.DTO,
                                                T114.VNVDNP
                                            FROM egr0315 e1
                                                LEFT JOIN TSI00114 T114 ON E1.NSI00114 = T114.NSI00114
                                            WHERE e1.ngrn = @ngr
                                    		ORDER BY e1.NSI00114, DFROM
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE ActivityTypeExt(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT 
                                         e1.NGRN,
                                         e1.DFROM,
                                         e1.DTO,
                                         T114.VNVDNP
                                       FROM egr0316 e1
                                       LEFT JOIN TSI00114 T114 ON E1.NSI00114 = T114.NSI00114
                                       WHERE e1.ngrn = @ngr
                                       ORDER BY DFROM
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE ActivityTypeExt2(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                            SELECT  
                                                    e1.NGRN,        
                                                    e1.DFROM,
                                                    e1.DTO,
                                                    T230.VNLVD
                                            from egr0318 e1
                                                LEFT JOIN TSI00230 T230 ON E1.NSI00230 = T230.NSI00230
                                            where e1.ngrn =@ngr 
                                    		order by e1.NSI00230, e1.DFROM
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE ActivityTypeExt3(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                            SELECT  
                                                    e1.NGRN,        
                                                    e1.DFROM,
                                                    e1.DTO,
                                                    T114.VNVDNP
                                            from egr0305 e1
                                                LEFT JOIN TSI00114 T114 ON E1.NSI00114 = T114.NSI00114
                                            where e1.ngrn =@ngr
                                    		order by e1.NSI00114, DFROM
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE ActivityTypeMain(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT 
                                                    e1.NGRN,
                                                    e1.DFROM,
                                                    e1.DTO,
                                                    T114.VNVDNP
                                            from egr0356 e1
                                                LEFT JOIN TSI00114 T114 ON E1.NSI00114 = T114.NSI00114
                                            where e1.ngrn = @ngr 
                                    		order by ngrn,DFROM,e1.DTO
                                    END ");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE Egr0359SocNum(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                    SELECT  
                                                    e1.NGRN,        
                                                    e1.DFROM,
                                                    e1.DTO,
                                                    CASE WHEN e1.DOPINFO is null THEN '0000000' ELSE e1.DOPINFO END DOPINFO,
                                                    e1.VSOC
                                            from egr0359 e1
                                            where e1.ngrn =@ngr
                                    		order by ngrn,DFROM
                                    END;");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0355(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                    SELECT          e1.NGRN,
                                                    e1.DFROM,
                                                    e1.DTO,
                                                    CASE WHEN e1.VCPD is null THEN '0000000000' ELSE e1.VCPD END VCPD,
                                                    e1.VCPDDOP
                                            from egr0355 e1
                                            where e1.ngrn = @ngr
                                    END;");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0331(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                            SELECT  e1.NGRN, e1.DFROM, e1.DTO, e1.NUNN, e1.VNAIM, e1.VNAIMB,
                                                    e1.VN, e1.VNB, e1.VFN, e1.VFNB, T201.VNSTRANP, e1.NINDEX,
                                                    e1.NKSOATO, T202.VNSFULL, T202.OBJECTNUMBER ATE, e1.VREGION,
                                                    e1.VDISTRICT, T239.VNTNPP, e1.VNP, T226.VNTULP, e1.VULITSA,
                                                    e1.VDOM, e1.VKORP, e1.VPOM, T227.VNTPOMP, e1.VADRPRIM,e1.VEMAIL,
                                                    e1.VTELS, e1.VPRIM
                                            from egr0331 e1
                                                LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                                LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                                LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                                LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                                LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                            where e1.ngrn = @ngr
                                    END;");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0303(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT 
                                                    e1.NGRN, e1.DFROM, e1.DTO, e1.NUNN, e1.VNAIM, e1.VN, T201.VNSTRANP,
                                                    e1.NINDEX, e1.NKSOATO,  T202.VNSFULL, T202.OBJECTNUMBER ATE, e1.VREGION,
                                                    e1.VDISTRICT, T239.VNTNPP, e1.VNP, T226.VNTULP, e1.VULITSA, e1.VDOM,
                                                    e1.VKORP, e1.VPOM, T227.VNTPOMP, e1.VADRPRIM, e1.VEMAIL,e1.VTELS, e1.VPRIM
                                            from egr0303 e1
                                                LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                                LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                                LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                                LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                                LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                            where e1.ngrn = @ngr
                                    		order by DFROM
                                    END;");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0360(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT e1.NGRN, e1.DFROM, e1.DTO, e1.VFIO, e1.VFIOB,
                                                    T206.VNVDOK, e1.VDOCSER, e1.VDOCNUM, e1.DDOC, e1.DDOCEND,
                                                    e1.VDOCORG, e1.CLN, e1.NPOL, e1.DR, e1.VMR,e1.VPRIM
                                            from egr0360 e1
                                                LEFT JOIN TSI00206 T206 ON E1.NSI00206 = T206.NSI00206
                                            where e1.ngrn = @ngr
                                    		order by ngrn,DFROM
                                    END;");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0301(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT  e1.NGRN, e1.DFROM, e1.DTO, T211S.VNVOBP, e1.NUNN, e1.VNAIM,
                                               e1.VNAIMB, T201.VNSTRANP, e1.NINDEX, e1.NKSOATO, T202.VNSFULL,   
                                    		 T202.OBJECTNUMBER ATE, e1.VREGION, e1.VDISTRICT, T239.VNTNPP,
                                               e1.VNP, T226.VNTULP, e1.VULITSA, e1.VDOM, e1.VKORP, e1.VPOM,
                                               T227.VNTPOMP, e1.VADRPRIM, e1.VEMAIL, e1.VTELS, T206.VNVDOK,
                                               e1.VDOCSER, e1.VDOCNUM, e1.DDOC, e1.DDOCEND, e1.VDOCORG, e1.CLN,
                                               e1.NPOL, e1.DR, e1.VMR, T201I.VNSTRANP VNSTRANPI, T204.VNVALUTP,
                                               e1.NUFI, e1.NUFM, e1.NUF, e1.NUFP, e1.NUFA,e1.VPRIM
                                            from egr0301 e1
                                                LEFT JOIN TSI00211 T211S ON E1.NSI00211S = T211S.NSI00211
                                                LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                                LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                                LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                                LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                                LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                                LEFT JOIN TSI00206 T206 ON E1.NSI00206 = T206.NSI00206
                                                LEFT JOIN TSI00201 T201I ON E1.NSI00201I = T201I.NSI00201
                                                LEFT JOIN TSI00204 T204 ON E1.NSI00204 = T204.NSI00204
                                            where e1.ngrn =  @ngr
                                    		order by DFROM		
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0358(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT e1.NGRN, e1.DFROM, e1.DTO, T217.VNTUFP, T218.VNVSUFP,
                                              T204.VNVALUTP, e1.NUF, e1.NUFI, e1.NUFM, e1.NDG,e1.NDGI,
                                              e1.NDGM,e1.NSDII, e1.NSPII, e1.NSDBI, e1.NSPBI,e1.NUFAQ,e1.NUFAM
                                            from egr0358 e1
                                                LEFT JOIN TSI00217 T217 ON E1.NSI00217 = T217.NSI00217
                                                LEFT JOIN TSI00218 T218 ON E1.NSI00218 = T218.NSI00218
                                                LEFT JOIN TSI00204 T204 ON E1.NSI00204 = T204.NSI00204
                                            where e1.ngrn =@ngr
                                    		order by ngrn,DFROM
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0321(@ngr int)
                                   AS
                                   BEGIN
                                   SET NOCOUNT ON;
                                      SELECT e1.NGRN, e1.DFROM, e1.DTO, T201.VNSTRANP, e1.NINDEX,
                                                   e1.NKSOATO, T202.VNSFULL, T202.OBJECTNUMBER ATE, e1.VREGION,
                                                   e1.VDISTRICT, T239.VNTNPP, e1.VNP, T226.VNTULP, e1.VULITSA,
                                                   e1.VDOM, e1.VKORP, e1.VPOM, T227.VNTPOMP, T234.VNVPOM, e1.VADRPRIM,
                                                   e1.VEMAIL, e1.VSITE, e1.VTELS,e1.VFAX
                                           from egr0321 e1
                                               LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                               LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                               LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                               LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                               LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                               LEFT JOIN TSI00234 T234 ON E1.NSI00234 = T234.NSI00234
                                           where e1.ngrn = @ngr 
                                   		order by e1.DFROM
                                   END");
            migrationBuilder.Sql(@"create or ALTER PROCEDURE [HistoryName]
                                    @ngr int
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                    select  e1.NGR04003, e1.NGR04001,e1.NGRN, e1.DCRTA, e1.DLVDA,
                                                    e1.DFROM,e1.DTO,e1.CACT,e1.CINCL,e1.VNAIM,
                                                    e1.VNAIMB,e1.VN,e1.VNB,e1.VFN,e1.VFNB,e1.DOP
                                            from egr0332 e1
                                            where e1.ngrn = @ngr
                                    
                                    		order by ngrn, DFROM
                                    end");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0313(@ngr int)
                                    AS
                                    BEGIN
                                    SET NOCOUNT ON;
                                       SELECT e1.DFROM, e1.DTO, e1.NUNN, e1.VNAIM, e1.VNAIMB, e1.VN,
                                              e1.VNB, e1.VFN, e1.VFNB, T201.VNSTRANP, e1.NINDEX, e1.NKSOATO,     
                                    		  T202.VNSFULL,  T202.OBJECTNUMBER ATE, e1.VREGION, e1.VDISTRICT,
                                              T239.VNTNPP, e1.VNP, T226.VNTULP, e1.VULITSA, e1.VDOM, e1.VKORP,
                                              e1.VPOM, T227.VNTPOMP, e1.VADRPRIM, e1.VEMAIL, e1.VTELS, e1.VPRIM
                                            from egr0313 e1
                                                LEFT JOIN TSI00201 T201 ON E1.NSI00201 = T201.NSI00201
                                                LEFT JOIN TSI00202 T202 ON E1.NSI00202 = T202.NSI00202
                                                LEFT JOIN TSI00239 T239 ON E1.NSI00239 = T239.NSI00239
                                                LEFT JOIN TSI00226 T226 ON E1.NSI00226 = T226.NSI00226
                                                LEFT JOIN TSI00227 T227 ON E1.NSI00227 = T227.NSI00227
                                            where e1.NGRNTEMP =@ngr 
                                    END");
            migrationBuilder.Sql(@"CREATE OR ALTER PROCEDURE q0357(@ngr int)
                                   AS
                                   BEGIN
                                   SET NOCOUNT ON;
                                           SELECT e1.NGRN, e1.DFROM, e1.DTO, T203.VNOPFP, T222.VNFOPF,
                                                   T012.VNVFSP, T246.VNFFSP, T113.VKOKOGUP,T221.VNFOKOGU
                                           from egr0357 e1
                                               LEFT JOIN TSI00203 T203 ON E1.NSI00203 = T203.NSI00203
                                               LEFT JOIN TSI00222 T222 ON E1.NSI00222 = T222.NSI00222
                                               LEFT JOIN TSI00012 T012 ON E1.NSI00012 = T012.NSI00012
                                               LEFT JOIN TSI00246 T246 ON E1.NSI00246 = T246.NSI00246
                                               LEFT JOIN TSI00113 T113 ON E1.NSI00113 = T113.NSI00113
                                               LEFT JOIN TSI00221 T221 ON E1.NSI00221 = T221.NSI00221
                                           where e1.ngrn = @ngr 
                                   		order by ngrn,DFROM
                                   END");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure mainSearch");
            migrationBuilder.Sql("drop procedure HistoryType");
            migrationBuilder.Sql("drop procedure HistoryManager");
        }
    }
}
