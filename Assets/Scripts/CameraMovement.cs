using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    GameObject CameraStartPoint;
    public GameObject Player;
    public float CamYPos;
    public float CamZPos;

    void Start()
    {
        transform.position = CameraStartPoint.transform.position;
    }

    void Update()
    {
        
        if (transform.position.x <= -25)
        {
            transform.position = new Vector3(-25, CamYPos, CamZPos);
        } else if (transform.position.x >= 25)
        {
            transform.position = new Vector3(25, CamYPos, CamZPos);
        }
        if (Player.transform.position.x >= -25 && Player.transform.position.x <= 25)
        {
            transform.position = new Vector3(Player.transform.position.x, CamYPos, CamZPos);
        }
    }
}
