using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rbPlayer; // Rigidbody Player
    private float speedMovePlayer; // Speed Move Player
    private float speedRotationPlayer; // Speed Rotation Player

    [SerializeField] private float speedMovement; // Speed Player 
    [SerializeField] private float speedRotate;

    [SerializeField] private Transform Point;


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();   // Get Rigidbody from Player


    }


    void FixedUpdate()
    {

        PlayerRay(); // Зрение игрока

        Move(); // Управление

       // Debug.Log(Convert.ToString(speedRotationPlayer) + " " + (Convert.ToString(speedMovePlayer))); // Выводим скорость перемещения
    }

    void Move()
    {
        speedMovePlayer = Input.GetAxis("Vertical") * speedMovement;  // движение игрока
        speedRotationPlayer = Input.GetAxis("Horizontal") * speedRotate;// Вращение игрока

        rbPlayer.AddRelativeForce(0f, 0f, speedMovePlayer);
        rbPlayer.AddRelativeTorque(0f, speedRotationPlayer, 0f);
    }
    void PlayerRay()
    {
        
        Ray ray = new Ray(transform.position, transform.forward); // Создание луча 
        Debug.DrawRay(transform.position, transform.forward * 50f, Color.green); // Отрисовываем луч

        
    }
}
