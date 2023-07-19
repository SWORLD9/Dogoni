using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private float SpeedCamera;
    [SerializeField] private GameObject Player;
    private Vector3 difference;
    private Vector3 difference2;
    private void Start()
    {
        difference = transform.position - Player.transform.position;
    }


    void Update()
    {
        difference2 = Player.transform.position + difference;
        transform.position = Vector3.MoveTowards(transform.position, difference2, SpeedCamera * Time.deltaTime);
    }
}
