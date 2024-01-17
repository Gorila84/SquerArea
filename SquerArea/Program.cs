using System.Globalization;

double width;
double height;
double diagonal;
string squereHeight;
string squereWidth;

NumberStyles style = NumberStyles.AllowDecimalPoint;

Console.WriteLine("Wpisz wysokośc prostokąta (format 0,00):");
squereHeight = Console.ReadLine();
squereHeight = squereHeight.Replace(',', '.');
double.TryParse(squereHeight, style, CultureInfo.InvariantCulture, out height);

Console.WriteLine("Wpisz szerokość prostokąta (format 0,00):");
squereWidth = Console.ReadLine();
squereWidth = squereWidth.Replace(',', '.');
double.TryParse(squereWidth, style, CultureInfo.InvariantCulture, out width);

diagonal = Math.Sqrt((Math.Pow(width, 2) + Math.Pow(height, 2)));
Console.WriteLine($"Przekątna prostokąta o wsyokości {height} i szerokości {width} wynosi: {diagonal.ToString("F2")}");
