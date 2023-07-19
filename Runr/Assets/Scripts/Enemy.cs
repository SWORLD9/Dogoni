using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public ParticleSystem _particleSystem; // ������� ������

    public GameObject Player; // give Player (����������)

    private NavMeshAgent agent; // NavMash Agent

    public GameObject position_point; // ����� ���� ������ 


    



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

