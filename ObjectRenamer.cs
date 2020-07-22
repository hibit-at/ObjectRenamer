using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class MenuItemTest : MonoBehaviour
{
    [MenuItem("CustomMenu/Rename %t", false, 1)]
    static void OutputConsole()
    {
        Transform[] transformArray = Selection.activeGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform e in transformArray)
        {
            if (e.name == Selection.activeGameObject.name) continue;
            e.name = e.name + "_" + Selection.activeGameObject.name;
        }
    }

    [MenuItem("CustomMenu/DoubleCheck %u", false, 1)]
    static void OutputConsole2()
    {
        List<string> check = new List<string>();
        Transform[] transformArray = Selection.activeGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform e in transformArray)
        {
            if (check.Contains(e.name) == true)
            {
                e.name = e.name + "_1";
            }
            check.Add(e.name);
        }
    }
}