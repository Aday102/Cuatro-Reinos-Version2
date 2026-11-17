using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public NewScriptableObjectScript datos;

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

    void Start()
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
}