using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RadialList))]
public sealed class RadialListEditor : Editor
{
    private static readonly HashSet<RadialList> _radialLists = new HashSet<RadialList>();

    static RadialListEditor()
    {
        EditorApplication.hierarchyChanged += UpdateView;
    }

    private void Awake()
    {
        _radialLists.Add(target as RadialList);
    }

    private static void UpdateView()
    {
        foreach (var rl in _radialLists)
            rl.UpdateListView();
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        UpdateView();
    }
}
