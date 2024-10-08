using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 InputVector { get; private set; }

    public Vector3 MousePosition { get; private set; }
    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        InputVector = new Vector2(h, v);

        MousePosition = Input.mousePosition;
        HandleShootInput();
    }
    void HandleShootInput()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            // Shoot
            PlayerGun.Instance.Shoot();
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            // super Shoot
            PlayerGun.Instance.Shoot2();
        }
    }
}
