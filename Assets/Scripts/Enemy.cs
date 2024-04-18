using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMelee : MonoBehaviour
{
    public int daño = 10;

    private void Update()
    {
        // Aquí implementa la lógica de ataque melee
    }
}

public class EnemigoEstatico : MonoBehaviour
{
    // Este enemigo no hace nada, se mantiene estático
}

public class EnemigoMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    private void Update()
    {
        // Aquí implementa la lógica de movimiento
    }
}
