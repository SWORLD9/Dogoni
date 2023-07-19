using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public ParticleSystem _particleSystem; // Частицы смерти

    public GameObject Player; // give Player (Догоняющий)

    private NavMeshAgent agent; // NavMash Agent

    public GameObject position_point; // Точка куда бежать 


    



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();  // give NavMash Agent

        MoveEnemy();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))

        {
            Instantiate(_particleSystem, this.gameObject.transform.position, _particleSystem.transform.rotation);
            Destroy(gameObject);

        }


    }

    

    public void MoveEnemy()
    {
        
       agent.SetDestination(position_point.transform.position);
         
      
    }
}

