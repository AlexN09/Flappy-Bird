using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button button; // Ссылка на компонент кнопки
    public GameObject labelSprite; // Ссылка на игровой объект спрайта'
    public static bool CanPlay = false;
    public static bool canRes = false;
    private void Start()
    {
        button.onClick.AddListener(OnClickButton); // Добавляем слушатель события нажатия на кнопку
    }
    private void Update()
    {
        if (BirdMovement.defeat) 
        {   
            button.gameObject.SetActive(true);
            labelSprite.SetActive(true);
            CanPlay = false;
        }
    }
    private void OnClickButton() 
    {
        button.gameObject.SetActive(false);
        labelSprite.SetActive(false);   
        CanPlay = true;
        Debug.Log(CanPlay);
        BirdMovement.canRes = true;
    }
}
