using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;



List<string> ciudadanos = new List<string>();
for (int i = 1; i <= 500; i++)
    ciudadanos.Add("Ciudadano " + i);


HashSet<string> pfizer = new HashSet<string>();
HashSet<string> astraZeneca = new HashSet<string>();
Random rnd = new Random();

while (pfizer.Count < 75)
    pfizer.Add(ciudadanos[rnd.Next(0, 500)]);

while (astraZeneca.Count < 75)
    astraZeneca.Add(ciudadanos[rnd.Next(0, 500)]);


HashSet<string> todos = new HashSet<string>(ciudadanos);


HashSet<string> vacunadosUnion = new HashSet<string>(pfizer);
vacunadosUnion.UnionWith(astraZeneca);
HashSet<string> noVacunados = new HashSet<string>(todos);
noVacunados.ExceptWith(vacunadosUnion);

// Ambas dosis = Pfizer ∩ AstraZeneca
HashSet<string> ambasDosis = new HashSet<string>(pfizer);
ambasDosis.IntersectWith(astraZeneca);

// Solo Pfizer = Pfizer – AstraZeneca
HashSet<string> soloPfizer = new HashSet<string>(pfizer);
soloPfizer.ExceptWith(astraZeneca);

// Solo AstraZeneca = AstraZeneca – Pfizer
HashSet<string> soloAstraZeneca = new HashSet<string>(astraZeneca);
soloAstraZeneca.ExceptWith(pfizer);

// Imprimir resultados en consola
Console.WriteLine("No vacunados: " + string.Join(", ", noVacunados));
Console.WriteLine("\nAmbas dosis: " + string.Join(", ", ambasDosis));
Console.WriteLine("\nSolo Pfizer: " + string.Join(", ", soloPfizer));
Console.WriteLine("\nSolo AstraZeneca: " + string.Join(", ", soloAstraZeneca));

// Generar PDF
string path = "ReporteVacunacion.pdf";
PdfWriter writer = new PdfWriter(path);
PdfDocument pdf = new PdfDocument(writer);
Document document = new Document(pdf);

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
