using UnityEngine;
public class Unidad : MonoBehaviour
{
    public DatosUnidades datos;
    public Unidad enemigo;
    public float velocidad;
    public float distanciaAtaque;
    public float velAtaque;
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
    private float tiempoDesdeElUltimoAtaque;
    private bool muerto = false;

    void Start()
    {
        nombre = datos.nombre;
        vidaActual = datos.vida;
        ataque = datos.ataque;
        armadura = datos.armadura;
    }
    void Update()
    {
        if (muerto || enemigo == null)
        {
            return;
        }
        float distancia = Vector3.Distance(transform.position, enemigo.transform.position);

        if (distancia > distanciaAtaque)
        {
            transform.position = Vector3.MoveTowards(transform.position, enemigo.transform.position, velocidad * Time.deltaTime);
        }
        else
        {
            tiempoDesdeElUltimoAtaque += Time.deltaTime;
            if (tiempoDesdeElUltimoAtaque >= velAtaque)
            {
                Atacar();
                tiempoDesdeElUltimoAtaque = 0; 
            }
        }
    }

    public void Atacar()
    {
        int danio = ataque - enemigo.armadura;
        if (danio < 1)
        {
            danio = 1;
        }
        Debug.Log(nombre + " ataca a " + enemigo.nombre + " y le quita " + danio);
        enemigo.RecibirDanio(danio);
    }
    public void RecibirDanio(int cantidad)
    {
        vidaActual -= cantidad;
        if (vidaActual <= 0)
        {
            vidaActual = 0;
            muerto = true;
            Debug.Log(nombre + " ha muerto");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log(nombre + " tiene " + vidaActual + " de vida");
        }
    }
}