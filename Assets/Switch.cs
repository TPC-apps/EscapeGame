using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Key key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �X�C�b�`�������ꂽ�Ƃ��ɌĂяo�����֐�
    public void onClick()
    {
        key.gameObject.SetActive(true);
    }
}
