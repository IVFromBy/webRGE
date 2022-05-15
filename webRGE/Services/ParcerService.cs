using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using webRGE.Context;
using webRGE.Entities;
using webRGE.Entities.Dictionary;
using webRGE.Entities.Enum;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webRGE.Services
{
    public partial class ParcerService
    {
        private readonly RgeDb _db;

        private IConfiguration _configuration { get; set; }

        public ParcerService(RgeDb db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        public async Task ParserSelector(TabelNames paerserType, string[] parseBody)
        {
            switch (paerserType)
            {

                case TabelNames.EGR01NAME: await ProcessEGR01NAME(parseBody); break;
                case TabelNames.TSI00219: await ProcessTSI00219(parseBody); break;
                case TabelNames.TSI00114: await ProcessTSI00114(parseBody); break;
                case TabelNames.TSI00208: await ProcessTSI00208(parseBody); break;
                case TabelNames.TSI00201: await ProcessTSI00201(parseBody); break;
                case TabelNames.TSI00202: await ProcessTSI00202(parseBody); break;
                case TabelNames.TSI00204: await ProcessTSI00204(parseBody); break;
                case TabelNames.TSI00206: await ProcessTSI00206(parseBody); break;
                case TabelNames.TSI00207: await ProcessTSI00207(parseBody); break;
                case TabelNames.TSI00211: await ProcessTSI00211(parseBody); break;
                case TabelNames.TSI00212: await ProcessTSI00212(parseBody); break;
                case TabelNames.TSI00213: await ProcessTSI00213(parseBody); break;
                case TabelNames.TSI00223: await ProcessTSI00223(parseBody); break;
                case TabelNames.TSI00226: await ProcessTSI00226(parseBody); break;
                case TabelNames.TSI00227: await ProcessTSI00227(parseBody); break;
                case TabelNames.TSI00228: await ProcessTSI00228(parseBody); break;
                case TabelNames.TSI00239: await ProcessTSI00239(parseBody); break;
                case TabelNames.TSI00243: await ProcessTSI00243(parseBody); break;
                case TabelNames.TSI00230: await ProcessTSI00230(parseBody); break;
                case TabelNames.TSI00234: await ProcessTSI00234(parseBody); break;
                case TabelNames.EGR01: await ProcessEGR01(parseBody); break;
                case TabelNames.EGR0332: await ProcessEGR0332(parseBody); break;
                case TabelNames.EGR0360: await ProcessEGR0360(parseBody); break;
                case TabelNames.EGR04G: await ProcessEGR04G(parseBody); break;
                case TabelNames.EGR04D: await ProcessEGR04D(parseBody); break;
                case TabelNames.EGR0301: await ProcessEGR0301(parseBody); break;
                case TabelNames.EGR0302: await ProcessEGR0302(parseBody); break;
                case TabelNames.EGR0303: await ProcessEGR0303(parseBody); break;
                case TabelNames.EGR0305: await ProcessEGR0305(parseBody); break;
                case TabelNames.EGR0313: await ProcessEGR0313(parseBody); break;
                case TabelNames.EGR0315: await ProcessEGR0315(parseBody); break;
                case TabelNames.EGR0316: await ProcessEGR0316(parseBody); break;
                case TabelNames.EGR0318: await ProcessEGR0318(parseBody); break;
                case TabelNames.EGR0321: await ProcessEGR0321(parseBody); break;
                case TabelNames.EGR0331: await ProcessEGR0331(parseBody); break;
                case TabelNames.EGR0355: await ProcessEGR0355(parseBody); break;
                case TabelNames.EGR0356: await ProcessEGR0356(parseBody); break;
                case TabelNames.EGR0357: await ProcessEGR0357(parseBody); break;
                case TabelNames.EGR0358: await ProcessEGR0358(parseBody); break;
                case TabelNames.EGR0359: await ProcessEGR0359(parseBody); break;
                case TabelNames.TSI00203: await ProcessTSI00203(parseBody); break;
                case TabelNames.TSI00222: await ProcessTSI00222(parseBody); break;
                case TabelNames.TSI00012: await ProcessTSI00012(parseBody); break;
                case TabelNames.TSI00246: await ProcessTSI00246(parseBody); break;
                case TabelNames.TSI00113: await ProcessTSI00113(parseBody); break;
                case TabelNames.TSI00221: await ProcessTSI00221(parseBody); break;
                case TabelNames.TSI00217: await ProcessTSI00217(parseBody); break;
                case TabelNames.TSI00218: await ProcessTSI00218(parseBody); break;
            }
        }


        public async Task ClearSelector(TabelNames paerserType)
        {
            switch (paerserType)
            {
                case TabelNames.EGR01NAME: await clearTbl(_db.Set<EGR01NAME>()); break;
                case TabelNames.TSI00219: await clearTbl(_db.Set<TSI00219>()); break;
                case TabelNames.TSI00114: await clearTbl(_db.Set<TSI00114>()); break;
                case TabelNames.TSI00208: await clearTbl(_db.Set<TSI00208>()); break;
                case TabelNames.TSI00211: await clearTbl(_db.Set<TSI00211>()); break;
                case TabelNames.TSI00230: await clearTbl(_db.Set<TSI00230>()); break;
                case TabelNames.TSI00212: await clearTbl(_db.Set<TSI00212>()); break;
                case TabelNames.TSI00213: await clearTbl(_db.Set<TSI00213>()); break;
                case TabelNames.TSI00201: await clearTbl(_db.Set<TSI00201>()); break;
                case TabelNames.TSI00202: await clearTbl(_db.Set<TSI00202>()); break;
                case TabelNames.TSI00204: await clearTbl(_db.Set<TSI00204>()); break;
                case TabelNames.TSI00206: await clearTbl(_db.Set<TSI00206>()); break;
                case TabelNames.TSI00207: await clearTbl(_db.Set<TSI00207>()); break;
                case TabelNames.TSI00223: await clearTbl(_db.Set<TSI00223>()); break;
                case TabelNames.TSI00226: await clearTbl(_db.Set<TSI00226>()); break;
                case TabelNames.TSI00227: await clearTbl(_db.Set<TSI00227>()); break;
                case TabelNames.TSI00228: await clearTbl(_db.Set<TSI00228>()); break;
                case TabelNames.TSI00239: await clearTbl(_db.Set<TSI00239>()); break;
                case TabelNames.TSI00234: await clearTbl(_db.Set<TSI00234>()); break;
                case TabelNames.TSI00243: await clearTbl(_db.Set<TSI00243>()); break;
                case TabelNames.EGR01: await clearTbl(_db.Set<EGR01>()); break;
                case TabelNames.EGR0301: await clearTbl(_db.Set<EGR0301>()); break;
                case TabelNames.EGR0302: await clearTbl(_db.Set<EGR0302>()); break;
                case TabelNames.EGR0303: await clearTbl(_db.Set<EGR0303>()); break;
                case TabelNames.EGR0305: await clearTbl(_db.Set<EGR0305>()); break;
                case TabelNames.EGR0313: await clearTbl(_db.Set<EGR0313>()); break;
                case TabelNames.EGR0332: await clearTbl(_db.Set<EGR0332>()); break;
                case TabelNames.EGR0360: await clearTbl(_db.Set<EGR0360>()); break;
                case TabelNames.EGR04D: await clearTbl(_db.Set<EGR04D>()); break;
                case TabelNames.EGR04G: await clearTbl(_db.Set<EGR04G>()); break;
                case TabelNames.EGR0315: await clearTbl(_db.Set<EGR0315>()); break;
                case TabelNames.EGR0316: await clearTbl(_db.Set<EGR0316>()); break;
                case TabelNames.EGR0318: await clearTbl(_db.Set<EGR0318>()); break;
                case TabelNames.EGR0321: await clearTbl(_db.Set<EGR0321>()); break;
                case TabelNames.EGR0331: await clearTbl(_db.Set<EGR0331>()); break;
                case TabelNames.EGR0355: await clearTbl(_db.Set<EGR0355>()); break;
                case TabelNames.EGR0357: await clearTbl(_db.Set<EGR0357>()); break;
                case TabelNames.EGR0358: await clearTbl(_db.Set<EGR0358>()); break;
                case TabelNames.EGR0359: await clearTbl(_db.Set<EGR0359>()); break;
                case TabelNames.TSI00203: await clearTbl(_db.Set<TSI00203>()); break;
                case TabelNames.TSI00222: await clearTbl(_db.Set<TSI00222>()); break;
                case TabelNames.TSI00012: await clearTbl(_db.Set<TSI00012>()); break;
                case TabelNames.TSI00246: await clearTbl(_db.Set<TSI00246>()); break;
                case TabelNames.TSI00113: await clearTbl(_db.Set<TSI00113>()); break;
                case TabelNames.TSI00221: await clearTbl(_db.Set<TSI00221>()); break;
                case TabelNames.TSI00217: await clearTbl(_db.Set<TSI00217>()); break;
                case TabelNames.TSI00218: await clearTbl(_db.Set<TSI00218>()); break;
            }
        }

        private async Task clearTbl<T>(DbSet<T> tbl) where T : class
        {
            _db.RemoveRange(tbl);
            await _db.SaveChangesAsync();
        }

        private async Task BulkSave<T>(IEnumerable<T> bList) where T : class
        {
            var dt = new DataTable();

            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                dt.Columns.Add(prop.Name);

            }

            foreach (var items in bList)
            {
                DataRow dr = dt.NewRow();

                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    dr[i] = properties[i].GetValue(items);
                }

                dt.Rows.Add(dr);
            }

            using var sqlBulk = new SqlBulkCopy(_configuration.GetConnectionString("Default"), SqlBulkCopyOptions.Default);
            {
                foreach (var prop in properties)
                {
                    sqlBulk.ColumnMappings.Add(prop.Name, prop.Name);
                }
                sqlBulk.DestinationTableName = $"{typeof(T).Name}";
                sqlBulk.BulkCopyTimeout = 0;
                await sqlBulk.WriteToServerAsync(dt);
            }

        }
    }

}

