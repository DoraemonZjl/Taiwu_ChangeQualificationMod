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


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_5d1130c5236f45daa69829962bb296a6 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_5d1130c5236f45daa69829962bb296a6()
		{
			//事件GUID
			Guid = Guid.Parse("5d1130c5-236f-45da-a698-29962bb296a6");
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
			MainRoleKey = "RoleTaiwu";
			//进行交互的角色的Key，为空时将不显示背景图上的角色头像
			TargetRoleKey = "CharacterId";
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
				new TaiwuEventOption{ OptionKey = "Option_661866737"},
				new TaiwuEventOption{ OptionKey = "Option_-1840164243"},
				new TaiwuEventOption{ OptionKey = "Option_1572916615"},
				new TaiwuEventOption{ OptionKey = "Option_-1240309973"}
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

			EventOptions[1].OnOptionVisibleCheck = OnOption2VisibleCheck;
			EventOptions[1].OnOptionAvailableCheck = OnOption2AvailableCheck;
			EventOptions[1].GetReplacedContent = OnOption2GetReplacedContent;
			EventOptions[1].OnOptionSelect = OnOption2Select;
			EventOptions[1].GetExtraFormatLanguageKeys = Option2GetExtraFormatLanguageKeys;
			OnOption2Create();

			EventOptions[2].OnOptionVisibleCheck = OnOption3VisibleCheck;
			EventOptions[2].OnOptionAvailableCheck = OnOption3AvailableCheck;
			EventOptions[2].GetReplacedContent = OnOption3GetReplacedContent;
			EventOptions[2].OnOptionSelect = OnOption3Select;
			EventOptions[2].GetExtraFormatLanguageKeys = Option3GetExtraFormatLanguageKeys;
			OnOption3Create();

			EventOptions[3].OnOptionVisibleCheck = OnOption4VisibleCheck;
			EventOptions[3].OnOptionAvailableCheck = OnOption4AvailableCheck;
			EventOptions[3].GetReplacedContent = OnOption4GetReplacedContent;
			EventOptions[3].OnOptionSelect = OnOption4Select;
			EventOptions[3].GetExtraFormatLanguageKeys = Option4GetExtraFormatLanguageKeys;
			OnOption4Create();
		}

		    public override bool OnCheckEventCondition()
		    {
		        return true;
		    }

		    public override void OnEventEnter()
		    {
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
		        return true;
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
		        TaiwuEvent.SetModInt("UpdateValue", true, 1);
		        return "e2430dbc-be2b-4e1f-88e2-78e6b1e511c8";
		    }

		    public List<string> Option1GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption2Create()
		    {
		    }

		    private bool OnOption2VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption2AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption2GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption2Select()
		    {
		        TaiwuEvent.SetModInt("UpdateValue", true, 2);
		        return "e2430dbc-be2b-4e1f-88e2-78e6b1e511c8";
		    }

		    public List<string> Option2GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption3Create()
		    {
		    }

		    private bool OnOption3VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption3AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption3GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption3Select()
		    {
		        TaiwuEvent.SetModInt("UpdateValue", true, 5);
		        return "e2430dbc-be2b-4e1f-88e2-78e6b1e511c8";
		    }

		    public List<string> Option3GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption4Create()
		    {
		    }

		    private bool OnOption4VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption4AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption4GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption4Select()
		    {
		        TaiwuEvent.SetModInt("UpdateValue", true, 10);
		        return "e2430dbc-be2b-4e1f-88e2-78e6b1e511c8";
		    }

		    public List<string> Option4GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion
	}
}