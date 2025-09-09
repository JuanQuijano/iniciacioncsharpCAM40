Console.Clear();

var fruit = "orange";
var mensaje = string.Empty;

switch (fruit)
{
    case "apple":
        mensaje = "App will display information for apple.";
        break;

    case "banana":
        mensaje = "App will display information for banana.";
        break;

    case "cherry":
        mensaje = "App will display information for cherry.";
        break;

    default:
        mensaje = "App will display information for a fruit not listed.";
        break;
}

 Console.WriteLine(mensaje);