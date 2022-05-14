using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    public void FreezePosition()
    {
        //Rigidbodyを取得
        var rb = GetComponent<Rigidbody>();

        //FreezePositionXをオンにする
        rb.constraints = RigidbodyConstraints.FreezePositionX;
    }
}
