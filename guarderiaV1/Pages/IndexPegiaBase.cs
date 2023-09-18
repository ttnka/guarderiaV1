using Microsoft.AspNetCore.Components;
using Radzen.Blazor;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading.Tasks;

namespace guarderiaV1.Pages
{
    public class IndexPegiaBase : ComponentBase 
    {
        protected string Titulo01 { get; set; }  = string.Empty;
        protected string Titulo02 { get; set; } = string.Empty;
        protected string BgColor { get; set; } = "lightgray";
        protected string Proyecto { get; set; } = "";
        protected List<KeyValuePair<string, string>> ProyectosList { get; set; } =
            new List<KeyValuePair<string, string>>();
        protected string[] T1 = {"Factibilidad", "Resumen Ejecutivo",
            "Análisis del Mercado", "Análisis Técnico", "Estudio Ambiental y Social",
            "Análisis Financiero", "Plan de Negocios", "Análisis de Riesgos",
            "Cronograma y Planificación", "Estudio Legal y Regulatorio" };
        protected int Indice { get; set; } = 0;

        protected override Task OnInitializedAsync()
        {
            LeerProyectos();
            return base.OnInitializedAsync();
        }

        protected void LeerProyectos ()
        {
            ProyectosList.Add(new KeyValuePair<string, string>("Norte", "Parque Norte"));
            ProyectosList.Add(new KeyValuePair<string, string>("Sur", "Parque Ford"));
        }
        protected void ElProyectoSelect()
        {
            BgColor = Proyecto == "Norte" ? "orange" : "lightblue";
        }
        protected void LeerTab(int tab)
        {
            Indice = tab;
            Titulo01 = T1[Indice];
            Titulo02 = LeerTitulos();
            
        }
        protected string LeerTitulos()
        {
            try
            {
                if (Indice < 0 || Indice > T1.Length - 1) return "Error";
                string resp = "";
                
                switch (Indice)
                {
                    case 0:
                        resp = "Este es un documento principal que ";
                        resp += "detalla el análisis completo del proyecto.";
                        resp += "Incluye información sobre el mercado, la tecnología,";
                        resp += "la organización, el financiamiento y la evaluación"; 
                        resp += "financiera";
                        
                        break;
                    case 1:
                        resp = "Es un resumen conciso de todo el proyecto, ";
                        resp += "destacando los aspectos más importantes, ";
                        resp += "como el objetivo del proyecto, los beneficios ";
                        resp += "esperados, los costos involucrados y la rentabilidad ";
                        resp += "proyectada";
                        break;
                    case 2:
                        resp = "Este documento se integrar de las ofertas hechas por los ";
                        resp += "clientes(ordenes de compra de las maquiladoras).";
                    break;
                    case 3:
                        resp = "En este documento se describe en detalle los procesos y los ";
                        resp += "recursos necesarios para llevar a cabo el proyecto. Se evalúa ";
                        resp += "la viabilidad técnica y se identifican posibles desafíos.";
                        break;
                    case 4:
                        resp = "Aquí se detallan los costos y los ingresos asociados al ";
                        resp += "proyecto a lo largo del tiempo.Se calculan indicadores ";
                        resp += "financieros como el VAN(Valor Actual Neto), la TIR(Tasa ";
                        resp += "Interna de Retorno) y el período de recuperación.";
                        break; 
                    case 5:
                        resp = "Un plan detallado que describe cómo se llevará a cabo el ";
                        resp += "proyecto. Incluye la estructura organizativa, la estrategia ";
                        resp += "de marketing, el plan de operaciones y el enfoque de ";
                        resp += "financiamiento";
                        break;
                    case 6:
                        resp = "Se identifican y evalúan los riesgos que podrían afectar al ";
                        resp += "proyecto. También se proponen estrategias para mitigar estos riesgos";
                        break;
                    case 7:
                        resp = "Se establece un cronograma detallado que muestra las diferentes etapas ";
                        resp += "del proyecto y el tiempo estimado para completarlas.";
                        break;
                    case 8:
                        resp = "Se analizan las regulaciones, permisos y licencias necesarias para ";
                        resp += "llevar a cabo el proyecto. Se asegura que el proyecto cumpla con todas las normativas.";
                        break;
                    default:
                        resp = "Vacio, selecciona nuevamente";
                        break;
                }
                return resp;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
            
    }
}
