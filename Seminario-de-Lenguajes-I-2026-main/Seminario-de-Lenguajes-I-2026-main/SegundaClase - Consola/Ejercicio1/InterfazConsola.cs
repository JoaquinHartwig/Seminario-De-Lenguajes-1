/*
 ╔═══════════════════════════════════════════════════════════════╗
 ║   BIBLIOTECA DE INTERFAZ VISUAL PARA CONSOLA C# .NET 10       ║
 ║   Funciones para crear interfaces atractivas en consola       ║
 ╚═══════════════════════════════════════════════════════════════╝
 
 INSTRUCCIONES DE USO:
 1. Agregá este archivo a tu proyecto
 2. Usá: using static InterfazConsola;
 3. Llamá las funciones directamente
 
 CARACTERÍSTICAS .NET:
 - Soporte completo de Unicode y emojis
 - Colores personalizables
 - Animaciones suaves
 - Async/Await para operaciones no bloqueantes
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MisUtilidades
{
    public static class InterfazConsola
    {
    // ============================================================
    // CONFIGURACIÓN DE COLORES
    // ============================================================
    
    public static class Colores
    {
        public static ConsoleColor Titulo { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor Exito { get; set; } = ConsoleColor.Green;
        public static ConsoleColor Error { get; set; } = ConsoleColor.Red;
        public static ConsoleColor Advertencia { get; set; } = ConsoleColor.Yellow;
        public static ConsoleColor Info { get; set; } = ConsoleColor.Blue;
        public static ConsoleColor Menu { get; set; } = ConsoleColor.White;
        public static ConsoleColor Destacado { get; set; } = ConsoleColor.Magenta;
    }

    // ============================================================
    // FUNCIONES BÁSICAS DE FORMATO
    // ============================================================

    /// Imprime una línea separadora simple
    public static void ImprimirLinea(int longitud = 50)
    {
        Console.WriteLine(new string('-', longitud));
    }

    /// Imprime una línea separadora doble
    public static void ImprimirLineaDoble(int longitud = 50)
    {
        Console.WriteLine(new string('═', longitud));
    }

    /// Imprime una línea separadora corta
    public static void ImprimirLineaCorta(int longitud = 30)
    {
        Console.WriteLine(new string('-', longitud));
    }

    /// Imprime una línea personalizada
    /// <param name="caracter">Caracter a usar</param>
    /// <param name="longitud">Longitud de la línea</param>
    /// <param name="color">Color de la línea</param>
    public static void ImprimirLineaCustom(char caracter, int longitud, ConsoleColor? color = null)
    {
        if (color.HasValue)
        {
            var colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = color.Value;
            Console.WriteLine(new string(caracter, longitud));
            Console.ForegroundColor = colorAnterior;
        }
        else
        {
            Console.WriteLine(new string(caracter, longitud));
        }
    }

    // ============================================================
    // CONTROL DE PANTALLA
    // ============================================================

    /// Limpia la pantalla de la consola
    public static void LimpiarPantalla()
    {
        Console.Clear();
    }

    /// Pausa la ejecución hasta que el usuario presione una tecla
    public static void Pausar()
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey(true);
    }

    /// Pausa con mensaje personalizado
    public static void PausarConMensaje(string mensaje)
    {
        Console.WriteLine($"\n{mensaje}");
        Console.ReadKey(true);
    }

    /// Salta N líneas en blanco

    public static void SaltarLineas(int cantidad = 1)
    {
        for (int i = 0; i < cantidad; i++)
            Console.WriteLine();
    }

    /// Establece el título de la ventana de consola
    public static void EstablecerTituloVentana(string titulo)
    {
        Console.Title = titulo;
    }

    /// Establece el tamaño de la ventana de consola
    public static void EstablecerTamañoVentana(int ancho, int alto)
    {
        try
        {
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(ancho, alto);
                Console.SetBufferSize(ancho, alto);
            }
        }
        catch
        {
            // En algunos sistemas no se puede modificar el tamaño
        }
    }

    // ============================================================
    // ENCABEZADOS Y TÍTULOS
    // ============================================================

    /// Imprime un título centrado con líneas y color
    public static void ImprimirTitulo(string titulo, ConsoleColor? color = null)
    {
        var colorUsar = color ?? Colores.Titulo;
        var colorAnterior = Console.ForegroundColor;
        
        Console.ForegroundColor = colorUsar;
        ImprimirLineaDoble();
        Console.WriteLine(titulo.PadLeft((50 + titulo.Length) / 2).PadRight(50));
        ImprimirLineaDoble();
        Console.ForegroundColor = colorAnterior;
    }

    /// Imprime un título con bordes tipo box
    public static void ImprimirTituloBox(string titulo, ConsoleColor? color = null)
    {
        var colorUsar = color ?? Colores.Titulo;
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = colorUsar;
        
        int ancho = Math.Max(titulo.Length + 4, 50);
        Console.WriteLine();
        Console.WriteLine("╔" + new string('═', ancho) + "╗");
        Console.WriteLine("║" + titulo.PadLeft((ancho + titulo.Length) / 2).PadRight(ancho) + "║");
        Console.WriteLine("╚" + new string('═', ancho) + "╝");
        
        Console.ForegroundColor = colorAnterior;
    }

    /// Imprime una sección con título destacado
    public static void ImprimirSeccion(string titulo)
    {
        Console.WriteLine();
        ImprimirLinea();
        Console.WriteLine($"  >>> {titulo}");
        ImprimirLinea();
    }

    /// Imprime un subtítulo
    public static void ImprimirSubtitulo(string subtitulo, ConsoleColor? color = null)
    {
        var colorAnterior = Console.ForegroundColor;
        if (color.HasValue)
            Console.ForegroundColor = color.Value;
            
        Console.WriteLine($"\n--- {subtitulo} ---");
        
        Console.ForegroundColor = colorAnterior;
    }

    // ============================================================
    // MENÚS
    // ============================================================

    /// Muestra un menú y retorna la opción seleccionada
    /// <param name="titulo">Título del menú</param>
    /// <param name="opciones">Lista de opciones</param>
    /// <returns>Índice de la opción seleccionada (0-based)</returns>
    public static int MostrarMenu(string titulo, params string[] opciones)
    {
        LimpiarPantalla();
        ImprimirTitulo(titulo);
        Console.WriteLine();

        for (int i = 0; i < opciones.Length; i++)
        {
            Console.WriteLine($"  [{i + 1}] {opciones[i]}");
        }
        
        Console.WriteLine();
        ImprimirLinea();
        Console.Write("  Seleccione una opción: ");
        
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int opcion) && 
                opcion >= 1 && opcion <= opciones.Length)
            {
                return opcion - 1;
            }
            
            MensajeError("Opción inválida. Intente nuevamente.");
            Console.Write("  Seleccione una opción: ");
        }
    }

    /// Muestra un menú interactivo con flechas de navegación
    public static int MostrarMenuInteractivo(string titulo, params string[] opciones)
    {
        int seleccion = 0;
        ConsoleKey tecla;

        do
        {
            LimpiarPantalla();
            ImprimirTitulo(titulo);
            Console.WriteLine("\n  Use ↑/↓ para navegar, Enter para seleccionar\n");

            for (int i = 0; i < opciones.Length; i++)
            {
                if (i == seleccion)
                {
                    Console.ForegroundColor = Colores.Destacado;
                    Console.WriteLine($"  ► {opciones[i]}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"    {opciones[i]}");
                }
            }

            var info = Console.ReadKey(true);
            tecla = info.Key;

            if (tecla == ConsoleKey.UpArrow)
                seleccion = seleccion == 0 ? opciones.Length - 1 : seleccion - 1;
            else if (tecla == ConsoleKey.DownArrow)
                seleccion = seleccion == opciones.Length - 1 ? 0 : seleccion + 1;

        } while (tecla != ConsoleKey.Enter);

        return seleccion;
    }

    /// Muestra un menú con bordes decorativos
    public static void MostrarMenuBox(string titulo, params string[] opciones)
    {
        LimpiarPantalla();
        int anchoMax = Math.Max(titulo.Length, opciones.Max(o => o.Length)) + 4;
        
        Console.WriteLine();
        Console.WriteLine("  ╔" + new string('═', anchoMax) + "╗");
        Console.WriteLine($"  ║{titulo.PadLeft((anchoMax + titulo.Length) / 2).PadRight(anchoMax)}║");
        Console.WriteLine("  ╠" + new string('═', anchoMax) + "╣");
        
        for (int i = 0; i < opciones.Length; i++)
        {
            Console.WriteLine($"  ║  {(i + 1)}. {opciones[i].PadRight(anchoMax - 6)}║");
        }
        
        Console.WriteLine("  ╚" + new string('═', anchoMax) + "╝");
        Console.Write("\n  Opción: ");
    }

    // ============================================================
    // MENSAJES DE ESTADO
    // ============================================================

    /// Muestra un mensaje de éxito
    public static void MensajeExito(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Exito;
        Console.WriteLine($"\n✓ {mensaje}");
        Console.ForegroundColor = colorAnterior;
    }

    /// Muestra un mensaje de error
    public static void MensajeError(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Error;
        Console.WriteLine($"\n✗ {mensaje}");
        Console.ForegroundColor = colorAnterior;
    }

    /// Muestra un mensaje de advertencia
    public static void MensajeAdvertencia(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Advertencia;
        Console.WriteLine($"\n⚠ {mensaje}");
        Console.ForegroundColor = colorAnterior;
    }

    /// Muestra un mensaje informativo
    public static void MensajeInfo(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Info;
        Console.WriteLine($"\nℹ {mensaje}");
        Console.ForegroundColor = colorAnterior;
    }

    /// Mensaje de éxito con bordes
    public static void MensajeExitoBox(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Exito;
        
        int ancho = mensaje.Length + 4;
        Console.WriteLine($"\n┌{new string('─', ancho)}┐");
        Console.WriteLine($"│ ✓ {mensaje} │");
        Console.WriteLine($"└{new string('─', ancho)}┘");
        
        Console.ForegroundColor = colorAnterior;
    }

    /// Mensaje de error con bordes
    public static void MensajeErrorBox(string mensaje)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = Colores.Error;
        
        int ancho = mensaje.Length + 10;
        Console.WriteLine($"\n┌{new string('─', ancho)}┐");
        Console.WriteLine($"│ ✗ ERROR: {mensaje} │");
        Console.WriteLine($"└{new string('─', ancho)}┘");
        
        Console.ForegroundColor = colorAnterior;
    }

    // ============================================================
    // TABLAS Y LISTADOS
    // ============================================================

    /// Imprime una tabla genérica con encabezados
    public static void ImprimirTabla<T>(IEnumerable<T> datos, params (string Nombre, Func<T, object> Selector, int Ancho)[] columnas)
    {
        Console.WriteLine();
        ImprimirLinea(columnas.Sum(c => c.Ancho) + columnas.Length + 1);
        
        // Encabezados
        foreach (var col in columnas)
        {
            Console.Write($"│ {col.Nombre.PadRight(col.Ancho - 2)}");
        }
        Console.WriteLine("│");
        ImprimirLinea(columnas.Sum(c => c.Ancho) + columnas.Length + 1);
        
        // Filas
        foreach (var item in datos)
        {
            foreach (var col in columnas)
            {
                var valor = col.Selector(item)?.ToString() ?? "";
                Console.Write($"│ {valor.PadRight(col.Ancho - 2)}");
            }
            Console.WriteLine("│");
        }
        
        ImprimirLinea(columnas.Sum(c => c.Ancho) + columnas.Length + 1);
        Console.WriteLine();
    }

    /// Imprime una lista numerada de elementos
    public static void ImprimirListaNumerada<T>(IEnumerable<T> items, Func<T, string> formatear = null!)
    {
        Console.WriteLine();
        int i = 1;
        foreach (var item in items)
        {
            var texto = formatear != null ? formatear(item) : item?.ToString() ?? "";
            Console.WriteLine($"  {i}. {texto}");
            i++;
        }
        Console.WriteLine();
    }

    /// Imprime una lista con viñetas
    public static void ImprimirListaViñetas<T>(IEnumerable<T> items, string viñeta = "•", Func<T, string> formatear = null!)
    {
        Console.WriteLine();
        foreach (var item in items)
        {
            var texto = formatear != null ? formatear(item) : item?.ToString() ?? "";
            Console.WriteLine($"  {viñeta} {texto}");
        }
        Console.WriteLine();
    }

    // ============================================================
    // ENTRADA DE DATOS CON VALIDACIÓN
    // ============================================================

    /// Solicita un número entero con validación
    public static int SolicitarEntero(string campo, int? min = null, int? max = null)
    {
        while (true)
        {
            Console.Write($"  ► {campo}: ");
            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                if ((!min.HasValue || valor >= min) && (!max.HasValue || valor <= max))
                    return valor;
                
                MensajeError($"El valor debe estar entre {min ?? int.MinValue} y {max ?? int.MaxValue}");
            }
            else
            {
                MensajeError("Debe ingresar un número entero válido");
            }
        }
    }

    /// Solicita un número decimal con validación
    public static double SolicitarDecimal(string campo, double? min = null, double? max = null)
    {
        while (true)
        {
            Console.Write($"  ► {campo}: ");
            if (double.TryParse(Console.ReadLine(), out double valor))
            {
                if ((!min.HasValue || valor >= min) && (!max.HasValue || valor <= max))
                    return valor;
                
                MensajeError($"El valor debe estar entre {min ?? double.MinValue} y {max ?? double.MaxValue}");
            }
            else
            {
                MensajeError("Debe ingresar un número decimal válido");
            }
        }
    }

    /// Solicita una cadena de texto con validación
    public static string SolicitarCadena(string campo, bool requerido = true, int longitudMax = 0)
    {
        while (true)
        {
            Console.Write($"  ► {campo}: ");
            var valor = Console.ReadLine() ?? "";
            
            if (requerido && string.IsNullOrWhiteSpace(valor))
            {
                MensajeError("Este campo es requerido");
                continue;
            }
            
            if (longitudMax > 0 && valor.Length > longitudMax)
            {
                MensajeError($"El texto no puede exceder {longitudMax} caracteres");
                continue;
            }
            
            return valor;
        }
    }

    /// Solicita una fecha con validación
    public static DateTime SolicitarFecha(string campo)
    {
        while (true)
        {
            Console.Write($"  ► {campo} (dd/MM/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
            {
                return fecha;
            }
            
            MensajeError("Formato de fecha inválido. Use dd/MM/yyyy");
        }
    }

    /// Solicita confirmación S/N
    public static bool ConfirmarAccion(string mensaje)
    {
        Console.Write($"\n  {mensaje} (S/N): ");
        var respuesta = Console.ReadKey();
        Console.WriteLine();
        return respuesta.Key == ConsoleKey.S || 
               char.ToUpper(respuesta.KeyChar) == 'S';
    }

    // ============================================================
    // PANELES DE INFORMACIÓN
    // ============================================================

    /// Abre un panel de información con título
    public static void AbrirPanel(string titulo, int ancho = 50)
    {
        Console.WriteLine();
        Console.WriteLine($"  ╔{new string('═', ancho)}╗");
        Console.WriteLine($"  ║ {titulo.PadRight(ancho - 1)}║");
        Console.WriteLine($"  ╠{new string('═', ancho)}╣");
    }

    /// Muestra un campo en el panel
    public static void MostrarCampo(string campo, object valor, int anchoTotal = 50)
    {
        var texto = $"{campo}: {valor}";
        Console.WriteLine($"  ║ {texto.PadRight(anchoTotal - 1)}║");
    }

    /// Cierra el panel de información
    public static void CerrarPanel(int ancho = 50)
    {
        Console.WriteLine($"  ╚{new string('═', ancho)}╝");
    }

    // ============================================================
    // RESÚMENES Y ESTADÍSTICAS
    // ============================================================

    /// Muestra un resumen con estadísticas
    public static void MostrarResumen(string titulo, Dictionary<string, object> datos)
    {
        AbrirPanel(titulo);
        foreach (var kvp in datos)
        {
            MostrarCampo(kvp.Key, kvp.Value);
        }
        CerrarPanel();
    }

    /// Muestra estadísticas en formato box
    public static void MostrarEstadisticas(string titulo, int cantidad, double promedio, double total)
    {
        Console.WriteLine();
        Console.WriteLine("  ╔══════════════════════════════════════╗");
        Console.WriteLine($"  ║ {titulo.PadRight(37)}║");
        Console.WriteLine("  ╠══════════════════════════════════════╣");
        Console.WriteLine($"  ║ Cantidad:        {cantidad,19} ║");
        Console.WriteLine($"  ║ Promedio:        ${promedio,18:N2} ║");
        Console.WriteLine($"  ║ Total:           ${total,18:N2} ║");
        Console.WriteLine("  ╚══════════════════════════════════════╝");
    }

    // ============================================================
    // BARRAS DE PROGRESO
    // ============================================================

    /// Muestra una barra de progreso
    public static void MostrarBarraProgreso(int actual, int total, int ancho = 30)
    {
        double porcentaje = (double)actual / total;
        int barrasLlenas = (int)(porcentaje * ancho);
        
        Console.Write("\r  Progreso: [");
        Console.Write(new string('█', barrasLlenas));
        Console.Write(new string('░', ancho - barrasLlenas));
        Console.Write($"] {porcentaje:P0}");
    }

    /// Barra de progreso con colores
    public static void MostrarBarraProgresoColor(int actual, int total, int ancho = 30)
    {
        double porcentaje = (double)actual / total;
        int barrasLlenas = (int)(porcentaje * ancho);
        
        Console.Write("\r  Progreso: [");
        
        var color = porcentaje < 0.33 ? ConsoleColor.Red :
                    porcentaje < 0.66 ? ConsoleColor.Yellow :
                    ConsoleColor.Green;
        
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(new string('█', barrasLlenas));
        Console.ForegroundColor = colorAnterior;
        
        Console.Write(new string('░', ancho - barrasLlenas));
        Console.Write($"] {porcentaje:P0}");
    }

    // ============================================================
    // ANIMACIONES Y EFECTOS
    // ============================================================

    /// Muestra animación de carga asíncrona
    public static async Task MostrarCargandoAsync(string mensaje, int duracionMs = 2000)
    {
        Console.Write($"\n  {mensaje}");
        var chars = new[] { '|', '/', '-', '\\' };
        var inicio = DateTime.Now;
        int i = 0;
        
        while ((DateTime.Now - inicio).TotalMilliseconds < duracionMs)
        {
            Console.Write($"\r  {mensaje} {chars[i]}");
            i = (i + 1) % chars.Length;
            await Task.Delay(100);
        }
        
        Console.WriteLine($"\r  {mensaje} ✓");
    }

    /// Escribe texto con efecto de máquina de escribir
    public static async Task EscribirConEfecto(string texto, int delayMs = 30)
    {
        foreach (char c in texto)
        {
            Console.Write(c);
            await Task.Delay(delayMs);
        }
        Console.WriteLine();
    }

    /// Animación de puntos suspensivos
    public static async Task AnimarPuntos(string mensaje, int duracionMs = 2000)
    {
        Console.Write($"\n  {mensaje}");
        var inicio = DateTime.Now;
        int puntos = 0;
        
        while ((DateTime.Now - inicio).TotalMilliseconds < duracionMs)
        {
            Console.Write($"\r  {mensaje}{new string('.', puntos)}   ");
            puntos = (puntos + 1) % 4;
            await Task.Delay(300);
        }
        
        Console.WriteLine($"\r  {mensaje}... ✓");
    }

    // ============================================================
    // SEPARADORES DECORATIVOS
    // ============================================================

    /// Imprime un separador con puntos
    public static void ImprimirSeparadorPuntos(int longitud = 50)
    {
        Console.WriteLine(string.Join(" ", Enumerable.Repeat("·", longitud / 2)));
    }

    /// Imprime un separador con flechas
    public static void ImprimirSeparadorFlechas(int longitud = 50)
    {
        Console.WriteLine(string.Join(" ", Enumerable.Repeat("→", longitud / 2)));
    }

    /// Imprime un separador con asteriscos
    public static void ImprimirSeparadorAsteriscos(int longitud = 50)
    {
        Console.WriteLine(string.Join(" ", Enumerable.Repeat("*", longitud / 2)));
    }

    // ============================================================
    // UTILIDADES AVANZADAS
    // ============================================================

    /// Imprime texto centrado
    public static void ImprimirCentrado(string texto, int ancho = 80)
    {
        int espacios = (ancho - texto.Length) / 2;
        Console.WriteLine(new string(' ', espacios) + texto);
    }

    /// Imprime un cuadro de texto con bordes
    public static void ImprimirCuadro(string texto)
    {
        int largo = texto.Length;
        Console.WriteLine($"\n  ┌{new string('─', largo + 2)}┐");
        Console.WriteLine($"  │ {texto} │");
        Console.WriteLine($"  └{new string('─', largo + 2)}┘");
    }
    /// Imprime texto con color temporal
    public static void ImprimirConColor(string texto, ConsoleColor color)
    {
        var colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(texto);
        Console.ForegroundColor = colorAnterior;
    }
    /// Crea un marco alrededor de múltiples líneas de texto
    public static void ImprimirMarco(params string[] lineas)
    {
        if (lineas.Length == 0) return;
        
        int anchoMax = lineas.Max(l => l.Length);
        
        Console.WriteLine($"\n  ╔{new string('═', anchoMax + 2)}╗");
        foreach (var linea in lineas)
        {
            Console.WriteLine($"  ║ {linea.PadRight(anchoMax)} ║");
        }
        Console.WriteLine($"  ╚{new string('═', anchoMax + 2)}╝");
    }

    /// Ejecuta una acción con indicador de progreso
    public static async Task<T> EjecutarConProgreso<T>(Func<Task<T>> accion, string mensaje)
    {
        var tarea = accion();
        await MostrarCargandoAsync(mensaje);
        return await tarea;
    }
}
}