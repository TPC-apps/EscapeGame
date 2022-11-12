using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Image doorImage;
    public Sprite imageOpenDoor;

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

    public void open()
    {
        if (isKeyPickedUp)
        {
            doorImage.sprite = imageOpenDoor;
        }
    }
}
