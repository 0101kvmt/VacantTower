using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_StartPoint : MonoBehaviour {

    private PlayerMovement thePlayer;
    private CameraController theCamera;

    public Vector2 startDirection;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMovement>();
        thePlayer.transform.position = transform.position;
        thePlayer.lastMove = startDirection;

    }

    // Update is called once per frame
    void Update()
    {

    }

}
