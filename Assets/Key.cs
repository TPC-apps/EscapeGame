using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Door door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 鍵がクリックされたときに呼び出される関数
    public void onKeyPicked()
    {
        door.setIsKeyPickedUp(true);
    }
}
