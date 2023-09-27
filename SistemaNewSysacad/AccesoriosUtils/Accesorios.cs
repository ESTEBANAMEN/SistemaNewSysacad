using System.Text.RegularExpressions;

namespace AccesoriosUtils
{
    public class Accesorios
    {
        public bool CorroborarTextoYEspacio(string texto)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            return regex.IsMatch(texto);
        }

        public bool CorroborarNumerico(string datoNumerico)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(datoNumerico);
        }

        public bool CorroborarTextoConNumero(string textoConNumero)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+ \\d{1,5}$");
            return regex.IsMatch(textoConNumero);
        }

        public bool CorroborarCorreoElectronico(string correo)
        {
            Regex regex = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            return regex.IsMatch(correo);
        }
    }
}