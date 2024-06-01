using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour
{
    public Transform player;
    public float mouseS;
    public float xRot = 0f;
    public float minY = -90f;
    public float maxY = 90f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        MouseLook();
    }

    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseS;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseS;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minY, maxY);

        transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        player.Rotate(Vector3.up * mouseX);
    }

}
