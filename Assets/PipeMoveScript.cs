using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -25;
    public LogicScript logicScript;
    

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x <deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }

        moveSpeed = 5 + logicScript.playerScore / 2;
    }
}