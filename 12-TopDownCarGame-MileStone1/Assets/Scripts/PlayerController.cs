using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
   
    public float xRange = 10;

    private float _horizontalInput;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    void PlayerMovement()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _horizontalInput * moveSpeed * Time.deltaTime);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}