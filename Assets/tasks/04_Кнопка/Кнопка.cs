using UnityEngine;
using UnityEngine.EventSystems;

public class Кнопка : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private Renderer _renderer;
    private Color _originalColor;

    void Start()
    {
        _renderer = _target.GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
    }

    public void PointerEnter()
    {
        _renderer.material.color = Color.yellow;
    }

    public void PointerExit()
    {
        _renderer.material.color = _originalColor;
    }
}