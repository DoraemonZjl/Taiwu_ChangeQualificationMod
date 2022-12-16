//本文件填写0-添加MOD对话人物(Clone)事件执行周期内相关阶段函数
//【记得经常使用 Ctrl+S 保存修改，只有保存以后才能在编辑事件时生效】
//可引用变量 ArgBox - 该事件从上层事件继承的参数盒子

// 在此区域填写自定义的using指令
// 注意：一般事件制作不需要填写; 在你明确知道每个using指令的意义和有明确使用需求的情况下再填写此指令集
#region CustomUsings
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent.EventHelper;
#endregion

#if IN_IDE
public class Event_b7eb79221e6b40af8640e12649a73e8a : TaiwuEventItem
{
#endif

    /// <summary>
    /// 该事件监听的触发点被触发后，该接口检测事件是否满足执行条件，如果不满足则不执行该事件
    /// </summary>
    /// <returns>true - 可以执行 false - 忽略触发不执行</returns>
    public override bool OnCheckEventCondition()
    {
        //TODO
        return true;
    }
    
    /// <summary>
    /// 该事件被触发且满足执行条件，事件显示前调用
    /// 一般用于向参数盒子中准备事件链需要用到的参数
    /// </summary>
    public override void OnEventEnter()
    {
        //TODO
        //强制将mod人物移动到太吾村地格
        //获取mod人物id
        int modCharacterId = -1;
        bool flag = TaiwuEvent.GetModData("ModCharacterId", true, ref modCharacterId);
        if (flag==true)
        {
            //获取太吾村位置
            GameData.Domains.Map.Location taiwuVillageLocation = EventHelper.GetTaiwuVillageLocation();
            //获取mod人物
            Character modCharacter = EventHelper.GetCharacterById(modCharacterId);
            if (modCharacter == null)
            {
                EventHelper.Log("强制将mod人物移动到太吾村地格函数中获取mod人物角色失败，此为bug。");
            }
            //将人物移动到太吾村
            EventHelper.MoveIntelligentCharacter(modCharacter, taiwuVillageLocation);
            EventHelper.Log("已将修改武学或技艺的mod人物移动至太吾村。");
        }
        else
        {
            EventHelper.Log("强制将mod人物移动到太吾村地格函数中获取mod人物id失败，此为bug。");
        }
    }

    /// <summary>
    /// 该事件执行完毕，即将退出该事件时调用
    /// 一般用于从参数盒子中移除事件链中不需要用到的参数，或记录事件触发月份，确保后续触发几率计算
    /// </summary>
    public override void OnEventExit()
    {
        //TODO
    }
    
    /// <summary>
    /// 该事件即将显示前调用,获取被替换占位符后的事件显示内容
    /// 如果事件文本预设满足系统默认的占位符替换方案，则可以不填写此接口
    /// </summary>
    public override string GetReplacedContentString()
    {
        //TODO
        return string.Empty;
    }
    
    /// <summary>
    /// 获取额外格式化使用的多语言字段
    /// </summary>
    /// <returns></returns>
    public override List<string> GetExtraFormatLanguageKeys()
    {
        return default;
    }

#if IN_IDE
}
#endif