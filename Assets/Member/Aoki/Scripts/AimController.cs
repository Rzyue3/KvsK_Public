using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimController : MonoBehaviour
{
    public Vector3 targetPos;
    public Image aimImage;

    void Update()
    {
        // �u�}�E�X�̈ʒu�v�Ɓu�Ə���̈ʒu�v�𓯊�������B
        transform.position = Input.mousePosition;
    }
}