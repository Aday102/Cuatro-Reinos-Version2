using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/DatosUnidades")]
public class DatosUnidades : ScriptableObject
{
    public string nombre;
    public int tier;
    public string rol;
    public string rasgo;
    public int vida;
    public int ataque;
    public int armadura;
    public int resistenciaMagica;
    public string movimiento;
    public string habilidad;
    public string trasElCombate;
}
