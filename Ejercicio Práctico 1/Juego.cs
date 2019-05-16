using System;

public class Juego
{

    #region "Enums"
    public enum eEstadoJuego
    {
        MostrandoMenu,
        EjecutandoJuego,
        JuegoFinalizado
    }
    #endregion

    public eEstadoJuego Estado { get; set; }
}
