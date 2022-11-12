using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Image doorImage;
    public Sprite imageOpenDoor;
    public Text clearText;

    // �����E�������Ǘ�����t���O
    private bool isKeyPickedUp = false;
    public void setIsKeyPickedUp(bool isPickedUp)
    {
        isKeyPickedUp = isPickedUp;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �h�A�������ꂽ�Ƃ��ɌĂяo�����֐�
    public void open()
    {
        // �����E���Ă��邩�𔻒肵�āA�E���Ă�����h�A���J��
        if (isKeyPickedUp)
        {
            doorImage.sprite = imageOpenDoor;
            // �h�A���J���ăN���A�̃e�L�X�g��\��
            clearText.gameObject.SetActive(true);
        }
    }
}
