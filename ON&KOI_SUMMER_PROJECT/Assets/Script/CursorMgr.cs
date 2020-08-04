using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMgr : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
