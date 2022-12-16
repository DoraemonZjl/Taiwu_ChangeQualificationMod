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
using GameData.Domains.TaiwuEvent.EventHelper;


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_15221e83a2d3470cb3c7543678163dc6 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_15221e83a2d3470cb3c7543678163dc6()
		{
			//事件GUID
			Guid = Guid.Parse("15221e83-a2d3-470c-b3c7-543678163dc6");
			//该事件是否是头部事件
			IsHeadEvent = true;
			//事件分组
			EventGroup = "ChangeQualification";
			//同一时间是否强制只允许触发一个同组事件
			ForceSingle = false;
			//事件类型
			EventType = EEventType.ModEvent;
			//事件触发点类型
			TriggerType = EventTrigger.RecordEnterGame;
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
		        bool flag = false;
		        TaiwuEvent.GetModData("ChangeQualificationMod",true,ref flag);
		        if (flag == true)
		        {
		            return false;
		        }
		        return true;
		    }

		    public override void OnEventEnter()
		    {
		        GameData.Domains.Map.Location taiwuVillageLocation = EventHelper.GetTaiwuVillageLocation();
		        Character modCharacter = EventHelper.CreateIntelligentCharacter(taiwuVillageLocation, Gender.Female, 18, 900,
		            EventHelper.GetSettlementIdByOrgTemplateId(Config.Organization.DefKey.Taiwu), Grade.Middle1);
		        EventHelper.AddFeature(modCharacter, 8, true);
		        EventHelper.AddFeature(modCharacter, 20, true);
		        EventHelper.AddFeature(modCharacter, 68, true);
		        EventHelper.AddFeature(modCharacter, 152, true);
		        EventHelper.AddFeature(modCharacter, 261, true);
		        int modCharacterId = modCharacter.GetId();
		        TaiwuEvent.SetModInt("ModCharacterId", true, modCharacterId);
		        TaiwuEvent.SetModBool("ChangeQualificationMod", true, true);
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