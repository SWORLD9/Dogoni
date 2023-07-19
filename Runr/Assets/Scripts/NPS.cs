using UnityEngine;
using UnityEngine.AI;

public class NPCBehavior : MonoBehaviour
{
    [SerializeField] private Transform target; // �����, �� �������� ����� �������
    [SerializeField] private Transform runTo; // �����, ���� ����� �������
    [SerializeField] private float runDistance = 4f; // ���������, ��� ������� NPC ������ �������
    [SerializeField] private float destroyDelay = 1f; // �������� ����� ��������� NPC

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
        if (!isRunning) // ���� NPC �� �������, �� ��������� ��������� �� ������
        {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance < runDistance)
            {
                isRunning = true;
                animator.SetBool("isrun", true);
                agent.SetDestination(runTo.position); // ������������� �����, ���� ����� ������
            }
        }
        else // ���� NPC �������, �� ��������� ��������� �� �����
        {
            float distance = Vector3.Distance(transform.position, runTo.position);
            if (distance < 0.5f) // ���� NPC ����������� ���������� ������ � �����, �� ���������� ���
            {
                Destroy(gameObject, destroyDelay);
            }
        }
    }
}