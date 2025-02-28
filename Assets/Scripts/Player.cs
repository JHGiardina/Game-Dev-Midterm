using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Vector2 newPosition;
    public Vector3 mousePositionG;
    Camera cam;
    public float yPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePositionG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, mousePositionG, speed * Time.fixedDeltaTime);
        transform.position = newPosition;

    }
}
