using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabControl : MonoBehaviour
{
    public Transform handposition;
    public Vector3 hand1;
    // Use this for initialization
    GameObject SObject;
    InformationMain script;
    public int smalli = 0;
    public int largei = 0;

    void Start()
    {
        SObject = GameObject.FindWithTag("Master");
        script = SObject.GetComponent<InformationMain>();

    }

    public void CreateLarge()
    {
        handposition = GameObject.Find("CreateArea").transform;
        Vector3 hand1 = handposition.transform.position; 
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("LargeBuilding");
        // Cubeプレハブを元に、インスタンスを生成、
        var largeclone = Instantiate(obj,hand1, Quaternion.identity);
        largeclone.name = "LargeBuilding" + largei;
        largei++;
        
        Debug.Log("largeプレハブ作成成功！ " + " 座標 1x = " + hand1.x + " / 1y = " + hand1.y + " / 1z = " + hand1.z);
    }

    public void CreateSmall()
    {
        handposition = GameObject.Find("CreateArea").transform;
        Vector3 hand1 = handposition.transform.position;

        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("SmallBuilding");
        // Cubeプレハブを元に、インスタンスを生成、
        var smallclone = Instantiate(obj, hand1, Quaternion.identity);
        smallclone.name = "SmallBuilding" + smalli;
        smalli++;

        Debug.Log("smallプレハブ作成成功！ " + " 座標 1x = " + hand1.x + "/ 1y = " + hand1.y + "/ 1z = " + hand1.z);
    }

    public void CreateSmalltest()
    {
        handposition = GameObject.Find("CreateArea").transform;
        Vector3 hand1 = handposition.transform.position;

        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("SmallBuilding");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, hand1, Quaternion.identity);

        Debug.Log("smallプレハブ作成成功！ " + " 座標 1x = " + hand1.x + "/ 1y = " + hand1.y + "/ 1z = " + hand1.z);
    }


    public void DeleteObject()
    {
        GameObject destroy = GameObject.Find(script.SelectedObjectName);
        Destroy(destroy);
    }

}
