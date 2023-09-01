using UnityEngine;
using TMPro;

public class ClickableObject : MonoBehaviour
{
    public int points = 10; // ���������� �����, ������� ������������ ��� ������� �� ������
    private TMP_Text scoreText; // ������ �� ��������� ���� ��� ����������� �����
    [SerializeField] GameObject target;

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>(); // �������� "ScoreText" �� ��� ������ ���������� ����
    }

    private void OnMouseDown()
    {
        HandleClick();
    }

    private void HandleClick()
    {
        // ���������� ���� � ��������� ���� �� ��������� ����
        GameManager.Instance.AddPoints(points);
        Destroy(target); // ������� ������
    }
}