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
using GameData.Domains.Combat;
using GameData.Domains.CombatSkill;
using GameData.Domains.TaiwuEvent.EventHelper;


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_f387e43facac4e88ae3292ccb64adfa7 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_f387e43facac4e88ae3292ccb64adfa7()
		{
			//事件GUID
			Guid = Guid.Parse("f387e43f-acac-4e88-ae32-92ccb64adfa7");
			//该事件是否是头部事件
			IsHeadEvent = true;
			//事件分组
			EventGroup = "ChangeQualification";
			//同一时间是否强制只允许触发一个同组事件
			ForceSingle = false;
			//事件类型
			EventType = EEventType.ModEvent;
			//事件触发点类型
			TriggerType = EventTrigger.CharacterClicked;
			//事件排序执行的优先级
			EventSortingOrder = 20000;
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
				new TaiwuEventOption{ OptionKey = "Option_336767243"}
			};
			InitOptions();		
		}


		#region EventAPI
		private void InitOptions()
		{
			EventOptions[0].OnOptionVisibleCheck = OnOption1VisibleCheck;
			EventOptions[0].OnOptionAvailableCheck = OnOption1AvailableCheck;
			EventOptions[0].GetReplacedContent = OnOption1GetReplacedContent;
			EventOptions[0].OnOptionSelect = OnOption1Select;
			EventOptions[0].GetExtraFormatLanguageKeys = Option1GetExtraFormatLanguageKeys;
			OnOption1Create();
		}

		    public override bool OnCheckEventCondition()
		    {
		        return true;
		    }

		    public override void OnEventEnter()
		    {
		        EventHelper.AddOptionToEvent("567d1caf-8b28-4dbf-8cbe-e746e8ac8cfd", Guid.ToString(), EventOptions[0].OptionKey);
		        EventHelper.ToEvent(string.Empty);
		        return;
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
		    private void OnOption1Create()
		    {
		    }

		    private bool OnOption1VisibleCheck()
		    {
		        int modCharacterId = -1;
		        bool flag = TaiwuEvent.GetModData("ModCharacterId", true, ref modCharacterId);
		        if (flag == true)
		        {
		            Character character = ArgBox.GetCharacter("CharacterId");
		            Character modCharacter = EventHelper.GetCharacterById(modCharacterId);
		            if (character == modCharacter)
		            {
		                EventHelper.Log("此对话是与修改资质mod人物的对话，显示修改资质选项。");
		                return true;
		            }
		            else
		            {
		                return false;
		            }
		        }
		        else
		        {
		            EventHelper.Log("3-修改武学or技艺选项获取mod人物id失败，此为bug。");
		            return false;
		        }
		    }

		    private bool OnOption1AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption1GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption1Select()
		    {
			return "5aab3fb9-a681-4846-91ad-1924d024db1e";
		    }

		    public List<string> Option1GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion
	}
}