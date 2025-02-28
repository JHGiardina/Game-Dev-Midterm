using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Vector2 newPosition;
    public Vector3 mousePositionG;
    Camera cam;
    public float yPos;
    public Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePositionG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = mousePositionG;
        body.MovePosition(newPosition);
        
    }
}
