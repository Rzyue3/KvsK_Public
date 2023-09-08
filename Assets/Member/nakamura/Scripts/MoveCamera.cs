using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject followTarget;//�J�������Ǐ]�������
    private Vector3 offset;//�����̎擾�p

    void Start()
    {
        //�J�n���_�̃J�����ƃ^�[�Q�b�g�̋����̎擾
        offset = gameObject.transform.position - followTarget.transform.position;
    }

    //�v���C���[���ړ�������ɃJ�������ړ�����悤��LateUpdate�Ƃ���
    void LateUpdate()
    {
        //�J�����̈ʒu���^�[�Q�b�g�̈ʒu�ɃI�t�Z�b�g�𑫂����ꏊ�ɂ���
        gameObject.transform.position = followTarget.transform.position + offset;
    }
}
