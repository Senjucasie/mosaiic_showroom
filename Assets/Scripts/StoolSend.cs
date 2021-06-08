using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class StoolSend : MonoBehaviour
{
    public Writecomment _writecomment;
    public void Onclick()
    {
        _writecomment.ChangeCurrentObject(Writecomment.CurrentObject.stool);
        _writecomment.showKeyboard();
    }
}
