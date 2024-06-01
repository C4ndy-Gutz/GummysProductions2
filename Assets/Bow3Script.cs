using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow3Script : MonoBehaviour
{
    public PlushScript gameManager;
    public Vector3 leftMoveForce;
    public Vector3 rightMoveForce;
    public Vector3<List>();
    public Vector3 posY;
    public Vector3 PosZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(leftMoveForce);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(rightMoveForce);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bow3")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gameManager.score += 6;
        }
        if (collision.gameObject.tag == "Killplane")
        {
            Destroy(gameObject);
            gameManager.hasGameWon = false;
            gameManager.isGameOver = true;
        }
    }
}
