using System;
using System.Linq;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.Enum;
using GameData.Domains.TaiwuEvent.EventHelper;
using GameData.Domains.TaiwuEvent.DisplayEvent;
using GameData.Domains.TaiwuEvent.EventOption;
using GameData.Domains.Character;
using GameData.Domains.Character.AvatarSystem;
using GameData.Domains.Combat;
using GameData.Domains.CombatSkill;
using GameData.Domains.Character.Relation;
using GameData.Domains.Adventure;
using GameData.Domains.Item;
using GameData.Domains.Item.Display;
using GameData.Domains.World;
using GameData.Domains.Information;
using GameData.Domains.Map;
using System.Collections.Generic;
using Config.EventConfig;
using GameData.Domains.Character;
using GameData.Domains.TaiwuEvent;
using GameData.Domains.TaiwuEvent.EventHelper;


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_e2430dbcbe2b4e1f88e278e6b1e511c8 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_e2430dbcbe2b4e1f88e278e6b1e511c8()
		{
			//事件GUID
			Guid = Guid.Parse("e2430dbc-be2b-4e1f-88e2-78e6b1e511c8");
			//该事件是否是头部事件
			IsHeadEvent = false;
			//事件分组
			EventGroup = "ChangeQualification";
			//同一时间是否强制只允许触发一个同组事件
			ForceSingle = false;
			//事件类型
			EventType = EEventType.ModEvent;
			//事件触发点类型
			TriggerType = EventTrigger.None;
			//事件排序执行的优先级
			EventSortingOrder = 500;
			//事件内容
			//EventContent = "";
			//进行决策的角色的Key，为空时将不显示选项上的角色头像
			MainRoleKey = "";
			//进行交互的角色的Key，为空时将不显示背景图上的角色头像
			TargetRoleKey = "";
			//事件背景图，为空表示该事件使用地块适应的背景图
			EventBackground = "";
			//事件对遮罩的控制
			MaskControl = EventMaskControl.NoChange;
			//遮罩渐变的时间
			MaskTweenTime = 0f;
			//绑定在Esc按键处理的选项Key
			EscOptionKey = "";
			//选项列表
			EventOptions = new TaiwuEventOption[]		        
			{
				
			};
			InitOptions();		
		}


		#region EventAPI
		private void InitOptions()
		{
		}

		    public override bool OnCheckEventCondition()
		    {
		        return true;
		    }

		    public override void OnEventEnter()
		    {
		        int changeQualificationAddOrDecrease = -1;
		        int updateCombatSkillType = -1;
		        int updateLifeSkillType = -1;
		        int updateValue = -1;
		        TaiwuEvent.GetModData("ChangeQualificationAddOrDecrease", true, ref changeQualificationAddOrDecrease);
		        TaiwuEvent.GetModData("UpdateCombatSkillType", true, ref updateCombatSkillType);
		        TaiwuEvent.GetModData("UpdateLifeSkillType", true, ref updateLifeSkillType);
		        TaiwuEvent.GetModData("UpdateValue", true, ref updateValue);
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
		            switch (changeQualificationAddOrDecrease)
		            {
		                case 0:
		                    short currentValue0 = EventHelper.GetRoleBaseCombatSkillQualificationByType(taiwu, (sbyte)updateCombatSkillType);
		                    EventHelper.SetCharBaseCombatSkillQualification(taiwu.GetId(), (sbyte)updateCombatSkillType, (short)(currentValue0 + updateValue));
		                    break;
		                case 1:
		                    short currentValue1 = EventHelper.GetRoleBaseLifeSkillQualificationByType(taiwu, (sbyte)updateLifeSkillType);
		                    EventHelper.SetCharBaseLifeSkillQualification(taiwu.GetId(), (sbyte)updateLifeSkillType, (short)(currentValue1 + updateValue));
		                    break;
		                case 2:
		                    short currentValue2 = EventHelper.GetRoleBaseCombatSkillQualificationByType(taiwu, (sbyte)updateCombatSkillType);
		                    EventHelper.SetCharBaseCombatSkillQualification(taiwu.GetId(), (sbyte)updateCombatSkillType, (short)(currentValue2 - updateValue));
		                    break;
		                case 3:
		                    short currentValue3 = EventHelper.GetRoleBaseLifeSkillQualificationByType(taiwu, (sbyte)updateLifeSkillType);
		                    EventHelper.SetCharBaseLifeSkillQualification(taiwu.GetId(), (sbyte)updateLifeSkillType, (short)(currentValue3 - updateValue));
		                    break;
		            }
		            TaiwuEvent.RemoveModInt("ChangeQualificationAddOrDecrease", true);
		            TaiwuEvent.RemoveModInt("UpdateCombatSkillType", true);
		            TaiwuEvent.RemoveModInt("UpdateLifeSkillType", true);
		            TaiwuEvent.RemoveModInt("UpdateValue", true);
		            return;
		        }
		    }

		    public override void OnEventExit()
		    {
		    }

		    public override string GetReplacedContentString()
		    {
		        return string.Empty;
		    }

		    public override List<string> GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion

		#region Options

		#endregion
	}
}