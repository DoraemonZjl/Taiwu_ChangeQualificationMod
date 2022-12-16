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


#pragma warning disable 1591

namespace Modder_76561198296001474.EventConfig.Taiwu.EventGroup2d9363e04918441281e84fd4ec7a0dac
{
	public class ChangeQualificationModEvent_8ed95c9f50f94de89c356cf6c5a185c7 : TaiwuEventItem
	{
		public ChangeQualificationModEvent_8ed95c9f50f94de89c356cf6c5a185c7()
		{
			//事件GUID
			Guid = Guid.Parse("8ed95c9f-50f9-4de8-9c35-6cf6c5a185c7");
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
				new TaiwuEventOption{ OptionKey = "Option_-1439621986"},
				new TaiwuEventOption{ OptionKey = "Option_-1766385178"},
				new TaiwuEventOption{ OptionKey = "Option_957033684"},
				new TaiwuEventOption{ OptionKey = "Option_1169039887"},
				new TaiwuEventOption{ OptionKey = "Option_-154958863"},
				new TaiwuEventOption{ OptionKey = "Option_-1288732613"},
				new TaiwuEventOption{ OptionKey = "Option_320210905"},
				new TaiwuEventOption{ OptionKey = "Option_-762793346"},
				new TaiwuEventOption{ OptionKey = "Option_-884895430"},
				new TaiwuEventOption{ OptionKey = "Option_-56733169"},
				new TaiwuEventOption{ OptionKey = "Option_-79603061"},
				new TaiwuEventOption{ OptionKey = "Option_-404380059"},
				new TaiwuEventOption{ OptionKey = "Option_1141954609"},
				new TaiwuEventOption{ OptionKey = "Option_1585965255"},
				new TaiwuEventOption{ OptionKey = "Option_-1027531922"},
				new TaiwuEventOption{ OptionKey = "Option_1240611399"}
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

			EventOptions[14].OnOptionVisibleCheck = OnOption15VisibleCheck;
			EventOptions[14].OnOptionAvailableCheck = OnOption15AvailableCheck;
			EventOptions[14].GetReplacedContent = OnOption15GetReplacedContent;
			EventOptions[14].OnOptionSelect = OnOption15Select;
			EventOptions[14].GetExtraFormatLanguageKeys = Option15GetExtraFormatLanguageKeys;
			OnOption15Create();

			EventOptions[15].OnOptionVisibleCheck = OnOption16VisibleCheck;
			EventOptions[15].OnOptionAvailableCheck = OnOption16AvailableCheck;
			EventOptions[15].GetReplacedContent = OnOption16GetReplacedContent;
			EventOptions[15].OnOptionSelect = OnOption16Select;
			EventOptions[15].GetExtraFormatLanguageKeys = Option16GetExtraFormatLanguageKeys;
			OnOption16Create();
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Music);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Chess);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Poem);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Painting);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Math);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Appraisal);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Forging);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Woodworking);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Medicine);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Toxicology);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Weaving);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Jade);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Taoism);
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
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Buddhism);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option14GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption15Create()
		    {
		    }

		    private bool OnOption15VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption15AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption15GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption15Select()
		    {
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Cooking);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option15GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }

		    private void OnOption16Create()
		    {
		    }

		    private bool OnOption16VisibleCheck()
		    {
		        return true;
		    }

		    private bool OnOption16AvailableCheck()
		    {
		        return true;
		    }

		    private string OnOption16GetReplacedContent()
		    {
		        return string.Empty;
		    }

		    private string OnOption16Select()
		    {
		        TaiwuEvent.SetModInt("UpdateLifeSkillType", true, LifeSkillType.Eclectic);
		        return "5d1130c5-236f-45da-a698-29962bb296a6";
		    }

		    public List<string> Option16GetExtraFormatLanguageKeys()
		    {
		        return default;
		    }


		#endregion
	}
}