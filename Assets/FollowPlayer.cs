using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.5f;
    public Vector3 offset;
    private GUIStyle style=new GUIStyle();

    public void OnGUI()
    {
        style.fontSize = 30;
        GUI.Label(new Rect(10, 200, 100, 50), "< small \n > big \n / medium", style);
    }
    private void FixedUpdate()
    {
        offset.y = player.localScale.y;
        offset.z = -player.localScale.z * 3;
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
