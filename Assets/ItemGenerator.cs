using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;

    //coinPrefabを入れる
    public GameObject coinPrefab;

    //conePrefabを入れる
    public GameObject conePrefab;

    //スタート地点
    public int startPos = 80;

    //ゴール地点
    public int goalPos = 360;

    //アイテムを出すｘ方向の範囲
    private float posRange = 3.4f;

    //コーンのｘ軸のポジション
    private float conePos = 4;

    //unityちゃんのオブジェクト
    public GameObject unitychan;

    //unityちゃんの初期位置
    public float movePosition;



    


    // Start is called before the first frame update

    void Start()
    {
        //unityちゃんのオブジェクトを取得
        unitychan = GameObject.Find("unitychan");

    }
    public void Objectpop()
    {
        

        //どのアイテムを出すのかをランダムに設定
        int num = Random.Range(1, 11);
        if (num <= 2)
        {
            //コーンをx軸方向に一直線に生成
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab);
                cone.transform.position = new Vector3(conePos * j, cone.transform.position.y, unitychan.transform.position.z + 50);
                
            }

        }
        else
        {

            //レーンごとにアイテムを生成
            for (int j = -1; j <= 1; j++)
            {
                //アイテムの種類を決める
                int item = Random.Range(1, 11);
                //アイテムを置くZ座標のオフセットをランダムに設定
                int offsetZ = Random.Range(-5, 6);
                //60%コイン配置:30%車配置:10%何もなし
                if (1 <= item && item <= 6)
                {
                    //コインを生成
                    GameObject coin = Instantiate(coinPrefab);
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + offsetZ + 50f);
                }
                else if (7 <= item && item <= 9)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab);
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + offsetZ + 50f);
                }
            }

        }

    }

    

    // Update is called once per frame
    void Update()
    {
        
        //unityちゃんの位置を取得
        float unityChanPosition = unitychan.transform.position.z;


        //unityちゃんが30m進むごとに50m先にオブジェクトを生成
        if (unityChanPosition >= movePosition)
        {
            movePosition += 30;
            //条件式の値をチェック
            Debug.Log(unityChanPosition + ">=" + movePosition);
            Objectpop();
        }
    }

}
