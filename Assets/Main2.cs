using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    //���C���J�����̃I�u�W�F�N�g
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //���C���J�����̃I�u�W�F�N�g���擾
        this.mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����̃|�W�V�������݂̃I�u�W�F�N�g�̃|�W�V�����ŃJ������Z���̃|�W�V�������傫���ꍇ�I�u�W�F�N�g������
        if (mainCamera.transform.position.z >= this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
