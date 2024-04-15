﻿using Newtonsoft.Json;

namespace Barreto.Exe.Maui.Utils;

public static class AppUtils
{
    public static string GetConfigValue(string key)
    {
        using var stream = FileSystem.OpenAppPackageFileAsync("data.json").Result;
        using var reader = new StreamReader(stream);
        var jsonVariables = reader.ReadToEnd();

        //Convert the json into a dictionary
        var variables = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonVariables);

        //Return the value of the key if it exists, otherwise return null
        return variables.TryGetValue(key, out string value) ? value : null;
    }

    public static async Task ShowAlert(string title, string message)
    {
        await Application.Current.MainPage.DisplayAlert(title, message, "Aceptar");
    }
    public static async Task ShowAlert(string message, AlertType type = AlertType.Info)
    {
        string title = type switch
        {
            AlertType.Success => "✅ Éxito",
            AlertType.Error => "❌ Error",
            AlertType.Warning => "⚠️ Alerta",
            _ => "ℹ️ Información"
        };

        await Application.Current.MainPage.DisplayAlert(title, message, "Aceptar");
    }
    public static async Task CheckConnection()
    {
        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
        {
            await ShowAlert("No hay conexión a internet.", AlertType.Error);
            Application.Current.Quit();
        }
    }

}
public enum AlertType
{
    Success,
    Error,
    Warning,
    Info
}