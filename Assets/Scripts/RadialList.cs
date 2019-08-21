using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class RadialList : MonoBehaviour
{

    public enum Direction
    {
        LEFT_TO_RIGHT,
        RIGHT_TO_LEFT
    }

    private RectTransform _rect;
    public Transform content;

    [Space(4)]
    [Header("References")]
    [SerializeField]
    public float radius = 1f;
    public float rotation = 100f;
    public Direction direction = Direction.LEFT_TO_RIGHT;

    private void Awake()
    {
        _rect = GetComponent<RectTransform>();
    }

    private void Start()
    {

    }

}
