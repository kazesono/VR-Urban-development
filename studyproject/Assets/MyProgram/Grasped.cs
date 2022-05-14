using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;


public class Grasped : MonoBehaviour
{

    GameObject SObject;
    InformationMain script;

    void Start()
    {
        //Bのスクリプトを取得
        SObject = GameObject.FindWithTag("Master");
        script = SObject.GetComponent<InformationMain>();
    }

    public void GraspedObject()
    {
        string ObjectName = this.gameObject.name;
        Debug.Log(ObjectName);
        //Destroy(this.gameObject);
        script.SelectedObjectName = ObjectName;
        Debug.Log("送信成功！");
    }

    void Update()
    {
        //if (this.gameObject.isGrasped = 2) ;
    }
}
