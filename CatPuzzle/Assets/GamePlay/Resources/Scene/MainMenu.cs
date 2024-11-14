using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using F8Framework.Core;

public class MainMenu : BaseView
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

#if UNITY_EDITOR
    protected override void SetComponents()
    {
        Canvas_Canvas = transform.Find("Canvas").GetComponent<Canvas>();
    }
#endif
    // 自动获取组件（自动生成，不能删除）
}