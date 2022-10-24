using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class funnymancontroller : MonoBehaviour
{
    public GameObject Player;
    public NavMeshAgent agent;

    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Pirate")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
    }

    void Update()
    {
        agent.SetDestination(Player.transform.position);
    }
}
