using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject objectToFollow;

    private Vector3 _offSet = new Vector3(0, 0, -10);
    public float FollowOffset = 0;

    private CarController _carControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        _carControllerScript = GameObject.Find("Player").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!_carControllerScript.CrossedFinishLine())
        {
            transform.position = new Vector3(0f, objectToFollow.transform.position.y + FollowOffset, -10f);
        }
        
    }
}
