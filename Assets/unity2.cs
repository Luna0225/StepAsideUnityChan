using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unity2 : MonoBehaviour
{

    //unityちゃんのオブジェクト
    public GameObject unitychan;

    //unityちゃんの初期位置
    public float movePosition = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //unityちゃんのオブジェクトを取得
        unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unityちゃんの位置を取得
        float unityChanPosition = unitychan.transform.position.z;

        if (unityChanPosition >= movePosition + 30f)
        {
            Debug.Log("unityちゃんが10m進んだ");
            movePosition = unityChanPosition;
        }
    }
}
