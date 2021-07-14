using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDFLoader : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
    }
   public void openPDF()
    {
         string namePDF =  "check";
         TextAsset pdfTem = Resources.Load<TextAsset>(namePDF) ;
        System.IO.File.WriteAllBytes(Application.persistentDataPath + "/" + namePDF + ".pdf", pdfTem.bytes);
        Application.OpenURL(Application.persistentDataPath + "/" + namePDF + ".pdf");
    }
}
