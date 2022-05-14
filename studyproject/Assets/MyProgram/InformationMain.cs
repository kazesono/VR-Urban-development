using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationMain : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public string SelectedObjectName;

    GameObject Sunlight;
    LightRoll script;

    void Start()
    {
        Sunlight = GameObject.Find("Directional Light"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = Sunlight.GetComponent<LightRoll>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }
    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //時間の取得
        float time = script.suntime;
        float time1;
        time *= -1;
        time += 12;
        time1 = Mathf.Floor(time);
        time -= time1;
        time *= 60;
        time = Mathf.Floor(time);
        //stringに変換
        string timehour = time1.ToString();
        string timeminitue = time.ToString();
        //テキストの表示
        if(time < 10)
        {
            score_text.text = "選択中:" + SelectedObjectName + "\n Time  " + timehour + ":0" + timeminitue;
        }
        else
        {
            score_text.text = "選択中:" + SelectedObjectName + "\n Time  " + timehour + ":" + timeminitue;
        }
        
    }

}
