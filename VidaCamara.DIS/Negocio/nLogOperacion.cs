﻿using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using VidaCamara.DIS.data;
using VidaCamara.DIS.Modelo;
using VidaCamara.DIS.Modelo.EEntidad;

namespace VidaCamara.DIS.Negocio
{
    public class nLogOperacion
    {
        private DateTime FechEven = DateTime.Now;
        private String CodiCnx = String.Empty;
        //este el el metodo generico para llamar desde cualquier parte de la aplicacion
        //ejemplo
        //llena la entidad
        //var operacion = LogOperacion(){agregar sus propiedades menos (FechEven,CodiCnx)}
        //luego instacia la clase nLogOperacion
        //var negocio = nLogOperacion().setGuardarLogOperacion(operacion);
        public long setGuardarLogOperacion(LogOperacion log)
        { 
            log.FechEven = FechEven;
            log.CodiCnx = CodiCnx;
            return new dLogOperacion().setGuardarLogOperacion(log);
        }

        public void setLLenarEntidad(int IdeContrato,string TipoOper,string CodiEven, string CodiOper,string CodiUsu)
        {
            var entity = new LogOperacion()
            {
                IDE_CONTRATO = IdeContrato,
                TipoOper = TipoOper,
                CodiEven = CodiEven,
                CodiOper = CodiOper,
                CodiUsu = CodiUsu
            };
            this.setGuardarLogOperacion(entity);
        }

        public List<HLogOperacion> getListLogOperacion(HLogOperacion log, int jtStartIndex, int jtPageSize,object[] filters, out int total) 
        {
            return new dLogOperacion().getListLogOperacion(log, jtStartIndex, jtPageSize, filters, out total);
        }
        public string descargarConsultaExcel(HLogOperacion log, object[] filters)
        {
            try
            {
                var nombreArchivo = "Log " + filters[0].ToString() + " " + DateTime.Now.ToString("yyyyMMdd");
                var rutaTemporal = @HttpContext.Current.Server.MapPath("~/Temp/Descargas/" + nombreArchivo + ".xlsx");
                int total;
                var book = new XSSFWorkbook();
                string[] columns = { "Contrato", "Tipo evento", "Fecha  evento", "Evento", "Usuario" };
                var sheet = book.CreateSheet(nombreArchivo);
                var rowBook = sheet.CreateRow(1);
                ICell cellBook;
                for (int i = 0; i < columns.Length; i++)
                {
                    cellBook = rowBook.CreateCell(i + 1);
                    cellBook.SetCellValue(columns[i]);
                    cellBook.CellStyle = setFontText(12, true, book);
                }
                var listLogOperacion = getListLogOperacion(log, 0, 100000, filters, out total);
                for (int i = 0; i < listLogOperacion.Count; i++)
                {
                    var rowBody = sheet.CreateRow(2 + i);

                    ICell cellContrato = rowBody.CreateCell(1);
                    cellContrato.SetCellValue(listLogOperacion[i].IDE_CONTRATO);
                    cellContrato.CellStyle = setFontText(11, false, book);

                    ICell cellTipoEvento = rowBody.CreateCell(2);
                    cellTipoEvento.SetCellValue(listLogOperacion[i].TipoEvento);
                    cellTipoEvento.CellStyle = setFontText(11, false, book);

                    ICell cellFechaEvento = rowBody.CreateCell(3);
                    cellFechaEvento.SetCellValue(listLogOperacion[i].FechEven.ToString());
                    cellFechaEvento.CellStyle = setFontText(11, false, book);

                    ICell cellEvento = rowBody.CreateCell(4);
                    cellEvento.SetCellValue(listLogOperacion[i].Evento);
                    cellEvento.CellStyle = setFontText(11, false, book);

                    ICell cellUsuario = rowBody.CreateCell(5);
                    cellUsuario.SetCellValue(listLogOperacion[i].CodiUsu);
                    cellUsuario.CellStyle = setFontText(11, false, book);
                }

                using (var file = new FileStream(rutaTemporal, FileMode.Create, FileAccess.ReadWrite))
                {
                    book.Write(file);
                    file.Close();
                    book.Close();
                }

                return rutaTemporal;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private ICellStyle setFontText(short point, bool color, XSSFWorkbook book)
        {
            var font = book.CreateFont();
            font.FontName = "Calibri";
            font.Color = (IndexedColors.Black.Index);
            font.FontHeightInPoints = point;

            var style = book.CreateCellStyle();
            style.SetFont(font);
            style.Alignment = HorizontalAlignment.Center;
            style.VerticalAlignment = VerticalAlignment.Center;
            if (color)
            {
                style.FillForegroundColor = HSSFColor.Grey25Percent.Index;
                style.FillPattern = FillPattern.SolidForeground;
            }
            style.BorderBottom = BorderStyle.Thin;
            style.BorderTop = BorderStyle.Thin;
            style.BorderLeft = BorderStyle.Thin;
            style.BorderRight = BorderStyle.Thin;
            return style;
        }
    }
}
