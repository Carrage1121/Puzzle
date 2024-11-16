using F8Framework.Core;
using UnityEngine;
using UnityEngine.UI;

namespace GamePlay.Script.UI.MainMenu
{
    public partial class UIMainMenu : BaseView
    {
        // Awake
        protected override void OnAwake()
        {
        
        }
    
        // 参数传入
        protected override void OnAdded(int uiId, object[] args = null)
        {
        
        }
    
        // Start
        protected override void OnStart()
        {
        
        }
    
        protected override void OnViewTweenInit()
        {
            //transform.localScale = Vector3.one * 0.7f;
        }
    
        // 自定义打开界面动画
        protected override void OnPlayViewTween()
        {
            //transform.ScaleTween(Vector3.one, 0.1f).SetEase(Ease.Linear).SetOnComplete(OnViewOpen);
        }
    
        // 打开界面动画完成后
        protected override void OnViewOpen()
        {
        
        }
    
        // 删除之前
        protected override void OnBeforeRemove()
        {
        
        }
    
        // 删除
        protected override void OnRemoved()
        {
        
        }
    
        // 自动获取组件（自动生成，不能删除）
    [SerializeField] private Canvas Canvas_Canvas;
    [SerializeField] private Button BeginGameButton_Button;
    [SerializeField] private Button AcButton_Button;
    [SerializeField] private Button ExitButton_Button;
    [SerializeField] private TMPro.TMP_Text TextTMP_TextTMP;
    [SerializeField] private TMPro.TMP_Text TextTMP_TextTMP_2;
    [SerializeField] private TMPro.TMP_Text TextTMP_TextTMP_3;

#if UNITY_EDITOR
    protected override void SetComponents()
    {
        Canvas_Canvas = transform.Find("Canvas").GetComponent<Canvas>();
        BeginGameButton_Button = transform.Find("Canvas/Panel/ButtonList/BeginGame-Button").GetComponent<Button>();
        AcButton_Button = transform.Find("Canvas/Panel/ButtonList/Ac-Button").GetComponent<Button>();
        ExitButton_Button = transform.Find("Canvas/Panel/ButtonList/Exit-Button").GetComponent<Button>();
        TextTMP_TextTMP = transform.Find("Canvas/Panel/ButtonList/BeginGame-Button/Text (TMP)").GetComponent<TMPro.TMP_Text>();
        TextTMP_TextTMP_2 = transform.Find("Canvas/Panel/ButtonList/Ac-Button/Text (TMP)").GetComponent<TMPro.TMP_Text>();
        TextTMP_TextTMP_3 = transform.Find("Canvas/Panel/ButtonList/Exit-Button/Text (TMP)").GetComponent<TMPro.TMP_Text>();
    }
#endif
    // 自动获取组件（自动生成，不能删除）
    }
}