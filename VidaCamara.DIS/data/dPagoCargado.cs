﻿using System;
using System.Collections.Generic;
using System.Linq;
using VidaCamara.DIS.Modelo;

namespace VidaCamara.DIS.data
{
    public class dPagoCargado
    {
        public List<HistorialCargaArchivo_LinDet> listArchivoCargado(HistorialCargaArchivo_LinCab historiaLinCab, HistorialCargaArchivo_LinDet historiaLinDetParam, object[] filterParam, int jtStartIndex, int jtPageSize, out int total)
        {
            var listDetalle = new List<HistorialCargaArchivo_LinDet>();
            try
            {
                using (var db = new DISEntities())
                {
                    var nombreTipoArchivo = filterParam[0].ToString();
                    var tipoArchivo = db.TipoArchivos.Where(t => t.NombreTipoArchivo.Equals(nombreTipoArchivo)).FirstOrDefault();
                    if (tipoArchivo.Archivoes.Count == 0)
                    {
                        total = 0;
                        return null;
                    }
                    else
                    {
                        var archivoId = tipoArchivo.Archivoes.Where(a => a.TipoArchivoId == tipoArchivo.TipoArchivoId).FirstOrDefault();
                        total = db.HistorialCargaArchivo_LinDets.Where(a => a.HistorialCargaArchivo_LinCab.IDE_CONTRATO == historiaLinCab.IDE_CONTRATO && a.HistorialCargaArchivo_LinCab.ArchivoId == archivoId.ArchivoId).Count();
                        var query = db.HistorialCargaArchivo_LinDets.OrderBy(a=>a.IdHistorialCargaArchivoLinDet)
                            .Where(a => a.HistorialCargaArchivo_LinCab.IDE_CONTRATO == historiaLinCab.IDE_CONTRATO && a.HistorialCargaArchivo_LinCab.ArchivoId == archivoId.ArchivoId &&
                                   (a.COD_AFP.Equals(historiaLinDetParam.COD_AFP) || historiaLinDetParam.COD_AFP.Equals("0")) &&
                                   (a.COD_CUSP.Equals(historiaLinDetParam.COD_CUSP) || string.IsNullOrEmpty(historiaLinDetParam.COD_CUSP)) &&
                                   (a.PRI_NOMB_PEN.Contains(historiaLinDetParam.PRI_NOMB_PEN) || string.IsNullOrEmpty(historiaLinDetParam.PRI_NOMB_PEN)) &&
                                   (a.SEG_NOMB_PEN.Contains(historiaLinDetParam.SEG_NOMB_PEN) || string.IsNullOrEmpty(historiaLinDetParam.PRI_NOMB_PEN)) &&
                                   (a.APE_MATE_PEN.Contains(historiaLinDetParam.APE_MATE_PEN) || string.IsNullOrEmpty(historiaLinDetParam.APE_MATE_PEN)) &&
                                   (a.APE_PATE_PEN.Contains(historiaLinDetParam.APE_PATE_PEN) || string.IsNullOrEmpty(historiaLinDetParam.APE_MATE_PEN)) &&
                                   (a.NUM_DOCU_PEN.Equals(historiaLinDetParam.NUM_DOCU_PEN) || string.IsNullOrEmpty(historiaLinDetParam.NUM_DOCU_PEN)) &&
                                   (a.NUM_SOLI_PEN.Equals(historiaLinDetParam.NUM_SOLI_PEN) || string.IsNullOrEmpty(historiaLinDetParam.NUM_SOLI_PEN))
                             )
                            .Skip(jtStartIndex).Take(jtPageSize).ToList();

                        foreach (var item in query)
                        {
                            //llenar toda la entidad  HistorialCargaArchivo_LinDet 
                            var historiaLinDet = new HistorialCargaArchivo_LinDet()
                            {
                                IdHistorialCargaArchivoLinDet = item.IdHistorialCargaArchivoLinDet,
                                IdHistorialCargaArchivoLinCab = item.IdHistorialCargaArchivoLinCab,
                                FechaInsert = item.FechaInsert,
                                TipoLinea = item.TipoLinea,
                                NumeroLinea = item.NumeroLinea,
                                FEC_DEVE = item.FEC_DEVE,
                                FEC_FALL = item.FEC_FALL,
                                FEC_OCUR = item.FEC_OCUR,
                                FEC_PAGO_APO_ADI = item.FEC_PAGO_APO_ADI,
                                FEC_INV_DEF = item.FEC_INV_DEF,
                                CAP_GAST_SEP = item.CAP_GAST_SEP,
                                PARE = item.PARE,
                                SAL_CIC_SOL = item.SAL_CIC_SOL,
                                TIP_REGI = item.TIP_REGI,
                                TIP_SOLI = item.TIP_SOLI,
                                NUM_BENE = item.NUM_BENE,
                                NUM_MESE_DEV = item.NUM_MESE_DEV,
                                POR_BENE = item.POR_BENE,
                                TIP_IDEN_SOL = item.TIP_IDEN_SOL,
                                TIP_PENS = item.TIP_PENS,
                                TIP_DOCU_IDE_PEN = item.TIP_DOCU_IDE_PEN,
                                TIP_MOVI = item.TIP_MOVI,
                                COD_CSV_01 = item.COD_CSV_01,
                                COD_CSV_02 = item.COD_CSV_02,
                                COD_CSV_03 = item.COD_CSV_03,
                                COD_CSV_04 = item.COD_CSV_04,
                                COD_CSV_05 = item.COD_CSV_05,
                                COD_CSV_06 = item.COD_CSV_06,
                                COD_CSV_07 = item.COD_CSV_07,
                                COD_CSV_08 = item.COD_CSV_08,
                                COD_AFP = item.COD_AFP,
                                COD_IDE_CSV = item.COD_IDE_CSV,
                                FRA_MESE_DEV = item.FRA_MESE_DEV,
                                IND_PENS_PRE = item.IND_PENS_PRE,
                                MTO_PPRE_ORI = item.MTO_PPRE_ORI,
                                TIP_CAMB_VTA = item.TIP_CAMB_VTA,
                                EXC_PENS_SOL = item.EXC_PENS_SOL,
                                EXC_PENS_NM = item.EXC_PENS_NM,
                                MES_DEVE = item.MES_DEVE,
                                CAP_REQU_PEN = item.CAP_REQU_PEN,
                                CRU_FAMI = item.CRU_FAMI,
                                FEC_NACI = item.FEC_NACI,
                                FEC_NACI_PEN = item.FEC_NACI_PEN,
                                FEC_PAGO = item.FEC_PAGO,
                                FEC_PAGO_TEX = item.FEC_PAGO_TEX,
                                FEC_SECI = item.FEC_SECI,
                                FEC_SINI_OCU = item.FEC_SINI_OCU,
                                FEC_DEVE_ACT = item.FEC_DEVE_ACT,
                                FEC_DEVE_INI = item.FEC_DEVE_INI,
                                FEC_FIN_SUB = item.FEC_FIN_SUB,
                                RAM_PROM_SOL = item.RAM_PROM_SOL,
                                TAS_INTE = item.TAS_INTE,
                                VACIO_10 = item.VACIO_10,
                                DES_PENS_MONE = item.DES_PENS_MONE,
                                MTO_APOR_ADI = item.MTO_APOR_ADI,
                                MTO_APOR_ADI_SOL = item.MTO_APOR_ADI_SOL,
                                MTO_APOR_COM = item.MTO_APOR_COM,
                                MTO_PENS_PAG = item.MTO_PENS_PAG,
                                MTO_PPRE_MN = item.MTO_PPRE_MN,
                                MTO_APOR_OBL = item.MTO_APOR_OBL,
                                MTO_MONE_APO_COM1 = item.MTO_MONE_APO_COM1,
                                MTO_MONE_APO_COM2 = item.MTO_MONE_APO_COM2,
                                MTO_MONE_APO_COM3 = item.MTO_MONE_APO_COM3,
                                MTO_MONE_APO_COM4 = item.MTO_MONE_APO_COM4,
                                MTO_MONE_APO_COM5 = item.MTO_MONE_APO_COM5,
                                MTO_MONE_APO_COM6 = item.MTO_MONE_APO_COM6,
                                MTO_MONE_APO_COM7 = item.MTO_MONE_APO_COM7,
                                MTO_MONE_APO_COM8 = item.MTO_MONE_APO_COM8,
                                MTO_MONE_APO_OBL1 = item.MTO_MONE_APO_OBL1,
                                MTO_MONE_APO_OBL2 = item.MTO_MONE_APO_OBL2,
                                MTO_MONE_APO_OBL3 = item.MTO_MONE_APO_OBL3,
                                MTO_MONE_APO_OBL4 = item.MTO_MONE_APO_OBL4,
                                MTO_MONE_APO_OBL5 = item.MTO_MONE_APO_OBL5,
                                MTO_MONE_APO_OBL6 = item.MTO_MONE_APO_OBL6,
                                MTO_MONE_APO_OBL7 = item.MTO_MONE_APO_OBL7,
                                MTO_MONE_APO_OBL8 = item.MTO_MONE_APO_OBL8,
                                MTO_PAGO_REE_SOL = item.MTO_PAGO_REE_SOL,
                                MTO_PRIM_PAG_PENS_AFP1 = item.MTO_PRIM_PAG_PENS_AFP1,
                                MTO_PRIM_PAG_PENS_AFP2 = item.MTO_PRIM_PAG_PENS_AFP2,
                                MTO_PRIM_PAG_PENS_AFP3 = item.MTO_PRIM_PAG_PENS_AFP3,
                                MTO_PRIM_PAG_PENS_AFP4 = item.MTO_PRIM_PAG_PENS_AFP4,
                                MTO_PRIM_PAG_PENS_AFP5 = item.MTO_PRIM_PAG_PENS_AFP5,
                                MTO_PRIM_PAG_PENS_AFP6 = item.MTO_PRIM_PAG_PENS_AFP6,
                                MTO_PRIM_PAG_PENS_AFP7 = item.MTO_PRIM_PAG_PENS_AFP7,
                                MTO_PRIM_PAG_PENS_AFP8 = item.MTO_PRIM_PAG_PENS_AFP8,
                                MTO_DSCT_PENS_PAG_AFP1 = item.MTO_DSCT_PENS_PAG_AFP1,
                                MTO_DSCT_PENS_PAG_AFP2 = item.MTO_DSCT_PENS_PAG_AFP2,
                                MTO_DSCT_PENS_PAG_AFP3 = item.MTO_DSCT_PENS_PAG_AFP3,
                                MTO_DSCT_PENS_PAG_AFP4 = item.MTO_DSCT_PENS_PAG_AFP4,
                                MTO_DSCT_PENS_PAG_AFP5 = item.MTO_DSCT_PENS_PAG_AFP5,
                                MTO_DSCT_PENS_PAG_AFP6 = item.MTO_DSCT_PENS_PAG_AFP6,
                                MTO_DSCT_PENS_PAG_AFP7 = item.MTO_DSCT_PENS_PAG_AFP7,
                                MTO_DSCT_PENS_PAG_AFP8 = item.MTO_DSCT_PENS_PAG_AFP8,
                                MTO_SOLE_APO_ADI_AFP1 = item.MTO_SOLE_APO_ADI_AFP1,
                                MTO_SOLE_APO_ADI_AFP2 = item.MTO_SOLE_APO_ADI_AFP2,
                                MTO_SOLE_APO_ADI_AFP3 = item.MTO_SOLE_APO_ADI_AFP3,
                                MTO_SOLE_APO_ADI_AFP4 = item.MTO_SOLE_APO_ADI_AFP4,
                                MTO_SOLE_APO_ADI_AFP5 = item.MTO_SOLE_APO_ADI_AFP5,
                                MTO_SOLE_APO_ADI_AFP6 = item.MTO_SOLE_APO_ADI_AFP6,
                                MTO_SOLE_APO_ADI_AFP7 = item.MTO_SOLE_APO_ADI_AFP7,
                                MTO_SOLE_APO_ADI_AFP8 = item.MTO_SOLE_APO_ADI_AFP8,
                                MTO_SOLE_REE_PAG_AFP1 = item.MTO_SOLE_REE_PAG_AFP1,
                                MTO_SOLE_REE_PAG_AFP2 = item.MTO_SOLE_REE_PAG_AFP2,
                                MTO_SOLE_REE_PAG_AFP3 = item.MTO_SOLE_REE_PAG_AFP3,
                                MTO_SOLE_REE_PAG_AFP4 = item.MTO_SOLE_REE_PAG_AFP4,
                                MTO_SOLE_REE_PAG_AFP5 = item.MTO_SOLE_REE_PAG_AFP5,
                                MTO_SOLE_REE_PAG_AFP6 = item.MTO_SOLE_REE_PAG_AFP6,
                                MTO_SOLE_REE_PAG_AFP7 = item.MTO_SOLE_REE_PAG_AFP7,
                                MTO_SOLE_REE_PAG_AFP8 = item.MTO_SOLE_REE_PAG_AFP8,
                                NRO_CSV = item.NRO_CSV,
                                NUM_DOCU_SOL = item.NUM_DOCU_SOL,
                                NUM_SINI = item.NUM_SINI,
                                NUM_SOLI = item.NUM_SOLI,
                                NUM_SOLI_PEN = item.NUM_SOLI_PEN,
                                NUM_DOCU_PEN = item.NUM_DOCU_PEN,
                                PEN_PAGA_MON = item.PEN_PAGA_MON,
                                PEN_BASE_MON = item.PEN_BASE_MON,
                                REM_PROM_ACT = item.REM_PROM_ACT,
                                NUM_APOR_ACT = item.NUM_APOR_ACT,
                                SAL_CIC_MN = item.SAL_CIC_MN,
                                TIP_CAMB_COM = item.TIP_CAMB_COM,
                                TIP_MONE = item.TIP_MONE,
                                TOT_CAPI_REQ_MN = item.TOT_CAPI_REQ_MN,
                                TOT_CAPI_REQ_ORI = item.TOT_CAPI_REQ_ORI,
                                COD_CUSP = item.COD_CUSP,
                                COD_BENE_MN = item.COD_BENE_MN,
                                APE_MATE_PEN = item.APE_MATE_PEN,
                                APE_MATE_SOLI = item.APE_MATE_SOLI,
                                APE_PATE_PEN = item.APE_PATE_PEN,
                                APE_PATE_SOL = item.APE_PATE_SOL,
                                PRI_NOMB_PEN = item.PRI_NOMB_PEN,
                                PRI_NOMB_SOL = item.PRI_NOMB_SOL,
                                SEG_NOMB_PEN = item.SEG_NOMB_PEN,
                                SEG_NOMB_SOL = item.SEG_NOMB_SOL,
                                SUC_INTE = item.SUC_INTE,
                                CumpleValidacion = item.CumpleValidacion,
                                HistorialCargaArchivo_LinCab = new HistorialCargaArchivo_LinCab()
                                {
                                    CONTRATO_SYS = new CONTRATO_SYS()
                                    {
                                        NRO_CONTRATO = item.HistorialCargaArchivo_LinCab.CONTRATO_SYS.NRO_CONTRATO
                                    }
                                }
                            };
                            listDetalle.Add(historiaLinDet);
                        }
                    }
                }
                return listDetalle;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}