using System;
using MisUtilidades;
using static MisUtilidades.InterfazConsola;

void pesajeEquipaje(string tipoTarifa, string tipoVuelo)
{
    int cantidadItems;
    if (tipoTarifa.ToUpper() == "P" || tipoTarifa.ToUpper() == "B")
    {
        cantidadItems = 1;
    }
        else if (tipoTarifa.ToUpper() == "F")
        {
            cantidadItems = 2;
        }
            else
            {
                cantidadItems = 3;
            }

    ImprimirTitulo("Pesaje de Equipaje");

    MensajeInfo($"Cantidad de items permitidos para el equipaje: {cantidadItems}");
    double pesoNacional = 0;
    double pesoInternacional = 0;
    for (int i = 1; i <= cantidadItems; i++)
    {
        Console.WriteLine($"Ingrese el peso del item {i} en kg: ");
        double pesoItem = Convert.ToDouble(Console.ReadLine()!);
        if (cantidadItems == 1)
        {
            pesoNacional = 8.0;
            pesoInternacional = 10.0;
        }
            else
            {
            pesoNacional = 15.0;
            pesoInternacional = 23.0;
            }
        
        if (tipoVuelo.ToUpper() == "N")
        {
            if (pesoItem > pesoNacional)
            {
                MensajeError($"El item {i} excede el peso permitido para vuelos nacionales ({pesoNacional} kg).");
            }
                else
                {
                    MensajeExito($"El item {i} cumple con el peso permitido para vuelos nacionales.");
                }
        }
            else if (pesoItem > pesoInternacional)
                {
                    MensajeError($"El item {i} excede el peso permitido para vuelos internacionales ({pesoInternacional} kg).");
                }
                    else
                    {
                        MensajeExito($"El item {i} cumple con el peso permitido para vuelos internacionales.");
                    }
    }
}

ImprimirTitulo("Sistema de Gestión de Pasajeros y Equipaje");
ImprimirLinea();

MensajeInfo("Ingrese sus datos ");

Console.WriteLine("Ingrese su nombre: ");
string nombrePasajero = Console.ReadLine()!;

Console.WriteLine("Ingrese su apellido: ");
string apellidoPasajero = Console.ReadLine()!;

Console.WriteLine("Ingrese su número de documento: ");
string nroDocumento = Console.ReadLine()!;

Console.WriteLine("Ingrese su número de viajero frecuente: ");
string nroViajeroFreq = Console.ReadLine()!;

string tipoTarifa = "";
bool tarifaValida = false;

while (!tarifaValida)
{
    Console.WriteLine("Ingrese el tipo de tarifa (P|B|F|PE): ");
    tipoTarifa = Console.ReadLine()!.ToUpper();
    
    if (tipoTarifa == "P" || tipoTarifa == "B" || tipoTarifa == "F" || tipoTarifa == "PE")
    {
        tarifaValida = true;
    }
    else
    {
        MensajeError("Tarifa inválida. Ingrese P, B, F o PE.");
    }
}

string tipoVuelo = "";
bool vueloValido = false;

while (!vueloValido)
{
    Console.WriteLine("Ingrese el tipo de vuelo (N|I): ");
    tipoVuelo = Console.ReadLine()!.ToUpper();

    if (tipoVuelo == "N" || tipoVuelo == "I")
    {
        vueloValido = true;
    }
    else
    {
        MensajeError("Tipo de vuelo inválido. Ingrese N para nacional o I para internacional.");
    }
}

LimpiarPantalla();

ImprimirTitulo("Información del Pasajero");

Console.WriteLine($"Nombre: {nombrePasajero}");
Console.WriteLine($"Apellido: {apellidoPasajero}");
Console.WriteLine($"Número de documento: {nroDocumento}");
Console.WriteLine($"Número de viajero frecuente: {nroViajeroFreq}");
Console.WriteLine($"Tipo de tarifa: {tipoTarifa.ToUpper()}");
Console.WriteLine($"Tipo de vuelo: {(tipoVuelo.ToUpper() == "N" ? "Nacional" : "Internacional")}");
ImprimirLineaDoble();

pesajeEquipaje(tipoTarifa, tipoVuelo);