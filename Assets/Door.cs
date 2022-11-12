using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Image doorImage;
    public Sprite imageOpenDoor;
    public Text clearText;

    // 鍵を拾ったか管理するフラグ
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

    // ドアが押されたときに呼び出される関数
    public void open()
    {
        // 鍵が拾っているかを判定して、拾っていたらドアを開く
        if (isKeyPickedUp)
        {
            doorImage.sprite = imageOpenDoor;
            // ドアを開いてクリアのテキストを表示
            clearText.gameObject.SetActive(true);
        }
    }
}
