// iText para PDF
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

// Generar 500 ciudadanos
var ciudadanos = new List<string>();
for (int i = 1; i <= 500; i++)
    ciudadanos.Add("Ciudadano " + i);

// Seleccionar 75 para Pfizer y 75 para AstraZeneca
var pfizer = new HashSet<string>();
var astraZeneca = new HashSet<string>();
var rnd = new Random();

while (pfizer.Count < 75)
    pfizer.Add(ciudadanos[rnd.Next(0, 500)]);

while (astraZeneca.Count < 75)
    astraZeneca.Add(ciudadanos[rnd.Next(0, 500)]);

// Operaciones de conjuntos
var todos = new HashSet<string>(ciudadanos);

// No vacunados = Todos – (Pfizer ∪ AstraZeneca)
var vacunadosUnion = new HashSet<string>(pfizer);
vacunadosUnion.UnionWith(astraZeneca);
var noVacunados = new HashSet<string>(todos);
noVacunados.ExceptWith(vacunadosUnion);

// Ambas dosis = Pfizer ∩ AstraZeneca
var ambasDosis = new HashSet<string>(pfizer);
ambasDosis.IntersectWith(astraZeneca);

// Solo Pfizer = Pfizer – AstraZeneca
var soloPfizer = new HashSet<string>(pfizer);
soloPfizer.ExceptWith(astraZeneca);

// Solo AstraZeneca = AstraZeneca – Pfizer
var soloAstraZeneca = new HashSet<string>(astraZeneca);
soloAstraZeneca.ExceptWith(pfizer);

// 4️⃣ Imprimir resultados en consola
Console.WriteLine("No vacunados: " + string.Join(", ", noVacunados));
Console.WriteLine("\nAmbas dosis: " + string.Join(", ", ambasDosis));
Console.WriteLine("\nSolo Pfizer: " + string.Join(", ", soloPfizer));
Console.WriteLine("\nSolo AstraZeneca: " + string.Join(", ", soloAstraZeneca));

// 5️⃣ Generar PDF
string path = "ReporteVacunacion.pdf";
var writer = new PdfWriter(path);
var pdf = new PdfDocument(writer);
var document = new Document(pdf);

document.Add(new Paragraph("Reporte de Vacunación COVID-19"));
document.Add(new Paragraph("--------------------------------------------------"));

document.Add(new Paragraph("No vacunados:"));
document.Add(new Paragraph(string.Join(", ", noVacunados)));

document.Add(new Paragraph("\nAmbas dosis:"));
document.Add(new Paragraph(string.Join(", ", ambasDosis)));

document.Add(new Paragraph("\nSolo Pfizer:"));
document.Add(new Paragraph(string.Join(", ", soloPfizer)));

document.Add(new Paragraph("\nSolo AstraZeneca:"));
document.Add(new Paragraph(string.Join(", ", soloAstraZeneca)));

document.Close();

Console.WriteLine($"\nPDF generado en: {System.IO.Path.GetFullPath(path)}");
