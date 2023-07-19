using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rbPlayer; // Rigidbody Player
    private float speedMovePlayer; // Speed Move Player
    private float speedRotationPlayer; // Speed Rotation Player

    public float speedMovement; // Speed Player 
    public float speedRotate;

    public Transform Point;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();   // Get Rigidbody from Player


    }


    void FixedUpdate()
    {

        PlayerRay(); // ������ ������

        Move(); // ����������

       // Debug.Log(Convert.ToString(speedRotationPlayer) + " " + (Convert.ToString(speedMovePlayer))); // ������� �������� �����������
    }

    void Move()
    {
        speedMovePlayer = Input.GetAxis("Vertical") * speedMovement;  // �������� ������
        speedRotationPlayer = Input.GetAxis("Horizontal") * speedRotate;// �������� ������

        rbPlayer.AddRelativeForce(0f, 0f, speedMovePlayer);
        rbPlayer.AddRelativeTorque(0f, speedRotationPlayer, 0f);
    }
    void PlayerRay()
    {
        
        Ray ray = new Ray(transform.position, transform.forward); // �������� ���� 
        Debug.DrawRay(transform.position, transform.forward * 50f, Color.green); // ������������ ���

        
    }
}
