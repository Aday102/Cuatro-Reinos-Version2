using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public DatosUnidades datos;

    public Enemigo objetivo;

    private string nombre;
    private int tier;
    private string rol;
    private string rasgo;
    private int vidaActual;
    private int ataque;
    private int armadura;
    private int resistenciaMagica;
    private string movimiento;
    private string habilidad;
    private string trasElCombate;

    private bool muerto = false;

    void Awake()
    {
        nombre = datos.nombre;
        tier = datos.tier;
        rol = datos.rol;
        rasgo = datos.rasgo;
        vidaActual = datos.vida;
        ataque = datos.ataque;
        armadura = datos.armadura;
        resistenciaMagica = datos.resistenciaMagica;
        movimiento = datos.movimiento;
        habilidad = datos.habilidad;
        trasElCombate = datos.trasElCombate;
    }

    public void Atacar()
    {
        int danio = ataque - objetivo.armadura;

        if (danio < 0)
        {
            danio = 0;
        }

        Debug.Log(nombre + " ataca a " + objetivo.nombre + " y le hace " + danio + " de daño.");

        objetivo.RecibirDanio(danio);
    }

    public void RecibirDanio(int danio)
    {
        vidaActual = vidaActual - danio;

        if (vidaActual <= 0)
        {
            vidaActual = 0;
            muerto = true;

            Debug.Log(nombre + " ha muerto.");
        }
        else
        {
            Debug.Log(nombre + " tiene " + vidaActual + " de vida.");
        }
    }

    public void Combatir()
    {
        while (!muerto && !objetivo.muerto)
        {
            Atacar();

            if (!objetivo.muerto)
            {
                objetivo.Atacar();
            }
        }
    }
}