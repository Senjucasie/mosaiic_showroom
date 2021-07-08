using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickComment : MonoBehaviour
{
    public UIManager UIcontrol;
   public void OnClick()
    {
        UIcontrol.OnclickComment(transform.GetSiblingIndex());
    }
}
