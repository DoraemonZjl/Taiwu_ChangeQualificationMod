//本文件填写6-修改数值(Clone)事件执行周期内相关阶段函数
//【记得经常使用 Ctrl+S 保存修改，只有保存以后才能在编辑事件时生效】
//可引用变量 ArgBox - 该事件从上层事件继承的参数盒子

// 在此区域填写自定义的using指令
// 注意：一般事件制作不需要填写; 在你明确知道每个using指令的意义和有明确使用需求的情况下再填写此指令集
#region CustomUsings
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.EventHelper;
#endregion

#if IN_IDE
public class Event_e2430dbcbe2b4e1f88e278e6b1e511c8 : TaiwuEventItem
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
        //判断执行前所需要的参数是否都存在
        //获取3-修改资质选项（增加或减少）
        int changeQualificationAddOrDecrease = -1;
        //获取4-修改武学资质（具体武学）
        int updateCombatSkillType = -1;
        //获取5-修改技艺资质（具体技艺）
        int updateLifeSkillType = -1;
        //获取6-修改数值
        int updateValue = -1;
        TaiwuEvent.GetModData("ChangeQualificationAddOrDecrease", true, ref changeQualificationAddOrDecrease);
        TaiwuEvent.GetModData("UpdateCombatSkillType", true, ref updateCombatSkillType);
        TaiwuEvent.GetModData("UpdateLifeSkillType", true, ref updateLifeSkillType);
        TaiwuEvent.GetModData("UpdateValue", true, ref updateValue);
        //做输出检测用
        List<int> check = new List<int>
        {
            changeQualificationAddOrDecrease,
            updateCombatSkillType,
            updateLifeSkillType,
            updateValue
        };
        if (changeQualificationAddOrDecrease.Equals(-1) || updateCombatSkillType.Equals(-1) || 
                 updateValue.Equals(-1)|| updateLifeSkillType.Equals(-1))
        {
            EventHelper.Log("获取参数失败，请查看GameData日志");
            foreach(int i in check)
            {
                EventHelper.Log("参数："+i);
            }
            return;
        }
        else
        {
            Character taiwu = ArgBox.GetCharacter(EventArgBox.RoleTaiwu);
            //修改资质类型:0为增加武学资质，1为增加技艺资质，2为减少武学资质，3为减少技艺资质
            switch (changeQualificationAddOrDecrease)
            {
                case 0:
                    //获取太吾当前对应资质当前值
                    short currentValue0 = EventHelper.GetRoleBaseCombatSkillQualificationByType(taiwu, (sbyte)updateCombatSkillType);
                    //修改对应的资质值
                    EventHelper.SetCharBaseCombatSkillQualification(taiwu.GetId(), (sbyte)updateCombatSkillType, (short)(currentValue0 + updateValue));
                    break;
                case 1:
                    short currentValue1 = EventHelper.GetRoleBaseLifeSkillQualificationByType(taiwu, (sbyte)updateLifeSkillType);
                    EventHelper.SetCharBaseLifeSkillQualification(taiwu.GetId(), (sbyte)updateLifeSkillType, (short)(currentValue1 + updateValue));
                    break;
                case 2:
                    //获取太吾当前对应资质当前值
                    short currentValue2 = EventHelper.GetRoleBaseCombatSkillQualificationByType(taiwu, (sbyte)updateCombatSkillType);
                    //修改对应的资质值
                    EventHelper.SetCharBaseCombatSkillQualification(taiwu.GetId(), (sbyte)updateCombatSkillType, (short)(currentValue2 - updateValue));
                    break;
                case 3:
                    short currentValue3 = EventHelper.GetRoleBaseLifeSkillQualificationByType(taiwu, (sbyte)updateLifeSkillType);
                    EventHelper.SetCharBaseLifeSkillQualification(taiwu.GetId(), (sbyte)updateLifeSkillType, (short)(currentValue3 - updateValue));
                    break;
            }
            //清楚标识
            TaiwuEvent.RemoveModInt("ChangeQualificationAddOrDecrease", true);
            TaiwuEvent.RemoveModInt("UpdateCombatSkillType", true);
            TaiwuEvent.RemoveModInt("UpdateLifeSkillType", true);
            TaiwuEvent.RemoveModInt("UpdateValue", true);
            return;
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