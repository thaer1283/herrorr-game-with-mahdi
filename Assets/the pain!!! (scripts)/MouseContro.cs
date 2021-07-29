using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseContro : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public float Senstivity = 100f;

    public Transform player; 

    float rotation = 0f;

    public float minAngel = -90f;
    public float maxAngel = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Senstivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * Senstivity * Time.deltaTime;

        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, minAngel, maxAngel);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);

        player.Rotate(Vector3.up * mouseX);
    }
}
