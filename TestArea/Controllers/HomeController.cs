using System;
using System.Web;
using System.Web.Mvc;
using TestArea.Models;

namespace TestArea.Controllers
{
    public class HomeController : Controller
    {
        LoggerService.LoggerClient loggerService = new LoggerService.LoggerClient();

        public ActionResult Index()
        {
            loggerService.Info("Open StartPage");
            return View();
        }

        public ActionResult SetPoints(Figure model)
        {
            loggerService.Info("Count the area");
            loggerService.Debug("In function SetPoints");
            try
            {
                string[] sepPoints = model.values.Split('\n');
                string[][] numPoints = new string[sepPoints.Length][];
                for (int i = 0; i < sepPoints.Length; i++)
                {
                    sepPoints[i] = sepPoints[i].Trim();
                    numPoints[i] = sepPoints[i].Split(' ');
                }
                DeleteEmpty(ref numPoints);
                loggerService.Debug("Empty points deleted");
                model.x = new int[numPoints.Length];
                model.y = new int[numPoints.Length];
                for (int i = 0; i < numPoints.Length; i++)
                {
                    model.x[i] = Convert.ToInt32(numPoints[i][0]);
                    model.y[i] = Convert.ToInt32(numPoints[i][1]);
                }
                loggerService.Debug("All points to the model setted");
                CountArea(model);
                loggerService.Debug("Area counted");
                return View("../Home/Result", model);
            }
            catch (Exception ex)
            {
                loggerService.Fatal(ex.Message);
                throw new HttpException((int)System.Net.HttpStatusCode.BadRequest, "No coordinates");
            }
        }

        public void CountArea (Figure model)
        {
            loggerService.Debug("In function CountArea");
            int numOfPoints = model.x.Length;
            double areaByX = 0;
            double areaByY = 0;
            int[] x = new int[numOfPoints + 2];
            int[] y = new int[numOfPoints + 2];
            for (int i = 1; i < x.Length - 1; i++)
            {
                x[i] = model.x[i - 1];
                y[i] = model.y[i - 1];
            }
            x[0] = model.x[numOfPoints - 1];
            x[x.Length - 1] = model.x[0];
            y[0] = model.y[numOfPoints - 1];
            y[y.Length - 1] = model.y[0];
            for (int i = 1; i < x.Length - 1; i++)
            {
                areaByX += x[i] * (y[i + 1] - y[i - 1]);
                areaByY += y[i] * (x[i - 1] - x[i + 1]);
            }
            areaByX = Math.Abs(areaByX / 2);
            areaByY = Math.Abs(areaByY / 2);
            loggerService.Debug("Area by X = " + areaByX.ToString());
            loggerService.Debug("Area by Y = " + areaByY.ToString());
            if (areaByX == areaByY) model.area = areaByX;
            else
            {
                loggerService.Error("Areas by X and by Y are not equal");
            };
        }

        public void RemoveAt<T>(ref T[] arr, int index)
        {
            loggerService.Debug("In function RemoveAt");
            for (int a = index; a < arr.Length - 1; a++)
            {
                arr[a] = arr[a + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        public void DeleteEmpty(ref string[][] array)
        {
            loggerService.Debug("In function DeleteEmpty");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == "")
                    {
                        RemoveAt(ref array, i);
                        if (i != 0) i--;
                        else j--;
                    }
                }
            }
        }

        public ActionResult Logger()
        {
            return View("../Home/Logger");
        }

        public ActionResult Trace()
        {
            return Redirect("../trace.axd");
        }
    }
}