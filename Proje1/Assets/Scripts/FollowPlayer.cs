using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -10);
    private Vector3 firstOffsetCamera = new Vector3(0, 6, -7);
    private Vector3 secondOffsetCamera = new Vector3(0, 8, -2);
    public bool switchCamer = true;
    private int qKeyPressedCount = 0;//Q ya ka� kez bas�ld���n� kontrol etmek i�in 

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKeyDown(KeyCode.Q))
        {
            qKeyPressedCount++;
            if (qKeyPressedCount == 3) // Q ya 3 defa bas�l�rsa bu kodun i�ine girecek 
            {
                qKeyPressedCount = 0;
                offset = new Vector3(0, 8, -10);
                switchCamer = true;
            }
            else if (switchCamer)
            {
                offset = firstOffsetCamera;
                switchCamer = false;
            }
            else
            {
                offset = secondOffsetCamera;
                switchCamer = true;
            }
        }


    }
}
