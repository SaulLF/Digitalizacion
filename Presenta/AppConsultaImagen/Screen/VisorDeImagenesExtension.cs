﻿using CefSharp;
using CefSharp.WinForms;
using gob.fnd.Dominio.Digitalizacion.Entidades.Consultas;
using gob.fnd.Dominio.Digitalizacion.Entidades.Imagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsultaImagen;

/// <summary>
/// Aqui van las rutinas relacionadas con el visor de imágenes
/// </summary>
public partial class MainFRM
{
    // private CefSharp.WinForms.ChromiumWebBrowser browser = new();
    private ArchivoImagenCorta[]? imagenesEncontradas = null;
    private int imagenActual = 0;
    private int regresaTabNavegacion = 0;
    private int regresaTabReportesFinales = 0;
    private string _unidadDeDiscoImagenes = "";


    protected void InicializaVisorDeImagenes()
    {
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
        btnImagenAnterior.Click += BtnImagenAnterior;
        btnImagenSiguiente.Click += BtnImagenSiguiente;
        btnRegresaBusquedaImagenNormal.Click += BtnRegresaBusquedaImagenNormalClick;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).


    }

    private void BtnRegresaBusquedaImagenNormalClick(object? sender, EventArgs e)
    {
        canNavigate = true;
        try
        {
            tabNavegacion.SelectedIndex = regresaTabNavegacion;
            tabReportesFinales.SelectedIndex = regresaTabReportesFinales;
        }
        finally
        {
            canNavigate = false;
        }
    }

    protected void CargaImagen(string imageFile) {
        if (File.Exists(imageFile))
        {
            var uri = new System.Uri(imageFile);
            var converted = uri.AbsoluteUri + "#toolbar";
            PnlMuestraImagenes.Visible = false;
            PnlMuestraImagenes.Update();
            Application.DoEvents();
            chromiumWebBrowser1.LoadUrl(converted);

            PnlMuestraImagenes.Visible = true;
            PnlMuestraImagenes.Update();
            Application.DoEvents();
        }
    }

    private void ChromiumWebBrowser1_LoadingStateChanged(object? sender, LoadingStateChangedEventArgs e)
    {
        string fileName = string.Format("{0}cargando.txt", _unidadDeDiscoImagenes);
        //chromiumWebBrowser1.Visible = !e.IsLoading;
        if (e.IsLoading)
        {
            if (!File.Exists(fileName))
            {
                System.IO.StreamWriter outputFile = new (fileName);  // System.IO.StreamWriter
                outputFile.WriteLine(fileName);
                outputFile.Close();
            }
        }
        else
            if (File.Exists(fileName))
                File.Delete(fileName);
    }

    private void MuestraExpedienteEnImagen(ExpedienteDeConsulta? expediente)
    {
        if (expediente == null)
        {
            pnlVisorDeImagenes.Visible = false;
            return;
        }
        pnlVisorDeImagenes.Visible = true;

        txtNumCreditoVI.Text = expediente.NumCredito;
        txtAcreditadoVI.Text = expediente.Acreditado;
        txtAnalistaVI.Text = expediente.Analista;
        txtFechaEntradaMesaVI.Text = expediente.FechaSolicitud.HasValue? expediente.FechaSolicitud.Value.ToShortDateString() : string.Empty;
        txtFechaPrimeraMinistracionVI.Text = expediente.FechaInicioMinistracion.HasValue ? expediente.FechaInicioMinistracion.Value.ToShortDateString() : string.Empty;
    }

    protected void ImagenAnterior() 
    {
        if (imagenActual == 0)
        {
            MessageBox.Show("Es la primera imagen");
            return;
        }
        else
        {
            imagenActual--;
            if (imagenesEncontradas is not null && imagenesEncontradas.Length > 0)
            {
                string archivoActual = Path.Combine(imagenesEncontradas[imagenActual].CarpetaDestino ?? "", imagenesEncontradas[imagenActual].NombreArchivo ?? "");
                if (!File.Exists(archivoActual))
                {
                    archivoActual = Path.Combine(imagenesEncontradas[imagenActual].CarpetaDestino ?? "", imagenesEncontradas[imagenActual].NombreArchivo ?? "").Replace("F:\\", _unidadDeDiscoImagenes, StringComparison.OrdinalIgnoreCase);
                }
                lblCargando.Text = "Cargando...";
                lblCargando.ForeColor = Color.Red;
                lblCargando.Visible = true;
                try
                {
                    CargaImagen(archivoActual);
                }
                finally
                {
                    lblCargando.Text = String.Format("Imagen {0}/{1}", imagenActual + 1, imagenesEncontradas.Length);
                    lblCargando.ForeColor = Color.Black;
                    lblCargando.Visible = true;
                }
            }
        }
        
    }

    protected void ImagenSiguiente()
    {
        if (imagenesEncontradas is null || imagenActual == imagenesEncontradas.Length  -1)
        {
            MessageBox.Show("Es la ultima imagen");
            return;
        }
        else
        {
            imagenActual++;
            if (imagenesEncontradas is not null && imagenesEncontradas.Length > 0)
            {
                string archivoActual = Path.Combine(imagenesEncontradas[imagenActual].CarpetaDestino ?? "", imagenesEncontradas[imagenActual].NombreArchivo ?? "");
                if (!File.Exists(archivoActual))
                {
                    archivoActual = Path.Combine(imagenesEncontradas[imagenActual].CarpetaDestino ?? "", imagenesEncontradas[imagenActual].NombreArchivo ?? "").Replace("F:\\", _unidadDeDiscoImagenes, StringComparison.OrdinalIgnoreCase);
                }
                lblCargando.Text = "Cargando...";
                lblCargando.ForeColor = Color.Red;
                lblCargando.Visible = true;
                try
                {
                    CargaImagen(archivoActual);
                }
                finally
                {
                    lblCargando.Text = String.Format("Imagen {0}/{1}", imagenActual + 1, imagenesEncontradas.Length);
                    lblCargando.ForeColor = Color.Black;
                    lblCargando.Visible = true;
                }
            }
        }
    }
    private void BtnImagenSiguiente(object sender, EventArgs e)
    {
        ImagenSiguiente();
    }

    private void BtnImagenAnterior(object sender, EventArgs e)
    {
        ImagenAnterior();
    }
}
