using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using webRGE.Entities;

namespace webRGE.Services
{
    public partial class ParcerService
    {


        private async Task ProcessEGR01NAME(string[] arrayList)
        {
            List<EGR01NAME> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR01NAME reg = new EGR01NAME
                    {

                        DFROM = string.IsNullOrEmpty(data[0]) ? null : DateTime.ParseExact(data[0], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[1]) ? null : DateTime.ParseExact(data[1], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGRN = string.IsNullOrEmpty(data[2]) ? null : Convert.ToInt32(data[2]),
                        NKSOST = string.IsNullOrEmpty(data[3]) ? null : Convert.ToInt32(data[3]),
                        NSI00219 = string.IsNullOrEmpty(data[4]) ? null : Convert.ToInt32(data[4]),
                        VFIO = data[5],
                        VFN = data[6],
                        VN = data[7],
                        VNAIM = data[8],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR01(string[] arrayList)
        {
            List<EGR01> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR01 reg = new EGR01
                    {

                        DFROM = string.IsNullOrEmpty(data[0]) ? null : DateTime.ParseExact(data[0], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[1]) ? null : DateTime.ParseExact(data[1], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[3]) ? null : Convert.ToInt64(data[3]),
                        NGRN = string.IsNullOrEmpty(data[4]) ? null : Convert.ToInt64(data[4]),
                        NKNOTREG = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NKSCRT = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                        NKSLKV = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKSOST = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NKUZ = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NKUZCRT = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NKUZLKV = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NKVOB = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSI00208 = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NSI00211 = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NSI00212 = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSI00212CRT = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00212LKV = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00219 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00228 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00243 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        VNRCRT = data[21],
                        VNRLKV = data[22],
                    };

                    _List.Add(reg);
                }
            }

            await BulkSave(_List);
        }

        private async Task ProcessEGR0332(string[] arrayList)
        {
            List<EGR0332> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0332 reg = new EGR0332
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        VFN = data[10],
                        VFNB = data[11],
                        VN = data[12],
                        VNAIM = data[13],
                        VNAIMB = data[14],
                        VNB = data[15],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0360(string[] arrayList)
        {
            List<EGR0360> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0360 reg = new EGR0360
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        CLN = data[2],
                        DCRTA = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOC = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOCEND = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[7]) ? null : DateTime.ParseExact(data[7], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[8]) ? null : DateTime.ParseExact(data[8], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DR = string.IsNullOrEmpty(data[9]) ? null : DateTime.ParseExact(data[9], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[10]) ? null : DateTime.ParseExact(data[10], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NGR04003 = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt64(data[12]),
                        NGRN = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt64(data[13]),
                        NKVDOK = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NPOL = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSI00206 = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        VDOCNUM = data[17],
                        VDOCORG = data[18],
                        VDOCSER = data[19],
                        VFIO = data[20],
                        VFIOB = data[21],
                        VMR = data[22],
                        VPRIM = data[23],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR04G(string[] arrayList)
        {
            List<EGR04G> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR04G reg = new EGR04G
                    {

                        DDOC = string.IsNullOrEmpty(data[0]) ? null : DateTime.ParseExact(data[0], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[1]) ? null : DateTime.ParseExact(data[1], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DSROK = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt64(data[5]),
                        NGR04004 = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt64(data[6]),
                        NGRN = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt32(data[7]),
                        NKOP = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt32(data[8]),
                        NKOSN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NKUZ = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NKUZD = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NKUZR = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NSI00212 = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NSI00212D = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NSI00212R = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSI00213 = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00223 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        VDOCN = data[18],
                        VNRESH = data[19],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR04D(string[] arrayList)
        {
            List<EGR04D> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR04D reg = new EGR04D
                    {

                        DOP = string.IsNullOrEmpty(data[0]) ? null : DateTime.ParseExact(data[0], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[1]) ? null : Convert.ToInt64(data[1]),
                        NGR04004 = string.IsNullOrEmpty(data[2]) ? null : Convert.ToInt64(data[2]),
                        NGR04004A = string.IsNullOrEmpty(data[3]) ? null : Convert.ToInt64(data[3]),
                        NGRN = string.IsNullOrEmpty(data[4]) ? null : Convert.ToInt64(data[4]),
                        NKOP = string.IsNullOrEmpty(data[5]) ? null : Convert.ToInt32(data[5]),
                        NSI00223 = string.IsNullOrEmpty(data[6]) ? null : Convert.ToInt32(data[6]),
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0301(string[] arrayList)
        {
            List<EGR0301> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0301 reg = new EGR0301
                    {
                        CACT = data[0],
                        CINCL = data[1],
                        CLN = data[2],
                        DCRTA = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOC = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOCEND = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[7]) ? null : DateTime.ParseExact(data[7], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[8]) ? null : DateTime.ParseExact(data[8], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DR = string.IsNullOrEmpty(data[9]) ? null : DateTime.ParseExact(data[9], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[10]) ? null : DateTime.ParseExact(data[10], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NGR04003 = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt64(data[12]),
                        NGRN = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt64(data[13]),
                        NGRNS = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt64(data[14]),
                        NGRNTEMP = data[15],
                        NINDEX = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NKSOATO = data[17],
                        NKSTRAN = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NKSTRANI = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NKTNP = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NKTPOM = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NKTUL = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        NKVALUT = string.IsNullOrEmpty(data[23]) ? null : Convert.ToInt32(data[23]),
                        NKVDOK = string.IsNullOrEmpty(data[24]) ? null : Convert.ToInt32(data[24]),
                        NKVOBS = string.IsNullOrEmpty(data[25]) ? null : Convert.ToInt32(data[25]),
                        NPOL = string.IsNullOrEmpty(data[26]) ? null : Convert.ToInt32(data[26]),
                        NSI00201 = string.IsNullOrEmpty(data[27]) ? null : Convert.ToInt32(data[27]),
                        NSI00201I = string.IsNullOrEmpty(data[28]) ? null : Convert.ToInt32(data[28]),
                        NSI00202 = string.IsNullOrEmpty(data[29]) ? null : Convert.ToInt32(data[29]),
                        NSI00204 = string.IsNullOrEmpty(data[30]) ? null : Convert.ToInt32(data[30]),
                        NSI00206 = string.IsNullOrEmpty(data[31]) ? null : Convert.ToInt32(data[31]),
                        NSI00211S = string.IsNullOrEmpty(data[32]) ? null : Convert.ToInt32(data[32]),
                        NSI00226 = string.IsNullOrEmpty(data[33]) ? null : Convert.ToInt32(data[33]),
                        NSI00227 = string.IsNullOrEmpty(data[34]) ? null : Convert.ToInt32(data[34]),
                        NSI00239 = string.IsNullOrEmpty(data[35]) ? null : Convert.ToInt32(data[35]),
                        NUF = string.IsNullOrEmpty(data[36]) ? null : Convert.ToDecimal(data[36], CultureInfo.InvariantCulture),
                        NUFA = string.IsNullOrEmpty(data[37]) ? null : Convert.ToDecimal(data[37], CultureInfo.InvariantCulture),
                        NUFI = string.IsNullOrEmpty(data[38]) ? null : Convert.ToDecimal(data[38], CultureInfo.InvariantCulture),
                        NUFM = string.IsNullOrEmpty(data[39]) ? null : Convert.ToDecimal(data[39], CultureInfo.InvariantCulture),
                        NUFP = string.IsNullOrEmpty(data[40]) ? null : Convert.ToDecimal(data[40], CultureInfo.InvariantCulture),
                        NUNN = string.IsNullOrEmpty(data[41]) ? null : Convert.ToInt32(data[41]),
                        VADRPRIM = data[42],
                        VDISTRICT = data[43],
                        VDOCNUM = data[44],
                        VDOCORG = data[45],
                        VDOCSER = data[46],
                        VDOM = data[47],
                        VEMAIL = data[48],
                        VKORP = data[49],
                        VMR = data[50],
                        VNAIM = data[51],
                        VNAIMB = data[52],
                        VNP = data[53],
                        VPOM = data[54],
                        VPRIM = data[55],
                        VREGION = data[56],
                        VTELS = data[57],
                        VULITSA = data[58],
                    };
                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }


        private async Task ProcessEGR0302(string[] arrayList)
        {
            List<EGR0302> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0302 reg = new EGR0302
                    {
                        CACT = data[0],
                        CINCL = data[1],
                        CLN = data[2],
                        DCRTA = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOC = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOCA = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOCAEND = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DDOCEND = string.IsNullOrEmpty(data[7]) ? null : DateTime.ParseExact(data[7], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[8]) ? null : DateTime.ParseExact(data[8], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[9]) ? null : DateTime.ParseExact(data[9], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[10]) ? null : DateTime.ParseExact(data[10], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DR = string.IsNullOrEmpty(data[11]) ? null : DateTime.ParseExact(data[11], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[12]) ? null : DateTime.ParseExact(data[12], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt64(data[13]),
                        NGR04003 = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt64(data[14]),
                        NGRN = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt64(data[15]),
                        NGRNS = data[16],
                        NGRNTEMP = data[17],
                        NINDEX = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NKDOLGN = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NKSOATO = data[20],
                        NKSTRAN = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NKTNP = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        NKTPOM = string.IsNullOrEmpty(data[23]) ? null : Convert.ToInt32(data[23]),
                        NKTUL = string.IsNullOrEmpty(data[24]) ? null : Convert.ToInt32(data[24]),
                        NKVDOK = string.IsNullOrEmpty(data[25]) ? null : Convert.ToInt32(data[25]),
                        NKVDOKA = string.IsNullOrEmpty(data[26]) ? null : Convert.ToInt32(data[26]),
                        NPOL = string.IsNullOrEmpty(data[27]) ? null : Convert.ToInt32(data[27]),
                        NSI00201 = string.IsNullOrEmpty(data[28]) ? null : Convert.ToInt32(data[28]),
                        NSI00202 = string.IsNullOrEmpty(data[29]) ? null : Convert.ToInt32(data[29]),
                        NSI00206 = string.IsNullOrEmpty(data[30]) ? null : Convert.ToInt32(data[30]),
                        NSI00206A = string.IsNullOrEmpty(data[31]) ? null : Convert.ToInt32(data[31]),
                        NSI00207 = string.IsNullOrEmpty(data[32]) ? null : Convert.ToInt32(data[32]),
                        NSI00226 = string.IsNullOrEmpty(data[33]) ? null : Convert.ToInt32(data[33]),
                        NSI00227 = string.IsNullOrEmpty(data[34]) ? null : Convert.ToInt32(data[34]),
                        NSI00239 = string.IsNullOrEmpty(data[35]) ? null : Convert.ToInt32(data[35]),
                        NUNN = data[36],
                        VADRPRIM = data[37],
                        VDISTRICT = data[38],
                        VDOCANUM = data[39],
                        VDOCNUM = data[40],
                        VDOCORG = data[41],
                        VDOCSER = data[42],
                        VDOM = data[43],
                        VEMAIL = data[44],
                        VKORP = data[45],
                        VMR = data[46],
                        VNAIM = data[47],
                        VNAIMB = data[48],
                        VNP = data[49],
                        VPOM = data[50],
                        VPRIM = data[51],
                        VREGION = data[52],
                        VTELHOME = data[53],
                        VTELSOT = data[54],
                        VTELWORK = data[55],
                        VULITSA = data[56],
                    };

                    _List.Add(reg);

                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0303(string[] arrayList)
        {
            List<EGR0303> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0303 reg = new EGR0303
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NGRNTEMP = data[10],
                        NINDEX = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NKSOATO = data[12],
                        NKSTRAN = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKTNP = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKTPOM = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NKTUL = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00201 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00202 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00226 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00227 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00239 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NUNN = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        VADRPRIM = data[23],
                        VDISTRICT = data[24],
                        VDOM = data[25],
                        VEMAIL = data[26],
                        VKORP = data[27],
                        VN = data[28],
                        VNAIM = data[29],
                        VNP = data[30],
                        VPOM = data[31],
                        VPRIM = data[32],
                        VREGION = data[33],
                        VTELS = data[34],
                        VULITSA = data[35],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0305(string[] arrayList)
        {
            List<EGR0305> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0305 reg = new EGR0305
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NSI00114 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        VKVDN = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0313(string[] arrayList)
        {
            List<EGR0313> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0313 reg = new EGR0313
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NGRNTEMP = data[10],
                        NINDEX = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NKSOATO = data[12],
                        NKSTRAN = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKTNP = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKTPOM = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NKTUL = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00201 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00202 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00226 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00227 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00239 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NUNN = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        VADRPRIM = data[23],
                        VDISTRICT = data[24],
                        VDOM = data[25],
                        VEMAIL = data[26],
                        VFN = data[27],
                        VFNB = data[28],
                        VKORP = data[29],
                        VN = data[30],
                        VNAIM = data[31],
                        VNAIMB = data[32],
                        VNB = data[33],
                        VNP = data[34],
                        VPOM = data[35],
                        VPRIM = data[36],
                        VREGION = data[37],
                        VTELS = data[38],
                        VULITSA = data[39],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0315(string[] arrayList)
        {
            List<EGR0315> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0315 reg = new EGR0315
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NSI00114 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        VKVDN = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0316(string[] arrayList)
        {
            List<EGR0316> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0316 reg = new EGR0316
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NSI00114 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        VKVDN = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0318(string[] arrayList)
        {
            List<EGR0318> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0318 reg = new EGR0318
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt32(data[9]),
                        NKLVD = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt64(data[10]),
                        NSI00230 = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0321(string[] arrayList)
        {
            List<EGR0321> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0321 reg = new EGR0321
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NINDEX = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NKSOATO = data[11],
                        NKSTRAN = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NKTNP = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKTPOM = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKTUL = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NKVPOM = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00201 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00202 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00226 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00227 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00234 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NSI00239 = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt32(data[22]),
                        VADRPRIM = data[23],
                        VDISTRICT = data[24],
                        VDOM = data[25],
                        VEMAIL = data[26],
                        VFAX = data[27],
                        VKORP = data[28],
                        VNP = data[29],
                        VPOM = data[30],
                        VREGION = data[31],
                        VSITE = data[32],
                        VTELS = data[33],
                        VULITSA = data[34],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0331(string[] arrayList)
        {
            List<EGR0331> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0331 reg = new EGR0331
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NGRNTEMP = data[10],
                        NINDEX = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NKSOATO = data[12],
                        NKSTRAN = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKTNP = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKTPOM = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NKTUL = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00201 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00202 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00226 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00227 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00239 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                        NUNN = string.IsNullOrEmpty(data[22]) ? null : Convert.ToInt64(data[22]),
                        VADRPRIM = data[23],
                        VDISTRICT = data[24],
                        VDOM = data[25],
                        VEMAIL = data[26],
                        VFN = data[27],
                        VFNB = data[28],
                        VKORP = data[29],
                        VN = data[30],
                        VNAIM = data[31],
                        VNAIMB = data[32],
                        VNB = data[33],
                        VNP = data[34],
                        VPOM = data[35],
                        VPRIM = data[36],
                        VREGION = data[37],
                        VTELS = data[38],
                        VULITSA = data[39],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }
        private async Task ProcessEGR0355(string[] arrayList)
        {
            List<EGR0355> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0355 reg = new EGR0355
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        VCPD = data[10],
                        VCPDDOP = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0356(string[] arrayList)
        {
            List<EGR0356> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0356 reg = new EGR0356
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NSI00114 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        VKVDN = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0357(string[] arrayList)
        {
            List<EGR0357> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0357 reg = new EGR0357
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[7]) ? null : Convert.ToInt64(data[7]),
                        NGR04003 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGRN = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NKFFS = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt32(data[10]),
                        NKFOKOGU = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt32(data[11]),
                        NKFOPF = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt32(data[12]),
                        NKOKOGU = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKOPF = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKVFS = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSI00012 = string.IsNullOrEmpty(data[16]) ? null : Convert.ToInt32(data[16]),
                        NSI00113 = string.IsNullOrEmpty(data[17]) ? null : Convert.ToInt32(data[17]),
                        NSI00203 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00221 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00222 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSI00246 = string.IsNullOrEmpty(data[21]) ? null : Convert.ToInt32(data[21]),
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0358(string[] arrayList)
        {
            List<EGR0358> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0358 reg = new EGR0358
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DTO = string.IsNullOrEmpty(data[6]) ? null : DateTime.ParseExact(data[6], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NDG = string.IsNullOrEmpty(data[7]) ? null : Convert.ToDecimal(data[7], CultureInfo.InvariantCulture),
                        NDGI = string.IsNullOrEmpty(data[8]) ? null : Convert.ToDecimal(data[8], CultureInfo.InvariantCulture),
                        NDGM = string.IsNullOrEmpty(data[9]) ? null : Convert.ToDecimal(data[9], CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt64(data[10]),
                        NGR04003 = string.IsNullOrEmpty(data[11]) ? null : Convert.ToInt64(data[11]),
                        NGRN = string.IsNullOrEmpty(data[12]) ? null : Convert.ToInt64(data[12]),
                        NKTUF = string.IsNullOrEmpty(data[13]) ? null : Convert.ToInt32(data[13]),
                        NKVALUT = string.IsNullOrEmpty(data[14]) ? null : Convert.ToInt32(data[14]),
                        NKVSUF = string.IsNullOrEmpty(data[15]) ? null : Convert.ToInt32(data[15]),
                        NSDBI = string.IsNullOrEmpty(data[16]) ? null : Convert.ToDecimal(data[16], CultureInfo.InvariantCulture),
                        NSDII = string.IsNullOrEmpty(data[17]) ? null : Convert.ToDecimal(data[17], CultureInfo.InvariantCulture),
                        NSI00204 = string.IsNullOrEmpty(data[18]) ? null : Convert.ToInt32(data[18]),
                        NSI00217 = string.IsNullOrEmpty(data[19]) ? null : Convert.ToInt32(data[19]),
                        NSI00218 = string.IsNullOrEmpty(data[20]) ? null : Convert.ToInt32(data[20]),
                        NSPBI = string.IsNullOrEmpty(data[21]) ? null : Convert.ToDecimal(data[21], CultureInfo.InvariantCulture),
                        NSPII = string.IsNullOrEmpty(data[22]) ? null : Convert.ToDecimal(data[22], CultureInfo.InvariantCulture),
                        NUF = string.IsNullOrEmpty(data[23]) ? null : Convert.ToDecimal(data[23], CultureInfo.InvariantCulture),
                        NUFAM = string.IsNullOrEmpty(data[24]) ? null : Convert.ToDecimal(data[24], CultureInfo.InvariantCulture),
                        NUFAQ = string.IsNullOrEmpty(data[25]) ? null : Convert.ToDecimal(data[25], CultureInfo.InvariantCulture),
                        NUFI = string.IsNullOrEmpty(data[26]) ? null : Convert.ToDecimal(data[26], CultureInfo.InvariantCulture),
                        NUFM = string.IsNullOrEmpty(data[27]) ? null : Convert.ToDecimal(data[27], CultureInfo.InvariantCulture),
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

        private async Task ProcessEGR0359(string[] arrayList)
        {
            List<EGR0359> _List = new();

            foreach (string line in arrayList)
            {
                if (line != null)
                {
                    string[] data = line.Split('\t');

                    EGR0359 reg = new EGR0359
                    {

                        CACT = data[0],
                        CINCL = data[1],
                        DCRTA = string.IsNullOrEmpty(data[2]) ? null : DateTime.ParseExact(data[2], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DFROM = string.IsNullOrEmpty(data[3]) ? null : DateTime.ParseExact(data[3], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DLVDA = string.IsNullOrEmpty(data[4]) ? null : DateTime.ParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOP = string.IsNullOrEmpty(data[5]) ? null : DateTime.ParseExact(data[5], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        DOPINFO = data[6],
                        DTO = string.IsNullOrEmpty(data[7]) ? null : DateTime.ParseExact(data[7], "dd-MMM-yy", CultureInfo.InvariantCulture),
                        NGR04001 = string.IsNullOrEmpty(data[8]) ? null : Convert.ToInt64(data[8]),
                        NGR04003 = string.IsNullOrEmpty(data[9]) ? null : Convert.ToInt64(data[9]),
                        NGRN = string.IsNullOrEmpty(data[10]) ? null : Convert.ToInt64(data[10]),
                        VSOC = data[11],
                    };

                    _List.Add(reg);
                }
            }
            await BulkSave(_List);
        }

      
    }
}
