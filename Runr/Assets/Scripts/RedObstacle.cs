using UnityEngine;

public class RedObstacle : MonoBehaviour
{
    private Vector3 startPos;
    public Vector3 endPos;
    

    public float speed;

    private void Start()
    {
       
        startPos = transform.position; 
    }
    void FixedUpdate()
    {


        
        if (startPos != endPos) { MoveObstecle(endPos); }
        else { MoveObstecle(startPos); }

        
    }

    void MoveObstecle(Vector3 pos)
    {
        this.transform.position = Vector3.Lerp(this.transform.position, pos, speed*Time.deltaTime);
        Debug.Log(startPos);
    }
}
