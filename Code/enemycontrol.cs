/*
 * Enemy Control Script
 * 
 * Purpose: Manages enemy AI behavior including player detection, chase mechanics,
 * and game-over conditions when enemy reaches the player.
 * 
 * Key Features:
 * - Player detection within configurable radius (default: 10 units)
 * - NavMesh-based pathfinding to chase player
 * - Collision detection with player
 * - Game over trigger when enemy touches player
 * - Visual debugging with Gizmos
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class enemycontrol : MonoBehaviour
{
    public float lookradius = 10f; // Detection radius for spotting player
    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update. Initializes references to player and NavMesh agent component.
    void Start()
    {
        target = playermanager.instance.player.transform;
        agent =GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame.
    // Calculates distance to player and initiates chase if within detection radius.
    void Update()
    {
        float distance = Vector3.Distance(target.position,transform.position);
        if(distance<=lookradius)
        {
            agent.SetDestination(target.position);
        }
    }

    // Called when another collider enters this object's trigger collider. Triggers game over when enemy collides with player.
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="player")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("menu");
            SceneManager.UnloadScene("Main Scene");
        }
    }

    // Called when the object is selected in the Unity Editor.
    // Draws a visual representation of the detection radius for debugging.
    private void OnDrawGizmosSelected()
    {
        Gizmos.color =Color.red;
        Gizmos.DrawWireSphere(transform.position,lookradius);
    }
}
