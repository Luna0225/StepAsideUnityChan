using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    //メインカメラのオブジェクト
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラのオブジェクトを取得
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //カメラのポジション現在のオブジェクトのポジションでカメラのZ軸のポジションが大きい場合オブジェクトを消去
        if (mainCamera.transform.position.z >= this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
