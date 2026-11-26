
namespace RetoExcepciones
{
    class EdadInvalidaException : Exception
    {
        public int Edad { get;}

        public EdadInvalidaException(string mensaje, int edad)
        : base(mensaje)
        {
            Edad = edad;
        }
    }
    class Program
{
    
    static void Main()
    {
        
        
        try
            {
            Console.Write("introducir tu edad: ");
            string option = Console.ReadLine() ?? "";
            int edad = int.Parse(option);
            if(edad < 0 || edad > 120)
                {
                    throw new EdadInvalidaException($"La edad debe estar entre 0 y 120 años: ", edad);
                }
            }
        catch (FormatException)
            {
                Console.WriteLine("Error: Debes introducir un número válido");
            }
            catch (EdadInvalidaException ex)
            {
                Console.WriteLine($"Error de validación: {ex.Message} (Edad ingresada: {ex.Edad})");
            }
            finally
            {
                Console.WriteLine("Proceso de validación finalizado" );
            }


        }
    }
}
