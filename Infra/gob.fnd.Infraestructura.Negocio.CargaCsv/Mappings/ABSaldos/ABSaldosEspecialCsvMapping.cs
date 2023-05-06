﻿using gob.fnd.Dominio.Digitalizacion.Entidades.CorteDiario.ABSaldos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;
using TinyCsvParser.TypeConverter;

namespace gob.fnd.Infraestructura.Negocio.CargaCsv.Mappings.ABSaldos
{
    public class ABSaldosEspecialCsvMapping : CsvMapping<ABSaldosEspecialCarga>
    {
        public ABSaldosEspecialCsvMapping()
            : base()
        {
            MapProperty(00, p => p.Regional);
            MapProperty(01, p => p.NumCte);
            MapProperty(02, p => p.Sucursal);
            MapProperty(03, p => p.ApellPaterno);
            MapProperty(04, p => p.ApellMaterno);
            MapProperty(05, p => p.Nombre1);
            MapProperty(06, p => p.Nombre2);
            MapProperty(07, p => p.Tnfinal);
            MapProperty(08, p => p.RazonSocial);
            MapProperty(09, p => p.ActividadPrinc);
            MapProperty(10, p => p.Sector);
            MapProperty(11, p => p.TpoPersona);
            MapProperty(12, p => p.EstadoInegi);
            MapProperty(13, p => p.MunicipioInegi);
            MapProperty(14, p => p.LocalidadInegi);
            MapProperty(15, p => p.NumCredito);
            MapProperty(16, p => p.NumProducto);
            MapProperty(17, p => p.Divisa);
            MapProperty(18, p => p.CodLinea);
            MapProperty(19, p => p.PorcRecProp);
            MapProperty(20, p => p.TipoCartera);
            MapProperty(21, p => p.FechaApertura, new DateTimeConverter("MM/dd/yyyy"));
            MapProperty(22, p => p.FechaVencim, new DateTimeConverter("MM/dd/yyyy"));
            MapProperty(23, p => p.TasaInteres);
            MapProperty(24, p => p.TasaFijaOVar);
            MapProperty(25, p => p.CodTasaBase);
            MapProperty(26, p => p.Superficie);
            MapProperty(27, p => p.Actividad);
            MapProperty(28, p => p.RelGarcred);
            MapProperty(29, p => p.CodigoInsCre);
            MapProperty(30, p => p.CodInversion);
            MapProperty(31, p => p.CodCaract);
            MapProperty(32, p => p.CodCaract2);
            MapProperty(33, p => p.CodAgricola);
            MapProperty(34, p => p.CodProd);
            MapProperty(35, p => p.StatusContable);
            MapProperty(36, p => p.PorcentajeEstim);
            MapProperty(37, p => p.ElegiblePf);
            MapProperty(38, p => p.PorcentajeFiFo);
            MapProperty(39, p => p.BanderaFiFo);
            MapProperty(40, p => p.MontoOtorgado);
            MapProperty(41, p => p.MtoMinistraCap);
            MapProperty(42, p => p.SldoCapCont);
            MapProperty(43, p => p.SldoIntCont);
            MapProperty(44, p => p.SldoTotCont);
            MapProperty(45, p => p.SldoTotContval);
            MapProperty(46, p => p.NumContrato);
            MapProperty(47, p => p.FechaSuscripcion);
            MapProperty(48, p => p.FechaVencCont);
            MapProperty(49, p => p.MontoAutoCont);
            MapProperty(50, p => p.MontoEjercido);
            MapProperty(51, p => p.TipoCreditoCont);
            MapProperty(52, p => p.EsUnionCredito);
            MapProperty(53, p => p.DatosRegistro);
            MapProperty(54, p => p.CodCalifica);
            MapProperty(55, p => p.Nocreditos);
            MapProperty(56, p => p.Noclientes);
            MapProperty(57, p => p.CodigoIns);
            MapProperty(58, p => p.PorcenRedesc);
            MapProperty(59, p => p.FactorAplica);
            MapProperty(60, p => p.TipoMargen);
            MapProperty(61, p => p.MargenInter);
            MapProperty(62, p => p.LineaDesc);
            MapProperty(63, p => p.TasaFon);
            MapProperty(64, p => p.NumControl);
            MapProperty(65, p => p.Marcacred);
            MapProperty(66, p => p.CodSujetoFj);
            MapProperty(67, p => p.CalEdosFin);
            MapProperty(68, p => p.CapVig);
            MapProperty(69, p => p.IntFinVig);
            MapProperty(70, p => p.IntFinVigNp);
            MapProperty(71, p => p.CapVen);
            MapProperty(72, p => p.IntFinVen);
            MapProperty(73, p => p.IntFinVenNp);
            MapProperty(74, p => p.IntNorVig);
            MapProperty(75, p => p.IntNorVigNp);
            MapProperty(76, p => p.IntNorVen);
            MapProperty(77, p => p.IntNorVenNp);
            MapProperty(78, p => p.IntDesVen);
            MapProperty(79, p => p.IntPen);
            MapProperty(80, p => p.DCapVig);
            MapProperty(81, p => p.DIntFinVig);
            MapProperty(82, p => p.DIntFinVigNp);
            MapProperty(83, p => p.DIntNorVig);
            MapProperty(84, p => p.DIntNorVigNp);
            MapProperty(85, p => p.TipoCredito);
            MapProperty(86, p => p.TipoDescuento);
            MapProperty(87, p => p.FechaIngusgaap);
            MapProperty(88, p => p.CuotasCap);
            MapProperty(89, p => p.CuotasCapVen);
            MapProperty(90, p => p.CuotasInt);
            MapProperty(91, p => p.CuotasIntVen);
            MapProperty(92, p => p.DiasVenusgaap);
            MapProperty(93, p => p.DiasVennopag);
            MapProperty(94, p => p.ClaveAsigusgaap);
            MapProperty(95, p => p.Ejecutivo);
            MapProperty(96, p => p.Unidad);
            MapProperty(97, p => p.FechaMinis);
            MapProperty(98, p => p.CobroCapital);
            MapProperty(99, p => p.CobroInt);
            MapProperty(100, p => p.FolioAserca);
            MapProperty(101, p => p.CredDemandado);
            MapProperty(102, p => p.ImpPgsCredmnd);
        }
    }
}
