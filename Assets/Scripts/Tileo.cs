using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private Image _renderer;

    public void Init(bool isOffset)
    {
        _renderer.color = _baseColor;
    }

    void OnMouseEnter()
    {

    }

    void OnMouseExit()
    {

    }
}