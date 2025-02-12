using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanelController : MonoBehaviour
{
    [SerializeField] private GameObject quizCardPrefab;
    [SerializeField] private Transform quizCardParent;
    
    
    void Start()
    {
        ShowQuizCard();
    }
    
    private void ShowQuizCard()
    {
        var quizCardObject = Instantiate(quizCardPrefab, quizCardParent);
    }
    
    public void OnClickGameOverButton()
    {
            GameManager.Instance.QuitGame();
    }
}
