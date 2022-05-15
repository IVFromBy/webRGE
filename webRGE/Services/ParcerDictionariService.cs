using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using webRGE.Entities.Dictionary;

namespace webRGE.Services
{
    public partial class ParcerService
    {

        private async Task ProcessTSI00219(string[] arrayList)
        {
            List<TSI00219> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00219 reg = new TSI00219
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKSOST = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00219 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNSOSTK = data[12],
                        VNSOSTP = data[13],
                    };

                    _List.Add(reg);
                }
            }

            await BulkSave(_List);
        }

        private async Task ProcessTSI00208(string[] arrayList)
        {
            List<TSI00208> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00208 reg = new TSI00208
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKSCRT = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00208 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNSCRTK = data[12],
                        VNSCRTP = data[13],
                    };

                    _List.Add(reg);
                }
            }

            await BulkSave(_List);
        }

        private async Task ProcessTSI00211(string[] arrayList)
        {
            List<TSI00211> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00211 reg = new TSI00211
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVOB = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00211 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNVOBK = data[12],
                        VNVOBP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00212(string[] arrayList)
        {
            List<TSI00212> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00212 reg = new TSI00212
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = data[5],
                        NKFOKOGU = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKIND = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKLOKOGU = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NKOKOGU = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NKOKPO = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NKSOATO = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NKUZ = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NKUZA = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKUZS = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKUZTO = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NOP = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00113 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00202 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00212 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00212S = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00221 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NSTDOK = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        NSTOBM = string.IsNullOrEmpty(data[23]) ? null : Convert.ToInt32(data[23]),
                        NUNN = string.IsNullOrEmpty(data[24]) ? null : Convert.ToInt64(data[24]),
                        VDBLINK = data[25],
                        VNOPKPP = data[26],
                        VNOPKPR = data[27],
                        VNUZK = data[28],
                        VNUZP = data[29],
                        VUSRNAME = data[30],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00228(string[] arrayList)
        {
            List<TSI00228> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00228 reg = new TSI00228
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKSLKV = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00228 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNSLKVK = data[12],
                        VNSLKVP = data[13],
                    };

                    _List.Add(reg);
                }
            }

            await BulkSave(_List);
        }

        private async Task ProcessTSI00213(string[] arrayList)
        {
            List<TSI00213> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00213 reg = new TSI00213
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKOSN = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00213 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNOSN = data[12],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00223(string[] arrayList)
        {
            List<TSI00223> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00223 reg = new TSI00223
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NFIX = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKOP = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKOPA = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NKUZA = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NMAIN = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NOP = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NREAL = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSI00223 = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NSI00223A = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NSTDOK = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSTOBM = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        VNOP = data[17],
                        VNOPK = data[18],
                        VNOPKORR = data[19],
                        VNOPREP = data[20],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00243(string[] arrayList)
        {
            List<TSI00243> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00243 reg = new TSI00243
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKNOTREG = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00243 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNNOTREGK = data[12],
                        VNNOTREGP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00201(string[] arrayList)
        {
            List<TSI00201> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00201 reg = new TSI00201
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKSTRAN = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00201 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VALFA2 = data[12],
                        VALFA3 = data[13],
                        VNSTRANK = data[14],
                        VNSTRANP = data[15],
                    };

                    _List.Add(reg);
                }
            }
            
            await BulkSave(_List);
        }


        private async Task ProcessTSI00202(string[] arrayList)
        {
            List<TSI00202> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00202 reg = new TSI00202
                    {

                        CACT = data[0],
                        CATNAME = data[1],
                        CATNAMECONV = data[2],
                        CATSHORTNAME = data[3],
                        COMMENTARY = data[4],
                        CSTATUS = data[5],
                        CTAE = data[6],
                        DFROM = string.IsNullOrEmpty(data[7]) ? null : DateTime.ParseExact(data[7], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[8]) ? null : DateTime.ParseExact(data[8], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[9]) ? null : DateTime.ParseExact(data[9], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NAMEDISTR = data[10],
                        NAMEREGION = data[11],
                        NKCATEGORY = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NKEYS = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKSOATO = data[14],
                        NKUZA = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NOP = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00202 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00239 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00245 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSTDOK = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSTOBM = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        OBJECTNUMBER = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        SOATODEPEND = data[23],
                        UIDOPERIN = string.IsNullOrEmpty(data[24]) ? null : Convert.ToInt32(data[24]),
                        UIDOPEROUT = string.IsNullOrEmpty(data[25]) ? null : Convert.ToInt32(data[25]),
                        VAL_NAME = data[26],
                        VKSOATO = data[27],
                        VNCENTR = data[28],
                        VNP = data[29],
                        VNSFULL = data[30],
                        VNSOATO = data[31],
                        VNSSHORT = data[32],
                        VSELSOVET = data[33],
                    };

                    _List.Add(reg);
                }
            }
            
            await BulkSave(_List);
        }

        private async Task ProcessTSI00239(string[] arrayList)
        {
            List<TSI00239> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00239 reg = new TSI00239
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKTNP = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00239 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNTNPK = data[12],
                        VNTNPP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00226(string[] arrayList)
        {
            List<TSI00226> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00226 reg = new TSI00226
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKTUL = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00226 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNTULK = data[12],
                        VNTULP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00227(string[] arrayList)
        {
            List<TSI00227> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00227 reg = new TSI00227
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKTPOM = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00227 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNTPOMK = data[12],
                        VNTPOMP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00206(string[] arrayList)
        {
            List<TSI00206> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00206 reg = new TSI00206
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVDOK = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKVOB = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NOP = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSI00206 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSI00211 = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NSTDOK = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSTOBM = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        VANSWER = data[14],
                        VCLASS = data[15],
                        VNVDOK = data[16],
                        VNVDOKK = data[17],
                        VNVDOKRP = data[18],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00204(string[] arrayList)
        {
            List<TSI00204> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00204 reg = new TSI00204
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVALUT = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00204 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VCOUNTRY = data[12],
                        VNVALUTK = data[13],
                        VNVALUTP = data[14],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00207(string[] arrayList)
        {
            List<TSI00207> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00207 reg = new TSI00207
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKDOLGN = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),                        
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00207 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNDOLGNK = data[12],
                        VNDOLGNP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00114(string[] arrayList)
        {
            List<TSI00114> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00114 reg = new TSI00114
                    {

                        CACT = data[0],
                        CPD = data[1],
                        CSTATUS = data[2],
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKEYS = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOLD = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NOP = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSI00114 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTDOK = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NSTOBM = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        VKVDN = data[13],
                        VNVDNK = data[14],
                        VNVDNP = data[15],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00230(string[] arrayList)
        {
            List<TSI00230> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00230 reg = new TSI00230
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKLOKOGU = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKLVD = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NKLVDP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NKUZ = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NKUZA = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NOP = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NSI00113 = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSI00212 = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NSI00230 = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NSTDOK = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSTOBM = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        VNLVD = data[17],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00234(string[] arrayList)
        {
            List<TSI00234> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00234 reg = new TSI00234
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVPOM = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00234 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNVPOM = data[12],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00203(string[] arrayList)
        {
            List<TSI00203> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00203 reg = new TSI00203
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKOPF = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NMUF = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NOP = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSI00203 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTDOK = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NSTOBM = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        VCONTAINEDWORDS = data[13],
                        VNOPFBK = data[14],
                        VNOPFBP = data[15],
                        VNOPFEBK = data[16],
                        VNOPFEBP = data[17],
                        VNOPFEK = data[18],
                        VNOPFEP = data[19],
                        VNOPFK = data[20],
                        VNOPFP = data[21],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00222(string[] arrayList)
        {
            List<TSI00222> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00222 reg = new TSI00222
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKFOPF = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00222 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNFOPF = data[12],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }
        private async Task ProcessTSI00012(string[] arrayList)
        {
            List<TSI00012> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00012 reg = new TSI00012
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),

                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVFS = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00012 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNVFSK = data[12],
                        VNVFSP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00246(string[] arrayList)
        {
            List<TSI00246> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00246 reg = new TSI00246
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKFFS = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00246 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNFFSK = data[12],
                        VNFFSP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00113(string[] arrayList)
        {
            List<TSI00113> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00113 reg = new TSI00113
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKOKOGU = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKSOOU = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKUZA = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NOP = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSI00113 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSI00113S = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NSTDOK = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSTOBM = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        VKOKOGUK2 = data[14],
                        VKOKOGUK = data[15],
                        VKOKOGUP = data[16],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }
        private async Task ProcessTSI00221(string[] arrayList)
        {
            List<TSI00221> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00221 reg = new TSI00221
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKFOKOGU = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00221 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNFOKOGU = data[12],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }
        private async Task ProcessTSI00217(string[] arrayList)
        {
            List<TSI00217> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00217 reg = new TSI00217
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKTUF = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKUZA = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00217 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNTUFK = data[12],
                        VNTUFP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessTSI00218(string[] arrayList)
        {
            List<TSI00218> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    TSI00218 reg = new TSI00218
                    {

                        CACT = data[0],
                        CSTATUS = data[1],
                        DFROM = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NKUZA = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKVSUF = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NSI00218 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NSTDOK = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NSTOBM = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        VNVSUFK = data[12],
                        VNVSUFP = data[13],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }
    }
}
