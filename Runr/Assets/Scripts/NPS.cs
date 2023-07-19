using UnityEngine;
using UnityEngine.AI;

public class NPCBehavior : MonoBehaviour
{
    [SerializeField] private Transform target; // игрок, от которого нужно убежать
    [SerializeField] private Transform runTo; // точка, куда нужно убежать
    [SerializeField] private float runDistance = 4f; // дистанция, при которой NPC начнет убегать
    [SerializeField] private float destroyDelay = 1f; // задержка перед удалением NPC

    private NavMeshAgent agent;
    private Animator animator;
    private bool isRunning = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!isRunning) // если NPC не убегает, то проверяем дистанцию до игрока
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < runDistance)
            {
                isRunning = true;
                animator.SetBool("isrun", true);
                agent.SetDestination(runTo.position); // устанавливаем точку, куда нужно бежать
            }
        }
        else // если NPC убегает, то проверяем дистанцию до точки
        {
            float distance = Vector3.Distance(transform.position, runTo.position);
            if (distance < 0.5f) // если NPC приблизился достаточно близко к точке, то уничтожаем его
            {
                Destroy(gameObject, destroyDelay);
            }
        }
    }
}