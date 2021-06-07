
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
    public class WriteComment : MonoBehaviour
    {
        [Experimental]
        [SerializeField] private NonNativeKeyboard keyboard = null;
        public TMP_InputField Inputtext;
        public TextMeshProUGUI Anotationtext;
       [SerializeField]
        private Transform _spawnPos;
        public GameObject CommentPrefab;
        public GameObject _KeyBoard;
        


        public void showKeyboard()
        {
#if UNITY_EDITOR
            keyboard.Close();
            keyboard.PresentKeyboard();
            keyboard.OnClosed += DisableKeyboard;
            keyboard.OnTextSubmitted += DisableKeyboard;
            keyboard.OnTextUpdated += UpdateText;
#endif
        }

        private void UpdateText(string text)
        {
#if UNITY_EDITOR

            Anotationtext.text = text;
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
        public void CreateComment(TMP_InputField inputtxt)
        {

            GameObject comment = Instantiate(CommentPrefab, _spawnPos.position, Quaternion.identity);
            comment.transform.GetChild(0).GetComponent<TextMeshPro>().text = Anotationtext.text;

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
            if(_KeyBoard.activeSelf)
            keyboard.OnTextUpdated -= UpdateText;
            keyboard.OnClosed -= DisableKeyboard;
            keyboard.OnTextSubmitted -= DisableKeyboard;
            keyboard.Close();
#endif
        }
    }
}