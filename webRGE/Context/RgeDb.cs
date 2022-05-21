using Microsoft.EntityFrameworkCore;
using webRGE.Entities;
using webRGE.Entities.Dictionary;
using webRGE.Entities.Reports;

namespace webRGE.Context
{
    public class RgeDb : DbContext
    {
        #region main
        public DbSet<EGR01NAME> EGR01NAME { get; set; }
        public DbSet<EGR01> EGR01 { get; set; }
        public DbSet<EGR0301> EGR0301 { get; set; }
        public DbSet<EGR0302> EGR0302 { get; set; }
        public DbSet<EGR0305> EGR0305 { get; set; }
        public DbSet<EGR0313> EGR0313 { get; set; }
        public DbSet<EGR0332> EGR0332 { get; set; }
        public DbSet<EGR0303> EGR0303 { get; set; }
        public DbSet<EGR0315> EGR0315 { get; set; }
        public DbSet<EGR0316> EGR0316 { get; set; }
        public DbSet<EGR0360> EGR0360 { get; set; }
        public DbSet<EGR04G> EGR04G { get; set; }
        public DbSet<EGR04D> EGR04D { get; set; }
        public DbSet<EGR0318> EGR0318 { get; set; }
        public DbSet<EGR0321> EGR0321 { get; set; }
        public DbSet<EGR0331> EGR0331 { get; set; }
        public DbSet<EGR0355> EGR0355 { get; set; }
        public DbSet<EGR0356> EGR0356 { get; set; }
        public DbSet<EGR0357> EGR0357 { get; set; }
        public DbSet<EGR0358> EGR0358 { get; set; }
        public DbSet<EGR0359> EGR0359 { get; set; }
        #endregion

        #region dictionary
        public DbSet<TSI00114> TSI00114 { get; set; }
        public DbSet<TSI00212> TSI00212 { get; set; }
        public DbSet<TSI00208> TSI00208 { get; set; }
        public DbSet<TSI00228> TSI00228 { get; set; }
        public DbSet<TSI00243> TSI00243 { get; set; }
        public DbSet<TSI00219> TSI00219 { get; set; }
        public DbSet<TSI00211> TSI00211 { get; set; }
        public DbSet<TSI00223> TSI00223 { get; set; }
        public DbSet<TSI00213> TSI00213 { get; set; }
        public DbSet<TSI00201> TSI00201 { get; set; }
        public DbSet<TSI00202> TSI00202 { get; set; }
        public DbSet<TSI00239> TSI00239 { get; set; }
        public DbSet<TSI00226> TSI00226 { get; set; }
        public DbSet<TSI00227> TSI00227 { get; set; }
        public DbSet<TSI00113> TSI00113 { get; set; }
        public DbSet<TSI00206> TSI00206 { get; set; }
        public DbSet<TSI00207> TSI00207 { get; set; }
        public DbSet<TSI00204> TSI00204 { get; set; }
        public DbSet<TSI00230> TSI00230 { get; set; }
        public DbSet<TSI00234> TSI00234 { get; set; }
        public DbSet<TSI00203> TSI00203 { get; set; }
        public DbSet<TSI00222> TSI00222 { get; set; }
        public DbSet<TSI00012> TSI00012 { get; set; }
        public DbSet<TSI00246> TSI00246 { get; set; }
        public DbSet<TSI00221> TSI00221 { get; set; }
        public DbSet<TSI00217> TSI00217 { get; set; }
        public DbSet<TSI00218> TSI00218 { get; set; }



        #endregion

        #region reports
        public DbSet<MainSearch> MainSearchs { get; set; }
        public DbSet<HistoryStatus> HistoryStatusReport { get; set; }
        public DbSet<HistoryName> HistoryNameReport { get; set; }
        public DbSet<HistoryManager> HistoryManagerReport { get; set; }
        public DbSet<ActivityTypeExt> ActivityTypeExtReport { get; set; }
        public DbSet<ActivityTypeExt2> ActivityTypeExt2Report { get; set; }
        public DbSet<ActivityTypeExt3> ActivityTypeExt3Report { get; set; }
        public DbSet<ActivityType> ActivityTypeReport { get; set; }
        public DbSet<ActivityTypeMain> ActivityTypeMainReport { get; set; }
        public DbSet<q0313> q0313Report { get; set; }
        public DbSet<q0355> q0355Report { get; set; }
        public DbSet<q0331> q0331Report { get; set; }
        public DbSet<SocNum> SocNumReport { get; set; }

        #endregion

        public RgeDb(DbContextOptions<RgeDb> options) : base(options)
        {
            //Database.EnsureDeleted();
           // Database.EnsureCreated();
            
        }
        
    }
}
