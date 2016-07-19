#region Usings

using System;
using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Http;
using RedingtonMiniProject.Helpers;
using RedingtonMiniProject.Models;

#endregion

namespace RedingtonMiniProject.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpGet]
        public double Index()
        {
            return -1;
        }

        [HttpGet]
        public double CombineWith(double a, double b)
        {
            try
            {
                var result = ProbabilityCalculatorTool.CombineWith(a, b);
                LogOperation(Operation.CombineWith, a, b, result.ToString());
                return result;
            }
            catch (Exception e)
            {
                LogOperation(Operation.CombineWith, a, b, "Exception: " + e.GetType().Name);
                return -1;
            }
        }

        [HttpGet]
        public double Either(double a, double b)
        {
            try
            {
                var result = ProbabilityCalculatorTool.Either(a, b);
                LogOperation(Operation.Either, a, b, result.ToString());
                return result;
            }
            catch (Exception e)
            {
                LogOperation(Operation.Either, a, b, "Exception: " + e.GetType().Name);
                return -1;
            }
        }

        private void LogOperation(Operation operation, double a, double b, string result)
        {
            var logPath = GetLogPath();

            if (logPath == null)
            {
                // For some reason logFile path cannot be obtained. Returning
                return;
            }

            if (!File.Exists(logPath))
            {
                File.Create(logPath);
            }

            using (var streamWriter = File.AppendText(logPath))
            {
                streamWriter.WriteLine($"{DateTime.Now} {operation} a={a} b={b} result={result}");
            }
        }

        private string GetLogPath()
        {
            var filename = ConfigurationManager.AppSettings["LogFilename"];
            if (string.IsNullOrEmpty(filename))
            {
                return null;
            }

            return HttpContext.Current?.Server.MapPath("~/App_Data/" + filename);
        }
    }
}