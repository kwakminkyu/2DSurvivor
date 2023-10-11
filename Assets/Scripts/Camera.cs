using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float offsetX = 0.0f;            
    public float offsetY = 0.0f;           
    public float offsetZ = -10.0f;          

    public float CameraSpeed = 10.0f;
    Vector3 TargetPos;

    private void FixedUpdate()
    {
        TargetPos = new Vector3(
            GameManager.instance.player.transform.position.x + offsetX,
            GameManager.instance.player.transform.position.y + offsetY,
            GameManager.instance.player.transform.position.z + offsetZ
            );

        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.fixedDeltaTime * CameraSpeed);
    }
}
