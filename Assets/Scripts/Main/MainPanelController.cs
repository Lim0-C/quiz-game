using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainPanelController : MonoBehaviour
{
    [SerializeField] private TMP_Text _heartText;
    [SerializeField] private TMP_Text _stageText;
    
    public void OnClickPlayButton()
    {
        GameManager.Instance.StartGame();
    }

    #region Main Menu 버튼 클릭 함수

    public void OnClickShopButton()
    {
        
    }

    public void OnClickStageButton()
    {
        
    }

    public void OnClickLeaderboardButton()
    {
        
    }

    public void OnClickSettingsButton()
    {
        
    }

    #endregion
}
