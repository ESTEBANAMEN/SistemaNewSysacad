using System.Text.RegularExpressions;

namespace AccesoriosUtils
{
    public class Accesorios
    {
        public bool CorroborarTextoYEspacio(string texto)
        {
            Regex regex = new Regex("^[a-zA-Z\\s/]+$");
            return regex.IsMatch(texto);
        }

        public bool CorroborarNumerico(string datoNumerico)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(datoNumerico);
        }

        public bool CorroborarTextoConNumeroConEspacio(string textoConNumero)
        {
            Regex regex = new Regex("^[a-zA-Z\\s]+ \\d{1,5}$");
            return regex.IsMatch(textoConNumero);
        }

        public bool CorroborarTextoConNumeroSinEspacio(string textoConNumero)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(textoConNumero);
        }

        public bool CorroborarCorreoElectronico(string correo)
        {
            Regex regex = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            return regex.IsMatch(correo);
        }

        public bool CorroborarFechaMmYy(string fecha)
        {
            Regex regex = new Regex("^(0[1-9]|1[0-2])/(0[0-9]|1[0-9]|2[0-9]|3[0-9]|4[0-9]|5[0-9]|6[0-9]|7[0-9]|8[0-9]|9[0-9])$");
            return regex.IsMatch(fecha);
        }
    }
}