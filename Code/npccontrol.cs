/*
 * NPC Control Script
 * 
 * Purpose: Controls the wandering behavior of enemy NPCs in the game terrain.
 * This script makes enemies patrol randomly within a defined radius using Unity's NavMesh system.
 * 
 * Key Features:
 * - Random wandering within configurable radius
 * - Timer-based movement updates
 * - NavMesh-based pathfinding for terrain-aware navigation
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npccontrol : MonoBehaviour
{
    public float wanderRadius;
    public float wanderTimer;
    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >=wanderTimer)
        {
            Vector3 newpos = RandomNavSphere(transform.position, wanderRadius ,- 1);
            agent.SetDestination(newpos);
            timer = 0;
        }
    }
    
    // Generates a random point on the NavMesh within specified radius
    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
        return navHit.position;
    }
}
