using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unity2 : MonoBehaviour
{

    //unity�����̃I�u�W�F�N�g
    public GameObject unitychan;

    //unity�����̏����ʒu
    public float movePosition = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //unity�����̃I�u�W�F�N�g���擾
        unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unity�����̈ʒu���擾
        float unityChanPosition = unitychan.transform.position.z;

        if (unityChanPosition >= movePosition + 30f)
        {
            Debug.Log("unity�����10m�i��");
            movePosition = unityChanPosition;
        }
    }
}
