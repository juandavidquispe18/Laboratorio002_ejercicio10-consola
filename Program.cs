// See https://aka.ms/new-console-template for more information

//Ingresar datos de consumo
Console.Write("Ingrese el monto total del consumo: ");
double monto_consumo = Convert.ToDouble(Console.ReadLine());

//Operaciones y cálculos
bool aplica_descuento = monto_consumo > 100;

double descuento = aplica_descuento ? 0.2 * monto_consumo : 0.1 * monto_consumo;
double impuesto = 0.18 * monto_consumo;
double sub_total = monto_consumo + impuesto;
double importe_total = sub_total - descuento;

//Mostrar resultado
Console.WriteLine($"Monto del descuento: S/ {descuento}");
Console.WriteLine($"Impuesto (18%): S/ {impuesto}");
Console.WriteLine($"Subtotal: S/ {sub_total}");
Console.WriteLine($"Importe a pagar: S/ {importe_total}");
Console.ReadKey();