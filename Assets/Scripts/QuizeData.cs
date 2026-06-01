using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(fileName = "QuizeData", menuName = "Scriptable Objects/QuizeData")]
public class QuizeData : ScriptableObject
{
    public List<DataList> dataLists;
}

[Serializable]
public class DataList
{
    public string question;//問題文
    public string[] selection;//選択肢
    public string anser;//答え

    public bool judgment;//判定(不要の可能性あり)
}
