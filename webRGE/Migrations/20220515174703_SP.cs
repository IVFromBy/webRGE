using Microsoft.EntityFrameworkCore.Migrations;

namespace webRGE.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE or alter PROCEDURE mainSearch
	                                @ngr int = null,
	                                @nm nvarchar(30) = null
                                   AS
                                  BEGIN
	                                SET NOCOUNT ON; 
                                  SELECT TOP 100
                                    e1.NGRN,
                                    e1.VNAIM,
                                    e1.VN,
                                    e1.VFN,
                                    e1.VFIO,
                                    e1.DFROM,
                                    e1.DTO,
                                    T219.VNSOSTK
                            from egr01name e1
                                LEFT JOIN TSI00219 T219     ON E1.NSI00219      = T219.NSI00219
                    	       where e1.NGRN = @ngr
                    		   or  (vfio like '%'+@nm+'%'
                    		    or
                                  vnaim like '%'+@nm+'%'
                    			  or
                                  vn like '%'+@nm+'%')
                                END");
            /*
             CREATE NONCLUSTERED INDEX idx_EGR04D_f
ON [dbo].[EGR04D] ([NGR04001],[NGR04004A])
             */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop procedure mainSearch");
        }
    }
}
