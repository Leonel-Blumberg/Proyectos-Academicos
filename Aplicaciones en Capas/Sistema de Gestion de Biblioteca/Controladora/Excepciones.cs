namespace Controladora
{
    public class DatosInvalidosException(string mensaje) : Exception(mensaje) { }
    public class ElementoEnLaBaseDeDatosException(string mensaje) : Exception(mensaje) { }
}
