using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour {

    public GameObject player;

    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
