using UnityEngine;
using TMPro;

public class ClickFunction : MonoBehaviour
{
    [SerializeField] GameObject target;
    private void Start()
    {
    }

    public void OnMouseDown()
    {
        GameManager.Instance.AddPoints(10);
        Destroy(target);
    }
}
