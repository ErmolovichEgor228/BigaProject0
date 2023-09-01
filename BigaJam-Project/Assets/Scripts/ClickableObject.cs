using UnityEngine;
using TMPro;

public class ClickableObject : MonoBehaviour
{
    public int points = 10; // Количество очков, которое прибавляется при нажатии на объект
    private TMP_Text scoreText; // Ссылка на текстовое поле для отображения счета
    [SerializeField] GameObject target;

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>(); // Замените "ScoreText" на имя вашего текстового поля
    }

    private void OnMouseDown()
    {
        HandleClick();
    }

    private void HandleClick()
    {
        // Прибавляем очки и обновляем счет на текстовом поле
        GameManager.Instance.AddPoints(points);
        Destroy(target); // Удаляем объект
    }
}