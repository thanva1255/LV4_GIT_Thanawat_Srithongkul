using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStick : MonoBehaviour
{
    private Vector3 Stick;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Stick =transform.position - Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.transform.position + Stick;
    }
}
