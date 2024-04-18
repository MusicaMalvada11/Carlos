using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerController : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        // Obtener el componente NavMeshAgent del jugador
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Verificar si se ha hecho clic con el botón izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Lanzar un rayo desde la posición del clic del mouse hacia el mundo
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Si el rayo golpea un objeto del NavMesh
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, NavMesh.AllAreas))
            {
                // Mover al jugador hacia la posición del clic del mouse
                navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
