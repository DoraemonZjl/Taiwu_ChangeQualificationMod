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
	public class ChangeQualificationModEvent_1dec845fa450401e99305d7d49252d01 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_1dec845fa450401e99305d7d49252d01()
		{
			//事件GUID
			Guid = Guid.Parse("1dec845f-a450-401e-9930-5d7d49252d01");
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
				new TaiwuEventOption{ OptionKey = "Option_-736305346"},
				new TaiwuEventOption{ OptionKey = "Option_-2097313193"},
				new TaiwuEventOption{ OptionKey = "Option_-1343876831"},
				new TaiwuEventOption{ OptionKey = "Option_-1377278821"},
				new TaiwuEventOption{ OptionKey = "Option_-1674828957"},
				new TaiwuEventOption{ OptionKey = "Option_-1734153963"},
				new TaiwuEventOption{ OptionKey = "Option_551083046"},
				new TaiwuEventOption{ OptionKey = "Option_-1261963243"},
				new TaiwuEventOption{ OptionKey = "Option_-882500797"},
				new TaiwuEventOption{ OptionKey = "Option_698393935"},
				new TaiwuEventOption{ OptionKey = "Option_-1882797176"},
				new TaiwuEventOption{ OptionKey = "Option_-1344762204"},
				new TaiwuEventOption{ OptionKey = "Option_1741358026"},
				new TaiwuEventOption{ OptionKey = "Option_-739186931"}
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

			EventOptions[4].OnOptionVisibleCheck = OnOption5VisibleCheck;
			EventOptions[4].OnOptionAvailableCheck = OnOption5AvailableCheck;
			EventOptions[4].GetReplacedContent = OnOption5GetReplacedContent;
			EventOptions[4].OnOptionSelect = OnOption5Select;
			EventOptions[4].GetExtraFormatLanguageKeys = Option5GetExtraFormatLanguageKeys;
			OnOption5Create();

			EventOptions[5].OnOptionVisibleCheck = OnOption6VisibleCheck;
			EventOptions[5].OnOptionAvailableCheck = OnOption6AvailableCheck;
			EventOptions[5].GetReplacedContent = OnOption6GetReplacedContent;
			EventOptions[5].OnOptionSelect = OnOption6Select;
			EventOptions[5].GetExtraFormatLanguageKeys = Option6GetExtraFormatLanguageKeys;
			OnOption6Create();

			EventOptions[6].OnOptionVisibleCheck = OnOption7VisibleCheck;
			EventOptions[6].OnOptionAvailableCheck = OnOption7AvailableCheck;
			EventOptions[6].GetReplacedContent = OnOption7GetReplacedContent;
			EventOptions[6].OnOptionSelect = OnOption7Select;
			EventOptions[6].GetExtraFormatLanguageKeys = Option7GetExtraFormatLanguageKeys;
			OnOption7Create();

			EventOptions[7].OnOptionVisibleCheck = OnOption8VisibleCheck;
			EventOptions[7].OnOptionAvailableCheck = OnOption8AvailableCheck;
			EventOptions[7].GetReplacedContent = OnOption8GetReplacedContent;
			EventOptions[7].OnOptionSelect = OnOption8Select;
			EventOptions[7].GetExtraFormatLanguageKeys = Option8GetExtraFormatLanguageKeys;
			OnOption8Create();

			EventOptions[8].OnOptionVisibleCheck = OnOption9VisibleCheck;
			EventOptions[8].OnOptionAvailableCheck = OnOption9AvailableCheck;
			EventOptions[8].GetReplacedContent = OnOption9GetReplacedContent;
			EventOptions[8].OnOptionSelect = OnOption9Select;
			EventOptions[8].GetExtraFormatLanguageKeys = Option9GetExtraFormatLanguageKeys;
			OnOption9Create();

			EventOptions[9].OnOptionVisibleCheck = OnOption10VisibleCheck;
			EventOptions[9].OnOptionAvailableCheck = OnOption10AvailableCheck;
			EventOptions[9].GetReplacedContent = OnOption10GetReplacedContent;
			EventOptions[9].OnOptionSelect = OnOption10Select;
			EventOptions[9].GetExtraFormatLanguageKeys = Option10GetExtraFormatLanguageKeys;
			OnOption10Create();

			EventOptions[10].OnOptionVisibleCheck = OnOption11VisibleCheck;
			EventOptions[10].OnOptionAvailableCheck = OnOption11AvailableCheck;
			EventOptions[10].GetReplacedContent = OnOption11GetReplacedContent;
			EventOptions[10].OnOptionSelect = OnOption11Select;
			EventOptions[10].GetExtraFormatLanguageKeys = Option11GetExtraFormatLanguageKeys;
			OnOption11Create();

			EventOptions[11].OnOptionVisibleCheck = OnOption12VisibleCheck;
			EventOptions[11].OnOptionAvailableCheck = OnOption12AvailableCheck;
			EventOptions[11].GetReplacedContent = OnOption12GetReplacedContent;
			EventOptions[11].OnOptionSelect = OnOption12Select;
			EventOptions[11].GetExtraFormatLanguageKeys = Option12GetExtraFormatLanguageKeys;
			OnOption12Create();

			EventOptions[12].OnOptionVisibleCheck = OnOption13VisibleCheck;
			EventOptions[12].OnOptionAvailableCheck = OnOption13AvailableCheck;
			EventOptions[12].GetReplacedContent = OnOption13GetReplacedContent;
			EventOptions[12].OnOptionSelect = OnOption13Select;
			EventOptions[12].GetExtraFormatLanguageKeys = Option13GetExtraFormatLanguageKeys;
			OnOption13Create();

			EventOptions[13].OnOptionVisibleCheck = OnOption14VisibleCheck;
			EventOptions[13].OnOptionAvailableCheck = OnOption14AvailableCheck;
			EventOptions[13].GetReplacedContent = OnOption14GetReplacedContent;
			EventOptions[13].OnOptionSelect = OnOption14Select;
			EventOptions[13].GetExtraFormatLanguageKeys = Option14GetExtraFormatLanguageKeys;
			OnOption14Create();
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
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Neigong);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
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
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Posing);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
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
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Stunt);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
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
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.FistAndPalm);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option4GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption5Create()
		    {
		    }

		    private bool OnOption5VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption5AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption5GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption5Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Finger);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option5GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption6Create()
		    {
		    }

		    private bool OnOption6VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption6AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption6GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption6Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Leg);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option6GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption7Create()
		    {
		    }

		    private bool OnOption7VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption7AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption7GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption7Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Throw);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option7GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption8Create()
		    {
		    }

		    private bool OnOption8VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption8AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption8GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption8Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Sword);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option8GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption9Create()
		    {
		    }

		    private bool OnOption9VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption9AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption9GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption9Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Blade);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option9GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption10Create()
		    {
		    }

		    private bool OnOption10VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption10AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption10GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption10Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Polearm);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option10GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption11Create()
		    {
		    }

		    private bool OnOption11VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption11AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption11GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption11Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Special);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option11GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption12Create()
		    {
		    }

		    private bool OnOption12VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption12AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption12GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption12Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.Whip);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option12GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption13Create()
		    {
		    }

		    private bool OnOption13VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption13AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption13GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption13Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.ControllableShot);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option13GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption14Create()
		    {
		    }

		    private bool OnOption14VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption14AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption14GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption14Select()
		    {
		        TaiwuEvent.SetModInt("UpdateCombatSkillType", true, CombatSkillType.CombatMusic);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option14GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion
	}
}