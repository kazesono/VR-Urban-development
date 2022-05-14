using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("L");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(5.0f, 1.0f, 0.2f), Quaternion.identity);
    }

}