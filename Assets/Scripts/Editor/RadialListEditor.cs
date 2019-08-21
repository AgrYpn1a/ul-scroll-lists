using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RadialList))]
public sealed class RadialListEditor : Editor
{
    private RadialList _rl;

    private void OnEnable()
    {
        EditorApplication.hierarchyChanged -= HandleHierarchyChange;
        EditorApplication.hierarchyChanged += HandleHierarchyChange;
    }

    private void HandleHierarchyChange()
    {

    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        _rl = target as RadialList;

        float angleDelta = 360f / (_rl.content.childCount + 1);
        float angle = 0f + _rl.rotation;

        float maxAngle = -180f;

        if (_rl.direction == RadialList.Direction.LEFT_TO_RIGHT)
        {
            maxAngle = 180f;
            angle += maxAngle;
        }

        foreach (RectTransform element in _rl.content)
        {
            angle += angleDelta;

            Debug.Log("Child " + element);
            //element.anchoredPosition = new Vector3(_rl.radius * Mathf.Cos(angle * Mathf.Deg2Rad), _rl.radius * Mathf.Sin(angle * Mathf.Deg2Rad), 0f);
            element.localPosition = new Vector2(
            _rl.radius * Mathf.Cos(angle * Mathf.Deg2Rad),
            _rl.radius * Mathf.Sin(angle * Mathf.Deg2Rad));

        }
    }

}
