using UnityEngine;

public class Spawning_Behavior : MonoBehaviour
{
    public GameObject[] candy_vars;
    GameObject newObject;
    public float startTime;
    public float ratio = 2;
    public Player player;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Player>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        float timeElapsed = currentTime - startTime;
        if (Input.GetMouseButtonDown(0))
        {
            SpawnCandy();
        }
    }

    public void SpawnCandy()
    {
        int numVars = candy_vars.Length;
        if(numVars > 0)
        {
            int _selection = Random.Range(0, numVars);
            newObject = Instantiate(candy_vars[_selection], new Vector3(0,0,0), Quaternion.identity);
            newObject.transform.position = transform.position;
        }
    }
}
