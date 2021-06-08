using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class JigSawSend : MonoBehaviour
{
    public Writecomment _writecomment;
    public void Onclick()
    {
        _writecomment.ChangeCurrentObject(Writecomment.CurrentObject.jigsaw);
        _writecomment.showKeyboard();
    }
}
