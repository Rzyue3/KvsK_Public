using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologButtonGeneration : MonoBehaviour
{
    //�����p�{�^���擾�p
    [SerializeField]
    private GameObject prologButton;
    //�{�^�������f�B���C�^�C���ݒ�p�ϐ�
    [SerializeField]
    private float createTime = 1f;
    //�o�ߎ��Ԍv���p�ϐ�
    private float elapsedTime = 0;
    //�{�^�������t���O
    private bool isButtonCreate = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isButtonCreate) elapsedTime += Time.deltaTime;
        if (elapsedTime > createTime)
        {
            Instantiate(prologButton, this.transform);
            isButtonCreate = true;
            elapsedTime = 0;
        }

    }
}
