using System.Collections;
using System.Collections.Generic;
using TouchScript;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.UI;

public class TUIOTest : MonoBehaviour
{
    public Image GreenBtnImg;
    public Image RedBtnImg;
    void Start()
    {

    }

    // Update is called once per frame
    public void OnGreenBtnClick()
    {

        StartCoroutine(GreenWait());
    }

    public void OnRedBtnClick()
    {
   
        StartCoroutine(RedWait());
    }

    IEnumerator GreenWait()
    {
        GreenBtnImg.raycastTarget = false;
        yield return new WaitForSeconds(1);
        GreenBtnImg.raycastTarget = true;
    }
    IEnumerator RedWait()
    {
        RedBtnImg.raycastTarget = false;
        Debug.Log("s");
        yield return new WaitForSeconds(1);
        RedBtnImg.raycastTarget = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(1);
            IList<TouchScript.Pointers.Pointer> PressedPointers = TouchManager.Instance.PressedPointers;
            foreach(TouchScript.Pointers.Pointer point in PressedPointers)
            {
                Debug.Log(point.Position);
            }
  
        }
    }
}
