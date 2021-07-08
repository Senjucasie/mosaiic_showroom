using System;
using UnityEngine;
[Serializable]
public class CommentDataHolder
{
    public string Title;
    public string Content;
    public GameObject Comment;

    public CommentDataHolder(string title, string content,GameObject comment)
    {
        Title = title;
        Content = content;
        Comment = comment;
    }

}