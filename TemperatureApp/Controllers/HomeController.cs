using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemperatureApp.Models;
using Temperature;

namespace TemperatureApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(IFormCollection iFormCollection)
    {
        Conversion con = new Conversion();
        if (iFormCollection["temperature"] == "Celsius_to_Fahrenheit")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, Convert.ToDouble(iFormCollection["temp"]));
        }
        else if (iFormCollection["temperature"] == "Kelvin_to_Fahrenheit")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, Convert.ToDouble(iFormCollection["temp"]));
        }
        else if (iFormCollection["temperature"] == "Celsius_to_Kelvin")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, Convert.ToDouble(iFormCollection["temp"]));
        }
        else if (iFormCollection["temperature"] == "Kelvin_to_Celsius")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, Convert.ToDouble(iFormCollection["temp"]));
        }
        else if (iFormCollection["temperature"] == "Fahrenheit_to_Kelvin")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, Convert.ToDouble(iFormCollection["temp"]));
        }
        else if (iFormCollection["temperature"] == "Celsius_to_Fahrenheit")
        {
            ViewData["temp"] = con.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, Convert.ToDouble(iFormCollection["temp"]));
        }
        else
        {
            ViewData["temp"] = iFormCollection["temp"];
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
