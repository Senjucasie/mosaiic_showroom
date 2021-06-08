
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


namespace Microsoft.MixedReality.Toolkit.Experimental.UI
{
    /// <summary>
    /// This component links the NonNativeKeyboard to a TMP_InputField
    /// Put it on the TMP_InputField and assign the NonNativeKeyboard.prefab
    /// </summary>
    public class Writecomment : MonoBehaviour
    {
        [Experimental]
        [SerializeField] private NonNativeKeyboard keyboard = null;
        public TMP_InputField[] Inputtext;
        public TextMeshProUGUI[] Anotationtext;
       [SerializeField]
        private Transform[] _spawnPos,_keyboardPos;
        public GameObject CommentPrefab;
        public  enum CurrentObject { chair,stool,jigsaw,etron,astronaut};
        public static CurrentObject SelectedModel;
        


        public void showKeyboard()
        {
#if UNITY_EDITOR
            keyboard.Close();
            keyboard.PresentKeyboard();
            keyboard.OnClosed += DisableKeyboard;
            keyboard.OnTextSubmitted += DisableKeyboard;
            keyboard.OnTextUpdated += UpdateText;
           
            switch(SelectedModel)
            {
                case CurrentObject.chair:
                    {
                        keyboard.transform.position = _keyboardPos[0].position;
                        keyboard.transform.parent = _keyboardPos[0];
                        break;
                    }
                case CurrentObject.stool:
                    {
                        keyboard.transform.position = _keyboardPos[1].position;
                        keyboard.transform.parent = _keyboardPos[1];
                        break;
                    }
                case CurrentObject.jigsaw:
                    {
                        keyboard.transform.position = _keyboardPos[2].position;
                        keyboard.transform.parent = _keyboardPos[2];
                        break;
                    }
                case CurrentObject.etron:
                    {
                        keyboard.transform.position = _keyboardPos[3].position;
                        keyboard.transform.parent = _keyboardPos[3];
                        break;
                    }
                case CurrentObject.astronaut:
                    {
                        keyboard.transform.position = _keyboardPos[4].position;
                        keyboard.transform.parent = _keyboardPos[4];
                        break;
                    }
            }
#endif
        }

        private void UpdateText(string text)
        {
#if UNITY_EDITOR
            switch (SelectedModel)
           {
                case CurrentObject.chair:
                    {
                        Anotationtext[0].text = text;
                        Inputtext[0].text=text;

                        break;
                    }
                case CurrentObject.stool:
                    {
                        Anotationtext[1].text = text;
                        Inputtext[1].text = text;
                        break;
                    }
                case CurrentObject.jigsaw:
                    {
                        Anotationtext[2].text = text;
                        Inputtext[2].text = text;
                        break;
                    }
                case CurrentObject.etron:
                    {
                        Anotationtext[3].text = text;
                        Inputtext[3].text = text;
                        break;
                    }
                case CurrentObject.astronaut:
                    {
                        Anotationtext[4].text = text;
                        Inputtext[4].text = text;
                        break;
                    }
            }

#endif
        }

        private void DisableKeyboard(object sender, EventArgs e)
        {
#if UNITY_EDITOR
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;

            keyboard.Close();
#endif
        }
        public void CreateComment()
        {
            switch (SelectedModel)
            {
                case CurrentObject.chair:
                    {
                        GameObject comment = Instantiate(CommentPrefab, _spawnPos[0].position, Quaternion.identity);
                        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Inputtext[0].text;
                        break;
                    }
                case CurrentObject.stool:
                    {
                        GameObject comment = Instantiate(CommentPrefab, _spawnPos[1].position, Quaternion.identity);
                        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Inputtext[1].text;
                        break;
                    }
                case CurrentObject.jigsaw:
                    {
                        GameObject comment = Instantiate(CommentPrefab, _spawnPos[2].position, Quaternion.identity);
                        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Inputtext[2].text;
                        break;
                    }
                case CurrentObject.etron:
                    {
                        GameObject comment = Instantiate(CommentPrefab, _spawnPos[3].position, Quaternion.identity);
                        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Inputtext[3].text;
                        break;
                    }
                case CurrentObject.astronaut:
                    {
                        GameObject comment = Instantiate(CommentPrefab, _spawnPos[4].position, Quaternion.identity);
                        comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Inputtext[4].text;
                        break;
                    }
            }
        }
        public void ChangeCurrentObject(CurrentObject model)
        {
            SelectedModel = model;
        }
            
        /*         public void cancelCom()
                {
                    content.GetComponent<TextMeshPro>().text = "Leave a comment...";
                    keyboard.OnTextUpdated -= UpdateText;
                    keyboard.OnClosed -= DisableKeyboard;
                    keyboard.OnTextSubmitted -= DisableKeyboard;

                    keyboard.Close();
                } */

        //public void createComment()
        //{
        //    var offset = new Vector3(UnityEngine.Random.Range(-0.0f, 0.0f), UnityEngine.Random.Range(-0.0f, 0.0f), 0.5f);
        //    var spawnPos = CoreServices.InputSystem.GazeProvider.GazeOrigin + Vector3.ClampMagnitude(CoreServices.InputSystem.GazeProvider.GazeDirection, 0.1f) + offset;
        //    commentPrefab.GetComponentInChildren<TextMeshPro>().text = content.GetComponent<TextMeshPro>().text;
        //    //Instantiate(commentPrefab, spawnPos, Quaternion.identity);
        //    content.GetComponent<TextMeshPro>().text = "Leave a comment...";

        //    GameObject clone = Instantiate(commentPrefab.gameObject, spawnPos, Quaternion.identity) as GameObject;
        //    clone.transform.parent = GameObject.Find("Menu").transform;
        //}
        public void Cancel()
        {
#if UNITY_EDITOR
           
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;
            keyboard.Close();
#endif
        }
    }
}