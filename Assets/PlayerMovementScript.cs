using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject Player;
    public Vector3 moveDirection;
    public float speed = 3f;
    public Transform player;
    public float mouseSensitivity;
    public float xRot = 0f;
    public float minY = -90f;
    public float maxY = 90f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(x, 0, z);
        transform.Translate(moveDirection * Time.fixedDeltaTime * speed);

    }
}
